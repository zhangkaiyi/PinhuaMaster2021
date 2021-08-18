using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ModifyShiftD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string ShiftId { get; set; }
    }
}
