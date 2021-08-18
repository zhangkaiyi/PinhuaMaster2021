using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 放假登记
    {
        public string 编号 { get; set; }
        public DateTime 期初 { get; set; }
        public DateTime? 期末 { get; set; }
        public string 性质 { get; set; }
        public string 备注 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
