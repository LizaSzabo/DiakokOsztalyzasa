using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IndexModel(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager, ILogger<IndexModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            await _signInManager.SignOutAsync();

            var user = new IdentityUser
            {
                UserName = "admin",
            };

            var result = await _userManager.CreateAsync(user, "edutest2021");
            System.Diagnostics.Debug.WriteLine(user.UserName);

            return RedirectToPage("Diakok/Index");
        }
    }
}
