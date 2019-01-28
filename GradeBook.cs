using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        public string Name;

        List<Double> grades;
        public GradeBook()
        {
             grades = new List<Double>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats= new GradeStatistics();
            double sum = 0;
            int c = 0;
            
            foreach(double grade in grades)
            {
                sum = sum + grade;
                c++;
                if (grade > stats.MaxGrade)
                    stats.MaxGrade = grade;
                stats.MinGrade = Math.Min(grade, stats.MinGrade);
            }
            stats.AvgGrade = sum / grades.Count;
            return stats;
        }
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}
