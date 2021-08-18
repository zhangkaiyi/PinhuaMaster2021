using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class PayrollDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal? AllHours { get; set; }
        public decimal? DaytimeHours { get; set; }
        public decimal? OvertimeHours { get; set; }
        public string IsFullAttendance { get; set; }
        public decimal? FinalAmount { get; set; }
        public int? Y { get; set; }
        public int? M { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public decimal? DaytimeAmount { get; set; }
        public decimal? OvertimeAmount { get; set; }
        public decimal? DinnerAmount { get; set; }
        public int? TimesOfDinner { get; set; }
        public int? DaysOfWork { get; set; }
        public int? DaysOfLeave { get; set; }
        public string PriceOverview { get; set; }
        public string Post { get; set; }
        public decimal? FullAttendanceAmount { get; set; }
        public int PrimayKey { get; set; }
    }
}
