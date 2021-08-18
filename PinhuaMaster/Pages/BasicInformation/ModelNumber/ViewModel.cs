using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.BasicInformation.ModelNumber.ViewModel
{
    public class ModelNumberDTO
    {
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public int? Rank { get; set; }
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
        //public int? ExcelServerRn { get; set; }
        //public int? ExcelServerCn { get; set; }
        //public string ExcelServerRc1 { get; set; }
        //public string ExcelServerWiid { get; set; }
        //public int? ExcelServerChg { get; set; }
        public string 线稿 { get; set; }
        public string 实物图形 { get; set; }
    }

    public class ModelNumberProfile : Profile
    {
        public ModelNumberProfile()
        {
            CreateMap<产品型号清单, ModelNumberDTO>()
            .ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            .ForMember(dst => dst.ExcelServerRtid, map => map.MapFrom(src => src.ExcelServerRtid))
            .ForMember(dst => dst.ModelNumber, map => map.MapFrom(src => src.编号))
            .ForMember(dst => dst.ModelName, map => map.MapFrom(src => src.名称))
            .ForMember(dst => dst.Rank, map => map.MapFrom(src => src.排序));
            CreateMap<ModelNumberDTO, 产品型号清单>()
            .ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            .ForMember(dst => dst.ExcelServerRtid, map => map.MapFrom(src => src.ExcelServerRtid))
            .ForMember(dst => dst.编号, map => map.MapFrom(src => src.ModelNumber))
            .ForMember(dst => dst.名称, map => map.MapFrom(src => src.ModelName))
            .ForMember(dst => dst.排序, map => map.MapFrom(src => src.Rank));
        }
    }
}
