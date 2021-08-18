using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DinClockConfig
    {
        public short Id { get; set; }
        public string ClockId { get; set; }
        public string DinLevId { get; set; }
        public string DinLevName { get; set; }
        public float DinLevPrice { get; set; }
        public string BegTime { get; set; }
        public string EndTime { get; set; }
    }
}
