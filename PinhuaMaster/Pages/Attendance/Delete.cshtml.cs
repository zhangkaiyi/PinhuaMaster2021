using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;
using Microsoft.EntityFrameworkCore;

namespace PinhuaMaster.Pages.Attendance
{
    public class DeleteModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public DeleteModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string rcId)
        {
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            if (a != null)
                _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.AttendanceReport.Where(x => x.ExcelServerRcid == rcId);
            if (b != null)
                _pinhuaContext.AttendanceReport.RemoveRange(b);
            var c = _pinhuaContext.AttendanceReportResults.Where(x => x.ExcelServerRcid == rcId);
            if (c != null)
                _pinhuaContext.AttendanceReportResults.RemoveRange(c);

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}