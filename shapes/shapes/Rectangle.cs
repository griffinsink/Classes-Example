using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public double CalculateArea()
        {
            double area;
            area = Length * Width;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter;
            perimeter = 2*(Length + Width);
            return perimeter;
        }
    }
}
