using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public interface IRepository
    {
        IList<Diak> ListStudents();
        IList<Osztalyzat> ListOsztalyzatok();
        Diak InsertDiak(Diak value);
        Diak AddOsztalyzat(long diakId, int ertek);
        Diak FindDiak(long id);
    }
}
