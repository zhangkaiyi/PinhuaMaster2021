using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.Statement.ViewModel;

namespace PinhuaMaster.Pages.Statement.External
{
    public class YiJiaModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public YiJiaModel(PinhuaContext pinhuaContext)
        {
            CustomerId = "KH-1304-001";
            _pinhuaContext = pinhuaContext;
        }

        public string CustomerId { get; set; }

        public IEnumerable<DbQuery_对账汇总> StatementData { get; set; }

        public void OnGet()
        {
            StatementData = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == CustomerId).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
        }

        public IActionResult OnGetAjax()
        {
            var dto = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == CustomerId).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(dto, settings);
        }
    }
}