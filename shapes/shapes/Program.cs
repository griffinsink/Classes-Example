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
            List<Rectangle> rectangles = new List<Rectangle>();
            Circle[] circles = new Circle[2];

            Rectangle r1 = new Rectangle();
            r1.Length = 5;
            r1.Width = 5;
            Console.WriteLine($"The perimeter for r1 is {r1.CalculatePerimeter()} and the area is {r1.CalculateArea()}");

            Rectangle r2 = new Rectangle()
            {
                Length=10, Width=10
            };
            Console.WriteLine($"The perimeter for r2 is {r2.CalculatePerimeter()} and the area is {r2.CalculateArea()}");

            rectangles.Add(r1);
            rectangles.Add(r2);

            Circle c1 = new Circle(5.75);
            Console.WriteLine($"the area of c1 is {c1.CalculateArea():N2} and the {c1.CalculatePerimeter().ToString("N3")}");

            Circle c2 = new Circle();
            c2.Radius = 7;
            Console.WriteLine($"the area of c2 is {c2.CalculateArea():N3} and the perimeter is {c2.CalculatePerimeter():N3}");

            circles[0] = c1;
            circles[1] = c2;

            foreach (var rectangle in rectangles)
            {
                Console.WriteLine($"The perimeter for r1 is {rectangle.CalculatePerimeter()} and the area is {rectangle.CalculateArea()}");
            }

            foreach (var circle in circles)
            {
                Console.WriteLine($"The perimeter for r1 is {circle.CalculatePerimeter()} and the area is {circle.CalculateArea()}");
            }

            Console.ReadKey();
        }
    }
}
