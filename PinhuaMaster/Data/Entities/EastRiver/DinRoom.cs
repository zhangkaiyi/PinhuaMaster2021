using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DinRoom
    {
        public string DinRoomId { get; set; }
        public string DinRoomName { get; set; }
        public string Mem { get; set; }
        public string PassWord { get; set; }
        public int? NTransTimes { get; set; }
        public bool? BBookCenter { get; set; }
        public decimal? NAccountBalance { get; set; }
    }
}
