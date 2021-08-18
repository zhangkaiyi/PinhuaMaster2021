using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Services;

namespace PinhuaMaster.Pages.Attendance
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly EastRiverContext _eastRiverContext;
        private readonly IAttendanceService _attendanceService;

        public CreateModel(PinhuaContext pinhuaContext, EastRiverContext eastRiverContext, IAttendanceService attendanceService)
        {
            _pinhuaContext = pinhuaContext;
            _eastRiverContext = eastRiverContext;
            _attendanceService = attendanceService;
        }

        public int? Y { get; set; }
        public int? M { get; set; }

        public IList<YMList> ymList { get; set; }

        public void OnGet()
        {
            var a = _eastRiverContext.TimeRecords.AsNoTracking().Select(p => p.SignTime.Year).Distinct().ToList();
            var reports = _pinhuaContext.AttendanceReport.AsNoTracking().ToList();
            ymList = (from y in a
                      join m in _eastRiverContext.TimeRecords.AsNoTracking() on y equals m.SignTime.Year into ms
                      select new YMList
                      {
                          Year = y,
                          MonthList = ms.Select(p => p.SignTime.Month).Distinct().OrderByDescending(p => p)
                          .Select(p => new MType
                          {
                              Month = p,
                              State = reports.Where(r => r.Y == y && r.M == p).Count() > 0 ? "已存在" : ""
                          })
                      }).OrderByDescending(p => p.Year).ToList();


        }

        public IActionResult OnGetAjax(int? Y, int? M)
        {
            var result = _attendanceService.GetAttendanceData(Y, M);

            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(result, settings);
        }

        public IActionResult OnPost(string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
                return Page();
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<AttendanceServiceDTO>(jsonStr);

            if (data == null)
                return Page();


            var Rcid = _pinhuaContext.GetNewRcId();
            var rtId = _pinhuaContext.GetRtId("AttendanceReport");
            var repCase = new EsRepCase
            {
                RcId = Rcid,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
            };

            var reportMain = new AttendanceReport
            {
                ExcelServerRcid = Rcid,
                ExcelServerRtid = rtId,
                Y = data.Y.Value,
                M = data.M.Value
            };

            var reportDetails = new List<AttendanceReportResults>();

            foreach (var person in data.PersonList)
            {
                var detail = new AttendanceReportResults
                {
                    ExcelServerRcid = Rcid,
                    ExcelServerRtid = rtId,
                    Y = data.Y.Value,
                    M = data.M.Value,
                    编号 = person.Id,
                    姓名 = person.Name,
                    是否全勤 = person.IsFullAttendance ? "是" : "否",
                    正班 = person.DaytimeHours,
                    加班 = person.OvertimeHours,
                    总工时 = person.TotalHours,
                    缺勤 = person.TimesOfAbsent,
                    迟到 = person.TimesOfLate,
                    早退 = person.TimesOfLeaveEarly,
                    请假 = person.TimesOfAskForLeave,
                    用餐 = person.TimesOfDinner,
                };
                reportDetails.Add(detail);
            }
            // 保存明细
            var abc = new List<AttendanceReportDetails>();
            foreach (var person in data.PersonList)
            {
                foreach (var detail in person.Results)
                {
                    foreach (var range in detail.Details)
                    {
                        var o = new AttendanceReportDetails
                        {
                            编号 = person.Id,
                            姓名 = person.Name,
                            日期 = detail.Date,
                            班段 = range.RangeId,
                            班段描述 = range.Range,
                            上班 = range.Time1Fix,
                            下班 = range.Time2Fix,
                            工时 = range.Hours,
                            考勤结果 = range.State,
                            ExcelServerRcid = Rcid,
                            ExcelServerRtid = rtId,
                        };
                        abc.Add(o);
                    }
                }
            }

            _pinhuaContext.EsRepCase.Add(repCase);
            _pinhuaContext.AttendanceReport.Add(reportMain);
            _pinhuaContext.AttendanceReportResults.AddRange(reportDetails);
            _pinhuaContext.AttendanceReportDetails.AddRange(abc);
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }

    public class YMList
    {
        public int Year { get; set; }
        public IEnumerable<MType> MonthList { get; set; }
    }

    public class MType
    {
        public int Month { get; set; }
        public string State { get; set; }
    }
}