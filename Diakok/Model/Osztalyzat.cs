using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    [Table("Osztalyzat")]
    public class Osztalyzat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long osztalyzatID { get; set; }

        public int Ertek { get; set; }
        public long DiakId { get; set; }
        public Diak Diak { get; set; }
    }
}
