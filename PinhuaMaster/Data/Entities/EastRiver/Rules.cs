using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Rules
    {
        public string RuleId { get; set; }
        public string RuleName { get; set; }
        public string Rules1 { get; set; }
        public decimal DaysMonth { get; set; }
        public decimal? RelaxDays { get; set; }
        public decimal HoursDay { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? SunRate { get; set; }
        public decimal? HdRate { get; set; }
        public string Memo { get; set; }
    }
}
