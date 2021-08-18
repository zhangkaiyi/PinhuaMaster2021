using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Finance.Collection
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
            var b = _pinhuaContext.收款单.Where(x => x.ExcelServerRcid == rcId);
            if (b != null)
                _pinhuaContext.收款单.RemoveRange(b);
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}