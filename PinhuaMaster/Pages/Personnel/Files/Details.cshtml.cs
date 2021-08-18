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
    public class DetailsModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public DetailsModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public PersonnelFilesDTO PersonnelFile { get; set; }
        public IEnumerable<考勤卡号变动> AttendanceCards { get; set; }

        public void OnGet(string Id)
        {
            var result = _pinhuaContext.人员档案.AsNoTracking().FirstOrDefault(p => p.人员编号 == Id);
            PersonnelFile = _mapper.Map<人员档案, PersonnelFilesDTO>(result);
            AttendanceCards = _pinhuaContext.考勤卡号变动.AsNoTracking().Where(p => p.ExcelServerRcid == result.ExcelServerRcid);
        }
    }
}