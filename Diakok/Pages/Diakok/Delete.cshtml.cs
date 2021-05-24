using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Diakok.DAL;
using Diakok.Model;

namespace Diakok.Pages.Diakok
{
    public class DeleteModel : PageModel
    {
        private readonly DiakDbContext _context;

        public DeleteModel(DiakDbContext context)
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

            //Diak = await _context.Diakok.FirstOrDefaultAsync(m => m.DiakID == id);

            if (Diak == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

          //  Diak = await _context.Diakok.FindAsync(id);

            if (Diak != null)
            {
               // _context.Diakok.Remove(Diak);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
