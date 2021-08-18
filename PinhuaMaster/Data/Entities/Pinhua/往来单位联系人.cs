using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 往来单位联系人
    {
        public string 联系人 { get; set; }
        public string 手机 { get; set; }
        public string 电话 { get; set; }
        public string 传真 { get; set; }
        public string 邮箱 { get; set; }
        public string 职务 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public int Idx { get; set; }
    }
}
