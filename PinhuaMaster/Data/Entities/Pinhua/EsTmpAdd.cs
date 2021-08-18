using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsTmpAdd
    {
        public string RtId { get; set; }
        public byte[] TmpFile { get; set; }
        public byte[] Css { get; set; }
    }
}
