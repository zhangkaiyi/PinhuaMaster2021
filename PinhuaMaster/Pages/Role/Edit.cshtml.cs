using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data;

namespace PinhuaMaster.Pages.Role
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
        public string RoleId { get; set; }

        public void OnGet(string Id)
        {
            RoleId = Id;    
        }

        public async Task<IActionResult> OnPostAsync(string roleName, IList<string> usersToAdd, IList<string> usersToRemove)
        {
            foreach(var userId in usersToAdd)
            {
                var user = await _userManager.FindByIdAsync(userId);
                await _userManager.AddToRoleAsync(user, roleName);
            }
            foreach(var userId in usersToRemove)
            {
                var user = await _userManager.FindByIdAsync(userId);
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
            return RedirectToPage("/Role/Index");
        }
    }
}