using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class InventoryCountDetails
    {
        public string 型号编号 { get; set; }
        public string 描述 { get; set; }
        public string 规格 { get; set; }
        public decimal? 长 { get; set; }
        public decimal? 宽 { get; set; }
        public decimal? 高 { get; set; }
        public decimal? 数量 { get; set; }
        public decimal? 成本 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 型号名称 { get; set; }
        public int 自增列 { get; set; }
        public string SubModelNumber { get; set; }
    }
}
