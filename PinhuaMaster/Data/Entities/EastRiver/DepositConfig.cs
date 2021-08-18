using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DepositConfig
    {
        public int Flag { get; set; }
        public string RefId { get; set; }
        public decimal Value { get; set; }
        public string Note { get; set; }
    }
}
