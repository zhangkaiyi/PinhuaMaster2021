using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.StockManagement.StockOut
{
    public class DeleteModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public DeleteModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public string Id { get; set; }

        public void OnGet(string Id)
        {
            this.Id = Id;
        }

        public IActionResult OnPost(string Id)
        {
            var rcId = _pinhuaContext.StockOutMain.FirstOrDefault(x => x.OrderId == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.StockOutMain.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.StockOutMain.RemoveRange(b);
            var c = _pinhuaContext.StockOutDetails.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.StockOutDetails.RemoveRange(c);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}