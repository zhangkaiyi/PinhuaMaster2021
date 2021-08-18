using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsWorkFlow
    {
        public int PId { get; set; }
        public string RtId { get; set; }
        public string PName { get; set; }
        public string PDesc { get; set; }
        public byte[] PSpec { get; set; }
    }
}
