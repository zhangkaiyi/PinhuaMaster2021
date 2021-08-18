using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data.Entities.EastRiver;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Attendance.EastRiver
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

        public void OnGet()
        {

        }
    }
}