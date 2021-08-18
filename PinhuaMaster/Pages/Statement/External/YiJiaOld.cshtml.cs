using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.Statement.ViewModel;

namespace PinhuaMaster.Pages.Statement.External
{
    public class YiJiaOldModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public YiJiaOldModel(PinhuaContext pinhuaContext)
        {
            CustomerId = "KH-1304-001";
            _pinhuaContext = pinhuaContext;
        }

        public string CustomerId { get; set; }

        public Model应收应付 StatementData { get; set; }

        public void OnGet()
        {
            StatementData = 应收应付及明细(CustomerId);
        }

        public IActionResult OnGetAjax()
        {
            var dto = 应收应付及明细(CustomerId);
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(dto, settings);
        }

        private IEnumerable<对账结算主表> statementResultList(string Id) // 对应Id的对账结算数据
        {
            var detailsOfDuizhang = from p in _pinhuaContext.对账结算主表
                                    where p.单位编号 == Id
                                    select p;
            return detailsOfDuizhang.ToList();
        }
        private IEnumerable<收款单> collectionList(string Id) // 对应Id的收款单
        {
            var detailsOfShoukuan = from p in _pinhuaContext.收款单
                                    where p.单位编号 == Id
                                    select p;
            return detailsOfShoukuan.ToList();
        }

        private IEnumerable<付款单> paymentList(string Id) // 对应Id的收款单
        {
            var detailsOfFukuan = from p in _pinhuaContext.付款单
                                  where p.单位编号 == Id
                                  select p;
            return detailsOfFukuan.ToList();
        }

        private IEnumerable<Model出库入库> GetReceivableList(string Id) // 对应Id的发货详情
        {
            // 旧版送货单
            var oldDelivery = from p1 in _pinhuaContext.发货.AsNoTracking()
                              join p2 in _pinhuaContext.发货Detail.AsNoTracking() on p1.ExcelServerRcid equals p2.ExcelServerRcid
                              join p3 in _pinhuaContext.业务类型.AsNoTracking() on p1.业务类型 equals p3.业务类型1
                              join p4 in _pinhuaContext.物料登记.AsNoTracking() on p2.编号 equals p4.编号
                              where p1.客户编号 == Id && p3.MvP == "GI"
                              select new Model出库入库
                              {
                                  Record = new Model出库入库条目
                                  {
                                      CustomerId = p1.客户编号,
                                      OrderId = p1.送货单号,
                                      Date = p1.送货日期,
                                      Type = p1.业务类型,
                                      TypeDescription = p3.类型描述,
                                      Remarks = p1.备注
                                  },
                                  RecordDetail = new Model出库入库明细
                                  {
                                      ItemId = p2.编号,
                                      Description = p4.描述,
                                      Specification = p2.规格,
                                      Qty = p2.Pcs,
                                      Unit = p2.计价单位,
                                      UnitQty = p2.单位数量,
                                      Price = p2.单价,
                                      Amount = p2.金额 * p3.业务计算
                                  }
                              };
            // 新版简易送货单
            var easyDelivery = from p in _pinhuaContext.Gi2Main.AsNoTracking()
                               join d in _pinhuaContext.Gi2Details.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                               join b in _pinhuaContext.业务类型.AsNoTracking() on p.DeliveryType equals b.业务类型1
                               where p.CustomerId == Id
                               select new Model出库入库
                               {
                                   Record = new Model出库入库条目
                                   {
                                       CustomerId = p.CustomerId,
                                       OrderId = p.DeliveryId,
                                       Date = p.DeliveryDate,
                                       Type = p.DeliveryType,
                                       TypeDescription = b.类型描述,
                                       Remarks = p.Remarks
                                   },
                                   RecordDetail = new Model出库入库明细
                                   {
                                       ItemId = d.Id.ToString(),
                                       Description = d.Description,
                                       Specification = d.Specification,
                                       Qty = d.Qty,
                                       Unit = d.Unit,
                                       UnitQty = d.UnitQty,
                                       Price = d.Price,
                                       Amount = d.Amount * b.业务计算
                                   }
                               };
            // 送货单数据合并
            return oldDelivery.Union(easyDelivery).ToList();
        }

