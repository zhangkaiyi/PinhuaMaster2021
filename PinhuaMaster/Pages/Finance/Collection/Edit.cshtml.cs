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
using AutoMapper;

namespace PinhuaMaster.Pages.Finance.Collection
{
    public class EditModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public EditModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public 收款单 Collection { get; set; }
        public List<SelectListItem> CollectionTypeSelectList { get; set; }
        public List<SelectListItem> CustomerSelectList { get; set; }

        public void OnGet(string Id)
        {
            Collection = _pinhuaContext.收款单.AsNoTracking().FirstOrDefault(p => p.收款单号 == Id);
            CollectionTypeSelectList = _pinhuaContext.GetCollectionTypeSelectList();
            CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
        }

        public IActionResult OnPost()
        {
            var order = _pinhuaContext.收款单.FirstOrDefault(x => x.ExcelServerRcid == Collection.ExcelServerRcid);
            Collection.收款单位 = _pinhuaContext.往来单位.FirstOrDefault(x => x.单位编号 == Collection.单位编号)?.单位名称;

            PinhuaContextExtensions.Copy.ShadowCopy(Collection, order);

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}