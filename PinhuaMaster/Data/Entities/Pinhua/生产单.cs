using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 生产单
    {
        public DateTime? 日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 单号 { get; set; }
        public DateTime? 交期 { get; set; }
        public string 客户号 { get; set; }
        public string 客户名 { get; set; }
        public string 状态 { get; set; }
        public string 备注 { get; set; }
        public string 概要 { get; set; }
    }
}
