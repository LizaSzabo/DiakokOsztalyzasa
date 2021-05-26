using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateStudent
    {

        private readonly IRepository repository;

        public CreateStudent(IRepository repository)
        {
            this.repository = repository;
        }

        public bool AddStudent(Student student)
        {
            if (student != null && student.Name != null && student.Name != "" && student.Grade > 0)
            {
                repository.InsertStudent(student);
                return true;
            }
            else return false;  
        }
    }
}
