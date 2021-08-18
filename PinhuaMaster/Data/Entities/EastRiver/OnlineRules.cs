using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OnlineRules
    {
        public string OnlineRuleId { get; set; }
        public string OnlineRuleName { get; set; }
        public string GroupId { get; set; }
        public string DinLevId { get; set; }
        public int? MaxCount { get; set; }
        public decimal? MaxConsume { get; set; }
    }
}
