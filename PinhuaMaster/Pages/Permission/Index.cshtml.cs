using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PinhuaMaster.Data;

namespace PinhuaMaster.Pages.Permission
{
    public class IndexModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager { get; set; }
        private RoleManager<IdentityRole> _roleManager { get; set; }
        private ApplicationDbContext _identityContext { get; set; }

        public IndexModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext identityContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _identityContext = identityContext;
        }

        public IdentityRole SelectRole { get; set; }
        public IList<ApplicationRolePage> RolePages{ get; set; }

        public void OnGet(string roleId)
        {
            var roles = _roleManager.Roles.ToList();
            SelectRole = roles.FirstOrDefault(p => p.Id == roleId);
            if (SelectRole == null)
                SelectRole = roles.FirstOrDefault();
            RolePages = _identityContext.RolePages.ToList();
        }

        public IActionResult OnPostDelete(string roleId, string path)
        {
            var results = _identityContext.RolePages.Where(p => p.RoleId == roleId && p.Page == path);
            foreach (var result in results)
                _identityContext.RolePages.Remove(result);
            _identityContext.SaveChanges();
            return RedirectToPage("Index", new { roleId });
        }
    }
}