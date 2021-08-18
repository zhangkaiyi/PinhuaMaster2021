using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Pictures
    {
        public int PicId { get; set; }
        public string PicName { get; set; }
        public byte[] Content { get; set; }
    }
}
