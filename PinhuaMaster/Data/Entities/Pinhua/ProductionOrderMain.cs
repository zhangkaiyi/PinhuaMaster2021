using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class ProductionOrderMain
    {
        public DateTime? 下单日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 单号 { get; set; }
        public DateTime? 交货日期 { get; set; }
        public string 客户编号 { get; set; }
        public string 客户名称 { get; set; }
        public string 状态 { get; set; }
    }
}
