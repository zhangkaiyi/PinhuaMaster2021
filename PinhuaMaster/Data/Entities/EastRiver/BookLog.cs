using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class BookLog
    {
        public long Id { get; set; }
        public DateTime DAccDate { get; set; }
        public int? NBookType { get; set; }
        public string COperator { get; set; }
        public DateTime? DOperateTime { get; set; }
        public string CDescription { get; set; }
        public decimal? NUserBalance { get; set; }
        public decimal? NDinRoomBalance { get; set; }
    }
}
