using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class CardAppType
    {
        public int AppIdx { get; set; }
        public string AppName { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int CardAppType1 { get; set; }
        public int WalletType { get; set; }
        public int WalletBalType { get; set; }
        public decimal? WalletOverLimit { get; set; }
        public int DebitFlag { get; set; }
        public decimal MaxDebit { get; set; }
        public int? BalanceValidity { get; set; }
        public bool? BalanceValidityFlag { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public bool? IsInUse { get; set; }
    }
}
