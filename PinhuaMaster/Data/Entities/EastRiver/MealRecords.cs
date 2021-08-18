using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MealRecords
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public int WalletFlag { get; set; }
        public int CardSequ { get; set; }
        public int ClockId { get; set; }
        public int PosSequ { get; set; }
        public string OpcardId { get; set; }
        public string VerId { get; set; }
        public int CardTimes { get; set; }
        public decimal CardConsume { get; set; }
        public decimal CardBalance { get; set; }
        public decimal CardOldbalance { get; set; }
        public string Kind { get; set; }
        public string CardTypeCode { get; set; }
        public string AreaCode { get; set; }
        public string PsamappSn { get; set; }
        public string Tac { get; set; }
        public string CompanyId { get; set; }
        public string CommonEmpId { get; set; }
        public string CompanyEmpId { get; set; }
        public int BusiType { get; set; }
        public int BusiStyle { get; set; }
        public int CardFormat { get; set; }
        public DateTime SignTime { get; set; }
        public int? Mark { get; set; }
        public int? Flag { get; set; }
        public bool? Passed { get; set; }
        public int? Mealtype { get; set; }
        public DateTime? OpYmd { get; set; }
        public int? DifineSequ { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public decimal? AllowanceBalance { get; set; }
        public int? MoneyType { get; set; }
        public decimal? ModifyBalance { get; set; }
        public int? OnLineId { get; set; }
        public int? OtherId { get; set; }
        public int? PushResult { get; set; }
        public string DepartId { get; set; }
        public DateTime? DCollectTime { get; set; }
        public long NRecSeq { get; set; }
        public DateTime? DAccDate { get; set; }
        public bool? BIsInvalid { get; set; }
        public bool? BPassCheck { get; set; }
        public bool? BObsolete { get; set; }
        public bool? DoAnomaly { get; set; }
    }
}
