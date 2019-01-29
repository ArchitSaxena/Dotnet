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
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.addGrade(94);
            book.addGrade(89);
            book.addGrade(76);
            book.Name = "Archit";

            Console.WriteLine(book.Name);
            
            book.Name = "Archit Saxena";
            Console.WriteLine(book.Name);
            

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello Archit. I hpe you are fine.");

            GradeStatistics stats = book.ComputeStatistics();
            //GradeBook book2 = book;
            //book2.addGrade(75);
            WriteResult("Average grade", stats.AvgGrade);
            WriteResult("Maximum grade" ,(int)stats.MaxGrade);
            WriteResult("Minimum grade" ,stats.MinGrade);
        }
        static void WriteResult(string description, double ans)
        {
            //Console.WriteLine(description + ": " + ans);
            Console.WriteLine("{0}: {1:F2}", description, ans); //It acts as a placeholder.
        }
        static void WriteResult(string description, int ans)
        {
            Console.WriteLine(description + ": " + ans);
            //String interpolation
            //Console.WriteLine($"{description}: {ans}");
        }
        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }
    }
}
