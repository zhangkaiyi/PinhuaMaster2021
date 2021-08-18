using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ReportMonth
    {
        public string Ym { get; set; }
        public string EmpId { get; set; }
        public bool Audit { get; set; }
        public string Auditor { get; set; }
        public DateTime? AuditDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public short? MonthDays { get; set; }
        public decimal? PlanDays { get; set; }
        public decimal? SunDays { get; set; }
        public decimal? HdDays { get; set; }
        public decimal? CalDays { get; set; }
        public decimal? DutyDays { get; set; }
        public decimal? WorkDays { get; set; }
        public decimal? AbsentDays { get; set; }
        public decimal? LeaveDays { get; set; }
        public decimal? FactHrs { get; set; }
        public decimal? BasicHrs { get; set; }
        public decimal? MidHrs { get; set; }
        public decimal? NsHrs { get; set; }
        public decimal? OtHrs { get; set; }
        public decimal? SunHrs { get; set; }
        public decimal? HdHrs { get; set; }
        public decimal? AbsentHrs { get; set; }
        public decimal? LateMins { get; set; }
        public decimal? LateCount { get; set; }
        public decimal? LeaveMins { get; set; }
        public decimal? LeaveCount { get; set; }
        public decimal? NsCount { get; set; }
        public decimal? MidCount { get; set; }
        public decimal? OtCount { get; set; }
        public decimal? L0hrs { get; set; }
        public decimal? L1hrs { get; set; }
        public decimal? L2hrs { get; set; }
        public decimal? L3hrs { get; set; }
        public decimal? L4hrs { get; set; }
        public decimal? L5hrs { get; set; }
        public decimal? L6hrs { get; set; }
        public decimal? L7hrs { get; set; }
        public decimal? L8hrs { get; set; }
        public decimal? L9hrs { get; set; }
        public decimal? OutworkHrs { get; set; }
        public decimal? ShutdownHrs { get; set; }
        public decimal? OutworkDays { get; set; }
        public decimal? ShutdownDays { get; set; }
        public decimal? ShiftHrs { get; set; }
        public decimal? OnwatchHrs { get; set; }
        public decimal? RelaxDays { get; set; }
        public decimal? OverDays { get; set; }
    }
}
