using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diakok.Model
{
    public class StudentStatistics
    {
        public StudentStatistics( string name, double average, int insufficientCount, int bestMark)
        {
            Name = name;
            Average = average;
            InsufficientCount = insufficientCount;
            BestMark = bestMark;
        }

        public StudentStatistics() { }

        public string Name { get; set; }
        public double Average { get; set; }
        public int InsufficientCount{ get; set; }
        public int BestMark { get; set; }
    }
}
