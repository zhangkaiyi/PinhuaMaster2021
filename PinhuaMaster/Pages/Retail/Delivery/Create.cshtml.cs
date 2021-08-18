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
using PinhuaMaster.Pages.Retail.Delivery.ViewModel;

namespace PinhuaMaster.Pages.Retail.Delivery
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
        public Gi2ViewModel Order { get; set; } = new Gi2ViewModel();

        public void OnGet()
        {
            Order.DeliveryTypes = BuildTypes();
            Order.CustomerSelectList = _pinhuaContext.GetCustomerSelectList();

            Order.Main.DeliveryId = buildOrderId();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "171.1";
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

                var main = _mapper.Map<Gi2MainDTO, RetailGiMain>(Order.Main);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;

                var details = _mapper.Map<List<Gi2DetaislDTO>, List<RetailGiDetails>>(Order.Details);
                details.ForEach(i =>
                {
                    i.ExcelServerRcid = Rcid;
                    i.ExcelServerRtid = rtId;
                    i.DeliveryId = main.DeliveryId;
                });

                if (details.Count == 0)
                {
                    ModelState.AddModelError("", "出库清单不可为空");
                    Order.DeliveryTypes = BuildTypes();
                    Order.CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
                    return Page();
                }
                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.RetailGiMain.Add(main);
                _pinhuaContext.RetailGiDetails.AddRange(details);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                Order.DeliveryTypes = BuildTypes();
                Order.CustomerSelectList = _pinhuaContext.GetCustomerSelectList();
                return Page();
            }
        }

        private string buildOrderId()
        {
            _pinhuaContext.Database.OpenConnection();
            var cmd = _pinhuaContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "SELECT dbo.GetRetailDeliveryID('RS',GETDATE())";
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