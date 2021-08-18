using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Zky.Utility;

namespace PinhuaMaster.Extensions
{
    public static class PinhuaContextExtensions
    {
        public static string ClientIp(this PinhuaContext context)
        {
            var ip = HttpContext.Current.Request.Headers["X-Forwarded-For"].FirstOrDefault()?.Split(',')?.FirstOrDefault();
            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Current.Connection.RemoteIpAddress.ToString();
            }
            return ip;
        }

        /// <summary>
        /// 判断是不是公司内部网络，公司网络信息在数据库中
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool IsInternalNetwork(this PinhuaContext context)
        {

            var ip1 = context.WeixinClockOptions.FirstOrDefault().Ip;
            var ip2 = context.ClientIp();
            return ip1.Equals(ip2);
        }

        /// <summary>
        /// 获取自动编号
        /// </summary>
        /// <param name="context"></param>
        /// <param name="stdId">ES_IdRule中的stdId</param>
        /// <param name="prefix">需要的前缀</param>
        /// <param name="n">需要增大的数字</param>
        /// <param name="len">数字部分需要补足的位数</param>
        /// <returns></returns>
        public static string GetAutoId(this PinhuaContext context, int stdId, string prefix, int n, int len)
        {
            context.Database.ExecuteSqlCommand($"exec ES_p_AutoIdNum @stdId, @prefix, @n", new[]{
                 new SqlParameter("stdId", stdId) ,new SqlParameter("prefix", prefix) ,new SqlParameter("n", n)
            });

            var obj = context.EsIdRec
                .Where(p => p.StdId == stdId && p.Prefix == prefix)
                .FirstOrDefault();

            return obj == null ? string.Empty : prefix + obj.MaxNum.ToString($"D{len}");
        }

        /// <summary>
        /// 获取自动编号
        /// </summary>
        /// <param name="context"></param>
        /// <param name="stdId">ES_IdRule中的stdId</param>
        /// <param name="prefix">需要的前缀</param>
        /// <param name="n">需要增大的数字</param>
        /// <param name="len">数字部分需要补足的位数</param>
        /// <returns></returns>
        public static string GetZkyAutoId(this PinhuaContext context, int stdId)
        {

            var outputNewId = new SqlParameter
            {
                ParameterName = "newId",
                SqlDbType = SqlDbType.NVarChar,
                Size = 100,
                Direction = ParameterDirection.Output
            };
            context.Database.ExecuteSqlCommand($"exec ZKY_p_AutoId @theStdId, @newId output", new[]{
                 new SqlParameter("theStdId", stdId) ,outputNewId
            });

            return outputNewId.Value.ToString();
        }

        /// <summary>
        /// 获取最大的Id
        /// </summary>
        /// <param name="context"></param>
        /// <param name="idName">要获取Id的代号</param>
        /// <param name="n">Id要增大的数</param>
        /// <returns></returns>
        public static int GetNewId(this PinhuaContext context, int idName, int n)
        {
            context.Database.ExecuteSqlCommand($"exec GetNewId_s @id, @n", new[]{
                 new SqlParameter("id", idName) ,new SqlParameter("n", n)
            });

            var obj = context.EsSysIdS.AsNoTracking()
                .Where(p => p.IdName == idName && p.IdDate.Year == DateTime.Now.Year && p.IdDate.Month == DateTime.Now.Month && p.IdDate.Day == DateTime.Now.Day)
                .FirstOrDefault();

            return obj == null ? 0 : obj.MaxId;
        }

        /// <summary>
        /// 获取新的rcid文本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetNewRcId(this PinhuaContext context)
        {
            var newId = context.GetNewId(26, 1);
            var rcId = "rc" + DateTime.Now.ToString("yyyyMMdd") + newId.ToString("D5");

            return newId == 0 ? "" : rcId;
        }

        /// <summary>
        /// 获取新的rcid文本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetNewPicNo(this PinhuaContext context)
        {
            var newId = context.GetNewId(33, 1);
            var rcId = "P" + DateTime.Now.ToString("yyyyMMdd") + newId.ToString("D5");

            return newId == 0 ? "" : rcId;
        }

        /// <summary>
        /// 获取新的rcid文本
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string GetNewLinkNo(this PinhuaContext context)
        {
            var newId = context.GetNewId(34, 1);
            var rcId = "L" + DateTime.Now.ToString("yyyyMMdd") + newId.ToString("D5");

            return newId == 0 ? "" : rcId;
        }

