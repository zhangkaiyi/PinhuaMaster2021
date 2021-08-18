using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Holidays
    {
        public string HdName { get; set; }
        public DateTime HdDate { get; set; }
        public DateTime HdEnd { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public decimal? HdRate { get; set; }
        public int? HdKind { get; set; }
        public string DepartId { get; set; }
        public bool AlwayUse { get; set; }
        public bool SubDepart { get; set; }
        public bool? Bless { get; set; }
    }
}
