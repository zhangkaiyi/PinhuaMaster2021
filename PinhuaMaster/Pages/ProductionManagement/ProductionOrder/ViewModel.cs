using AutoMapper;
using Microsoft.AspNetCore.Http;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder.ViewModel
{
    public class vm生产单
    {
        public dto生产单M M { get; set; }
        public List<dto生产单D> D { get; set; }
    }

    public class dto生产单M
    {
        public string 单号 { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        [Required]
        public DateTime? 日期 { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        [Required]
        public DateTime? 交期 { get; set; }
        [Required]
        public string 客户号 { get; set; }
        public string 客户名 { get; set; }
        public string 状态 { get; set; }
        public string 概要 { get; set; }
        public string 备注 { get; set; }
        [Display(Name = "制单")]
        public string 制单 { get; set; }
        [Display(Name = "制单日期")]
        [Newtonsoft.Json.JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? 制单日期 { get; set; }
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
    }

    public class dto生产单D
    {
        public string 描述 { get; set; }
        public decimal? 长 { get; set; }
        public decimal? 宽 { get; set; }
        public decimal? 高 { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalQtyConverter))]
        public decimal? 片数 { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalSquareConverter))]
        public decimal? 平方数 { get; set; }
        public string 是否开槽 { get; set; }
        public string 开槽要求 { get; set; }
        public string 是否拉丝 { get; set; }
        public string 拉丝要求 { get; set; }
        public string 是否刻线 { get; set; }
        public string 刻线要求 { get; set; }
        public string 是否油漆 { get; set; }
        public string 油漆要求 { get; set; }
        public string 图片 { get; set; }
        public string 图片base64 { get; set; }
        public string 图片name { get; set; }
        public string 图片type { get; set; }
        public string 其他要求 { get; set; }
        public int Idx { get; set; }
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
    }

    public class 生产单Profile : Profile
    {
        public 生产单Profile()
        {
            CreateMap<生产单, dto生产单M>()
            .ForMember(dst => dst.备注, map => map.MapFrom(src => string.IsNullOrEmpty(src.备注) ? "" : src.备注));
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<dto生产单M, 生产单>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate));

            CreateMap<生产单d, dto生产单D>()
            .ForMember(dst => dst.其他要求, map => map.MapFrom(src => string.IsNullOrEmpty(src.其他要求) ? "" : src.其他要求))
            .ForMember(dst => dst.刻线要求, map => map.MapFrom(src => string.IsNullOrEmpty(src.刻线要求) ? "" : src.刻线要求))
            .ForMember(dst => dst.是否刻线, map => map.MapFrom(src => string.IsNullOrEmpty(src.刻线要求) ? "否" : "是"))
            .ForMember(dst => dst.拉丝要求, map => map.MapFrom(src => string.IsNullOrEmpty(src.拉丝要求) ? "" : src.拉丝要求))
            .ForMember(dst => dst.是否拉丝, map => map.MapFrom(src => string.IsNullOrEmpty(src.拉丝要求) ? "否" : "是"))
            .ForMember(dst => dst.开槽要求, map => map.MapFrom(src => string.IsNullOrEmpty(src.开槽要求) ? "" : src.开槽要求))
            .ForMember(dst => dst.是否开槽, map => map.MapFrom(src => string.IsNullOrEmpty(src.开槽要求) ? "否" : "是"))
            .ForMember(dst => dst.油漆要求, map => map.MapFrom(src => string.IsNullOrEmpty(src.油漆要求) ? "" : src.油漆要求))
            .ForMember(dst => dst.是否油漆, map => map.MapFrom(src => string.IsNullOrEmpty(src.油漆要求) ? "否" : "是"));
            CreateMap<dto生产单D, 生产单d>();
            //.ForMember(dst => dst.Id, map => map.MapFrom(src => int.Parse(src.Index)));
        }
    }
}
