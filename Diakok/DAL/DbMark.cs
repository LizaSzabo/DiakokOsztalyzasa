using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class DbMark
    {
        public int id{ get; set; }

        public int Value { get; set; }
        public long StudentId { get; set; }
        public virtual DbStudent Student { get; set; }
}
}
