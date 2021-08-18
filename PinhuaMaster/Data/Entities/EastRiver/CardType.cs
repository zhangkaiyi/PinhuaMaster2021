using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class CardType
    {
        public int CardType1 { get; set; }
        public string CardName { get; set; }
        public bool? AttendFlag { get; set; }
        public bool? DoorFlag { get; set; }
        public bool? OffLineMealFlag { get; set; }
    }
}
