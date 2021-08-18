using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class TranslateD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime TranslateTime { get; set; }
        public string OldDepart { get; set; }
        public string TrnaslateDepart { get; set; }
    }
}
