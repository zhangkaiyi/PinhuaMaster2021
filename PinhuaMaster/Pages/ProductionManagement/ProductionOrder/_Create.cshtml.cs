using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.ProductionManagement.ProductionOrder.ViewModel;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder
{
    public class _CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public _CreateModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public ViewModel.vm生产单 Order { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPostAjaxSubmit(vm生产单 Order)
        {
            return new JsonResult("result:参数填写错误, 请检查!");
        }
    }
}