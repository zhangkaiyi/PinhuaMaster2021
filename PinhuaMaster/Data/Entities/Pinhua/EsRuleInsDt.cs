using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsRuleInsDt
    {
        public string RuleId { get; set; }
        public int DtIdDest { get; set; }
        public string Sdts { get; set; }
        public string JoinCond { get; set; }
    }
}
