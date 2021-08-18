using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ClosingAccount
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public int AccountId { get; set; }
        public DateTime ClosingDate { get; set; }
        public decimal PreBalance { get; set; }
        public decimal ConsumeTotal { get; set; }
        public decimal ChargeTotal { get; set; }
        public decimal CardBalance { get; set; }
        public int TimesTotal { get; set; }
        public int SequTotal { get; set; }
        public string OpUser { get; set; }
        public DateTime CreatDate { get; set; }
    }
}
