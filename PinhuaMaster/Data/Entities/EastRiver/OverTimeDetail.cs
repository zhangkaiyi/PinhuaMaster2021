using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OverTimeDetail
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime SignDate { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public int? StatusId { get; set; }
        public int? Rest { get; set; }
        public bool IsOt { get; set; }
        public int? Kind { get; set; }
    }
}
