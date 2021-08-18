using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.BasicInformation.Partner.ViewModel
{
    public class PartnerDTO
    {
        public string 单位编号 { get; set; }
        [Required]
        public string 单位名称 { get; set; }
        public string 电话 { get; set; }
        public string 传真 { get; set; }
        public string 单位地址 { get; set; }
        public DateTime? 登记日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
        public string 单位类型 { get; set; }
        public string 单位性质 { get; set; }
        public int? Rank { get; set; }
        public string 外协关联仓库 { get; set; }
    }

    public class PartnerProfile : Profile
    {
        public PartnerProfile()
        {
            CreateMap<往来单位, PartnerDTO>();
            CreateMap<PartnerDTO, 往来单位>();
        }
    }
}
