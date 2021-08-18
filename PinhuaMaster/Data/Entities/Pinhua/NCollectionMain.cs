using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class NCollectionMain
    {
        public string OrderSource { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal? CollectionAmount { get; set; }
        public string CollectionType { get; set; }
        public string CollectionAccount { get; set; }
        public string CollectionId { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
