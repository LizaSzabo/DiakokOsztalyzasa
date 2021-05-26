using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class ListStudents
    {
        private readonly IRepository repository;
        public IList<Student> Students { get; set; }

        public ListStudents(IRepository repository)
        {
            this.repository = repository;
        }

        public IList<Student> ListAllStudents()
        {
            Students = repository.ListStudents();
            return Students.OrderBy(o => o.Name).ToList();
        }

    }
}
