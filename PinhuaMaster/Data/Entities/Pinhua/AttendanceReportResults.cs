using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class AttendanceReportResults
    {
        public string 编号 { get; set; }
        public string 姓名 { get; set; }
        public decimal? 正班 { get; set; }
        public decimal? 加班 { get; set; }
        public decimal? 总工时 { get; set; }
        public string 是否全勤 { get; set; }
        public int? 迟到 { get; set; }
        public int? 早退 { get; set; }
        public int? 缺勤 { get; set; }
        public int? 请假 { get; set; }
        public int? 用餐 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int Y { get; set; }
        public int M { get; set; }
    }
}
