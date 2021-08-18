using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 门店送样明细
    {
        public string 品名 { get; set; }
        public string 类型 { get; set; }
        public int? 长 { get; set; }
        public int? 数量 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int? 宽 { get; set; }
        public int PrimaryKey { get; set; }
    }
}
