using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;

namespace PinhuaMaster.Pages.Finance.Payment
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public CreateModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public 付款单 Payment { get; set; }
        public List<SelectListItem> PaymentTypeSelectList { get; set; }
        public List<SelectListItem> CustomerSelectList { get; set; }

        public void OnGet()
        {
            PaymentTypeSelectList = _pinhuaContext.GetCollectionTypeSelectList();
            CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
        }

        public IActionResult OnPost()
        {
            var year = DateTime.Now.ToString("yy");

            var exsistedIds = (from p in _pinhuaContext.付款单
                               where p.付款单号.Substring(0, 4) == "FK" + year
                               orderby p.付款单号 descending
                               select p.付款单号)
                             .ToList();
            var orderIndex = int.Parse(exsistedIds.Count() == 0 ? "0" : exsistedIds.First().Substring(4, 6)) + 1;

            var name = _pinhuaContext.往来单位.FirstOrDefault(x => x.单位编号 == Payment.单位编号)?.单位名称;

            Payment.付款单号 = "FK" + year + orderIndex.ToString("D6");
            Payment.付款单位 = name;

            var rcId = _pinhuaContext.GetNewRcId();
            var rtId = _pinhuaContext.GetRtId("付款单");
            var repCase = new EsRepCase
            {
                RcId = rcId,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
                FillDate = DateTime.Now,
            };

            Payment.ExcelServerRcid = rcId;
            Payment.ExcelServerRtid = rtId;
            _pinhuaContext.EsRepCase.Add(repCase);
            _pinhuaContext.付款单.Add(Payment);
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}