using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class AssignEmp
    {
        public int Id { get; set; }
        public string CardId { get; set; }
        public int? ClockId { get; set; }
        public int? Kind { get; set; }
        public double? LossMoney { get; set; }
        public string Doors { get; set; }
        public int? Level { get; set; }
        public string AreaId { get; set; }
        public string PassWord { get; set; }
        public string PassTime { get; set; }
        public DateTime? OpDate { get; set; }
        public string OpUser { get; set; }
        public string EmpId { get; set; }
        public string SegTime { get; set; }
    }
}
