using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    
    public class Mark
    {
        public Mark(long id, int value, long studentId)
        {
            markID = id;
            Value = value;
            StudentId = studentId;
        }

        public Mark() { }

        public long markID { get; set; }

        public int Value { get; set; }
        public long StudentId { get; set; }
    }
}
