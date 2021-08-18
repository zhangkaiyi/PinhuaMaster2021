using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using PinhuaMaster.Data;

namespace PinhuaMaster.Pages.Permission
{
    public class CreateModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager { get; set; }
        private RoleManager<IdentityRole> _roleManager { get; set; }
        private ApplicationDbContext _identityContext { get; set; }

        public CreateModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext identityContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _identityContext = identityContext;
        }

        public string RoleId { get; set; }

        public void OnGet(string roleId)
        {
            RoleId = roleId;
        }

        public IActionResult OnPost(string roleId, IList<string> pagesAddToRole)
        {
            foreach (var page in pagesAddToRole)
            {
                _identityContext.RolePages.Add(new ApplicationRolePage
                {
                    RoleId = roleId,
                    Page = page
                });
            }
            _identityContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}