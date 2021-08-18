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
    public class DetailsModel : PageModel
    {
        private readonly PinhuaMaster.Data.Entities.Pinhua.PinhuaContext _context;

        public DetailsModel(PinhuaMaster.Data.Entities.Pinhua.PinhuaContext context)
        {
            _context = context;
        }

        public OvertimeFormMain OvertimeFormMain { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OvertimeFormMain = await _context.OvertimeFormMain.SingleOrDefaultAsync(m => m.Y == id);

            if (OvertimeFormMain == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
