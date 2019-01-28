using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GradeBook book = new GradeBook();
            book.addGrade(94);
            book.addGrade(89);
            book.addGrade(76);

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello Archit. I hpe you are fine.");

            GradeStatistics stats = book.ComputeStatistics();
            //GradeBook book2 = book;
            //book2.addGrade(75);
            Console.WriteLine(stats.AvgGrade);
            Console.WriteLine(stats.MaxGrade);
            Console.WriteLine(stats.MinGrade);
        }
    }
}
