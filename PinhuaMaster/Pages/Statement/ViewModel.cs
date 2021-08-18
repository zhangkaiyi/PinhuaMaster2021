using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.Statement.ViewModel
{
    public class Model应收应付
    {
        public string 单位编号 { get; set; }
        public string 单位名称 { get; set; }
        public decimal? 应收合计 { get; set; }
        public decimal? 应付合计 { get; set; }
        public List<Model应收应付明细> 明细 { get; set; }
    }
    public class Model应收应付明细
    {
        public string RcId { get; set; }
        public string Type { get; set; }
        public string TypeDescription { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? Date { get; set; }
        public string OrderId { get; set; }
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
        public string Specification { get; set; }
        public decimal? Qty { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalSquareConverter))]
        public decimal? UnitQty { get; set; }
        public string Unit { get; set; }
        public decimal? Price { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalAmountConverter))]
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalAmountConverter))]
        public decimal? TotalAmount { get; set; }
    }
    public class Model出库入库
    {
        public Model出库入库条目 Record { get; set; }
        public Model出库入库明细 RecordDetail { get; set; }
    }
    public class Model出库入库条目
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string TypeDescription { get; set; }
        public string Remarks { get; set; }
    }
    public class Model出库入库明细
    {
        public string ItemId { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Qty { get; set; }
        public string Unit { get; set; }
        public decimal? UnitQty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
    }
}
