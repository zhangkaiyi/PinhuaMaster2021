using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TimePicRecordsHis
    {
        public int SerialId { get; set; }
        public string CardNo { get; set; }
        public DateTime SignTime { get; set; }
        public byte[] Picture { get; set; }
    }
}
