using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MchargeRecords
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public int WalletFlag { get; set; }
        public decimal ChargeMoney { get; set; }
        public decimal CardBalance { get; set; }
        public int CardTimes { get; set; }
        public int CardSequ { get; set; }
        public int Kind { get; set; }
        public int ClockId { get; set; }
        public string CardTypeCode { get; set; }
        public string AreaCode { get; set; }
        public string Tac { get; set; }
        public DateTime OpYmd { get; set; }
        public string OpUser { get; set; }
        public DateTime OpDate { get; set; }
        public string Remark { get; set; }
        public int? DifineSequ { get; set; }
        public decimal? AllowanceBalance { get; set; }
        public int? MoneyType { get; set; }
        public string VerId { get; set; }
        public string ChargeState { get; set; }
        public decimal? WriteCardMoney { get; set; }
        public string DepartId { get; set; }
        public DateTime? DCollectTime { get; set; }
        public long NRecSeq { get; set; }
        public DateTime? DAccDate { get; set; }
        public bool? BIsInvalid { get; set; }
        public bool? BPassCheck { get; set; }
        public int? NPosSequ { get; set; }
        public bool? BObsolete { get; set; }
        public decimal? NInBounds { get; set; }
        public bool? DoAnomaly { get; set; }
    }
}
