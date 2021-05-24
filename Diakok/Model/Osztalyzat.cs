using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    
    public class Osztalyzat
    {
        public Osztalyzat(long id, int ertek, long diakId)
        {
            osztalyzatID = id;
            Ertek = ertek;
            DiakId = diakId;
        }

        public Osztalyzat() { }

        public long osztalyzatID { get; set; }

        public int Ertek { get; set; }
        public long DiakId { get; set; }
    }
}
