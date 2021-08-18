using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OrderDinTab
    {
        public string EmpId { get; set; }
        public DateTime DinDate { get; set; }
        public byte Dins { get; set; }
        public DateTime? OrderTime { get; set; }
        public decimal? DinPrice { get; set; }
        public int Consumed { get; set; }
        public DateTime? ConsumedTime { get; set; }
        public int? ConsumedClockId { get; set; }
        public decimal? CardConsume { get; set; }
        public decimal? CardBalance { get; set; }
        public int? CardTimes { get; set; }
        public int? WalletFlag { get; set; }
        public int? ClockId { get; set; }
        public string CardId { get; set; }
        public bool? CancelOrder { get; set; }
        public string OpUser { get; set; }
        public DateTime? CancelDate { get; set; }
        public long NRecSeq { get; set; }
        public DateTime DCollectTime { get; set; }
        public DateTime? DAccDate { get; set; }
        public bool? BIsInvalid { get; set; }
        public bool? BPassCheck { get; set; }
        public bool? BObsolete { get; set; }
    }
}
