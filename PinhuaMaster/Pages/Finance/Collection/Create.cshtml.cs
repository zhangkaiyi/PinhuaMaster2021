using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;

namespace PinhuaMaster.Pages.Finance.Collection
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public CreateModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public 收款单 Collection { get; set; }
        public List<SelectListItem> CollectionTypeSelectList { get; set; }
        public List<SelectListItem> CustomerSelectList { get; set; }

        public void OnGet()
        {
            CollectionTypeSelectList = _pinhuaContext.GetCollectionTypeSelectList();
            CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
        }

        public IActionResult OnPost()
        {
            var year = DateTime.Now.ToString("yy");

            var exsistedIds = (from p in _pinhuaContext.收款单
                               where p.收款单号.Substring(0, 4) == "SK" + year
                               orderby p.收款单号 descending
                               select p.收款单号)
                             .ToList();
            var orderIndex = int.Parse(exsistedIds.Count() == 0 ? "0" : exsistedIds.First().Substring(4, 6)) + 1;

            var name = _pinhuaContext.往来单位.FirstOrDefault(x => x.单位编号 == Collection.单位编号)?.单位名称;

            Collection.收款单号 = "SK" + year + orderIndex.ToString("D6");
            Collection.收款单位 = name;

            var rcId = _pinhuaContext.GetNewRcId();
            var rtId = _pinhuaContext.GetRtId("收款单");
            var repCase = new EsRepCase
            {
                RcId = rcId,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
                FillDate = DateTime.Now,
            };

            Collection.ExcelServerRcid = rcId;
            Collection.ExcelServerRtid = rtId;

            _pinhuaContext.EsRepCase.Add(repCase);
            _pinhuaContext.收款单.Add(Collection);
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}