using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MallowanceCardTask
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public int WalletFlag { get; set; }
        public decimal Deposit { get; set; }
        public int Kind { get; set; }
        public int ChargeVer { get; set; }
        public DateTime? Validatebegin { get; set; }
        public DateTime? ValidateEnd { get; set; }
        public string EmpId { get; set; }
        public string EmpFName { get; set; }
        public int? ClockId { get; set; }
        public string Areacode { get; set; }
        public string Cardtypecode { get; set; }
        public int Cardtype { get; set; }
        public int Flag { get; set; }
        public string Operator { get; set; }
        public DateTime? Opdate { get; set; }
        public DateTime? Executedate { get; set; }
        public string RealCardNo { get; set; }
        public string BatchNo { get; set; }
        public int? RegId { get; set; }
        public DateTime? AllowEndDate { get; set; }
    }
}
