using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class GradeStatistics
    {
        public double AvgGrade;
        public double MaxGrade;
        public double MinGrade;
        public GradeStatistics()
        {
            MaxGrade = double.MinValue;
            MinGrade = double.MaxValue;
        }
    }
}
