using AutoMapper;
using PinhuaMaster.Data.Entities.Pinhua;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Pages.Personnel.Files.ViewModel
{
    public class PersonnelFilesDTO
    {
        [Display(Name = "编号")]
        public string Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "状态")]
        public string State { get; set; }
        [Required, Display(Name = "性别")]
        public string Sex { get; set; }
        [Required, Display(Name = "身份证")]
        [RegularExpression(@"^(^\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", ErrorMessage = "身份信息无效")]
        public string IdentityCard { get; set; }
        [Required, Display(Name = "生日")]
        public DateTime? BirthDate { get; set; }
        [Required, Display(Name = "电话")]
        public string ContactNumber { get; set; }
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Required, Display(Name = "入职时间")]
        public DateTime? InServiceFrom { get; set; }
        [Display(Name = "离职时间")]
        public DateTime? InServiceEnd { get; set; }
        [Display(Name = "登记时间")]
        public DateTime? SignedDate { get; set; }
        [Display(Name = "离职原因")]
        public string ReasonOfLeave { get; set; }
        [Display(Name = "岗位编号")]
        public string PostId { get; set; }
        [Display(Name = "工资方案")]
        public string SchemaId { get; set; }

        public string ExcelServerRcid { get; set; }
        public string ExcelServerRtid { get; set; }
    }

    public class PersonnelFilesProfile : Profile
    {
        public PersonnelFilesProfile()
        {
            CreateMap<人员档案, PersonnelFilesDTO>()
                .ForMember(dst => dst.Id, map => map.MapFrom(src => src.人员编号))
                .ForMember(dst => dst.SignedDate, map => map.MapFrom(src => src.登记时间))
                .ForMember(dst => dst.Name, map => map.MapFrom(src => src.姓名))
                .ForMember(dst => dst.State, map => map.MapFrom(src => src.状态))
                .ForMember(dst => dst.Sex, map => map.MapFrom((src, dst) => string.IsNullOrEmpty(src.性别) ? "女" : src.性别))
                .ForMember(dst => dst.IdentityCard, map => map.MapFrom(src => src.证件号码))
                .ForMember(dst => dst.BirthDate, map => map.MapFrom(src => src.出生年月))
                .ForMember(dst => dst.ContactNumber, map => map.MapFrom(src => src.联系电话))
                .ForMember(dst => dst.Address, map => map.MapFrom(src => src.联系地址))
                .ForMember(dst => dst.InServiceFrom, map => map.MapFrom(src => src.入职时间))
                .ForMember(dst => dst.InServiceEnd, map => map.MapFrom(src => src.离职时间))
                .ForMember(dst => dst.ReasonOfLeave, map => map.MapFrom(src => src.离职或辞退原因))
                .ForMember(dst => dst.PostId, map => map.MapFrom((src, dst) => string.IsNullOrEmpty(src.工作岗位) ? "1" : src.工作岗位))
                .ForMember(dst => dst.SchemaId, map => map.MapFrom((src, dst) => string.IsNullOrEmpty(src.工资方案) ? "1" : src.工资方案))
                .ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom(src => src.ExcelServerRcid))
                .ForMember(dst => dst.ExcelServerRtid, map => map.MapFrom(src => src.ExcelServerRtid));

            CreateMap<PersonnelFilesDTO, 人员档案>()
                .ForMember(dst => dst.人员编号, map => map.MapFrom(src => src.Id))
                .ForMember(dst => dst.登记时间, map => map.MapFrom(src => src.SignedDate))
                .ForMember(dst => dst.姓名, map => map.MapFrom(src => src.Name))
                .ForMember(dst => dst.状态, map => map.MapFrom(src => src.State))
                .ForMember(dst => dst.性别, map => map.MapFrom(src => src.Sex))
                .ForMember(dst => dst.证件号码, map => map.MapFrom(src => src.IdentityCard))
                .ForMember(dst => dst.出生年月, map => map.MapFrom(src => src.BirthDate))
                .ForMember(dst => dst.联系电话, map => map.MapFrom(src => src.ContactNumber))
                .ForMember(dst => dst.联系地址, map => map.MapFrom(src => src.Address))
                .ForMember(dst => dst.入职时间, map => map.MapFrom(src => src.InServiceFrom))
                .ForMember(dst => dst.离职时间, map => map.MapFrom(src => src.InServiceEnd))
                .ForMember(dst => dst.离职或辞退原因, map => map.MapFrom(src => src.ReasonOfLeave))
                .ForMember(dst => dst.工作岗位, map => map.MapFrom(src => src.PostId))
                .ForMember(dst => dst.工资方案, map => map.MapFrom(src => src.SchemaId))
                .ForMember(dst => dst.ExcelServerRcid, map => map.MapFrom((src, dst) => string.IsNullOrEmpty(src.ExcelServerRcid) ? dst.ExcelServerRcid : src.ExcelServerRcid))
                .ForMember(dst => dst.ExcelServerRtid, map => map.MapFrom((src, dst) => string.IsNullOrEmpty(src.ExcelServerRtid) ? dst.ExcelServerRtid : src.ExcelServerRtid));
        }
    }


}

