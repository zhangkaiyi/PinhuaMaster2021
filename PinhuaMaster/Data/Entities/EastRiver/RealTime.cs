using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class RealTime
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public string EmpId { get; set; }
        public int? DoorId { get; set; }
        public DateTime? PassTime { get; set; }
        public int? Readno { get; set; }
        public int? Cardresult { get; set; }
    }
}
