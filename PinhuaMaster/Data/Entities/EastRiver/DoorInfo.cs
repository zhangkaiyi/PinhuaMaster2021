using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorInfo
    {
        public DoorInfo()
        {
            DoorAndEmp = new HashSet<DoorAndEmp>();
            DoorAndMachine = new HashSet<DoorAndMachine>();
            DoorConnectedDoorId1Navigation = new HashSet<DoorConnected>();
            DoorConnectedDoorId2Navigation = new HashSet<DoorConnected>();
        }

        public int DoorId { get; set; }
        public string DoorName { get; set; }
        public int AreaId { get; set; }
        public short ListMode { get; set; }

        public ICollection<DoorAndEmp> DoorAndEmp { get; set; }
        public ICollection<DoorAndMachine> DoorAndMachine { get; set; }
        public ICollection<DoorConnected> DoorConnectedDoorId1Navigation { get; set; }
        public ICollection<DoorConnected> DoorConnectedDoorId2Navigation { get; set; }
    }
}
