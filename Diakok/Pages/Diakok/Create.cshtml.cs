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
        private readonly DiakDbContext _context;

        public CreateModel(DiakDbContext context)
        {
            _context = context;
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

            _context.Diakok.Add(Diak);
          
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
