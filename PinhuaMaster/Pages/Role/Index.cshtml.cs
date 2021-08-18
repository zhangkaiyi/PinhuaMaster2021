using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data;
using Microsoft.AspNetCore.Identity;

namespace PinhuaMaster.Pages.Role
{
    public class IndexModel : PageModel
    {
        private RoleManager<IdentityRole> _roleManager { get; set; }
        public IndexModel(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostDeleteAsync(string Id)
        {
            await _roleManager.DeleteAsync(await _roleManager.FindByIdAsync(Id));
            return RedirectToPage("/Role/Index");
        }
    }
}