using Diakok.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.DAL
{
    public class Repository:  IRepository
    {
        private readonly StudentDbContext db;

        public Repository(StudentDbContext db)
        {
            this.db = db;
        }

        public IList<Student> ListStudents()
        {
            return db.Students.Select(ToModel).ToList();
        }

        public IList<Mark> ListMarks()
        {
            return db.Marks.Select(ToModelMark).ToList();
        }

        public Student InsertStudent(Student value)
        {
                DbStudent toInsert;
                toInsert = new DbStudent() { Name = value.Name, Grade = value.Grade, BirthDate = value.BirthDate, Phone = value.Phone };
                db.Students.Add(toInsert);

                db.SaveChanges();
            

                return new Student(toInsert.id, toInsert.Name, toInsert.Grade, value.BirthDate, value.Phone);
            
        }


        public Student AddMark(long studentId, int value)
        {
           
                var dbRecord = db.Students.FirstOrDefault(d => d.id == studentId);
                if (dbRecord == null) return null;
                else
                {
                    
                        var toInsertOsztalyzat = new DbMark() { Value = value, Student = dbRecord, StudentId = studentId };
                        db.Marks.Add(toInsertOsztalyzat);
                        dbRecord.Marks.Add(toInsertOsztalyzat);
                   
                    db.SaveChanges();

                    return ToModel(dbRecord);
                
            }
        }

        public Student FindStudent(long id)
        {
            var dbStudent = db.Students.FirstOrDefault(d => d.id == id);
                        
            if (dbStudent != null)
            {
                return ToModel(dbStudent);

            }
            else return null;
        }

        public Student ToModel(DbStudent value)
        {
           
                var osztalyzatok = db.Marks.FirstOrDefault(o => o.StudentId == value.id);

                return new Student(value.id, value.Name, value.Grade, value.BirthDate, value.Phone);
            
        }

        public Mark ToModelMark(DbMark value)
        {

            return new Mark(value.id, value.Value, value.StudentId);

        }


    }
}
