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
using PinhuaMaster.Pages.OrderManagement.EasyDelivery.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyDelivery
{
    public class DetailsModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public DetailsModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public Gi2ViewModel Order { get; set; }
        public List<SelectListItem> DeliveryTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();

        public void OnGet(string Id)
        {
            DeliveryTypes = BuildTypes();
            Customers = BuildCustomers();

            var remoteOrder = _pinhuaContext.Gi2Main.AsNoTracking().FirstOrDefault(p => p.DeliveryId == Id);
            if (remoteOrder == null)
                return;

            Order = new Gi2ViewModel
            {
                Main = _mapper.Map<Gi2Main, Gi2MainDTO>(remoteOrder),
                Details = _mapper.Map<List<Gi2Details>, List<Gi2DetaislDTO>>(_pinhuaContext.Gi2Details.AsNoTracking().Where(p => p.DeliveryId == remoteOrder.DeliveryId).ToList()),
            };

            Order.Main.DeliveryTypeDescription = _pinhuaContext.业务类型.FirstOrDefault(p => p.业务类型1 == Order.Main.DeliveryType).类型描述;
        }

        private List<SelectListItem> BuildTypes()
        {
            var types = from p in _pinhuaContext.业务类型.AsNoTracking()
                        where p.状态 == "Yes" && p.MvP == "GI"
                        select p;
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

        private List<SelectListItem> BuildCustomers()
        {
            var customers = from p in _pinhuaContext.往来单位.ToList()
                            select p;

            var groups = from p in customers
                         orderby p.Rank descending
                         group p by p.Rank into g
                         select g.Key;
            var groupingCustomers = new List<SelectListItem>();
            foreach (var key in groups)
            {
                var optGroup = new SelectListGroup
                {
                    Name = key?.ToString()
                };
                foreach (var customer in customers)
                {
                    if (customer.Rank == key)
                    {
                        groupingCustomers.Add(new SelectListItem
                        {
                            Group = optGroup,
                            Text = customer.单位编号 + " - " + customer.单位名称,
                            Value = customer.单位编号
                        });
                    }
                }
            }
            return groupingCustomers;
        }

    }
}