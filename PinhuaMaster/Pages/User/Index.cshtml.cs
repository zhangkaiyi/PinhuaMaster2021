using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinhuaMaster.Data;
using Microsoft.AspNetCore.Identity;

namespace PinhuaMaster.Pages.User
{
    public class IndexModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager { get; set; }
        private RoleManager<IdentityRole> _roleManager { get; set; }

        public IndexModel(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostDeleteAsync(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                //_logger.LogInformation("User created a new account with password.");

                //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                //var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                //await _emailSender.SendEmailConfirmationAsync(Input.Email, callbackUrl);

                //await _signInManager.SignInAsync(user, isPersistent: false);
                //return LocalRedirect(Url.GetLocalUrl(returnUrl));
                return RedirectToPage("Index");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return Page();
        }
    }
}