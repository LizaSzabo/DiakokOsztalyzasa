using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Diakok.DAL;
using Diakok.Model;

namespace Diakok.Pages.Diakok
{
    public class CreateModel : PageModel
    {
        private readonly IRepository repository;

        public CreateModel(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Diak Diak { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            /*new_diak.Osztalyzatok = new List<Osztalyzat>();
            new_diak.Osztalyzatok.Add(new Osztalyzat {  Ertek = 7, Diak = Diak, DiakId = Diak.DiakID  });*/
            //  _context.Diakok.Add(new_diak);

            repository.InsertDiak(Diak);

            return RedirectToPage("./Index");
        }
    }
}
