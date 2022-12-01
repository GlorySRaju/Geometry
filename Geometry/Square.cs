using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Square : IGeometry
    {
        public double side, area, perimeter;

        public Square()
        {
            Console.WriteLine("\nEnter the side of Square");
            side = double.Parse(Console.ReadLine());
        }
        public void Area()
        {
            area = side * side;
            Console.WriteLine("\nAREA =" + area);
        }

        public void Perimeter()
        {
            perimeter = 4 * side;
            Console.WriteLine("\nPERIMETER =" + perimeter);
        }
    }
}
