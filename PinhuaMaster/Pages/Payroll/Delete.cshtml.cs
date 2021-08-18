using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Payroll
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
            var b = _pinhuaContext.PayrollMain.Where(x => x.ExcelServerRcid == rcId);
            if (b != null)
                _pinhuaContext.PayrollMain.RemoveRange(b);
            var c = _pinhuaContext.PayrollDetails.Where(x => x.ExcelServerRcid == rcId);
            if (c != null)
                _pinhuaContext.PayrollDetails.RemoveRange(c);

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }

    }
}