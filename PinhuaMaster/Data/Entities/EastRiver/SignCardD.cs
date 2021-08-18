using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class SignCardD
    {
        public int Id { get; set; }
        public string BillId { get; set; }
        public string EmpId { get; set; }
        public DateTime SignTime { get; set; }
        public int? StatusId { get; set; }
    }
}
