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

        public List<Diak> Diak { get; set; }

        public async Task OnGetAsync()
        {
          //  Diak = await _context.Diakok.ToListAsync();
            Diak = Diak.OrderBy(o => o.Nev).ToList();
        }
    }
}
