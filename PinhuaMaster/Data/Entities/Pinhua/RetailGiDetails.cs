using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class RetailGiDetails
    {
        public int Id { get; set; }
        public string DeliveryId { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitQty { get; set; }
        public string Unit { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public string BindOrder { get; set; }
        public int? BindItem { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
