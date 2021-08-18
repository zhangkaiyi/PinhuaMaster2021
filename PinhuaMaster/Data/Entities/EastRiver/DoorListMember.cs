using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorListMember
    {
        public int GroupId { get; set; }
        public string EmpId { get; set; }

        public DoorListGroup Group { get; set; }
    }
}
