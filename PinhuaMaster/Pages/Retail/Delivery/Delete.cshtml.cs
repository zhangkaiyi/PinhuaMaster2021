using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Retail.Delivery
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
            var rcId = _pinhuaContext.RetailGiMain.FirstOrDefault(x => x.DeliveryId == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.RetailGiMain.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.RetailGiMain.RemoveRange(b);
            var c = _pinhuaContext.RetailGiDetails.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.RetailGiDetails.RemoveRange(c);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}