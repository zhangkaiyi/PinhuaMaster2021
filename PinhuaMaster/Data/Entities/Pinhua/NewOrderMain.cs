using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class NewOrderMain
    {
        public string OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CId { get; set; }
        public string CName { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public DateTime? DeliceryDate { get; set; }
        public decimal? OrderAmount { get; set; }
        public string OrderType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string OrderState { get; set; }
        public string OrderFinishedPercent { get; set; }
        public string OrderRemarks { get; set; }
        public string CreatedBy { get; set; }
    }
}
