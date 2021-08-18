using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MchangeCard
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string OldCardId { get; set; }
        public string NewCardId { get; set; }
        public decimal? CardBalance { get; set; }
        public int? CardTimes { get; set; }
        public decimal? CardCost { get; set; }
        public string Memo { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public int? CardSequ { get; set; }
        public int? OldCardType { get; set; }
        public int? NewCardType { get; set; }
        public bool? BTransferFlag { get; set; }
        public DateTime? DTransferDate { get; set; }
        public decimal? NTransferMoney { get; set; }
    }
}
