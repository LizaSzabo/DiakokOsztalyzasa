using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class DbOsztalyzat
    {
        public int id{ get; set; }

        public int Ertek { get; set; }
        public long DiakId { get; set; }
        public virtual DbDiak Diak { get; set; }
}
}
