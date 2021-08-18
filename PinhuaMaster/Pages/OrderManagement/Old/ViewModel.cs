using AutoMapper;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.OrderManagement.Old.ViewModel
{
    public class OrderDTO
    {
        public string 客户 { get; set; }
        public string 送货单号 { get; set; }
        public string 地址 { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? 送货日期 { get; set; }
        public string 备注 { get; set; }
        public string 客户编号 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 业务类型 { get; set; }
        public string 业务描述 { get; set; }
        public string 冲销理由 { get; set; }
        public string 创建者 { get; set; }
        public string 联系人 { get; set; }
        public string 联系电话 { get; set; }
    }

    public class OldOrderProfile : Profile
    {
        public OldOrderProfile()
        {
            CreateMap<发货, OrderDTO>();
        }
    }
}
