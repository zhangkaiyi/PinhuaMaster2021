using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class BookInfoLog
    {
        public long Id { get; set; }
        public int NLogType { get; set; }
        public DateTime? DLogTime { get; set; }
        public string CSender { get; set; }
        public string CReceiver { get; set; }
        public string CLogMsg { get; set; }
        public DateTime? DOpTime { get; set; }
        public bool? Notify { get; set; }
    }
}