        private IEnumerable<Model出库入库> GetPayableList(string Id) // 对应Id的收货详情
        {
            // 送货单退货
            var oldDeliveryReturn = from p1 in _pinhuaContext.发货.AsNoTracking()
                                    join p2 in _pinhuaContext.发货Detail.AsNoTracking() on p1.ExcelServerRcid equals p2.ExcelServerRcid
                                    join p3 in _pinhuaContext.业务类型.AsNoTracking() on p1.业务类型 equals p3.业务类型1
                                    join p4 in _pinhuaContext.物料登记.AsNoTracking() on p2.编号 equals p4.编号
                                    where p1.客户编号 == Id && p3.MvP == "GR"
                                    select new Model出库入库
                                    {
                                        Record = new Model出库入库条目
                                        {
                                            CustomerId = p1.客户编号,
                                            OrderId = p1.送货单号,
                                            Date = p1.送货日期,
                                            Type = p1.业务类型,
                                            TypeDescription = p3.类型描述,
                                            Remarks = p1.备注
                                        },
                                        RecordDetail = new Model出库入库明细
                                        {
                                            ItemId = p2.编号,
                                            Description = p4.描述,
                                            Specification = p2.规格,
                                            Qty = p2.Pcs,
                                            Unit = p2.计价单位,
                                            UnitQty = p2.单位数量,
                                            Price = p2.单价,
                                            Amount = p2.金额 * p3.业务计算
                                        }
                                    };
            // 入库单
            var purchase = from p1 in _pinhuaContext.收货.AsNoTracking()
                           join p2 in _pinhuaContext.收货D.AsNoTracking()
                           on p1.ExcelServerRcid equals p2.ExcelServerRcid
                           join p3 in _pinhuaContext.业务类型.AsNoTracking() on p1.业务类型 equals p3.业务类型1
                           where p1.供应商编号 == Id && p3.MvP == "GR"
                           select new Model出库入库
                           {
                               Record = new Model出库入库条目
                               {
                                   CustomerId = p1.供应商编号,
                                   OrderId = p1.单号,
                                   Date = p1.日期,
                                   Type = p1.业务类型,
                                   TypeDescription = p3.类型描述,
                                   Remarks = ""
                               },
                               RecordDetail = new Model出库入库明细
                               {
                                   ItemId = p2.编号,
                                   Description = p2.名称,
                                   Specification = p2.规格,
                                   Qty = p2.Pcs,
                                   Unit = p2.计价单位,
                                   UnitQty = p2.单位数量,
                                   Price = p2.单价,
                                   Amount = p2.金额
                               }
                           };
            // 新版采购单
            var easyPurchasing = from p in _pinhuaContext.Gr2Main.AsNoTracking()
                                 join d in _pinhuaContext.Gr2Details.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid
                                 join b in _pinhuaContext.业务类型.AsNoTracking() on p.PurchasingType equals b.业务类型1
                                 where p.Supplier == Id
                                 select new Model出库入库
                                 {
                                     Record = new Model出库入库条目
                                     {
                                         CustomerId = p.Supplier,
                                         OrderId = p.PurchasingId,
                                         Date = p.PurchasingDate,
                                         Type = p.PurchasingType,
                                         TypeDescription = b.类型描述,
                                         Remarks = p.Remarks
                                     },
                                     RecordDetail = new Model出库入库明细
                                     {
                                         ItemId = d.ItemId.ToString(),
                                         Description = d.Description,
                                         Specification = d.Specification,
                                         Qty = d.Qty,
                                         Unit = d.Unit,
                                         UnitQty = d.UnitQty,
                                         Price = d.Price,
                                         Amount = d.Amount * b.业务计算
                                     }
                                 };
            // 采购单数据合并
            var detailsOfShou = oldDeliveryReturn.ToList().Union(purchase.ToList()).Union(easyPurchasing.ToList());
            return detailsOfShou;
        }

        private Model应收应付 ReceivableWithDetails(string Id)
        {
            var last日期 = statementResultList(Id).Any() ? statementResultList(Id).Max(x => x.日期) : new DateTime(1900, 1, 1); // 最新对账日期
            var last金额 = statementResultList(Id)
                .Where(x => x.日期 == last日期)
                .Select(x => new Model应收应付明细
                {
                    Date = x.日期,
                    Amount = x.应收 - x.应付,
                    TypeDescription = "结算",
                    OrderId = "Settlement"
                }); // 最新对账金额

            // 对账后的收发详情
            var listOf出库After = GetReceivableList(Id).Where(x => x.Record.Date > last日期);
            // var listOf入库After = listOf入库(Id).Where(x => x.Record.送货日期 > last日期);
            // 对账后的收款详情
            var listOf收款After = from p in collectionList(Id)
                                where p.收款日期 > last日期
                                select new Model应收应付明细
                                {
                                    Date = p.收款日期,
                                    Amount = -p.收款金额,
                                    Remarks = p.备注,
                                    TypeDescription = "收款",
                                    OrderId = p.收款单号,
                                    RcId = p.ExcelServerRcid
                                };
            var hello = from p in listOf出库After
                        group p by p.Record.OrderId into g
                        select new
                        {
                            g.Key,
                            单据应收合计 = g.Sum(e => e.RecordDetail.Amount)
                        };
            var yingShou = (from p in listOf出库After
                            join p2 in hello on p.Record.OrderId equals p2.Key
                            select new Model应收应付明细
                            {
                                Type = p.Record.Type,
                                TypeDescription = p.Record.TypeDescription,
                                Date = p.Record.Date,
                                OrderId = p.Record.OrderId,
                                ItemId = p.RecordDetail.ItemId,
                                ItemDescription = p.RecordDetail.Description,
                                Specification = p.RecordDetail.Specification,
                                Qty = p.RecordDetail.Qty,
                                UnitQty = p.RecordDetail.UnitQty,
                                Unit = p.RecordDetail.Unit,
                                Price = p.RecordDetail.Price,
                                Amount = p.RecordDetail.Amount,
                                Remarks = p.Record.Remarks,
                                TotalAmount = p2.单据应收合计
                            })
                           .Union(listOf收款After)
                           .Union(last金额);

            // 应收与明细
            var yingShouWithDetails = new Model应收应付
            {
                单位编号 = Id,
                明细 = yingShou.OrderByDescending(x => x.Date).ThenByDescending(x => x.OrderId).ToList(),
                应收合计 = yingShou.Sum(x => x.Amount)
            };

            return yingShouWithDetails;
        }

