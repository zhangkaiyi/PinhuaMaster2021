using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Mrefund
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public decimal OldCardBalance { get; set; }
        public decimal BackMoney { get; set; }
        public decimal? CardBalance { get; set; }
        public int? CardTimes { get; set; }
        public decimal? CardCost { get; set; }
        public bool Verified { get; set; }
        public bool Quit { get; set; }
        public int? Kind { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
    }
}
