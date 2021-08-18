﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.Retail.Delivery.ViewModel
{
    public class Gi2ViewModel
    {
        public Gi2MainDTO Main { get; set; } = new Gi2MainDTO();
        public List<Gi2DetaislDTO> Details { get; set; } = new List<Gi2DetaislDTO>();
        public List<SelectListItem> DeliveryTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CustomerSelectList { get; set; } = new List<SelectListItem>();
    }

    public class Gi2MainDTO
    {
        [Required, Display(Name = "单号")]
        public string DeliveryId { get; set; }
        [Display(Name = "客户单位")]
        public string CustomerId { get; set; }
        [Required,Display(Name = "客户名称")]
        public string CustomerName { get; set; }
        [Required, Display(Name = "业务类型")]
        public string DeliveryType { get; set; }
        [Display(Name = "业务描述")]
        public string DeliveryTypeDescription { get; set; }
        [Required, Display(Name = "日期")]
        [Newtonsoft.Json.JsonConverter(typeof(MyDateConverter))]
        public DateTime? DeliveryDate { get; set; }
        [Display(Name = "地址")]
        public string DeliveryAddress { get; set; }
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

    public class Gi2DetaislDTO
    {
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
        public string DeliveryId { get; set; }
        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
        //public int? ExcelServerRn { get; set; }
        //public int? ExcelServerCn { get; set; }
        //public string ExcelServerRc1 { get; set; }
        //public string ExcelServerWiid { get; set; }
        //public int? ExcelServerChg { get; set; }
    }

    public class Gi2Search
    {
        [Display(Name = "单号")]
        public string DeliveryId { get; set; }
        [Display(Name = "客户编号")]
        public string CustomerId { get; set; }
        [Display(Name = "客户名称")]
        public string CustomerName { get; set; }
        [Display(Name = "单据类型")]
        public string DeliveryType { get; set; }
        [Display(Name = "单据类型描述")]
        public string DeliveryTypeDescription { get; set; }
        [Display(Name = "送货日期")]
        public DateTime? DeliveryDate { get; set; }
        [Display(Name = "送货地址")]
        public string DeliveryAddress { get; set; }
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

    public class Gi2Profile : Profile
    {
        public Gi2Profile()
        {
            CreateMap<RetailGiMain, Gi2MainDTO>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<Gi2MainDTO, RetailGiMain>();
            //.ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
            //.ForMember(dst => dst.DeliveryDate, map => map.MapFrom(src => src.DeliveryDate));

            CreateMap<RetailGiDetails, Gi2DetaislDTO>();
            //.ForMember(dst => dst.DeliveryId, map => map.MapFrom(src => src.Id.ToString()));
            CreateMap<Gi2DetaislDTO, RetailGiDetails>();
            //.ForMember(dst => dst.Id, map => map.MapFrom(src => int.Parse(src.Index)));
        }
    }
}
