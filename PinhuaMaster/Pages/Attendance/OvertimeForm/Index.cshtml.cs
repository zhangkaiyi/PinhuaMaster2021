using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Attendance.OvertimeForm
{
    public class IndexModel : PageModel
    {
        private readonly PinhuaMaster.Data.Entities.Pinhua.PinhuaContext _context;

        public IndexModel(PinhuaMaster.Data.Entities.Pinhua.PinhuaContext context)
        {
            _context = context;
        }

        public IList<OvertimeFormMain> OvertimeFormMain { get;set; }

        public async Task OnGetAsync()
        {
            OvertimeFormMain = await _context.OvertimeFormMain.ToListAsync();
        }
    }
}
