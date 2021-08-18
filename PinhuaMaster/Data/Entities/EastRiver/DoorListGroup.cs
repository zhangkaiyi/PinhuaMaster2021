using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorListGroup
    {
        public DoorListGroup()
        {
            DoorAndEmp = new HashSet<DoorAndEmp>();
            DoorListMember = new HashSet<DoorListMember>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int? CardClass { get; set; }
        public string Right { get; set; }

        public ICollection<DoorAndEmp> DoorAndEmp { get; set; }
        public ICollection<DoorListMember> DoorListMember { get; set; }
    }
}
