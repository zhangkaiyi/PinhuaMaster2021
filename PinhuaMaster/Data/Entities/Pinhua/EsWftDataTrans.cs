using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsWftDataTrans
    {
        public int RtfIdTo { get; set; }
        public int TId { get; set; }
        public int? RtfIdFrom { get; set; }
        public short? IfIndex { get; set; }
    }
}
