using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class SignInRecord
    {
        public int Id { get; set; }
        public string MeetingCode { get; set; }
        public int? ClockId { get; set; }
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public DateTime SignTime { get; set; }
        public byte InOutFlag { get; set; }
        public byte? Flag { get; set; }
    }
}
