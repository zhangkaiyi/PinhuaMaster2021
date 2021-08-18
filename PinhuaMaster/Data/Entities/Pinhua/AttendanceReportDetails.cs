using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class AttendanceReportDetails
    {
        public DateTime? 日期 { get; set; }
        public int? 班段 { get; set; }
        public string 班段描述 { get; set; }
        public string 考勤结果 { get; set; }
        public DateTime? 上班 { get; set; }
        public DateTime? 下班 { get; set; }
        public decimal? 工时 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int 主键 { get; set; }
        public string 编号 { get; set; }
        public string 姓名 { get; set; }
    }
}
