using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class BlackCardTaskClockState
    {
        public int TaskId { get; set; }
        public int ClockId { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public string RealCardNo { get; set; }
    }
}
