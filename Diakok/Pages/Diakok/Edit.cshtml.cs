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
        private readonly DiakDbContext _context;

        public EditModel(DiakDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Diak Diak { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Diak = await _context.Diakok.FirstOrDefaultAsync(m => m.DiakID == id);

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

            _context.Attach(Diak).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiakExists(Diak.DiakID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DiakExists(long id)
        {
            return _context.Diakok.Any(e => e.DiakID == id);
        }
    }
}
