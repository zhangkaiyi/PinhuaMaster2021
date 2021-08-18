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
using PinhuaMaster.Pages.BasicInformation.Partner.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.Partner
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
        public PartnerDTO PartnerInfo { get; set; } = new PartnerDTO();

        public void OnGet()
        {
            PartnerInfo.单位编号 = buildOrderId();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "14.1";
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

                var main = _mapper.Map<PartnerDTO, 往来单位>(PartnerInfo);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;

                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.往来单位.Add(main);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

        private string buildOrderId()
        {
            _pinhuaContext.Database.OpenConnection();
            var cmd = _pinhuaContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "SELECT dbo.GetPartnerID('P',GETDATE())";
            var result = cmd.ExecuteReader();
            var orderId = string.Empty;
            while (result.Read())
            {
                orderId = result[0].ToString();
            }
            _pinhuaContext.Database.CloseConnection();
            return orderId;
        }
    }
}