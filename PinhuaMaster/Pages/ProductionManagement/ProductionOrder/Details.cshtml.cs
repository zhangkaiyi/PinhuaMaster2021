using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.ProductionManagement.ProductionOrder.ViewModel;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder
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

        public vm生产单 Order { get; set; }

        public void OnGet(string Id)
        {
            Order = new vm生产单();
            Order.M = _mapper.Map<生产单, dto生产单M>(_pinhuaContext.生产单.AsNoTracking().FirstOrDefault(p => p.单号 == Id));
            Order.D = _mapper.Map<List<生产单d>, List<dto生产单D>>(_pinhuaContext.生产单d.AsNoTracking().Where(d => d.ExcelServerRcid == Order.M.ExcelServerRcid).ToList());
        }
    }
}