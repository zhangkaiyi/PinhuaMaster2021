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
using PinhuaMaster.Pages.BasicInformation.ModelNumber.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.ModelNumber
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
        public ModelNumberDTO ModelNumberInfo { get; set; } = new ModelNumberDTO();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "169.1";
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

                var main = _mapper.Map<ModelNumberDTO, Data.Entities.Pinhua.产品型号清单>(ModelNumberInfo);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;

                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.产品型号清单.Add(main);
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