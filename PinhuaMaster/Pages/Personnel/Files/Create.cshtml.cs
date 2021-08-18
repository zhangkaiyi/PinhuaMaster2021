using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.Pinhua;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.Personnel.Files.ViewModel;

namespace PinhuaMaster.Pages.Personnel.Files
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
        public PersonnelFilesDTO PersonnelFile { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            PersonnelFile.Id = _pinhuaContext.CreatePersonnelFileId("PF", 4);

            var rcId = _pinhuaContext.GetNewRcId();
            var rtId = _pinhuaContext.GetRtId("人员档案");
            var repCase = new EsRepCase
            {
                RcId = rcId,
                RtId = rtId,
                LstFiller = 2,
                LstFillerName = User.Identity.Name,
                LstFillDate = DateTime.Now,
                FillDate = DateTime.Now,
            };

            PersonnelFile.ExcelServerRcid = rcId;
            PersonnelFile.ExcelServerRtid = rtId;
            PersonnelFile.SignedDate = DateTime.Now;

            _pinhuaContext.EsRepCase.Add(repCase);
            _pinhuaContext.人员档案.Add(_mapper.Map<PersonnelFilesDTO, 人员档案>(PersonnelFile));
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}