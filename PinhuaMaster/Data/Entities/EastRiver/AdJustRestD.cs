using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class AdJustRestD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime? OriDate { get; set; }
        public string OriBtime { get; set; }
        public string OriEtime { get; set; }
        public DateTime RestDate { get; set; }
        public string RestBtime { get; set; }
        public string RestEtime { get; set; }
        public int Kind { get; set; }
    }
}
