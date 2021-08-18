using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;

namespace PinhuaMaster.Pages.Attendance.OvertimeForm
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaMaster.Data.Entities.Pinhua.PinhuaContext _context;

        public CreateModel(PinhuaMaster.Data.Entities.Pinhua.PinhuaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnGetAjaxUsers()
        {
            var users = _context.人员档案.AsNoTracking().Where(u => u.状态 == "在职").Select(u => new OvertimeUser { Id = u.人员编号, Name = u.姓名 }).ToList();
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(users, settings);
        }

        [BindProperty]
        public OvertimeFormInput Input { get; set; }

        public OvertimeFormES Dst { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Dst = Mapper.Map<OvertimeFormInput, OvertimeFormES>(Input);

            var Rcid = _context.GetNewRcId();
            var rtId = _context.GetRtId("OvertimeForm");
            var repCase = new EsRepCase
            {
                RcId = Rcid,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
            };

            Dst.Form.ExcelServerRcid = Rcid;
            Dst.Form.ExcelServerRtid = rtId;
            foreach (var user in Dst.Users)
            {
                user.ExcelServerRcid = Rcid;
                user.ExcelServerRtid = rtId;
            }

            _context.EsRepCase.Add(repCase);
            _context.OvertimeFormMain.Add(Dst.Form);
            _context.OvertimeFormDetails.AddRange(Dst.Users);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

    public class OvertimeForm
    {
        public DateTime YMD { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }

    public class OvertimeUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class OvertimeFormInput
    {
        public OvertimeForm Form { get; set; }
        public IList<OvertimeUser> Users { get; set; }
    }

    public class OvertimeFormES
    {
        public OvertimeFormMain Form { get; set; }
        public IList<OvertimeFormDetails> Users { get; set; }
    }

    public class OvertimeProfile : Profile
    {
        public OvertimeProfile()
        {
            CreateMap<OvertimeForm, OvertimeFormMain>()
                .ForMember(dst => dst.Y, map => map.MapFrom(src => src.YMD.Year))
                .ForMember(dst => dst.M, map => map.MapFrom(src => src.YMD.Month))
                .ForMember(dst => dst.D, map => map.MapFrom(src => src.YMD.Day))
                .ForMember(dst => dst.CreatedDate, map => map.MapFrom(src => DateTime.Now));

            CreateMap<OvertimeFormMain, OvertimeForm>()
                .ForMember(dst => dst.YMD, map => map.MapFrom(src => new DateTime(src.Y, src.M, src.D)));

            CreateMap<OvertimeUser, OvertimeFormDetails>()
                .ForMember(dst => dst.Id, map => map.MapFrom(src => src.Id))
                .ForMember(dst => dst.Name, map => map.MapFrom(src => src.Name));

            CreateMap<OvertimeFormInput, OvertimeFormES>()
                .ConvertUsing((src, dst) =>
                {
                    dst = new OvertimeFormES();
                    dst.Form = Mapper.Map<OvertimeForm, OvertimeFormMain>(src.Form);
                    dst.Users = new List<OvertimeFormDetails>();
                    src.Users = src.Users ?? new List<OvertimeUser>();
                    foreach (var user in src.Users)
                    {
                        var detail = Mapper.Map<OvertimeUser, OvertimeFormDetails>(user);
                        detail.Y = src.Form.YMD.Year;
                        detail.M = src.Form.YMD.Month;
                        detail.D = src.Form.YMD.Day;
                        dst.Users.Add(detail);
                    }
                    return dst;
                });

        }
    }
}