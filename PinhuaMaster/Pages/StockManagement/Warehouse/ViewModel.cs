using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.StockManagement.Warehouse.ViewModel
{
    public class WarehouseViewModel
    {
        public WarehouseDTO Main { get; set; } = new WarehouseDTO();
    }

    public class WarehouseDTO
    {
        [Required, Display(Name = "编号")]
        public string Id { get; set; }
        [Display(Name = "名称")]
        public string Name { get; set; }
        [Display(Name = "联系人")]
        public string Contact { get; set; }
        [Display(Name = "联系电话")]
        public string Phone { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Display(Name = "关联号")]
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
        //public int? ExcelServerRn { get; set; }
        //public int? ExcelServerCn { get; set; }
        //public string ExcelServerRc1 { get; set; }
        //public string ExcelServerWiid { get; set; }
        //public int? ExcelServerChg { get; set; }
    }

    public class WarehouseProfile : Profile
    {
        public WarehouseProfile()
        {
            CreateMap<PinhuaMaster.Data.Entities.Pinhua.Warehouse, WarehouseDTO>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<WarehouseDTO, PinhuaMaster.Data.Entities.Pinhua.Warehouse>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate));
        }
    }
}
