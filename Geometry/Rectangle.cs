using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Rectangle : IGeometry
    {
        private double length, width,area,perimeter;

        public Rectangle()
        {
            Console.WriteLine("\nEnter the Length of Rectangle");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the Width of Rectangle");
            width = Double.Parse(Console.ReadLine());

        }

        public void Area()
        {
            area = length * width;
            Console.WriteLine("\nAREA =" + area);
        }

        public void Perimeter()
        {
            perimeter = 2 * (length + width);
            Console.WriteLine("\nPERIMETR =" + perimeter);
        }
    }
}
