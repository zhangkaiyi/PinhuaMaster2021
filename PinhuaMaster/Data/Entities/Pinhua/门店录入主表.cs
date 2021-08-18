using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.Pinhua
{
    public partial class 门店录入主表
    {
        public DateTime? 录入日期 { get; set; }
        public string 门店编号 { get; set; }
        public string 门店名称 { get; set; }
        public string 联系人 { get; set; }
        public string 手机 { get; set; }
        public string 座机 { get; set; }
        public string 传真 { get; set; }
        public string 地址 { get; set; }
        public string 门店照片 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 备注 { get; set; }
        public string 出样照片 { get; set; }
    }
}
