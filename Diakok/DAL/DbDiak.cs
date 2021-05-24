using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class DbDiak
    {
        public int id { get; set; }

        public string Nev { get; set; }
        public int Evfolyam { get; set; }
        public string Szul_datum { get; set; }
        public string Telefon { get; set; }
        public ICollection<DbOsztalyzat> Osztalyzatok { get; set; }
    }
}
