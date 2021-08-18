using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class EmpPicArc
    {
        public int SerialId { get; set; }
        public string CardNo { get; set; }
        public byte[] Picture { get; set; }
        public DateTime? SignTime { get; set; }
    }
}
