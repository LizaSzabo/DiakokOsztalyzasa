using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class DiakDbContext: DbContext
    {
        public DiakDbContext()
          : base()
        {
          
        }

        public DiakDbContext(DbContextOptions options)
            : base(options)
        {
           
        }


        public List<DbDiak> GetDiak()
        {
            return Diakok.Local.ToList<DbDiak>();
        }

        public DbSet<DbDiak> Diakok { get; set; }
        public DbSet<DbOsztalyzat> Osztalyzatok { get; set; }
    }
}
