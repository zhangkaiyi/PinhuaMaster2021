using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class StockSubconctractingMain
    {
        public string OrderId { get; set; }
        public string MovementType { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Remarks { get; set; }
        public string Contact { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string WarehouseFrom { get; set; }
        public string WarehouseTo { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
