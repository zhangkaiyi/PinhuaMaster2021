using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class InitTransRecords
    {
        public long NRecSeq { get; set; }
        public DateTime? DAccDate { get; set; }
        public DateTime? DSignTime { get; set; }
        public string CTransCode { get; set; }
        public string CEmpId { get; set; }
        public string CCardId { get; set; }
        public int NAccountId { get; set; }
        public int? NClockId { get; set; }
        public int? NLogicalId { get; set; }
        public int? NPosSeq { get; set; }
        public string CDinRoomId { get; set; }
        public int NTransTimes { get; set; }
        public decimal NAmount { get; set; }
        public decimal NCloseBalance { get; set; }
        public bool? BAudit { get; set; }
    }
}
