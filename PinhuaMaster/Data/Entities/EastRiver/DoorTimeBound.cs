using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorTimeBound
    {
        public DoorTimeBound()
        {
            DoorAndEmp = new HashSet<DoorAndEmp>();
        }

        public int TimeBoundId { get; set; }
        public string TimeBoundName { get; set; }
        public string WeekDay { get; set; }
        public string DayTime { get; set; }
        public string TimeDesc { get; set; }

        public ICollection<DoorAndEmp> DoorAndEmp { get; set; }
    }
}
