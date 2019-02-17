using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Length = 5;
            r1.Width = 5;
            Console.WriteLine($"The perimeter for r1 is {r1.CalculatePerimeter()}, and the area is {r1.CalculateArea()}");
            r1.CalculateArea();

            Circle c1 = new Circle(5.75);
            Console.WriteLine($"The perimeter for c1 is {c1.CalculatePerimeter():N3}, and the area is {c1.CalculateArea()}");

            Console.ReadKey();

        }
    }
}
