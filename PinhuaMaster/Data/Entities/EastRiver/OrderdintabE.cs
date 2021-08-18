using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OrderdintabE
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public DateTime DinDate { get; set; }
        public byte Dins { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal? DinPrice { get; set; }
        public int? Consumed { get; set; }
        public DateTime? ConsumedTime { get; set; }
        public int? ConsumedClockId { get; set; }
        public decimal? CardConsume { get; set; }
        public int? CardTimes { get; set; }
        public decimal? CardBalance { get; set; }
        public int? Kind { get; set; }
    }
}
