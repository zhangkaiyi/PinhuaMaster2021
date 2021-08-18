using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorAndMachine
    {
        public int DoorId { get; set; }
        public int ClockId { get; set; }
        public int ReadNo { get; set; }

        public DoorInfo Door { get; set; }
    }
}
