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
using PinhuaMaster.Pages.BasicInformation.ProductRegistration.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.ProductRegistration
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
        public ProductRegistrationDTO ProductRegistrationInfo { get; set; } = new ProductRegistrationDTO();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "178.1";
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

                var main = _mapper.Map<ProductRegistrationDTO, ProductRegistrationMain>(ProductRegistrationInfo);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;

                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.ProductRegistrationMain.Add(main);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnGetModelNumbers()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var list = (from m in _pinhuaContext.产品型号清单.AsNoTracking()
                        join p in _pinhuaContext.ProductRegistrationMain.AsNoTracking() on m.编号 equals p.ModelNumber into products
                        select new ModelNumberDTO
                        {
                            ModelNumber = m.编号,
                            ModelName = m.名称,
                            AvalibleSubModelNumber = products.Count() > 0 ? products.Max(x => x.SubModelNumber) + 1 : 1
                        }).ToList();

            return new JsonResult(list, settings);
        }
    }
}