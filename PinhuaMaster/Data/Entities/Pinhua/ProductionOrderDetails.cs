using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class ProductionOrderDetails
    {
        public string 描述 { get; set; }
        public int? 长 { get; set; }
        public int? 宽 { get; set; }
        public int? 高 { get; set; }
        public int? 片数 { get; set; }
        public decimal? 平方数 { get; set; }
        public string 是否开槽 { get; set; }
        public string 开槽要求 { get; set; }
        public string 是否拉丝 { get; set; }
        public string 拉丝要求 { get; set; }
        public string 是否刻线 { get; set; }
        public string 刻线要求 { get; set; }
        public string 是否油漆 { get; set; }
        public string 油漆要求 { get; set; }
        public string 图片 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 其他要求 { get; set; }
        public int Idx { get; set; }
    }
}
