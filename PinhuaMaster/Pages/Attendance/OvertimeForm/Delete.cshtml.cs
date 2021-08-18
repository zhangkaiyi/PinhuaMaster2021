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
    public class DeleteModel : PageModel
    {
        private readonly PinhuaMaster.Data.Entities.Pinhua.PinhuaContext _context;

        public DeleteModel(PinhuaMaster.Data.Entities.Pinhua.PinhuaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OvertimeFormMain OvertimeFormMain { get; set; }

        public async Task<IActionResult> OnGetAsync(int? Y, int? M, int? D)
        {
            if (Y == null || M == null || D == null)
            {
                return NotFound();
            }

            OvertimeFormMain = await _context.OvertimeFormMain.SingleOrDefaultAsync(m => m.Y == Y && m.M == M && m.D == D);

            if (OvertimeFormMain == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? Y, int? M, int? D)
        {
            if (Y == null || M == null || D == null)
            {
                return NotFound();
            }

            OvertimeFormMain = await _context.OvertimeFormMain.FindAsync(Y, M, D);

            if (OvertimeFormMain != null)
            {
                var OvertimeFormDetails = _context.OvertimeFormDetails.Where(d => d.ExcelServerRcid == OvertimeFormMain.ExcelServerRcid);
                var repCase = _context.EsRepCase.Where(r => r.RcId == OvertimeFormMain.ExcelServerRcid);
                _context.OvertimeFormMain.Remove(OvertimeFormMain);
                _context.OvertimeFormDetails.RemoveRange(OvertimeFormDetails);
                _context.EsRepCase.RemoveRange(repCase);

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
