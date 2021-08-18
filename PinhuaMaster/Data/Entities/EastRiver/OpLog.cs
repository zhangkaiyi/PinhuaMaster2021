using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OpLog
    {
        public int Id { get; set; }
        public DateTime? OpTime { get; set; }
        public string BeWrite { get; set; }
        public string OpUser { get; set; }
        public string OpComPuter { get; set; }
    }
}
