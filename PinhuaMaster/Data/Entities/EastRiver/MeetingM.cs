using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MeetingM
    {
        public string BillId { get; set; }
        public string Meeting { get; set; }
        public string Presider { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string RoomCode { get; set; }
        public int? AheadMin { get; set; }
        public int? InLess { get; set; }
        public int? FroMin { get; set; }
        public int? OutLess { get; set; }
        public string Remark { get; set; }
        public bool? Outchecked { get; set; }
        public bool? AllowAudit { get; set; }
        public int? MessageState { get; set; }
        public DateTime? OpDate { get; set; }
        public string OpUser { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool? Audit { get; set; }
    }
}
