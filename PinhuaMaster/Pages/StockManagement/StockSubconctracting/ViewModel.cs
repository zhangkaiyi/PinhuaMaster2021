using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.StockManagement.StockSubconctracting.ViewModel
{
    public class StockSubconctractingViewModel
    {
        public StockSubconctractingMainDTO Main { get; set; } = new StockSubconctractingMainDTO();
        public List<StockSubconctractingDetailsDTO> Details { get; set; } = new List<StockSubconctractingDetailsDTO>();
        public List<SelectListItem> MovementTypeList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CustomerList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> WarehouseList { get; set; } = new List<SelectListItem>();
    }

    public class StockSubconctractingMainDTO
    {
        [Required, Display(Name = "单号")]
        public string OrderId { get; set; }
        [Required, Display(Name = "客户单位")]
        public string CustomerId { get; set; }
        [Display(Name = "客户单位名称")]
        public string CustomerName { get; set; }
        [Required, Display(Name = "移动类型")]
        public string MovementType { get; set; }
        [Display(Name = "移动类型描述")]
        public string MovementTypeDescription { get; set; }
        [Required, Display(Name = "日期")]
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? OrderDate { get; set; }
        [Display(Name = "地址")]
        public string CustomerAddress { get; set; }
        [Display(Name = "金额")]
        public decimal? Amount { get; set; }
        [Display(Name = "备注")]
        public string Remarks { get; set; }
        [Display(Name = "联系人")]
        public string Contact { get; set; }
        [Display(Name = "联系电话")]
        public string ContactNumber { get; set; }
        [Display(Name = "制单人")]
        public string CreatedBy { get; set; }
        [Display(Name = "制单日期")]
        [Newtonsoft.Json.JsonConverter(typeof(MyDateTimeConverter))]
        public DateTime? CreatedDate { get; set; }
        [Required, Display(Name = "出仓")]
        public string WarehouseFrom { get; set; }
        [Display(Name = "出仓名称")]
        public string WarehouseFromName { get; set; }
        [Required, Display(Name = "进仓")]
        public string WarehouseTo { get; set; }
        [Display(Name = "进仓名称")]
        public string WarehouseToName { get; set; }
        [Display(Name = "关联号")]
        public string ExcelServerRcid { get; set; }
        [Display(Name = "模板号")]
        public string ExcelServerRtid { get; set; }
        //public int? ExcelServerRn { get; set; }
        //public int? ExcelServerCn { get; set; }
        //public string ExcelServerRc1 { get; set; }
        //public string ExcelServerWiid { get; set; }
        //public int? ExcelServerChg { get; set; }
    }

    public class StockSubconctractingDetailsDTO
    {
        public string ModelNumber { get; set; }
        public string ModelName { get; set; }
        public int? SubModelNumber { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalQtyConverter))]
        public decimal? Qty { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalSquareConverter))]
        public decimal? UnitQty { get; set; }
        public string Unit { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalAmountConverter))]
        public decimal? Price { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(MyDecimalAmountConverter))]
        public decimal? Amount { get; set; }
        public int Id { get; set; }
        public string Remarks { get; set; }
        public string OrderId { get; set; }
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
        //public int? ExcelServerRn { get; set; }
        //public int? ExcelServerCn { get; set; }
        //public string ExcelServerRc1 { get; set; }
        //public string ExcelServerWiid { get; set; }
        //public int? ExcelServerChg { get; set; }
    }

    public class StockSubconctractingSearch
    {
        [Display(Name = "单号")]
        public string OrderId { get; set; }
        [Display(Name = "客户编号")]
        public string CustomerId { get; set; }
        [Display(Name = "客户名称")]
        public string CustomerName { get; set; }
        [Display(Name = "移动类型")]
        public string MovementType { get; set; }
        [Display(Name = "移动类型描述")]
        public string MovementTypeDescription { get; set; }
        [Display(Name = "单据日期")]
        public DateTime? OrderDate { get; set; }
        [Display(Name = "收货地址")]
        public string CustomerAddress { get; set; }
        [Display(Name = "单据金额")]
        public decimal? TotalAmount { get; set; }
        [Display(Name = "备注")]
        public string Remarks { get; set; }
        [Display(Name = "联系人")]
        public string Contact { get; set; }
        [Display(Name = "联系电话")]
        public string ContactNumber { get; set; }
        [Display(Name = "制单人")]
        public string CreatedBy { get; set; }
        [Display(Name = "制单日期")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "物料编号")]
        public int? ItemId { get; set; }
        [Display(Name = "物料描述")]
        public string ItemDescription { get; set; }
        [Display(Name = "物料规格")]
        public string ItemSpecification { get; set; }
        [Display(Name = "物料长度")]
        public decimal? ItemLength { get; set; }
        [Display(Name = "物料宽度")]
        public decimal? ItemWidth { get; set; }
        [Display(Name = "物料高度")]
        public decimal? ItemHeight { get; set; }
        [Display(Name = "物料片数")]
        public decimal? ItemQty { get; set; }
        [Display(Name = "物料单位数量")]
        public decimal? ItemUnitQty { get; set; }
        [Display(Name = "物料单位")]
        public string ItemUnit { get; set; }
        [Display(Name = "物料单价")]
        public decimal? ItemPrice { get; set; }
        [Display(Name = "物料金额")]
        public decimal? ItemAmount { get; set; }
        [Display(Name = "物料备注")]
        public string ItemRemarks { get; set; }
    }

    public class StockSubconctractingProfile : Profile
    {
        public StockSubconctractingProfile()
        {
            CreateMap<StockSubconctractingMain, StockSubconctractingMainDTO>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<StockSubconctractingMainDTO, StockSubconctractingMain>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate));

            CreateMap<StockSubconctractingDetails, StockSubconctractingDetailsDTO>();
            //.ForMember(dst => dst.DeliveryId, map => map.MapFrom(src => src.Id.ToString()));
            CreateMap<StockSubconctractingDetailsDTO, StockSubconctractingDetails>();
            //.ForMember(dst => dst.Id, map => map.MapFrom(src => int.Parse(src.Index)));
        }
    }
}
