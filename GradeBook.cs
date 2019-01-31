using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        protected List<Double> grades;
        public GradeBook()
        {
             grades = new List<Double>();
        }

        public virtual GradeStatistics ComputeStatistics()
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
        public void WriteGrade(TextWriter destination)
        {
            for(int i= grades.Count; i>0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                if(_name!= null)
                {
                  // _name = "Error";
                    NameChanged(_name, value);
                    _name = value;
                }
                else
                {
                    if(_name== null)
                    _name = value;
                }
            }
            
        }
        public NameChangedDelegate NameChanged;
        public void addGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}
