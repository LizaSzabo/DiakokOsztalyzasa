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
    public class DetailsModel : PageModel
    {
        private readonly DiakDbContext _context;

        public DetailsModel(DiakDbContext context)
        {
            _context = context;
        }

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
    }
}
