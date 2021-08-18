using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class LeaveD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal? LeaveDays { get; set; }
        public int LeaveId { get; set; }
        public int? StatusId { get; set; }
    }
}
