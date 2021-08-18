using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.OrderManagement.EasyDelivery.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyDelivery
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public CreateModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public Gi2ViewModel Order { get; set; }
        public List<SelectListItem> DeliveryTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CustomerSelectList { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> ContactsSelectList { get; set; } = new List<SelectListItem>();
        public List<往来单位联系人> ContactsList { get; set; }

        public void OnGet()
        {
            DeliveryTypes = BuildTypes();
            CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
            ContactsSelectList = _pinhuaContext.GetContactsSelectList();
            ContactsList = _pinhuaContext.往来单位联系人.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "157.1";
                var repCase = new EsRepCase
                {
                    RcId = Rcid,
                    RtId = rtId,
                    LstFiller = 2,
                    LstFillerName = User.Identity.Name,
                    LstFillDate = DateTime.Now,
                    //fillDate = DateTime.Now,
                    //wiId = "",
                    //state = 1,
                };

                var main = _mapper.Map<Gi2MainDTO, Gi2Main>(Order.Main);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;
                main.CustomerName = _pinhuaContext.往来单位.AsNoTracking().FirstOrDefault(p => p.单位编号 == Order.Main.CustomerId).单位名称;

                var details = _mapper.Map<List<Gi2DetaislDTO>, List<Gi2Details>>(Order.Details);
                details.ForEach(i =>
                {
                    i.ExcelServerRcid = Rcid;
                    i.ExcelServerRtid = rtId;
                    i.DeliveryId = main.DeliveryId;
                });

                if (details.Count == 0)
                {
                    ModelState.AddModelError("", "出库清单不可为空");
                    DeliveryTypes = BuildTypes();
                    CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
                    ContactsSelectList = _pinhuaContext.GetContactsSelectList();
                    return Page();
                }
                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.Gi2Main.Add(main);
                _pinhuaContext.Gi2Details.AddRange(details);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                DeliveryTypes = BuildTypes();
                CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
                ContactsSelectList = _pinhuaContext.GetContactsSelectList();
                return Page();
            }
        }

        public IActionResult OnGetContactNumber(string name)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var contact = _pinhuaContext.往来单位联系人.FirstOrDefault(p => p.联系人 == name) ?? new 往来单位联系人();

            return new JsonResult(contact, settings);
        }

        public IActionResult OnGetContactsInfo(string Id)
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var partner = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Id) ?? new 往来单位();

            var contacts = _pinhuaContext.往来单位联系人.Where(p => p.ExcelServerRcid == partner.ExcelServerRcid).ToList();

            return new JsonResult(contacts, settings);
        }

        private List<SelectListItem> BuildTypes()
        {
            var types = (from p in _pinhuaContext.业务类型.AsNoTracking()
                         where p.状态 == "Yes" && p.MvP == "GI"
                         select p).ToList();
            var groups = from p in types
                         group p by p.MvP into g
                         select g.Key;
            var groupingTypes = new List<SelectListItem>();
            foreach (var group in groups)
            {
                var optGroup = new SelectListGroup
                {
                    Name = group
                };
                foreach (var option in types)
                {
                    if (option.MvP == group)
                    {
                        groupingTypes.Add(new SelectListItem
                        {
                            Group = optGroup,
                            Text = option.业务类型1 + " - " + option.类型描述,
                            Value = option.业务类型1,
                        });
                    }
                }
            }
            return groupingTypes;
        }

    }
}