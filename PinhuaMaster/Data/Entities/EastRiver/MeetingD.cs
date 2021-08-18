using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class MeetingD
    {
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public short? Kind { get; set; }
        public short? State { get; set; }
        public string Remark { get; set; }
        public string SeatNo { get; set; }
    }
}
