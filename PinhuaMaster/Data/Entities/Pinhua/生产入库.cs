using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 生产入库
    {
        public int 自增 { get; set; }
        public DateTime 日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public decimal? 总数 { get; set; }
        public string 内容 { get; set; }
    }
}
