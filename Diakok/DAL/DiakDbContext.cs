using Diakok.Model;
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


        public List<Diak> GetDiak()
        {
            return Diakok.Local.ToList<Diak>();
        }

        public DbSet<Model.Diak> Diakok { get; set; }
        public DbSet<Model.Osztalyzat> Osztalyzatok { get; set; }
    }
}
