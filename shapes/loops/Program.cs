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
            double grade;
            double total = 0;
            double average;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter exam grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
            }

            average = (total / 3) / 100;

            Console.WriteLine($"The average grade for the 3 exams is {average:P2}");
            Console.ReadKey();
        }
    }
}
