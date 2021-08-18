using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Dorm
    {
        public string DormId { get; set; }
        public string DormName { get; set; }
        public int? Capacity { get; set; }
        public string Class { get; set; }
    }
}
