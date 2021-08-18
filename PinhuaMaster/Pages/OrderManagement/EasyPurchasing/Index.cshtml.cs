using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.OrderManagement.EasyPurchasing.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyPurchasing
{
    public class IndexModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;
        public IndexModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetAjaxPurchasingList()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var list = _pinhuaContext.Gr2Main.Select(p => _mapper.Map<Gr2Main, Gr2MainDto>(p)).OrderByDescending(p => p.PurchasingDate).ThenByDescending(p => p.CreatedDate).ToList();

            return new JsonResult(list, settings);
        }

        public IActionResult OnGetAjaxPurchasingDetails(string Id)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var details = from p in _pinhuaContext.Gr2Main.AsNoTracking().Where(p => p.PurchasingId == Id)
                          join d in _pinhuaContext.Gr2Details.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                          select new Gr2Details
                          {
                              ExcelServerRcid = d.ExcelServerRcid,
                              ExcelServerRtid = d.ExcelServerRtid,
                              PurchasingId = d.PurchasingId,
                              ItemId = d.ItemId,
                              Description = d.Description,
                              Specification = d.Specification,
                              Length = d.Length,
                              Width = d.Width,
                              Height = d.Height,
                              Qty = d.Qty,
                              UnitQty = d.UnitQty,
                              Unit = d.Unit,
                              Price = d.Price,
                              Amount = d.Amount,
                              Remarks = d.Remarks,
                          };

            return new JsonResult(details, settings);
        }

    }
}