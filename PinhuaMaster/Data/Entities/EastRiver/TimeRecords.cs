using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TimeRecords
    {
        public int Id { get; set; }
        public int? ClockId { get; set; }
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public DateTime SignTime { get; set; }
        public byte? Mark { get; set; }
        public byte? Flag { get; set; }
        public string BillId { get; set; }
        public string EventName { get; set; }
        public int? PosSequ { get; set; }
        public DateTime? DCollectTime { get; set; }
    }
}
