using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ReplaceRegM
    {
        public string BillId { get; set; }
        public string MeetingCode { get; set; }
        public string Remark { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool? Audit { get; set; }
    }
}
