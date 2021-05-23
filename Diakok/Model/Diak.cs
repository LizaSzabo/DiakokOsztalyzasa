using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    [Table("Diak")]
    public class Diak
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DiakID { get; set; }

        public string Nev { get; set; }
        public int Evfolyam { get; set; }
        public string Szul_datum { get; set; }
        public string Telefon { get; set; }
        public List<Osztalyzat> Osztalyzatok { get; set; }
    }
}
