using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class NewDeliveryMain
    {
        public string DeliveryId { get; set; }
        public string CId { get; set; }
        public string CName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? DeliveryAmount { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string OrderSource { get; set; }
        public string DeliveryBy { get; set; }
        public string CreatedBy { get; set; }
        public string CAddress { get; set; }
    }
}
