using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Reminds
    {
        public int Id { get; set; }
        public string EmpId { get; set; }
        public string Messages { get; set; }
        public short? Kind { get; set; }
        public short? State { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? RegDate { get; set; }
        public int? Sponsor { get; set; }
        public string PhoneCode { get; set; }
        public string Email { get; set; }
        public DateTime? DoTime { get; set; }
    }
}
