﻿using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class EsUruleFillRt
    {
        public string RuleId { get; set; }
        public int RtfIdDest { get; set; }
        public string Expr { get; set; }
        public short IfIndex { get; set; }
    }
}
