using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TransRecords
    {
        public long NRecSeq { get; set; }
        public DateTime? DAccDate { get; set; }
        public DateTime DSignTime { get; set; }
        public string CTransCode { get; set; }
        public string CEmpId { get; set; }
        public string CCardId { get; set; }
        public int NAccountId { get; set; }
        public int NClockId { get; set; }
        public int? NLogicalId { get; set; }
        public int NPosSeq { get; set; }
        public string CDinRoomId { get; set; }
        public int NTransTimes { get; set; }
        public decimal NAmount { get; set; }
        public decimal NCloseBalance { get; set; }
        public bool? BNotWriteCard { get; set; }
        public decimal? NWriteCardMoney { get; set; }
        public int? NKind { get; set; }
        public long? NRevertTransSeq { get; set; }
        public int NBookType { get; set; }
        public int NSrcType { get; set; }
        public bool? BCorrect { get; set; }
        public DateTime? DCorrectDate { get; set; }
        public bool? BTransFlag { get; set; }
        public long? NOrigRecSeq { get; set; }
        public int? NSavedTransTimes { get; set; }
        public DateTime InTime { get; set; }
        public decimal? NInBounds { get; set; }
        public bool? IsMoreTimes { get; set; }
        public bool? IsDmoreTimes { get; set; }
        public byte? IsSeries { get; set; }
        public bool? IsBook { get; set; }
        public string Mark { get; set; }
        public bool? BLoseFlag { get; set; }
        public long? NTransSeq { get; set; }
        public string DepartId { get; set; }
        public byte? BreakStat { get; set; }
        public byte? Invalid { get; set; }
    }
}
