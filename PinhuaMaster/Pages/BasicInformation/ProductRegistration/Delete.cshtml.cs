using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.BasicInformation.ProductRegistration
{
    public class DeleteModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public DeleteModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public string ModelNumber { get; set; }
        [BindProperty]
        public int SubModelNumber { get; set; }

        public void OnGet(string ModelNumber, int SubModelNumber)
        {
            this.ModelNumber = ModelNumber;
            this.SubModelNumber = SubModelNumber;
        }

        public IActionResult OnPost()
        {
            var rcId = _pinhuaContext.ProductRegistrationMain.FirstOrDefault(x => x.ModelNumber == ModelNumber && x.SubModelNumber == SubModelNumber).ExcelServerRcid;
            var a = _pinhuaContext.EsRepCase.Where(x => x.RcId == rcId);
            _pinhuaContext.EsRepCase.RemoveRange(a);
            var b = _pinhuaContext.ProductRegistrationMain.Where(x => x.ExcelServerRcid == rcId);
            _pinhuaContext.ProductRegistrationMain.RemoveRange(b);
            _pinhuaContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}