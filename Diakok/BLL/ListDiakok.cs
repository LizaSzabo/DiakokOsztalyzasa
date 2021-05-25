using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class ListDiakok
    {
        private readonly IRepository repository;
        public IList<Diak> Diakok { get; set; }

        public ListDiakok(IRepository repository)
        {
            this.repository = repository;
        }

        public IList<Diak> ListAllStudents()
        {
            Diakok = repository.ListStudents();
            return Diakok.OrderBy(o => o.Nev).ToList();
        }

    }
}
