using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Maps
    {
        public int MapId { get; set; }
        public string MapName { get; set; }
        public byte[] Content { get; set; }
    }
}
