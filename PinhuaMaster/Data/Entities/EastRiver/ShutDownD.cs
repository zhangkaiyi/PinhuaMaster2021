using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ShutDownD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal? Days { get; set; }
        public int? StatusId { get; set; }
        public decimal? Rate { get; set; }
    }
}
