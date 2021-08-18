using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public class DbQuery_盘点日期
    {
        public string 仓库编号 { get; set; }
        public string 仓库名称 { get; set; }
        public DateTime? 盘点日期 { get; set; }
    }

    public class DbQuery_库存盘点
    {
        public string Warehouse { get; set; }
        public string WarehouseName { get; set; }
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public int SubModelNumber { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Qty { get; set; }
    }

    public class DbQuery_对账汇总
    {
        public string CustomerId { get; set; }
        public string OrderId { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? OrderDate { get; set; }
        public string MovementType { get; set; }
        public string MovementTypeDescription { get; set; }
        public string Remarks { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Qty { get; set; }
        public string Unit { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalSquareConverter))]
        public decimal? UnitQty { get; set; }
        public decimal? Price { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalAmountConverter))]
        public decimal? Amount { get; set; }
    }

    public class DbQuery_对账合计
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal? Amount { get; set; }
    }

    public class DbQuery_产品
    {
        public string ModelNumber { get; set; }
        public int SubModelNumber { get; set; }
        public string ModelName { get; set; }
        public int? Rank { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
    }

    public partial class PinhuaContext : DbContext
    {
        public DbQuery<DbQuery_盘点日期> view_盘点日期 { get; set; }
        public DbQuery<DbQuery_库存盘点> view_库存明细 { get; set; }
        public DbQuery<DbQuery_对账汇总> myView_对账_汇总 { get; set; }
        public DbQuery<DbQuery_对账合计> myView_对账_合计 { get; set; }
        public DbQuery<DbQuery_产品> myView_Product { get; set; }
    }
}
