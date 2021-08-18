using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.OrderManagement.EasyDelivery.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyDelivery
{
    public class IndexModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public IndexModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public List<Gi2Main> DeliveryOrders { get; set; }
        public Gi2Search SearchViewModel { get; set; }

        public void OnGet()
        {
            DeliveryOrders = _pinhuaContext.Gi2Main.ToList();
        }

        public IActionResult OnGetAjaxEasyDelivery()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var orders = from p in _pinhuaContext.Gi2Main
                         join d in _pinhuaContext.Gi2Details on p.ExcelServerRcid equals d.ExcelServerRcid into details
                         join u in _pinhuaContext.往来单位 on p.CustomerId equals u.单位编号
                         join t in _pinhuaContext.业务类型 on p.DeliveryType equals t.业务类型1
                         orderby p.DeliveryDate descending, p.CreatedDate descending
                         select new Gi2MainDTO
                         {
                             DeliveryType = p.DeliveryType,
                             DeliveryTypeDescription = t.类型描述,
                             DeliveryId = p.DeliveryId,
                             CustomerId = p.CustomerId,
                             CustomerName = u.单位名称,
                             DeliveryAddress = p.DeliveryAddress,
                             DeliveryDate = p.DeliveryDate,
                             Remarks = p.Remarks,
                             CreatedBy = p.CreatedBy,
                             CreatedDate = p.CreatedDate,
                             Contact = p.Contact,
                             ContactNumber = p.ContactNumber,
                             Amount = details.Sum(x => x.Amount),
                         };
            return new JsonResult(orders, settings);
        }

        public IActionResult OnGetAjaxEasyDeliveryDetails(string Id)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var details = from d in _pinhuaContext.Gi2Details.AsNoTracking()
                          where d.DeliveryId == Id
                          select new Gi2DetaislDTO
                          {
                              ExcelServerRcid = d.ExcelServerRcid,
                              ExcelServerRtid = d.ExcelServerRtid,
                              DeliveryId = d.DeliveryId,
                              Id = d.Id,
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

        public IActionResult OnGetAdvanceSearch(string json)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
            var search = Newtonsoft.Json.JsonConvert.DeserializeObject<Gi2Search>(json);
            var deliveryIds = (from x in (from p in _pinhuaContext.Gi2Main.AsNoTracking()
                                          join d in _pinhuaContext.Gi2Details.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                                          //join u in _pinhuaContext.往来单位.AsNoTracking() on p.CustomerId equals u.单位编号
                                          join t in _pinhuaContext.业务类型.AsNoTracking() on p.DeliveryType equals t.业务类型1
                                          where (string.IsNullOrEmpty(search.DeliveryId) ? true : EF.Functions.Like(p.DeliveryId, $"%{search.DeliveryId}%"))
                                          && (string.IsNullOrEmpty(search.CustomerName) ? true : EF.Functions.Like(p.CustomerName, $"%{search.CustomerName}%"))
                                          && (string.IsNullOrEmpty(search.DeliveryTypeDescription) ? true : EF.Functions.Like(t.类型描述, $"%{search.DeliveryTypeDescription}%"))
                                          && (string.IsNullOrEmpty(search.Contact) ? true : EF.Functions.Like(p.Contact, $"%{search.Contact}%"))
                                          && (string.IsNullOrEmpty(search.ContactNumber) ? true : EF.Functions.Like(p.ContactNumber, $"%{search.ContactNumber}%"))
                                          && (string.IsNullOrEmpty(search.DeliveryAddress) ? true : EF.Functions.Like(p.DeliveryAddress, $"%{search.DeliveryAddress}%"))
                                          && (string.IsNullOrEmpty(search.Remarks) ? true : EF.Functions.Like(p.Remarks, $"%{search.Remarks}%"))
                                          && (string.IsNullOrEmpty(search.CreatedBy) ? true : EF.Functions.Like(p.CreatedBy, $"%{search.CreatedBy}%"))

                                          && (!search.ItemId.HasValue ? true : d.Id == search.ItemId)
                                          && (string.IsNullOrEmpty(search.ItemDescription) ? true : EF.Functions.Like(d.Description, $"%{search.ItemDescription}%"))
                                          && (string.IsNullOrEmpty(search.ItemSpecification) ? true : EF.Functions.Like(d.Specification, $"%{search.ItemSpecification}%"))
                                          && (string.IsNullOrEmpty(search.ItemRemarks) ? true : EF.Functions.Like(d.Remarks, $"%{search.ItemRemarks}%"))
                                          && (!search.ItemQty.HasValue ? true : d.Qty == search.ItemQty)
                                          && (!search.ItemUnitQty.HasValue ? true : d.UnitQty == search.ItemUnitQty)
                                          && (!search.ItemPrice.HasValue ? true : d.Price == search.ItemPrice)
                                          && (!search.ItemAmount.HasValue ? true : d.Amount == search.ItemAmount)
                                          orderby p.DeliveryDate descending, p.CreatedDate descending
                                          select p).ToList()
                               where ((search.DeliveryDate != null && x.DeliveryDate != null) ? search.DeliveryDate.Value.Date == x.DeliveryDate.Value.Date : true)
                                && ((search.CreatedDate != null && x.CreatedDate != null) ? search.CreatedDate.Value.Date == x.CreatedDate.Value.Date : true)
                               select x.DeliveryId).Distinct();
            var orders = from p in _pinhuaContext.Gi2Main
                         join d in _pinhuaContext.Gi2Details on p.ExcelServerRcid equals d.ExcelServerRcid into details
                         join u in _pinhuaContext.往来单位 on p.CustomerId equals u.单位编号
                         join t in _pinhuaContext.业务类型 on p.DeliveryType equals t.业务类型1
                         where deliveryIds.Contains(p.DeliveryId)
                         orderby p.DeliveryDate descending, p.CreatedDate descending
                         select new Gi2MainDTO
                         {
                             DeliveryType = p.DeliveryType,
                             DeliveryTypeDescription = t.类型描述,
                             DeliveryId = p.DeliveryId,
                             CustomerId = p.CustomerId,
                             CustomerName = u.单位名称,
                             DeliveryAddress = p.DeliveryAddress,
                             DeliveryDate = p.DeliveryDate,
                             Remarks = p.Remarks,
                             CreatedBy = p.CreatedBy,
                             CreatedDate = p.CreatedDate,
                             Contact = p.Contact,
                             ContactNumber = p.ContactNumber,
                             Amount = details.Sum(x => x.Amount),
                         };
            return new JsonResult(orders, settings);
        }
    }
}