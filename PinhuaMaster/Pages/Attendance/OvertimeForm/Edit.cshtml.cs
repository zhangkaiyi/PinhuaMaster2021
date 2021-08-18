using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Pages.Attendance.OvertimeForm
{
    public class EditModel : PageModel
    {
        private readonly PinhuaMaster.Data.Entities.Pinhua.PinhuaContext _context;

        public EditModel(PinhuaMaster.Data.Entities.Pinhua.PinhuaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OvertimeFormMain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OvertimeFormMainExists(OvertimeFormMain.Y))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OvertimeFormMainExists(int id)
        {
            return _context.OvertimeFormMain.Any(e => e.Y == id);
        }
    }
}
