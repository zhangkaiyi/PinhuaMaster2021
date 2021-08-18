using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class UserLog
    {
        public long Id { get; set; }
        public string OpUser { get; set; }
        public DateTime? OpDate { get; set; }
        public string Kind { get; set; }
        public string Msg { get; set; }
        public string CardId { get; set; }
    }
}
