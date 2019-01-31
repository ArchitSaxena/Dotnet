using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
   public class GradeStatistics
    {
        public double AvgGrade;
        public double MaxGrade;
        public double MinGrade;
        public GradeStatistics()
        {
            MaxGrade = double.MinValue;
            MinGrade = double.MaxValue;
        }
        public string LetterGrade
        {
            get
            {
                string result;
                if (AvgGrade >= 90)
                {
                    return "A";
                }
                else if (AvgGrade >= 80)
                {
                    return "B";
                }
                else if (AvgGrade >= 70)
                {
                    return "C";
                }
                else if (AvgGrade >= 60)
                {
                    return "D";
                }
                else
                    return "F";

                return result;
            }
        }
    }
}
