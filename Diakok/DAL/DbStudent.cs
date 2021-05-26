using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class DbStudent
    {
        public int id { get; set; }

        public string Name { get; set; }
        public int Grade { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public ICollection<DbMark> Marks { get; set; }
    }
}
