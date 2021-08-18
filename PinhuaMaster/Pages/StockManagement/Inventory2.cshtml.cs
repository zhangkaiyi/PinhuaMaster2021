using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.OrderManagement.EasyDelivery.ViewModel;
using PinhuaMaster.Pages.OrderManagement.EasyPurchasing.ViewModel;

namespace PinhuaMaster.Pages.StockManagement
{
    public class Inventory2Model : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public Inventory2Model(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public IList<Gi2ViewModel> EasyDeliveryList { get; set; }
        public IList<PurchasingViewModel> EasyPurchasingList { get; set; }

        public void OnGet()
        {

            // Stock in
            EasyPurchasingList = (from p in _pinhuaContext.Gr2Main.AsNoTracking()
                                  join d in _pinhuaContext.Gr2Details.AsNoTracking() on p.ExcelServerRcid equals d.ExcelServerRcid into details
                                  where p.PurchasingType == "171"   // 外协加工回库
                                  select new PurchasingViewModel
                                  {
                                      Main = _mapper.Map<Gr2Main, Gr2MainDto>(p),
                                      Details = _mapper.Map<IEnumerable<Gr2Details>, List<Gr2DetailsDto>>(details)
                                  }).ToList();

        }
    }
}