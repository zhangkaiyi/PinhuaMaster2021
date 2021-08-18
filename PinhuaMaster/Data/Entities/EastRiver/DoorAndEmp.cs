using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorAndEmp
    {
        public int GroupId { get; set; }
        public int DoorId { get; set; }
        public int? TimeBoundId { get; set; }

        public DoorInfo Door { get; set; }
        public DoorListGroup Group { get; set; }
        public DoorTimeBound TimeBound { get; set; }
    }
}
