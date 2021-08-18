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
    public class IndexModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public IndexModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public IEnumerable<DTO> Reports { get; set; }

        public void OnGet()
        {
            Reports = from r in _pinhuaContext.AttendanceReport.AsNoTracking()
                      join d in _pinhuaContext.AttendanceReportResults.AsNoTracking() on r.ExcelServerRcid equals d.ExcelServerRcid into details
                      select new DTO
                      {
                          Report = r,
                          Details = details
                      };
        }
    }

    public class DTO
    {
        public AttendanceReport Report { get; set; }
        public IEnumerable<AttendanceReportResults> Details { get; set; }
    }
}