using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ClockMallowanceCard
    {
        public int ClockId { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public string EmpId { get; set; }
        public string EmpFname { get; set; }
        public int? WalletFlag { get; set; }
        public int? Kind { get; set; }
        public decimal? Deposit { get; set; }
        public int ChargeVer { get; set; }
        public DateTime? ValidateBegin { get; set; }
        public DateTime? ValidateEnd { get; set; }
        public string Areacode { get; set; }
        public string Cardtypecode { get; set; }
        public int? Cardtype { get; set; }
        public int? RegId { get; set; }
        public string BatchNo { get; set; }
    }
}
