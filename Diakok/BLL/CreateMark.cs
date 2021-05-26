using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateMark
    {
        private readonly IRepository repository;
        private const int maxMark = 5;

        public CreateMark(IRepository repository)
        {
            this.repository = repository;
        }

        public bool AddMark(long studentId, int value)
        {
            if (value < 1 || value > maxMark)
            {
                return false;
            }
            else
            {
                repository.AddMark(studentId, value);
                return true;
            }
        }

        public Student FindStudentById(long id)
        {
            return repository.FindStudent(id);
        }
    }
}
