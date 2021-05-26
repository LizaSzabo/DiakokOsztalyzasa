using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
  
    public class Student
    {
        public Student(long id, string name, int grade, string date, string phone)
        {
            StudentID = id;
            Name = name;
            Grade = grade;
            BirthDate = date;
            Phone = phone;
        }

        public Student() { }

        public long StudentID { get; set; }

        public string Name { get; set; }
        public int Grade { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
    }
}
