using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.TagHelpers;

namespace PinhuaMaster.Pages.OrderManagement.Old.DeliveryOrder
{
    [Description("旧版送货单")]
    public class IndexModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        public IndexModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public class Delivery
        {
            public string DeliveryId { get; set; }
            public DateTime? DeliveryDate { get; set; }
            public string CId { get; set; }
            public string CName { get; set; }
            public string CAddress { get; set; }
            public string Remarks { get; set; }
            public string OrderType { get; set; }
            public string OrderDescription { get; set; }
            public string CreatedBy { get; set; }
            public string Contacts { get; set; }
            public string Phone { get; set; }
            public IList<Detail> Details { get; set; }
        }

        public class Detail
        {
            public string ItemId { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string Specification { get; set; }
            public decimal? Qty { get; set; }
            public decimal? UnitQty { get; set; }
            public string Unit { get; set; }
            public decimal? Price { get; set; }
            public decimal? Amount { get; set; }
        }

        public IList<Delivery> DeliveryOrders { get; set; }
        public MoPagerOption PagerOption { get; set; }

        public void OnGet(int pageSize = 10, int pageIndex = 1)
        {
            PagerOption = new MoPagerOption
            {
                CurrentPage = pageIndex,
                PageSize = pageSize,
                Total = _pinhuaContext.发货.Count(),
                RouteUrl = "/OrderManagement/Old/DeliveryOrder"
            };
            DeliveryOrders = new List<Delivery>();
            _pinhuaContext.发货.OrderByDescending(p => p.送货日期).Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList().ForEach(p =>
            {
                var details = _pinhuaContext.发货Detail.Where(d => d.ExcelServerRcid == p.ExcelServerRcid).Select(detail => new Detail
                {
                    ItemId = detail.编号,
                    Type = detail.类型,
                    Description = detail.描述,
                    Specification = detail.规格,
                    Qty = detail.Pcs,
                    UnitQty = detail.单位数量,
                    Unit = detail.计价单位,
                    Price = detail.单价,
                    Amount = detail.金额
                }).ToList();
                var order = new Delivery
                {
                    DeliveryId = p.送货单号,
                    DeliveryDate = p.送货日期,
                    CId = p.客户编号,
                    CName = p.客户,
                    CAddress = p.地址,
                    Remarks = p.备注,
                    OrderType = p.业务类型,
                    OrderDescription = p.业务描述,
                    Contacts = p.联系人,
                    Phone = p.联系电话,
                    CreatedBy = p.创建者,
                    Details = details
                };
                DeliveryOrders.Add(order);
            });

        }
    }
}