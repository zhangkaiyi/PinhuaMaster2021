using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
namespace PinhuaMaster.Pages.Attendance
{
    public class DetailsModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public DetailsModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public class LinqModel
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public IEnumerable<AttendanceReportResults> Details { get; set; }
        }

        public LinqModel AttendanceData { get; set; }

        public void OnGet(int Year, int Month, string Id)
        {
            AttendanceData = (from p in _pinhuaContext.AttendanceReport.AsNoTracking().Where(k => k.Y == Year && k.M == Month)
                              join d in _pinhuaContext.AttendanceReportResults.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid into details
                              select new LinqModel
                              {
                                  Year = p.Y,
                                  Month = p.M,
                                  Details = details
                              }).FirstOrDefault();
        }
    }
}