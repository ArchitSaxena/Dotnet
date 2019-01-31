using System;
using System.Collections.Generic;
using System.IO;
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

            GradeBook book = new ThrowAwayGradeBook();
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            GetGrades(book);
            GetBookName(book);

            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello Archit. I hpe you are fine.");

            SaveGrades(book);

            //GradeBook book2 = book;
            //book2.addGrade(75);

            WriteResults(book);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("Grades.txt"))
            {
                book.WriteGrade(outputFile);
            }
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average grade", stats.AvgGrade);
            WriteResult("Maximum grade", (int)stats.MaxGrade);
            WriteResult("Minimum grade", stats.MinGrade);
            WriteResult("Grade:", stats.LetterGrade);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();

                Console.WriteLine(book.Name);

                book.Name = "Archit Saxena";
                Console.WriteLine(book.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetGrades(GradeBook book)
        {
            book.addGrade(94);
            book.addGrade(89);
            book.addGrade(76);
        }

        static void WriteResult(string description, double ans)
        {
            //Console.WriteLine(description + ": " + ans);
            Console.WriteLine("{0}: {1:F2}", description, ans); //It acts as a placeholder.
        }
        static void WriteResult(string description, string ans)
        {
            Console.WriteLine(description + ": " + ans); 
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
