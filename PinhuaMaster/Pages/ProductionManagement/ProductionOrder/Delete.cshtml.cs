using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder
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
            var rcId = _pinhuaContext.生产单.FirstOrDefault(x => x.单号 == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.生产单.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.生产单.RemoveRange(b);
            var c = _pinhuaContext.生产单d.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.生产单d.RemoveRange(c);
            var d = _pinhuaContext.EsCasePic.Where(x => x.RcId == rcId);
            _pinhuaContext.EsCasePic.RemoveRange(d);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}