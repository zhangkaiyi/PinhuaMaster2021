using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;

namespace PinhuaMaster.Pages.Finance.Payment
{
    public class EditModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public EditModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public 付款单 Payment { get; set; }
        public List<SelectListItem> PaymentTypeSelectList { get; set; }
        public List<SelectListItem> CustomerSelectList { get; set; }

        public void OnGet(string Id)
        {
            Payment = _pinhuaContext.付款单.AsNoTracking().FirstOrDefault(p => p.付款单号 == Id);
            PaymentTypeSelectList = _pinhuaContext.GetCollectionTypeSelectList();
            CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
        }

        public IActionResult OnPost()
        {
            var order = _pinhuaContext.付款单.FirstOrDefault(x => x.ExcelServerRcid == Payment.ExcelServerRcid);
            Payment.付款单位 = _pinhuaContext.往来单位.FirstOrDefault(x => x.单位编号 == Payment.单位编号)?.单位名称;

            PinhuaContextExtensions.Copy.ShadowCopy(Payment, order);

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}