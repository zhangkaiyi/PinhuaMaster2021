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
using PinhuaMaster.Pages.StockManagement.Warehouse.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.Warehouse
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
        public WarehouseViewModel WarehouseInfo { get; set; } = new WarehouseViewModel();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "165.1";
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

                var main = _mapper.Map<WarehouseDTO, Data.Entities.Pinhua.Warehouse>(WarehouseInfo.Main);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;

                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.Warehouse.Add(main);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}