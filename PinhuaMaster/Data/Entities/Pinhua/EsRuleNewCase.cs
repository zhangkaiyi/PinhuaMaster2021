using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsRuleNewCase
    {
        public string RuleId { get; set; }
        public string RtIdDest { get; set; }
        public short FillerType { get; set; }
        public int? FillerRtfId { get; set; }
        public short IfQuickOpen { get; set; }
    }
}
