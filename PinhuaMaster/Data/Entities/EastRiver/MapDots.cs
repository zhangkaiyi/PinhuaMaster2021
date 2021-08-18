using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MapDots
    {
        public int MapId { get; set; }
        public int DoorId { get; set; }
        public int DotId { get; set; }
        public int? OpenPic { get; set; }
        public int? ClosePic { get; set; }
    }
}
