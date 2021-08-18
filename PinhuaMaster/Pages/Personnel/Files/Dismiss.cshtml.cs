using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.Personnel.Files.ViewModel;

namespace PinhuaMaster.Pages.Personnel.Files
{
    public class DismissModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public DismissModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public PersonnelFilesDTO PersonnelFile { get; set; }

        public void OnGet(string Id)
        {
            var result = _pinhuaContext.人员档案.AsNoTracking().FirstOrDefault(p => p.人员编号 == Id);
            PersonnelFile = _mapper.Map<人员档案, PersonnelFilesDTO>(result);
        }

        public IActionResult OnPost()
        {
            var result = _pinhuaContext.人员档案.FirstOrDefault(p => p.人员编号 == PersonnelFile.Id);
            result.状态 = "辞退";
            result.离职时间 = PersonnelFile.InServiceEnd;
            result.离职或辞退原因 = PersonnelFile.ReasonOfLeave;

            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}