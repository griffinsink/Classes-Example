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
            double examScore;
            double totalScore = 0;
            double average;
            string response;
            int count = 0;


            do
            {
                Console.WriteLine("Please enter your exam score: ");
                examScore = Convert.ToInt32(Console.ReadLine());
                totalScore = totalScore + examScore;
                count++;

                start:
                Console.WriteLine("Do you have another score you wish to enter?");
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {

                }
                else if (response == "no")
                {
                    Console.WriteLine("Thank you!");
                }
                else if (response != "yes" || response != "no")
                {
                    Console.WriteLine("Please enter yes or no");
                    goto start;
                }
            } while (response == "yes" && response != "yes" || response != "no");

            average = totalScore / count;

            Console.WriteLine(average);


            Console.ReadKey();

               

        }
    }
}
