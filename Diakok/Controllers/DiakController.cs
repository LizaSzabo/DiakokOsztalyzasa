using Diakok.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiakController : Controller
    {
        private readonly DiakDbContext _context;

        public DiakController(DiakDbContext context)
        {
            _context = context;
        }

        

        public async Task<IActionResult> Get()
        {
            var diakok =  _context.GetDiak();

            var response = diakok.Select(d => new
            {
                nev = d.Nev,
                evfolyam = d.Evfolyam,
                szul_datum = d.Szul_datum,
                telefon = d.Telefon
            });

            return Ok(response);
        }
    
    }
}
