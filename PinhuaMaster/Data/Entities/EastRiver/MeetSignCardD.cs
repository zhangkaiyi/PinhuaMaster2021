using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MeetSignCardD
    {
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime? SignTime { get; set; }
        public byte InOutFlag { get; set; }
        public string Remark { get; set; }
    }
}
