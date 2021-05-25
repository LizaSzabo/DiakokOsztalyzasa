using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    public class DiakStatisztika
    {
        public DiakStatisztika( string nev, double atlag, int elegtelen_oszt_szama, int legjobb_oszt)
        {
            Nev = nev;
            Atlag = atlag;
            ElegtelenekSzama = elegtelen_oszt_szama;
            Legjobb = legjobb_oszt;
        }

        public DiakStatisztika() { }

        public string Nev { get; set; }
        public double Atlag { get; set; }
        public int ElegtelenekSzama{ get; set; }
        public int Legjobb { get; set; }
    }
}
