using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ShiftsRule
    {
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public short ShiftsCyc { get; set; }
        public string ShiftsCycUnit { get; set; }
        public short? Start { get; set; }
        public string Shifts { get; set; }
        public string Memo { get; set; }
    }
}
