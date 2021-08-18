using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Mallowance
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public int? ClockId { get; set; }
        public decimal Deposit { get; set; }
        public int Kind { get; set; }
        public bool Charged { get; set; }
        public bool? Downed { get; set; }
        public decimal ChargeMoney { get; set; }
        public DateTime? ChargeDate { get; set; }
        public decimal? CardBalance { get; set; }
        public int CardTimes { get; set; }
        public string ChargeVer { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public int WalletFlag { get; set; }
        public DateTime? Validatebegin { get; set; }
        public DateTime? ValidateEnd { get; set; }
        public DateTime? AllowEndDate { get; set; }
        public bool? IsCancel { get; set; }
        public string BatchNo { get; set; }
        public string CardSn { get; set; }
        public string RealCardNo { get; set; }
    }
}
