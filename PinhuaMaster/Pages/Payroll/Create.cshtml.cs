using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.Attendance;
using PinhuaMaster.Pages.Payroll.ViewModel;
using PinhuaMaster.Pages.Personnel.Files.ViewModel;

namespace PinhuaMaster.Pages.Payroll
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public CreateModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public IList<YMList> ymList { get; set; }

        public void OnGet()
        {
            var payrolls = _pinhuaContext.PayrollMain.AsNoTracking().ToList();
            ymList = (from p in _pinhuaContext.AttendanceReport.AsNoTracking()
                      group p by p.Y into g
                      select new YMList
                      {
                          Year = g.Key,
                          MonthList = g.Select(x => new MType
                          {
                              Month = x.M,
                              State = payrolls.Where(payroll => payroll.Y == g.Key && payroll.M == x.M).Count() > 0 ? "已存在" : ""
                          }).OrderByDescending(ym => ym.Month)

                      }).OrderByDescending(p => p.Year).ToList();
        }

        public IActionResult OnGetAjaxComputePayroll(int? year, int? month)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var a = attendanceData(year, month);
            var b = toGroupBy(a);
            var c = toCompute(b);
            var d = toPayroll(c);
            var x = toPayrollNew(year, month);

            return new JsonResult(x, settings);
        }

        public IActionResult OnPost(int yyyy, int mm, string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
                return Page();
            var Payrolls = Newtonsoft.Json.JsonConvert.DeserializeObject<IList<PayrollDetailsDTO>>(jsonStr);

            if (Payrolls == null)
                return Page();

            var Rcid = _pinhuaContext.GetNewRcId();
            var rtId = _pinhuaContext.GetRtId("工资单");
            var repCase = new EsRepCase
            {
                RcId = Rcid,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
            };

            var payrollMain = new PayrollMain
            {
                ExcelServerRcid = Rcid,
                ExcelServerRtid = rtId,
                Y = yyyy,
                M = mm
            };

            var payrollDetails = new List<PayrollDetails>();
            foreach (var payroll in Payrolls)
            {
                var pd = new PayrollDetails
                {
                    ExcelServerRcid = Rcid,
                    ExcelServerRtid = rtId,
                    Y = yyyy,
                    M = mm,
                };
                _mapper.Map<PayrollDetailsDTO, PayrollDetails>(payroll, pd);
                payrollDetails.Add(pd);
            }

            _pinhuaContext.EsRepCase.Add(repCase);
            _pinhuaContext.PayrollMain.Add(payrollMain);
            _pinhuaContext.PayrollDetails.AddRange(payrollDetails);
            try
            {
                _pinhuaContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                ModelState.AddModelError("", e.InnerException.Message);
                return Page();
            }

            return RedirectToPage("Index");
        }

        private IEnumerable<考勤明细> attendanceData(int? year, int? month)
        {
            var x = from p in _pinhuaContext.考勤期间.AsNoTracking().Where(p => p.年 == year && p.月 == month)
                    join d in _pinhuaContext.考勤明细.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                    select d;

            return x;
        }

        private IEnumerable<AttendanceData> toGroupBy(IEnumerable<考勤明细> data)
        {
            var x = from d in data
                    group d by new { d.人员编号, d.姓名 } into g
                    select new AttendanceData
                    {
                        Id = g.Key.人员编号,
                        Name = g.Key.姓名,
                        Details = g.Select(p => p)
                    };
            return x;
        }

        private IList<AttendanceReportDTO> toCompute(IEnumerable<AttendanceData> data)
        {
            var list = new List<AttendanceReportDTO>();
            foreach (var record in data)
            {
                var x = from p in record.Details
                        let allHours = (p.正常出勤 ?? 0) + (p.加班 ?? 0)
                        let daytimeHours = allHours >= 9 ? 9 : allHours
                        let overtimeHours = allHours >= 9 ? allHours - 9 : 0
                        select new
                        {
                            Data = p,
                            daytimeHours,
                            overtimeHours,
                            allHours
                        };
                var a = new AttendanceReportDTO();
                a.Id = record.Id;
                a.Name = record.Name;
                a.DaysOfLeave = x.Count(p => p.Data.状态 == "异常") + x.Count(p => p.Data.状态 == "请假");
                a.DaysOfWork = x.Count(p => p.Data.状态 == "正常");
                a.IsFullAttendance = a.DaysOfLeave == 0 ? true : false;
                a.DaytimeHours = x.Sum(p => p.daytimeHours);
                a.OvertimeHours = x.Sum(p => p.overtimeHours);
                a.AllHours = x.Sum(p => p.allHours);
                a.TimesOfDinner = x.Count(p => !string.IsNullOrEmpty(p.Data.上班1)) + x.Count(p => !string.IsNullOrEmpty(p.Data.上班3));

                list.Add(a);
            }
            return list;
        }

        public IList<PayrollDetailsDTO> toPayroll(IList<AttendanceReportDTO> data)
        {
            var list = new List<PayrollDetailsDTO>();
            foreach (var record in data)
            {
                var file = _mapper.Map<人员档案, PersonnelFilesDTO>(_pinhuaContext.人员档案.AsNoTracking().FirstOrDefault(p => p.人员编号 == record.Id));
                var schemaDetails = _pinhuaContext.WageSchemaDetailsByTime.AsNoTracking().Where(p => p.SchemaId == file.SchemaId);
                var result = schemaDetails.FirstOrDefault(p => p.Id == file.PostId && p.Sex == file.Sex);
                var x = new PayrollDetailsDTO
                {
                    Id = record.Id,
                    Name = record.Name,
                    Sex = record.Sex,
                    AllHours = record.AllHours,
                    OvertimeHours = record.OvertimeHours,
                    DaytimeHours = record.DaytimeHours,
                    DaysOfLeave = record.DaysOfLeave,
                    DaysOfWork = record.DaysOfWork,
                    TimesOfDinner = record.TimesOfDinner,
                    IsFullAttendance = record.IsFullAttendance,
                    Post = _pinhuaContext.岗位主表.AsNoTracking().FirstOrDefault(p => p.Id == file.PostId).OperatingPost,
                    DaytimeAmount = record.DaytimeHours * result.DaytimePrice,
                    OvertimeAmount = record.OvertimeHours * result.OvertimePrice,
                    FullAttendanceAmount = record.IsFullAttendance ? record.DaytimeHours * result.FullAttendancePrice : 0,
                    DinnerAmount = record.TimesOfDinner * -2,
                    PriceOverview = $"{(record.IsFullAttendance ? result.DaytimePrice + result.FullAttendancePrice : result.DaytimePrice)?.ToString("0.0")} / {result.OvertimePrice?.ToString("0.0")}",
                };
                x.AllHoursAmountWithFullAttendance = x.DaytimeAmount + x.OvertimeAmount + x.FullAttendanceAmount;
                x.FinalAmount = x.DaytimeAmount + x.OvertimeAmount + x.FullAttendanceAmount + x.DinnerAmount;
                list.Add(x);
            }
            return list;
        }

        public IEnumerable<PayrollDetailsDTO> toPayrollNew(int? Y, int? M)
        {
            var list = new List<PayrollDetailsDTO>();
            foreach (var record in _pinhuaContext.AttendanceReportResults.Where(a => a.Y == Y && a.M == M))
            {
                var file = _mapper.Map<人员档案, PersonnelFilesDTO>(_pinhuaContext.人员档案.AsNoTracking().FirstOrDefault(p => p.人员编号 == record.编号));
                var schemaDetails = _pinhuaContext.WageSchemaDetailsByTime.AsNoTracking().Where(p => p.SchemaId == file.SchemaId);
                var result = schemaDetails.FirstOrDefault(p => p.Id == file.PostId && p.Sex == file.Sex);
                var x = new PayrollDetailsDTO
                {
                    Id = record.编号,
                    Name = record.姓名,
                    Sex = file.Sex,
                    AllHours = record.总工时,
                    DaytimeHours = record.正班,
                    OvertimeHours = record.加班,
                    TimesOfDinner = record.用餐,
                    IsFullAttendance = record.是否全勤 == "是",
                    Post = _pinhuaContext.岗位主表.AsNoTracking().FirstOrDefault(p => p.Id == file.PostId).OperatingPost,
                    DaytimeAmount = record.正班 * result.DaytimePrice,
                    OvertimeAmount = record.加班 * result.OvertimePrice,
                    FullAttendanceAmount = record.是否全勤 == "是" ? record.正班 * result.FullAttendancePrice : 0,
                    DinnerAmount = record.用餐 * -2,
                    PriceOverview = $"{(record.是否全勤 == "是" ? result.DaytimePrice + result.FullAttendancePrice : result.DaytimePrice)?.ToString("0.0")} / {result.OvertimePrice?.ToString("0.0")}",
                };
                x.AllHoursAmountWithFullAttendance = x.DaytimeAmount + x.OvertimeAmount + x.FullAttendanceAmount;
                x.FinalAmount = x.DaytimeAmount + x.OvertimeAmount + x.FullAttendanceAmount + x.DinnerAmount;
                list.Add(x);
            }
            return list.OrderBy(p => p.Id);
        }
    }
}