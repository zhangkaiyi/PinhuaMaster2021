using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using PinhuaMaster.Data;

namespace PinhuaMaster.Pages.Role
{
    public class CreateModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager { get; set; }
        private RoleManager<IdentityRole> _roleManager { get; set; }

        public CreateModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [BindProperty]
        [Required]
        public string RoleName { get; set; }

        public void OnGet()
        {
            
        }
        
        public async Task<IActionResult> OnPostAsync(string roleName)
        {
            if (ModelState.IsValid)
            {
                if (!string.IsNullOrEmpty(roleName))
                {
                    await _roleManager.CreateAsync(new IdentityRole(roleName));
                }
                return RedirectToPage("/Role/Index");
            }

            return Page();
        }
    }
}