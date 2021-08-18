using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class Gr2Main
    {
        public string PurchasingId { get; set; }
        public string PurchasingType { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string PurchasingAddress { get; set; }
        public DateTime? PurchasingDate { get; set; }
        public string Remarks { get; set; }
        public string Contact { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
