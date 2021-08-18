using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Personnel.Files
{
    public class IndexModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly EastRiverContext _eastRiverContext;

        public IndexModel(PinhuaContext pinhuaContext, EastRiverContext eastRiverContext)
        {
            _pinhuaContext = pinhuaContext;
            _eastRiverContext = eastRiverContext;
        }

        public IList<人员档案> PersonnelFiles { get; set; }

        public void OnGet()
        {
            PersonnelFiles = _pinhuaContext.人员档案.AsNoTracking().OrderByDescending(p => p.登记时间).ThenByDescending(p => p.人员编号).ToList();
        }
    }
}