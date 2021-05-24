using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
  
    public class Diak
    {
        public Diak(long id, string nev, int evfolyam, string datum, string telefon)
        {
            DiakID = id;
            Nev = nev;
            Evfolyam = evfolyam;
            Szul_datum = datum;
            Telefon = telefon;
        }

        public Diak() { }

        public long DiakID { get; set; }

        public string Nev { get; set; }
        public int Evfolyam { get; set; }
        public string Szul_datum { get; set; }
        public string Telefon { get; set; }
    }
}
