using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class AllowanceTempD
    {
        public string TempCode { get; set; }
        public int IndexId { get; set; }
        public string EmpId { get; set; }
        public decimal? Deposit { get; set; }
    }
}
