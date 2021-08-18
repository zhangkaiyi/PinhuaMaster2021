using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorConnected
    {
        public int DoorId1 { get; set; }
        public int DoorId2 { get; set; }

        public DoorInfo DoorId1Navigation { get; set; }
        public DoorInfo DoorId2Navigation { get; set; }
    }
}
