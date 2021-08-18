using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class ReportDay
    {
        public string EmpId { get; set; }
        public DateTime SignDate { get; set; }
        public bool Adjusted { get; set; }
        public string ShiftId { get; set; }
        public byte? Status { get; set; }
        public byte? SignCount { get; set; }
        public string In1 { get; set; }
        public string Out1 { get; set; }
        public string In2 { get; set; }
        public string Out2 { get; set; }
        public string In3 { get; set; }
        public string Out3 { get; set; }
        public string In4 { get; set; }
        public string Out4 { get; set; }
        public string In5 { get; set; }
        public string Out5 { get; set; }
        public decimal? PlanDays { get; set; }
        public decimal? SunDays { get; set; }
        public decimal? HdDays { get; set; }
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
        public string Notes { get; set; }
        public decimal? ShiftHrs { get; set; }
        public decimal? OnwatchHrs { get; set; }
        public bool? Audit { get; set; }
        public decimal? LateMins1 { get; set; }
        public decimal? LateMins2 { get; set; }
        public decimal? LeaveMins1 { get; set; }
        public decimal? LeaveMins2 { get; set; }
        public decimal? AbsentHrs1 { get; set; }
        public decimal? AbsentHrs2 { get; set; }
        public string Marks { get; set; }
    }
}
