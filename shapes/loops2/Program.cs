using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade;
            double total = 0;
            double average;
            string response;
            int count=0;

            do
            {
                Console.WriteLine("Please enter exam grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                count++;

                start:
                Console.WriteLine("Do you have another exam grade you would like to enter?");
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {

                }
                else if (response == "no")
                {
                    Console.WriteLine("thank you");
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                    goto start;
                }

            } while (response == "yes");

            average = total / count;

            Console.WriteLine(average);


            Console.ReadKey();

               

        }
    }
}
