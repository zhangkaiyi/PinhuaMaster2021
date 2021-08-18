using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class BatchCard
    {
        public int LoginId { get; set; }
        public string BeginCard { get; set; }
        public int LoginNum { get; set; }
        public int CardLen { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
    }
}
