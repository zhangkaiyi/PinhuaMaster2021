using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class WageSchemaDetailsByTime
    {
        public string Id { get; set; }
        public string OperatingPost { get; set; }
        public string Sex { get; set; }
        public decimal? DaytimePrice { get; set; }
        public decimal? OvertimePrice { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public decimal? FullAttendancePrice { get; set; }
        public string SchemaId { get; set; }
    }
}
