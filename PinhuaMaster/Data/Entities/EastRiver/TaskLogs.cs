using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TaskLogs
    {
        public int Id { get; set; }
        public int? ClockId { get; set; }
        public DateTime? TaskTime { get; set; }
        public string TaskLog { get; set; }
    }
}