        private Model应收应付 PayableWithDetails(string Id)
        {
            var last日期 = statementResultList(Id).Any() ? statementResultList(Id).Max(x => x.日期) : new DateTime(1900, 1, 1); // 最新对账日期
            //var last金额 = statementResultList(Id)
            //    .Where(x => x.日期 == last日期)
            //    .Select(x => new Model应收应付明细
            //    {
            //        Date = x.日期,
            //        Amount = -x.应付,
            //        TypeDescription = "结算",
            //        OrderId = "Settlement"
            //    }); // 最新对账金额

            // 对账后的收发详情
            // var listOf出库After = listOf出库(Id).Where(x => x.Record.送货日期 > last日期);
            var listOf入库After = GetPayableList(Id).Where(x => x.Record.Date > last日期);
            // 对账后的收款详情
            var listOf付款After = from p in paymentList(Id)
                                where p.付款日期 > last日期
                                select new Model应收应付明细
                                {
                                    Date = p.付款日期,
                                    Amount = p.付款金额,
                                    Remarks = p.备注,
                                    TypeDescription = "付款",
                                    OrderId = p.付款单号,
                                };
            var hello = from p in listOf入库After
                        group p by p.Record.OrderId into g
                        select new
                        {
                            g.Key,
                            单据应付合计 = g.Sum(e => e.RecordDetail.Amount)
                        };

            var yingFu = (from p in listOf入库After
                          join p2 in hello on p.Record.OrderId equals p2.Key
                          select new Model应收应付明细
                          {
                              Type = p.Record.Type,
                              TypeDescription = p.Record.TypeDescription,
                              Date = p.Record.Date,
                              OrderId = p.Record.OrderId,
                              ItemId = p.RecordDetail.ItemId,
                              ItemDescription = p.RecordDetail.Description,
                              Specification = p.RecordDetail.Specification,
                              Qty = p.RecordDetail.Qty,
                              UnitQty = p.RecordDetail.UnitQty,
                              Unit = p.RecordDetail.Unit,
                              Price = p.RecordDetail.Price,
                              Amount = -p.RecordDetail.Amount,
                              TotalAmount = -p2.单据应付合计
                          })
                           .Union(listOf付款After);
            //.Union(last金额);

            // 应收与明细
            var yingFuWithDetails = new Model应收应付
            {
                单位编号 = Id,
                明细 = yingFu.OrderByDescending(x => x.Date).ThenByDescending(x => x.OrderId).ToList(),
                应收合计 = yingFu.Sum(x => x.Amount)
            };

            return yingFuWithDetails;
        }

        private Model应收应付 应收应付及明细(string Id)
        {
            var yingShou = ReceivableWithDetails(Id);
            var yingFu = PayableWithDetails(Id);

            var yingShouYingFu = new Model应收应付
            {
                单位编号 = Id,
                单位名称 = _pinhuaContext.往来单位.AsNoTracking().FirstOrDefault(p => p.单位编号 == Id)?.单位名称,
                应收合计 = (yingShou.应收合计 ?? 0) + (yingFu.应收合计 ?? 0),
                明细 = yingShou.明细.Union(yingFu.明细).OrderByDescending(x => x.Date).ThenByDescending(x => x.OrderId).ToList()
            };

            if (yingShou.明细.FindAll(x => x.TypeDescription == "上期结算").Any() && yingFu.明细.FindAll(x => x.TypeDescription == "上期结算").Any())
            {
                var row = yingShou.明细.Find(x => x.TypeDescription == "上期结算");
                row.Amount = -yingFu.明细.Find(x => x.TypeDescription == "上期结算").Amount;
                yingShouYingFu.明细.RemoveAll(x => x.TypeDescription == "上期结算");
                yingShouYingFu.明细.Add(row);
            }
            return yingShouYingFu;
        }
    }
}