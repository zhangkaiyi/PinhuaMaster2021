using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class OvertimeFormMain
    {
        public int Y { get; set; }
        public int M { get; set; }
        public int D { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
