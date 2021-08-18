using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DinLev
    {
        public string DinLevId { get; set; }
        public string DinLevName { get; set; }
        public float DinLevPrice { get; set; }
        public string BegTime { get; set; }
        public string EndTime { get; set; }
        public bool Iscount { get; set; }
        public bool? Isvalid { get; set; }
        public string Mem { get; set; }
        public decimal? DinLevAmount { get; set; }
    }
}
