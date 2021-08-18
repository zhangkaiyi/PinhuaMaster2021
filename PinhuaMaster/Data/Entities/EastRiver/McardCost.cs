using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class McardCost
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public decimal? InMoney { get; set; }
        public decimal? OutMoney { get; set; }
        public int? Kind { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public DateTime? OpYmd { get; set; }
        public string Remark { get; set; }
        public int? MoneyType { get; set; }
        public DateTime? DAccDate { get; set; }
        public bool? BIsInvalid { get; set; }
        public bool? BPassCheck { get; set; }
        public bool? BObsolete { get; set; }
        public int? ClockId { get; set; }
    }
}
