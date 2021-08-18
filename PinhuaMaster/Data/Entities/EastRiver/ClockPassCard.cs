using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ClockPassCard
    {
        public int Clockid { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public string EmpId { get; set; }
        public string EmpFname { get; set; }
        public int Type { get; set; }
        public string Right { get; set; }
        public string Opendoorpw { get; set; }
        public string Timebound { get; set; }
        public string Areacode { get; set; }
        public string Cardtypecode { get; set; }
        public int? Cardtype { get; set; }
    }
}
