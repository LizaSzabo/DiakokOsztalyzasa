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

namespace Diakok.Pages.Diakok
{
    public class EditModel : PageModel
    {
        private readonly IRepository repository;

        public EditModel(IRepository repository)
        {
            this.repository = repository;
        }

        [BindProperty]
        public Diak Diak { get; set; }
        [BindProperty]
        public Osztalyzat Osztalyzat { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diak = repository.FindDiak(id);

            if (Diak == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


           repository.AddOsztalyzat(Diak.DiakID, Osztalyzat.Ertek);
        
           return RedirectToPage("./Index");

        }


    }
}
