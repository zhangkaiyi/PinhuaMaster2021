using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.StockManagement.StockIn
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
            var rcId = _pinhuaContext.StockInMain.FirstOrDefault(x => x.OrderId == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.StockInMain.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.StockInMain.RemoveRange(b);
            var c = _pinhuaContext.StockInDetails.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.StockInDetails.RemoveRange(c);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}