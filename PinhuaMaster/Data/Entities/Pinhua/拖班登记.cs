using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 拖班登记
    {
        public string 延班原因 { get; set; }
        public string 人员编号 { get; set; }
        public string 姓名 { get; set; }
        public DateTime? 时间 { get; set; }
        public string 审核状态 { get; set; }
        public string 审核人 { get; set; }
        public DateTime? 审核时间 { get; set; }
        public int Pk { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
