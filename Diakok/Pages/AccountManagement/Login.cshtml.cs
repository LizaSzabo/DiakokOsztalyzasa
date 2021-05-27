using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Diakok.DAL;
using Diakok.Model;
using Microsoft.AspNetCore.Identity;

namespace Diakok.Pages.AccountManagement
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginModel(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        public async Task<IActionResult> OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Login LoginM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(LoginM.UserName, LoginM.Password, LoginM.RememberMe, false);
             //   var ok = LoginM.UserName == "admin" && LoginM.Password == "edutest2021";

                if (result.Succeeded)
                {
                    return RedirectToPage("../Diakok/Index");
                }
                ModelState.AddModelError(string.Empty, "Hibás felhasználó név vagy jelszó");
                
            }
            return Page();
        }
    }
}
