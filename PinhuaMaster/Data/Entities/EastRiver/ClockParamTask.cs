using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ClockParamTask
    {
        public int Id { get; set; }
        public int ClockId { get; set; }
        public string XmlParam { get; set; }
        public int Flag { get; set; }
        public DateTime? Opdate { get; set; }
        public string Operator { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public string XmlResult { get; set; }
    }
}
