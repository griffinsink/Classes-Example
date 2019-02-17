using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            double area;
            area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter;
            perimeter = (2 * Math.PI) * Radius;
            return perimeter;
        }
    }
}
