using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Diakok.DAL;
using Diakok.Model;
using Diakok.BLL;

namespace Diakok.Pages.Diakok
{
    public class CreateModel : PageModel
    {
        private readonly CreateDiak createDiak;

        public CreateModel(IRepository repository)
        {
            createDiak = new CreateDiak(repository);
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Diak Diak { get; set; }

        public IActionResult OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            createDiak.AddDiak(Diak);

            return RedirectToPage("./Index");
        }
    }
}
