using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using AutoMapper;

namespace PinhuaMaster.Pages.OrderManagement.Old
{
    public class IndexModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public IndexModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetAjaxOrders()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var orders = _pinhuaContext.发货.AsNoTracking().OrderByDescending(o => o.送货日期).ThenBy(o => o.业务描述).Select(o => _mapper.Map<ViewModel.OrderDTO>(o));

            return new JsonResult(orders, settings);
        }
    }
}