using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class Test明细
    {
        public string 编号 { get; set; }
        public string 姓名 { get; set; }
        public int? 工资项编号 { get; set; }
        public string 工资项名称 { get; set; }
        public decimal? 设定金额 { get; set; }
        public DateTime? 起始日期 { get; set; }
        public DateTime? 截止日期 { get; set; }
        public decimal? 计算金额 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int UniqueId { get; set; }
    }
}
