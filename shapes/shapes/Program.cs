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
      
            Rectangle r1 = new Rectangle();
            r1.Length = 5;
            r1.Width = 5;
           // Console.WriteLine($"The perimeter for r1 is {r1.CalculatePerimeter()}, and the area is {r1.CalculateArea()}");

            Rectangle r2 = new Rectangle()
            {
                Length = 10,
                Width = 2
            };

            Circle c1 = new Circle(5.75);
            Console.WriteLine($"The perimeter for c1 is {c1.CalculatePerimeter():N3}, and the area is {c1.CalculateArea():n2}");

            foreach (var rectangle in rectangles)
            {
                Console.WriteLine(rectangle.CalculateArea());
               Console.WriteLine(rectangle.CalculatePerimeter());
            }

            Console.ReadKey();

        }
    }
}
