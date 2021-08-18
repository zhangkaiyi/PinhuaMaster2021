using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.BasicInformation.ModelNumber.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.ModelNumber
{
    public class IndexModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        private IMapper _mapper { get; set; }

        public IndexModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public List<ModelNumberDTO> ModelNumberList { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnGetAjaxModelNumberList()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var orders = from p in _pinhuaContext.产品型号清单
                         orderby p.排序 ascending, p.编号 ascending
                         select _mapper.Map<产品型号清单, ModelNumberDTO>(p);

            return new JsonResult(orders, settings);
        }
    }
}