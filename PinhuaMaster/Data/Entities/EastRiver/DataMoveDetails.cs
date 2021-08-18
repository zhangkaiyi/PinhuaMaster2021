using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DataMoveDetails
    {
        public long NDetSeq { get; set; }
        public long NRecSeq { get; set; }
        public string CSrcTabel { get; set; }
        public string CDestDb { get; set; }
        public string CDestTable { get; set; }
        public DateTime? DAccDateMin { get; set; }
        public DateTime? DAccDateMax { get; set; }
        public DateTime OpDate { get; set; }
        public string CDateField { get; set; }
    }
}
