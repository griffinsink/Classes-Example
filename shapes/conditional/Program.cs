using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int cogNumber, gearNumber;
            const double cogCost = 79.99;
            const double gearCost = 250.00;
            const double tax = .089;
            double markup;

            Console.WriteLine("Please enter the number of Cogs you wish to purchase: ");
            cogNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the number of Gears you wish to purchase: ");
            gearNumber = Convert.ToInt32(Console.ReadLine());

            if (cogNumber > 10 || gearNumber > 10 || (cogNumber + gearNumber) >= 16)
            {
                markup = .125;
            }
            else
            {
                markup = .15;
            }

            Console.WriteLine("");
            //display total cost, discount amount, sale tax amount, grand total
            Console.WriteLine("RECEIPT");
            Console.WriteLine($"Total Cost: {(markup*(cogNumber * cogCost + gearNumber * gearCost)) + ((cogNumber * cogCost) + (gearNumber * gearCost))}");
            Console.WriteLine($"discount amount ");

            Console.ReadKey();
        }
    }
}
