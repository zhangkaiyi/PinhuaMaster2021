using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ReturnCard
    {
        public string EmpId { get; set; }
        public string CardId { get; set; }
        public string EmpName { get; set; }
        public decimal? CardBalance { get; set; }
        public int? CardSequ { get; set; }
        public int? CardTime { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string OpUser { get; set; }
    }
}
