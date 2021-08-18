using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class DoorCardAndMachine
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public string CardSn { get; set; }
        public string EmpId { get; set; }
        public string EmpFname { get; set; }
        public int Clockid { get; set; }
        public int? ReadNo { get; set; }
        public int Type { get; set; }
        public string Right { get; set; }
        public string Opendoorpw { get; set; }
        public string Timebound { get; set; }
        public int Delflag { get; set; }
        public string Areacode { get; set; }
        public string Cardtypecode { get; set; }
        public int Cardtype { get; set; }
        public DateTime? Opdate { get; set; }
        public string Operator { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public string RealCardNo { get; set; }
    }
}
