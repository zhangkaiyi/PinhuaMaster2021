using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.OrderManagement.EasyPurchasing
{
    public class DeleteModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public DeleteModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public void OnGet(string Id)
        {

        }

        public IActionResult OnPost(string Id)
        {
            var rcId = _pinhuaContext.Gr2Main.FirstOrDefault(x => x.PurchasingId == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.Gr2Main.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.Gr2Main.RemoveRange(b);
            var c = _pinhuaContext.Gr2Details.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.Gr2Details.RemoveRange(c);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}