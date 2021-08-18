using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.BasicInformation.ProductRegistration.ViewModel
{
    public class ProductRegistrationDTO
    {
        [Required, Display(Name = "描述")]
        public string Description { get; set; }
        [Required, Display(Name = "型号")]
        public string ModelNumber { get; set; }
        [Display(Name = "型号名称")]
        public string ModelName { get; set; }
        [Required, Display(Name = "子型号")]
        public int? SubModelNumber { get; set; }
        [Required, Display(Name = "规格")]
        public string Specification { get; set; }
        [Required, Display(Name = "长")]
        public decimal? Length { get; set; }
        [Required, Display(Name = "宽")]
        public decimal? Width { get; set; }
        [Required, Display(Name = "高")]
        public decimal? Height { get; set; }
        public string ExcelServerRcid { get; set; }
        public int? ExcelServerRn { get; set; }
        public int? ExcelServerCn { get; set; }
        public string ExcelServerRc1 { get; set; }
        public string ExcelServerWiid { get; set; }
        public string ExcelServerRtid { get; set; }
        public int? ExcelServerChg { get; set; }
    }

    public class ModelNumberDTO
    {
        public string ModelNumber { get; set; }
        public int? AvalibleSubModelNumber { get; set; }
        public string ModelName { get; set; }
    }

    public class ProductRegistrationProfile : Profile
    {
        public ProductRegistrationProfile()
        {
            CreateMap<ProductRegistrationMain, ProductRegistrationDTO>();
            CreateMap<ProductRegistrationDTO, ProductRegistrationMain>();
        }
    }
}
