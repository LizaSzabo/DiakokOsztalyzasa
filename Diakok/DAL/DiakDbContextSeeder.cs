using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public static class DiakDbContextSeeder
    {
        public static void Seed(DiakDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

          
        }
    }
}