        /// <summary>
        /// 获取指定模板对应的RtId
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        static public string GetRtId(this PinhuaContext context, string templateName)
        {
            var rtId = from p in context.EsTmp
                       where p.RtName == templateName
                       select p.RtId;
            return rtId.First() ?? string.Empty;
        }

        static public string CreatePersonnelFileId(this PinhuaContext context, string prefix, int indexLength)
        {
            var year = DateTime.Now.ToString("yy");
            var prefixId = prefix + year;
            var exsistedMaxId = (from p in context.人员档案
                                 where p.人员编号.Substring(0, prefixId.Length) == prefixId
                                 && p.人员编号.Length == prefixId.Length + indexLength
                                 && p.登记时间.Value.Year == DateTime.Now.Year
                                 orderby p.人员编号 descending
                                 select p.人员编号)
                             .FirstOrDefault();
            var idIndex = int.Parse(string.IsNullOrEmpty(exsistedMaxId) ? "0" : exsistedMaxId.Substring(prefixId.Length, indexLength)) + 1;
            return prefixId + idIndex.ToString($"D{indexLength}");
        }

        /// <summary>
        /// 获取仓库的下拉框数据
        /// </summary>
        /// <param name="_pinhuaContext"></param>
        /// <returns></returns>
        static public List<SelectListItem> GetWarehouseSelectList(this PinhuaContext _pinhuaContext)
        {
            var list = from p in _pinhuaContext.Warehouse.ToList()
                       orderby p.Id ascending
                       select p;

            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem());
            foreach (var warehouse in list)
            {
                selectList.Add(new SelectListItem
                {
                    Text = warehouse.Id + " - " + warehouse.Name,
                    Value = warehouse.Id
                });


            }
            return selectList;
        }

        /// <summary>
        /// 获取联系人数据
        /// </summary>
        /// <param name="_pinhuaContext"></param>
        /// <returns></returns>
        static public List<SelectListItem> GetContactsSelectList(this PinhuaContext _pinhuaContext)
        {
            var list = from p in _pinhuaContext.往来单位联系人.ToList()
                       orderby p.联系人 ascending
                       select p;

            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Text = "无",
                Value = "",
            });
            foreach (var c in list)
            {
                selectList.Add(new SelectListItem
                {
                    Text = c.联系人,
                    Value = c.联系人
                });


            }
            return selectList;
        }

        /// <summary>
        /// 获取客户列表的下拉框数据
        /// </summary>
        /// <param name="_pinhuaContext"></param>
        /// <returns></returns>
        static public List<SelectListItem> GetCustomerSelectList(this PinhuaContext _pinhuaContext)
        {
            var customers = from p in _pinhuaContext.往来单位.ToList()
                            select p;

            var groups = from p in customers
                         orderby p.Rank descending
                         group p by p.Rank into g
                         select g.Key;
            var groupingCustomers = new List<SelectListItem>();

            groupingCustomers.Add(new SelectListItem
            {
                Text = "无",
                Value = "",
            });
            foreach (var key in groups)
            {
                var optGroup = new SelectListGroup
                {
                    Name = key?.ToString()
                };
                foreach (var customer in customers)
                {
                    if (customer.Rank == key)
                    {
                        groupingCustomers.Add(new SelectListItem
                        {
                            Group = optGroup,
                            Text = customer.单位编号 + " - " + customer.单位名称,
                            Value = customer.单位编号
                        });
                    }
                }
            }
            return groupingCustomers;
        }

        static public IEnumerable<产品型号清单> GetModelNames(this PinhuaContext _pinhuaContext)
        {
            var list = _pinhuaContext.产品型号清单.AsNoTracking().Where(p => !p.编号.StartsWith("DZ")).OrderBy(p => p.排序).ThenBy(p => p.编号).ToList();
            return list;
        }

        static public IEnumerable<InventoryDto> GetInventory(this PinhuaContext _pinhuaContext)
        {
            // 库存盘点日期
            var latestDate = (from w in _pinhuaContext.Warehouse
                              join i in (from p in _pinhuaContext.InventoryCount
                                         group p by p.仓库编号 into g
                                         select new
                                         {
                                             仓库编号 = g.Key,
                                             盘点日期 = new DateTime?(g.Max(p => p.盘点日期))
                                         }).ToList()
                              on w.Id equals i.仓库编号 into itmp
                              from i in itmp.DefaultIfEmpty()
                              select new
                              {
                                  仓库编号 = w.Id,
                                  盘点日期 = i.盘点日期 ?? new DateTime(1900, 1, 1)
                              }).ToList();

            // 库存盘点
            var inventory = from m in _pinhuaContext.InventoryCount
                            join md in _pinhuaContext.InventoryCountDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                            join c in latestDate on new { m.盘点日期, m.仓库编号 } equals new { c.盘点日期, c.仓库编号 }
                            select new
                            {
                                Warehouse = m.仓库编号,
                                ModelNumber = md.型号编号,
                                ModelName = md.型号名称,
                                Description = md.描述,
                                Specification = md.规格,
                                Length = md.长,
                                Width = md.宽,
                                Height = md.高,
                                Qty = md.数量,
                            };

            // 出库单，对应仓库库存减少
            var stockout = from m in _pinhuaContext.StockOutMain
                           join md in _pinhuaContext.StockOutDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                           join c in latestDate on m.WarehouseFrom equals c.仓库编号
                           where m.OrderDate > c.盘点日期
                           select new
                           {
                               Warehouse = m.WarehouseFrom,
                               md.ModelNumber,
                               md.ModelName,
                               md.Description,
                               md.Specification,
                               md.Length,
                               md.Width,
                               md.Height,
                               Qty = -md.Qty,
                           };
            // 入库单，对应仓库库存增多
            var stockin = from m in _pinhuaContext.StockInMain
                          join md in _pinhuaContext.StockInDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                          join c in latestDate on m.WarehouseTo equals c.仓库编号
                          where m.OrderDate > c.盘点日期
                          select new
                          {
                              Warehouse = m.WarehouseTo,
                              md.ModelNumber,
                              md.ModelName,
                              md.Description,
                              md.Specification,
                              md.Length,
                              md.Width,
                              md.Height,
                              md.Qty,
                          };
            // 转仓单，转出仓库库存减少
            var stocktransfer_out = from m in _pinhuaContext.StockTransferMain
                                    join md in _pinhuaContext.StockTransferDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                                    join c in latestDate on m.WarehouseTo equals c.仓库编号
                                    where m.OrderDate > c.盘点日期
                                    select new
                                    {
                                        Warehouse = m.WarehouseFrom,
                                        md.ModelNumber,
                                        md.ModelName,
                                        md.Description,
                                        md.Specification,
                                        md.Length,
                                        md.Width,
                                        md.Height,
                                        Qty = -md.Qty,
                                    };
            // 转仓单，转入仓库库存增加
            var stocktransfer_in = from m in _pinhuaContext.StockTransferMain
                                   join md in _pinhuaContext.StockTransferDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                                   join c in latestDate on m.WarehouseTo equals c.仓库编号
                                   where m.OrderDate > c.盘点日期
                                   select new
                                   {
                                       Warehouse = m.WarehouseTo,
                                       md.ModelNumber,
                                       md.ModelName,
                                       md.Description,
                                       md.Specification,
                                       md.Length,
                                       md.Width,
                                       md.Height,
                                       Qty = md.Qty,
                                   };

            // 外协加工单，转出仓库库存减少
            var stocksubconctracting_in = from m in _pinhuaContext.StockSubconctractingMain
                                          join md in _pinhuaContext.StockSubconctractingDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                                          join c in latestDate on m.WarehouseTo equals c.仓库编号
                                          where m.OrderDate > c.盘点日期
                                          select new
                                          {
                                              Warehouse = m.WarehouseFrom,
                                              md.ModelNumber,
                                              md.ModelName,
                                              md.Description,
                                              md.Specification,
                                              md.Length,
                                              md.Width,
                                              md.Height,
                                              Qty = -md.Qty,
                                          };
            // 外协加工单，转入仓库库存增加
            var stocksubconctracting_out = from m in _pinhuaContext.StockSubconctractingMain
                                           join md in _pinhuaContext.StockSubconctractingDetails on m.ExcelServerRcid equals md.ExcelServerRcid
                                           join c in latestDate on m.WarehouseTo equals c.仓库编号
                                           where m.OrderDate > c.盘点日期
                                           select new
                                           {
                                               Warehouse = m.WarehouseTo,
                                               md.ModelNumber,
                                               md.ModelName,
                                               md.Description,
                                               md.Specification,
                                               md.Length,
                                               md.Width,
                                               md.Height,
                                               Qty = md.Qty,
                                           };
            var all = from p in inventory.Union(stockout).Union(stockin).Union(stocktransfer_out).Union(stocktransfer_in).Union(stocksubconctracting_out).Union(stocksubconctracting_in).ToList()
                      orderby p.Warehouse, p.ModelNumber
                      group p by new
                      {
                          p.Warehouse,
                          p.ModelNumber,
                          p.ModelName,
                          p.Description,
                          p.Specification,
                          p.Length,
                          p.Width,
                          p.Height,
                      } into g
                      select new InventoryDto
                      {
                          Warehouse = g.Key.Warehouse,
                          ModelNumber = g.Key.ModelNumber,
                          ModelName = g.Key.ModelName,
                          Description = g.Key.Description,
                          Specification = g.Key.Specification,
                          Length = g.Key.Length,
                          Width = g.Key.Width,
                          Height = g.Key.Height,
                          Qty = g.Sum(p => p.Qty)
                      };
            return all;
        }

        public class InventoryDto
        {
            public string Warehouse { get; set; }
            public string ModelNumber { get; set; }
            public string ModelName { get; set; }
            public string Description { get; set; }
            public string Specification { get; set; }
            public decimal? Length { get; set; }
            public decimal? Width { get; set; }
            public decimal? Height { get; set; }
            public decimal? Qty { get; set; }
        }

        /// <summary>
        /// 获取收款付款类型的下拉列表
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        static public List<SelectListItem> GetCollectionTypeSelectList(this PinhuaContext context)
        {
            var collectionTypes = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Text = "银行"
                },
                new SelectListItem
                {
                    Text = "现金"
                },
                new SelectListItem
                {
                    Text = "微信"
                },
                new SelectListItem
                {
                    Text = "支付宝"
                },
            };
            return collectionTypes;
        }

        public static class Copy
        {
            public static void ShadowCopy(object from, object to)
            {
                if (from.GetType() == to.GetType())
                {
                    System.Reflection.PropertyInfo[] properties = from.GetType().GetProperties();

                    foreach (var p in properties)
                    {
                        var value = p.GetValue(from, null);
                        if (value != GetDefault(p.GetType()))
                            p.SetValue(to, value, null);
                    }
                }
            }

            public static object GetDefault(Type type)
            {
                if (type.IsValueType)
                {
                    return Activator.CreateInstance(type);
                }
                return null;
            }
        }

        /// <summary>
        /// 获取当前班段信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static WeixinWorkPlanDetail GetCurrentClockRange(this PinhuaContext context)
        {
            var ranges = context.GetCurrentClockRanges();

            foreach (var p in ranges)
            {
                p.今天的打卡开始到结束区间(out var left, out var right);

                if (DateTime.Now.IsBetween(left, right))
                    return p;
            }
            return null;
        }

        /// <summary>
        /// 获取当天打卡计划
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static WeixinWorkPlan GetCurrentClockPlan(this PinhuaContext context)
        {
            var plan = context.WeixinWorkPlan.AsNoTracking().Where(p => p.Id == 1).FirstOrDefault();
            return plan;
        }

        /// <summary>
        /// 获取当天打卡区间集合
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<WeixinWorkPlanDetail> GetCurrentClockRanges(this PinhuaContext context)
        {
            var plan = context.GetCurrentClockPlan();
            if (plan == null)
                return null;
            var ranges = context.WeixinWorkPlanDetail.AsNoTracking().Where(p => p.ExcelServerRcid == plan.ExcelServerRcid);
            return ranges.ToList();
        }

        /// <summary>
        /// 获取当天打卡区间最早与最晚时间
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool GetCurrentClockRangesBorder(this PinhuaContext context, out DateTime earliest, out DateTime latest)
        {
            var now = DateTime.Now;
            earliest = DateTime.MaxValue;
            latest = DateTime.MinValue;

            var ranges = context.GetCurrentClockRanges();
            if (ranges == null)
                return false;

            foreach (var range in ranges)
            {
                var t1 = range.Beginning.Value.ConvertDateToToday().AddMinutes(-range.MoveUp.Value);
                if (t1 < earliest)
                    earliest = t1;
                var t2 = range.Ending.Value.ConvertDateToToday().AddMinutes(range.PutOff.Value);
                if (t2 > latest)
                    latest = t2;
            }
            if (now <= earliest)   // 比最早时间早，说明在第二天，那就要返回前一天的区间
            {
                earliest = earliest.AddDays(-1);
                latest = latest.AddDays(-1);
            }

            return true;
        }

        /// <summary>
        /// 获取当天打卡区间最早与最晚时间
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static bool GetTargetDateClockRangesBorder(this PinhuaContext context, DateTime target, out DateTime earliest, out DateTime latest)
        {
            var now = DateTime.Now;
            earliest = DateTime.MaxValue;
            latest = DateTime.MinValue;

            var ranges = context.GetCurrentClockRanges();
            if (ranges == null)
                return false;

            foreach (var range in ranges)
            {
                var t1 = range.Beginning.Value.ConvertToTargetDate(target).AddMinutes(-range.MoveUp.Value);
                if (t1 < earliest)
                    earliest = t1;
                var t2 = range.Ending.Value.ConvertToTargetDate(target).AddMinutes(range.PutOff.Value);
                if (t2 > latest)
                    latest = t2;
            }

            return true;
        }

        public static bool GetAttendanceTimeRange(this PinhuaContext context, int year, int month, out DateTime earliest, out DateTime latest)
        {
            var first = new DateTime(year, month, 1);
            var last = first.AddMonths(1).AddDays(-1);
            earliest = DateTime.MaxValue;
            latest = DateTime.MinValue;

            var ranges = context.GetCurrentClockRanges();
            if (ranges == null)
                return false;

            foreach (var range in ranges)
            {
                var t1 = range.Beginning.Value.ConvertToTargetDate(first).AddMinutes(-range.MoveUp.Value);
                if (t1 < earliest)
                    earliest = t1;
                var t2 = range.Ending.Value.ConvertToTargetDate(last).AddMinutes(range.PutOff.Value);
                if (t2 > latest)
                    latest = t2;
            }

            return true;
        }

        /// <summary>
        /// 获取当天考勤记录集合
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<WeixinClock> GetCurrentClockRecords(this PinhuaContext context, string userid = null)
        {
            var result = new List<WeixinClock>();
            var bret = context.GetCurrentClockRangesBorder(out var earliest, out var latest);
            if (bret)
            {
                if (string.IsNullOrEmpty(userid))
                {
                    foreach (var clockinfo in context.WeixinClock)
                    {
                        if (clockinfo.Clocktime.Value.IsBetween(earliest, latest))
                            result.Add(clockinfo);
                    }
                }
                else
                {
                    var records1 = from p in context.WeixinClock
                                   where p.Userid == userid
                                   select p;
                    var records2 = from p in context.Wx异常说明
                                   where p.用户号 == userid && p.是否处理 == 1
                                   select new WeixinClock
                                   {
                                       Clocktype = p.类型,
                                       Clocktime = p.时间,
                                       Name = p.姓名,
                                       Userid = p.用户号,
                                   };
                    var records = records1.Union(records2).OrderBy(p => p.Clocktime);

                    foreach (var clockinfo in records)
                    {
                        if (clockinfo.Clocktime.Value.IsBetween(earliest, latest))
                            result.Add(clockinfo);
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// 获取当天考勤记录集合
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<WeixinClock> GetTargetDateTargetUserClockRecords(this PinhuaContext context, DateTime target, string userid)
        {
            var result = new List<WeixinClock>();
            var bret = context.GetTargetDateClockRangesBorder(target, out var earliest, out var latest);
            if (bret)
            {
                var records1 = from p in context.WeixinClock.AsNoTracking()
                               where p.Userid == userid
                               select p;
                var records2 = from p in context.Wx异常说明.AsNoTracking()
                               where p.用户号 == userid && p.是否处理 == 1
                               select new WeixinClock
                               {
                                   Clocktype = p.类型,
                                   Clocktime = p.时间,
                                   Name = p.姓名,
                                   Userid = p.用户号,
                               };
                var records = records1.ToList().Union(records2.ToList()).OrderBy(p => p.Clocktime);

                foreach (var clockinfo in records)
                {
                    if (clockinfo.Clocktime.Value.IsBetween(earliest, latest))
                        result.Add(clockinfo);
                }
            }
            return result;
        }

        public static List<WeixinClock> GetTargetMonthClockRecords(this PinhuaContext context, int year, int month)
        {
            var result = new List<WeixinClock>();
            var bret = context.GetAttendanceTimeRange(year, month, out var earliest, out var latest);
            if (bret)
            {
                var records1 = from p in context.WeixinClock.AsNoTracking()
                               where p.Clocktime.Value.IsBetween(earliest, latest)
                               select p;
                var records2 = from p in context.Wx异常说明.AsNoTracking()
                               where p.时间.Value.IsBetween(earliest, latest) && p.是否处理 == 1
                               select new WeixinClock
                               {
                                   Clocktype = p.类型,
                                   Clocktime = p.时间,
                                   Name = p.姓名,
                                   Userid = p.用户号,
                               };
                result = records1.Union(records2).OrderBy(p => p.Clocktime).ToList();
            }
            return result;
        }

    }
}
