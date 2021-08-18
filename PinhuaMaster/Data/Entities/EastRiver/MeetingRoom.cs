using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MeetingRoom
    {
        public string Code { get; set; }
        public string Room { get; set; }
        public int? PerNo { get; set; }
        public string InClocks { get; set; }
        public string Remark { get; set; }
    }
}
