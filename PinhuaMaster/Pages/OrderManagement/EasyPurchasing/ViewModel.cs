using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.OrderManagement.EasyPurchasing.ViewModel
{
    public class PurchasingViewModel
    {
        public Gr2MainDto Main { get; set; } = new Gr2MainDto();
        public List<Gr2DetailsDto> Details { get; set; } = new List<Gr2DetailsDto>();
        public List<SelectListItem> PurchasingTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SupplierList { get; set; } = new List<SelectListItem>();
    }

    public partial class Gr2MainDto
    {
        public string PurchasingId { get; set; }
        public string PurchasingType { get; set; }
        public string Supplier { get; set; }
        public string SupplierName { get; set; }
        public string PurchasingAddress { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? PurchasingDate { get; set; }
        public string Remarks { get; set; }
        public string Contact { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedBy { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }

    public partial class Gr2DetailsDto
    {
        public string PurchasingId { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitQty { get; set; }
        public string Unit { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }

    public class Gr2Profile : Profile
    {
        public Gr2Profile()
        {
            CreateMap<Gr2Main, Gr2MainDto>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<Gr2MainDto, Gr2Main>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate));

            CreateMap<Gr2Details, Gr2DetailsDto>();
            //.ForMember(dst => dst.DeliveryId, map => map.MapFrom(src => src.Id.ToString()));
            CreateMap<Gr2DetailsDto, Gr2Details>();
            //.ForMember(dst => dst.Id, map => map.MapFrom(src => int.Parse(src.Index)));
        }
    }
}
