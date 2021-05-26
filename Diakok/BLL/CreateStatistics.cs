using Diakok.DAL;
using Diakok.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.BLL
{
    public class CreateStatistics
    {

        private readonly IRepository repository;
        public IList<Student> Students { get; set; }
        public IList<Mark> Marks { get; set; }
        public List<StudentStatistics> Statistics { get; set; }
        private const int passGrade = 2;

        public CreateStatistics(IRepository repository)
        {
            this.repository = repository;
            Statistics = new List<StudentStatistics>();
        }

        public List<Model.StudentStatistics> ListAllStatistics()
        {
            Students = repository.ListStudents();
            Marks = repository.ListMarks();


            int marksValue = 0;
            int marksCount = 0;
            int insufficientCount = 0;
            int maxValue = 0;
            foreach(var student in Students)
            {
                marksValue = 0;
                marksCount = 0;
                insufficientCount = 0;
                maxValue = 0;
                foreach (var mark in Marks)
                {
                    if(mark.StudentId == student.StudentID)
                    {
                        marksCount++;
                        marksValue += mark.Value;
                        if(mark.Value < passGrade)
                        {
                            insufficientCount++;
                        }
                        if(mark.Value > maxValue)
                        {
                            maxValue = mark.Value;
                        }
                    }
                }
                if(marksCount > 0)
                    Statistics.Add(new StudentStatistics(student.Name, (double)marksValue / (double)marksCount, insufficientCount, maxValue));
            }

            Statistics = Statistics.OrderBy(o => o.Average).ToList();
            return Statistics;
        }

    }
}
