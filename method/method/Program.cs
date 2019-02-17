using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( LineValueForY(4, 2, 5));

            Console.ReadLine();
        }


        static double LineValueForY(double m, double x, double b)
        {
            double y;
            y = m * x + b;
            return y;
        }

        static int Factorial(int number)
        {
            int total=1;
            for (int i = number; i!=0; i--)
            {
                total = total * 1;
            }

            return total;
        }
        
    }
}
