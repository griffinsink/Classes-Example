using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;
            double totalScore = 0;
            double average;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter exam grade: ");
                score = Convert.ToInt32(Console.ReadLine());
                totalScore = totalScore + score;
            }

            average = totalScore / 3;

            Console.WriteLine($"average exam score is: {average}");

            Console.ReadKey();
        }
    }
}
