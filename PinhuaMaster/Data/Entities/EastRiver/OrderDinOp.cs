using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class OrderDinOp
    {
        public string EmpId { get; set; }
        public string CardNo { get; set; }
        public int Dinings { get; set; }
        public int ClockId { get; set; }
        public DateTime OrderTime { get; set; }
        public int DinType { get; set; }
        public DateTime DinDate { get; set; }
        public decimal? DinPrice { get; set; }
        public int OpType { get; set; }
        public string OpUser { get; set; }
        public DateTime OpDate { get; set; }
        public int Id { get; set; }
        public int? CardSequ { get; set; }
        public int? CardTimes { get; set; }
        public decimal? CardBalance { get; set; }
        public int? WalletFlag { get; set; }
        public int? Flag { get; set; }
        public int? PosSequ { get; set; }
        public string DinTab { get; set; }
        public DateTime? DCollectTime { get; set; }
    }
}
