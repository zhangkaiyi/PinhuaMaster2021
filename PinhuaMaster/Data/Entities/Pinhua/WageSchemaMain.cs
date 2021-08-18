using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class WageSchemaMain
    {
        public string Id { get; set; }
        public string SchemaName { get; set; }
        public string Type { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateEnd { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }
}
