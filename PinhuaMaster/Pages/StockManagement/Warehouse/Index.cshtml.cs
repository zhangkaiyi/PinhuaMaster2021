using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.StockManagement.Warehouse.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.Warehouse
{
    public class IndexModel : PageModel
    {
        private PinhuaContext _pinhuaContext { get; set; }
        private IMapper _mapper { get; set; }
        public IndexModel(PinhuaContext pinhuaContext,IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public List<WarehouseDTO> WarehouseList { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnGetAjaxWarehouseList()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            var orders = from p in _pinhuaContext.Warehouse
                         orderby p.Id ascending
                         select _mapper.Map<Data.Entities.Pinhua.Warehouse, WarehouseDTO>(p);

            return new JsonResult(orders, settings);
        }
    }
}