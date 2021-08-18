using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data;

namespace PinhuaMaster.Pages.User
{
    public class EditModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager { get; set; }
        private RoleManager<IdentityRole> _roleManager { get; set; }

        public EditModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty]
        public string UserId { get; set; }

        public void OnGet(string Id)
        {
            UserId = Id;
        }

        public async Task<IActionResult> OnPostAsync(string userId, IList<string> rolesToAdd, IList<string> rolesToRemove)
        {
            foreach (var roleName in rolesToAdd)
            {
                var user = await _userManager.FindByIdAsync(userId);
                await _userManager.AddToRoleAsync(user, roleName);
            }
            foreach (var roleName in rolesToRemove)
            {
                var user = await _userManager.FindByIdAsync(userId);
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
            return RedirectToPage("/User/Index");
        }
    }
}