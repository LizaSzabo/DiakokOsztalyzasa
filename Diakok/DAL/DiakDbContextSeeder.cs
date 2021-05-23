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

            context.Diakok.Add(new Model.Diak()
            {
               Nev = "Teszt Diák5"
               
            });

            context.Diakok.Add(new Model.Diak()
            {
                Nev = "Teszt Diák3"
            });

            context.Diakok.Add(new Model.Diak()
            {
                Nev = "Teszt Diák"
            });

            context.Diakok.Add(new Model.Diak()
            {
                Nev = "Teszt Diák1"
            });

          
        }
    }
}
