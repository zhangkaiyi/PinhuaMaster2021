using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class BlackCardTask
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public string EmpId { get; set; }
        public string EmpFname { get; set; }
        public int Flag { get; set; }
        public int? ClockId { get; set; }
        public int BlackSequ { get; set; }
        public int Cardtype { get; set; }
        public string Cardtypecode { get; set; }
        public string Areacode { get; set; }
        public DateTime? Opdate { get; set; }
        public string Operator { get; set; }
        public DateTime? ExecuteDate { get; set; }
    }
}
