using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TimePicRecords
    {
        public int SerialId { get; set; }
        public string CardNo { get; set; }
        public DateTime SignTime { get; set; }
        public byte[] Picture { get; set; }
        public int? ClockId { get; set; }
        public int? PosSequ { get; set; }
    }
}
