using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Shifts
    {
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public string DepartId { get; set; }
        public int? ShiftKind { get; set; }
        public decimal? WorkHrs { get; set; }
        public decimal? NeedHrs { get; set; }
        public bool IsDefault { get; set; }
        public string Shifts1 { get; set; }
        public string Memo { get; set; }
    }
}
