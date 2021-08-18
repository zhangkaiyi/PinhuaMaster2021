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
using PinhuaMaster.Pages.StockManagement.StockIn.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.StockIn
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
        public StockInViewModel Order { get; set; } = new StockInViewModel();

        public void OnGet()
        {
            Order.MovementTypeList = BuildTypes();
            Order.CustomerList = _pinhuaContext.GetCustomerSelectList();
            Order.WarehouseList = _pinhuaContext.GetWarehouseSelectList();

            Order.Main.OrderId = buildOrderId();
            Order.Main.MovementType = "101";
        }

        public IActionResult OnGetApiGetModelNames()
        {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(_pinhuaContext.myView_Product, settings);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "175.1";
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

                var main = _mapper.Map<StockInMainDTO, StockInMain>(Order.Main);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;
                main.CustomerName = _pinhuaContext.往来单位.AsNoTracking().FirstOrDefault(p => p.单位编号 == Order.Main.CustomerId).单位名称;

                var details = _mapper.Map<List<StockInDetailsDTO>, List<StockInDetails>>(Order.Details);
                details.ForEach(i =>
                {
                    i.ExcelServerRcid = Rcid;
                    i.ExcelServerRtid = rtId;
                    i.OrderId = main.OrderId;
                });

                if (details.Count == 0)
                {
                    ModelState.AddModelError("", "清单不可为空");
                    Order.MovementTypeList = BuildTypes();
                    Order.CustomerList = _pinhuaContext.GetCustomerSelectList();
                    Order.WarehouseList = _pinhuaContext.GetWarehouseSelectList();
                    return Page();
                }
                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.StockInMain.Add(main);
                _pinhuaContext.StockInDetails.AddRange(details);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                Order.MovementTypeList = BuildTypes();
                Order.CustomerList = _pinhuaContext.GetCustomerSelectList();
                Order.WarehouseList = _pinhuaContext.GetWarehouseSelectList();
                return Page();
            }
        }

        private string buildOrderId()
        {
            _pinhuaContext.Database.OpenConnection();
            var cmd = _pinhuaContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "SELECT dbo.GetStockInID('RK',GETDATE())";
            var result = cmd.ExecuteReader();
            var orderId = string.Empty;
            while (result.Read())
            {
                orderId = result[0].ToString();
            }
            _pinhuaContext.Database.CloseConnection();
            return orderId;
        }

        private List<SelectListItem> BuildTypes()
        {
            var types = (from p in _pinhuaContext.业务类型.AsNoTracking()
                        where p.状态 == "Yes" && p.MvP == "GR"
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