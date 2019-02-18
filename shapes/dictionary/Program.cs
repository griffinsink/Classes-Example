using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruit = new Dictionary<string, double>();
            fruit.Add("apples", 0.99);
            fruit.Add("orange", 0.50);
            fruit.Add("bananas", 0.50);
            fruit.Add("grapes", 2.99);
            fruit.Add("blueberries", 1.99);

            string name;

            Console.WriteLine("Please enter the fruit you wish to purchase: ");
            name = Console.ReadLine();

            if (name == KeyValuePair()))
            {
                Console.WriteLine($"The cost of {name} is {fruit.Values}");
            }

            Console.ReadKey();
        }
    }
}
