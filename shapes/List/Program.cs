using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> examGrade = new List<double>();

            string response;
            int count = 0;
            double average;
            double total = 0;


            do
            {
                double grade;
                Console.WriteLine("Please enter exam grade");
                grade = Convert.ToInt32(Console.ReadLine());
                count++;
                examGrade.Add(grade);

            start:
                Console.WriteLine("");
                Console.WriteLine("Do you have another exam grade you wish to enter?");
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {

                }
                else if (response == "no")
                {
                    Console.Write("thank you, your average exam score is: ");
                }
                else if (response != "yes" || response != "no")
                {
                    Console.WriteLine("Please enter a YES or NO response");
                    goto start;
                }
            } while (response == "yes");

            foreach (var grade in examGrade)
            {
                total += grade;

            }

            average = (total / count) / 100;

            Console.Write($"{average:P2}");
            Console.ReadKey();
        }
    }
}
