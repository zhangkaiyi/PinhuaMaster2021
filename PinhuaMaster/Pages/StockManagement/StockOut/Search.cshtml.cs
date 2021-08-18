using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Pages.StockManagement.StockOut.ViewModel;
using PinhuaMaster.Data.Entities.Pinhua;
using Microsoft.EntityFrameworkCore;

namespace PinhuaMaster.Pages.StockManagement.StockOut
{
    public class SearchModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        public SearchModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        [BindProperty]
        public StockOutSearch SearchViewModel { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var deliveryIds = (from x in (from p in _pinhuaContext.StockOutMain.AsNoTracking()
                                          join d in _pinhuaContext.StockOutDetails.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                                          //join u in _pinhuaContext.往来单位.AsNoTracking() on p.CustomerId equals u.单位编号
                                          join t in _pinhuaContext.业务类型.AsNoTracking() on p.MovementType equals t.业务类型1
                                          where (string.IsNullOrEmpty(SearchViewModel.OrderId) ? true : EF.Functions.Like(p.OrderId, $"%{SearchViewModel.OrderId}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.CustomerName) ? true : EF.Functions.Like(p.CustomerName, $"%{SearchViewModel.CustomerName}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.MovementTypeDescription) ? true : EF.Functions.Like(t.类型描述, $"%{SearchViewModel.MovementTypeDescription}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.Contact) ? true : EF.Functions.Like(p.Contact, $"%{SearchViewModel.Contact}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.ContactNumber) ? true : EF.Functions.Like(p.ContactNumber, $"%{SearchViewModel.ContactNumber}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.CustomerAddress) ? true : EF.Functions.Like(p.CustomerAddress, $"%{SearchViewModel.CustomerAddress}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.Remarks) ? true : EF.Functions.Like(p.Remarks, $"%{SearchViewModel.Remarks}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.CreatedBy) ? true : EF.Functions.Like(p.CreatedBy, $"%{SearchViewModel.CreatedBy}%"))

                                          && (!SearchViewModel.ItemId.HasValue ? true : d.Id == SearchViewModel.ItemId)
                                          && (string.IsNullOrEmpty(SearchViewModel.ItemDescription) ? true : EF.Functions.Like(d.Description, $"%{SearchViewModel.ItemDescription}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.ItemSpecification) ? true : EF.Functions.Like(d.Specification, $"%{SearchViewModel.ItemSpecification}%"))
                                          && (string.IsNullOrEmpty(SearchViewModel.ItemRemarks) ? true : EF.Functions.Like(d.Remarks, $"%{SearchViewModel.ItemRemarks}%"))
                                          && (!SearchViewModel.ItemQty.HasValue ? true : d.Qty == SearchViewModel.ItemQty)
                                          && (!SearchViewModel.ItemUnitQty.HasValue ? true : d.UnitQty == SearchViewModel.ItemUnitQty)
                                          && (!SearchViewModel.ItemPrice.HasValue ? true : d.Price == SearchViewModel.ItemPrice)
                                          && (!SearchViewModel.ItemAmount.HasValue ? true : d.Amount == SearchViewModel.ItemAmount)
                                          orderby p.OrderDate descending, p.CreatedDate descending
                                          select p).ToList()
                               where ((SearchViewModel.OrderDate != null && x.OrderDate != null) ? SearchViewModel.OrderDate.Value.Date == x.OrderDate.Value.Date : true)
                                && ((SearchViewModel.CreatedDate != null && x.CreatedDate != null) ? SearchViewModel.CreatedDate.Value.Date == x.CreatedDate.Value.Date : true)
                               select x.OrderId).Distinct();
            var orders = from p in _pinhuaContext.StockOutMain.AsNoTracking()
                         where deliveryIds.Contains(p.OrderId)
                         select p;
            return new JsonResult(orders, settings);
        }
    }
}