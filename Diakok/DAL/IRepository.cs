using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public interface IRepository
    {
        IList<Student> ListStudents();
        IList<Mark> ListMarks();
        Student InsertStudent(Student value);
        Student AddMark(long StudentId, int value);
        Student FindStudent(long id);
    }
}
