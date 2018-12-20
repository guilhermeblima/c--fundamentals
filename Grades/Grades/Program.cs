using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Yo, sup bro, Alan here, I'm gonna compute the grades!!");

            GradeBook book = new GradeBook();
            book.AddGrade(3f);
            book.AddGrade(8f);
            book.AddGrade(9f);
            book.AddGrade(3f);
            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Average",stats.AverageGrade);
            WriteResults("Highest",stats.HighestGrade);
            WriteResults("Lowest",stats.LowestGrade);
            
        }

        static void WriteResults(string description, float grade)
        {
            Console.WriteLine(description+": " + grade);
        }
    }
}
