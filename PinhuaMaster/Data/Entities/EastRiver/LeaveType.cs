using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class LeaveType
    {
        public int LeaveId { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveName { get; set; }
        public bool Disabled { get; set; }
        public decimal? PayRate { get; set; }
        public string Memo { get; set; }
    }
}
