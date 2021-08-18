using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.BasicInformation.Partner
{
    public class DeleteModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public DeleteModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public string Id { get; set; }

        public void OnGet(string Id)
        {
            this.Id = Id;
        }

        public IActionResult OnPost()
        {
            var rcId = _pinhuaContext.往来单位.FirstOrDefault(x => x.单位编号 == Id).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.往来单位.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.往来单位.RemoveRange(b);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}