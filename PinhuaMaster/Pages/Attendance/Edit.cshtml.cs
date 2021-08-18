using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.Payroll.ViewModel;
using PinhuaMaster.Services;
using static PinhuaMaster.Extensions.PinhuaContextExtensions;

namespace PinhuaMaster.Pages.Attendance
{
    public class EditModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly EastRiverContext _eastRiverContext;
        private readonly IAttendanceService _attendanceService;
        private readonly IAttendanceService2021 _attendanceService2021;

        public EditModel(PinhuaContext pinhuaContext, EastRiverContext eastRiverContext, IAttendanceService attendanceService, IAttendanceService2021 attendanceService2021)
        {
            _pinhuaContext = pinhuaContext;
            _eastRiverContext = eastRiverContext;
            _attendanceService = attendanceService;
            _attendanceService2021 = attendanceService2021;
        }

        public void OnGet(int? Y, int? M)
        {

        }

        public IActionResult OnGetAjaxExsitedAttendanceData(int? Y, int? M)
        {
            var result = _attendanceService.GetExsitedAttendanceData(Y, M);

            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(result, settings);
        }

        public async Task<IActionResult> OnPost(string jsonStr)
        {
            if (string.IsNullOrEmpty(jsonStr))
                return Page();
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<AttendanceServiceDTO>(jsonStr);

            if (data == null)
                return Page();

            var report = _pinhuaContext.AttendanceReport.AsNoTracking().FirstOrDefault(r => r.Y == data.Y && r.M == data.M);
            if (report == null)
                return Page();

            var reportDetails = new List<AttendanceReportResults>();

            foreach (var person in data.PersonList)
            {
                var detail = new AttendanceReportResults
                {
                    ExcelServerRcid = report.ExcelServerRcid,
                    ExcelServerRtid = report.ExcelServerRtid,
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
            reportDetails.ForEach(i =>
            {
                var result = _pinhuaContext.AttendanceReportResults.FirstOrDefault(p => p.Y == i.Y && p.M == i.M && p.编号 == i.编号);
                if (result == null)
                    // 如果该条信息不存在，则添加
                    _pinhuaContext.AttendanceReportResults.Add(i);
                else
                {
                    // 如果该条信息存在，则修改
                    Copy.ShadowCopy(i, result);
                }
            });
            await _pinhuaContext.AttendanceReportResults.Where(p => p.Y == data.Y && p.M == data.M).ForEachAsync(i =>
              {
                  var result = reportDetails.FirstOrDefault(p => p.编号 == i.编号);
                  if (result == null)
                      // 如果该条信息多余，则删除
                      _pinhuaContext.AttendanceReportResults.Remove(i);
              });

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
                            ExcelServerRcid = report.ExcelServerRcid,
                            ExcelServerRtid = report.ExcelServerRtid,
                        };
                        abc.Add(o);                    }

                }
            }
            var details = _pinhuaContext.AttendanceReportDetails.Where(d => d.ExcelServerRcid == report.ExcelServerRcid);
            _pinhuaContext.AttendanceReportDetails.RemoveRange(details);
            _pinhuaContext.AttendanceReportDetails.AddRange(abc);

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }

        public IActionResult OnGetExportByEPPlus(int? Y, int? M)
        {
            
            using (ExcelPackage pck = new ExcelPackage())
            {
                //Create the worksheet
                string sheetName = "Sheet1";
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add(sheetName);
                ws.Cells.Style.Font.Name = "Microsoft YaHei";
                ws.Cells.Style.Font.Size = 11;
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ws.Cells[1, 1].Value = $"考勤数据，{Y}-{M?.ToString("D2")}";
                ws.Row(1).Height = 40;
                ws.Row(1).Style.Font.Size = 12;
                ws.Cells[1, 1, 1, 11].Merge = true;
                ws.Cells[1, 1, 1, 11].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[2, 1].Value = "日期";
                ws.Cells[2, 2].Value = "业务描述";
                ws.Cells[2, 3].Value = "备注";
                ws.Cells[2, 4].Value = "产品编号";
                ws.Cells[2, 5].Value = "产品描述";
                ws.Cells[2, 6].Value = "规格";
                ws.Cells[2, 7].Value = "片数";
                ws.Cells[2, 8].Value = "数量";
                ws.Cells[2, 9].Value = "单位";
                ws.Cells[2, 10].Value = "单价";
                ws.Cells[2, 11].Value = "金额";
                ws.Row(2).Height = 30;
                ws.Row(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Row(2).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[2, 1, 2, 11].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[2, 1, 2, 11].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 246, 235));
                ws.Cells[2, 1, 2, 11].AutoFilter = true;
                var rowNum = 3;

                var saveAsFileName = $"考勤数据，{Y}-{M?.ToString("D2")}.xlsx";
                var fileExt = Path.GetExtension(saveAsFileName);
                var provider = new FileExtensionContentTypeProvider();
                return File(pck.GetAsByteArray(), provider.Mappings[fileExt], saveAsFileName);
            }
        }
    }
}