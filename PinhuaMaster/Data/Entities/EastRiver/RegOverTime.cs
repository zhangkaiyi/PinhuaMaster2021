﻿using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class RegOverTime
    {
        public string BillId { get; set; }
        public string OvertimeNo { get; set; }
        public string Requirer { get; set; }
        public string OtCause { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public string Checker { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool Audit { get; set; }
        public string Memo { get; set; }
    }
}
