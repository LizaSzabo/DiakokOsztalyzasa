using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Diakok.DAL;
using Diakok.Model;
using Diakok.BLL;

namespace Diakok.Pages.Diakok
{
    public class EditModel : PageModel
    {
        private readonly CreateOsztalyzat createOsztalyzat;

        public EditModel(IRepository repository)
        {
            createOsztalyzat = new CreateOsztalyzat(repository);
        }


        [BindProperty]
        public Diak Diak { get; set; }
        [BindProperty]
        public Osztalyzat Osztalyzat { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {

            Diak = createOsztalyzat.FindDiakById(id);

            if (Diak == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            createOsztalyzat.AddOsztalyzat(Diak.DiakID, Osztalyzat.Ertek);
        
           return RedirectToPage("./Index");

        }


    }
}
