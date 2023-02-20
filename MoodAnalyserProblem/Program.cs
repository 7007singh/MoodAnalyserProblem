using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Welcome analyzer problem___");
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in any mood");
            moodAnalyser.AnalyseMood();
            Console.ReadLine();
        }
    }
}
