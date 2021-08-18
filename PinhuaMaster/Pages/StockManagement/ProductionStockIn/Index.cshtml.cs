using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.StockManagement.StockIn.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.ProductionStockIn
{
    public class IndexModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public IndexModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public List<StockInMain> StockInOrders { get; set; }
        public StockInSearch AdvanceSearchViewModel { get; set; }

        public void OnGet()
        {
            StockInOrders = _pinhuaContext.StockInMain.ToList();
        }

        public IActionResult OnGetAjaxStockInOrders()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var orders = from p in _pinhuaContext.StockInMain
                         join d in _pinhuaContext.StockInDetails on p.ExcelServerRcid equals d.ExcelServerRcid into details
                         //join u in _pinhuaContext.往来单位 on p.CustomerId equals u.单位编号
                         join t in _pinhuaContext.业务类型 on p.MovementType equals t.业务类型1
                         join w in _pinhuaContext.Warehouse on p.WarehouseTo equals w.Id
                         where new List<string> { "131", "132" }.Contains(p.MovementType)
                         orderby p.OrderDate descending, p.CreatedDate descending
                         select new StockInMainDTO
                         {
                             WarehouseTo = p.WarehouseTo,
                             WarehouseToName = w.Name,
                             MovementType = p.MovementType,
                             MovementTypeDescription = t.类型描述,
                             OrderId = p.OrderId,
                             CustomerId = p.CustomerId,
                             //CustomerName = u.单位名称,
                             CustomerAddress = p.CustomerAddress,
                             OrderDate = p.OrderDate,
                             Remarks = p.Remarks,
                             CreatedBy = p.CreatedBy,
                             CreatedDate = p.CreatedDate,
                             Contact = p.Contact,
                             ContactNumber = p.ContactNumber,
                             Amount = details.Sum(x => x.Amount),
                         };
            return new JsonResult(orders, settings);
        }

        public IActionResult OnGetAjaxStockInDetails(string Id)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var details = from d in _pinhuaContext.StockInDetails.AsNoTracking()
                          where d.OrderId == Id
                          select new StockInDetailsDTO
                          {
                              ExcelServerRcid = d.ExcelServerRcid,
                              ExcelServerRtid = d.ExcelServerRtid,
                              OrderId = d.OrderId,
                              Id = d.Id,
                              ModelNumber = d.ModelNumber,
                              ModelName = d.ModelName,
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
            var search = Newtonsoft.Json.JsonConvert.DeserializeObject<StockInSearch>(json);
            var deliveryIds = (from x in (from p in _pinhuaContext.StockInMain.AsNoTracking()
                                          join d in _pinhuaContext.StockInDetails.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                                          //join u in _pinhuaContext.往来单位.AsNoTracking() on p.CustomerId equals u.单位编号
                                          join t in _pinhuaContext.业务类型.AsNoTracking() on p.MovementType equals t.业务类型1
                                          where (string.IsNullOrEmpty(search.OrderId) ? true : EF.Functions.Like(p.OrderId, $"%{search.OrderId}%"))
                                          && (string.IsNullOrEmpty(search.CustomerName) ? true : EF.Functions.Like(p.CustomerName, $"%{search.CustomerName}%"))
                                          && (string.IsNullOrEmpty(search.MovementTypeDescription) ? true : EF.Functions.Like(t.类型描述, $"%{search.MovementTypeDescription}%"))
                                          && (string.IsNullOrEmpty(search.Contact) ? true : EF.Functions.Like(p.Contact, $"%{search.Contact}%"))
                                          && (string.IsNullOrEmpty(search.ContactNumber) ? true : EF.Functions.Like(p.ContactNumber, $"%{search.ContactNumber}%"))
                                          && (string.IsNullOrEmpty(search.CustomerAddress) ? true : EF.Functions.Like(p.CustomerAddress, $"%{search.CustomerAddress}%"))
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
                                          orderby p.OrderDate descending, p.CreatedDate descending
                                          select p).ToList()
                               where ((search.OrderDate != null && x.OrderDate != null) ? search.OrderDate.Value.Date == x.OrderDate.Value.Date : true)
                                && ((search.CreatedDate != null && x.CreatedDate != null) ? search.CreatedDate.Value.Date == x.CreatedDate.Value.Date : true)
                               select x.OrderId).Distinct();
            var orders = from p in _pinhuaContext.StockInMain
                         join d in _pinhuaContext.StockInDetails on p.ExcelServerRcid equals d.ExcelServerRcid into details
                         join u in _pinhuaContext.往来单位 on p.CustomerId equals u.单位编号
                         join t in _pinhuaContext.业务类型 on p.MovementType equals t.业务类型1
                         where deliveryIds.Contains(p.OrderId)
                         orderby p.OrderDate descending, p.CreatedDate descending
                         select new StockInMainDTO
                         {
                             MovementType = p.MovementType,
                             MovementTypeDescription = t.类型描述,
                             OrderId = p.OrderId,
                             CustomerId = p.CustomerId,
                             CustomerName = u.单位名称,
                             CustomerAddress = p.CustomerAddress,
                             OrderDate = p.OrderDate,
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