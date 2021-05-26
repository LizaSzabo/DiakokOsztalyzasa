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
    public class StudentDbContext: DbContext
    {
        public StudentDbContext()
          : base()
        {
          
        }

        public StudentDbContext(DbContextOptions options)
            : base(options)
        {
           
        }


        public List<DbStudent> GetStudent()
        {
            return Students.Local.ToList<DbStudent>();
        }

        public DbSet<DbStudent> Students { get; set; }
        public DbSet<DbMark> Marks{ get; set; }
    }
}
