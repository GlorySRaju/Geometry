using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Circle : IGeometry
    {

        public double pi = 3.14;
        private double area,perimeter,radius;
       

        public Circle()
        {
            Console.WriteLine("\nEnter the Radius of Circle");
            radius = Double.Parse(Console.ReadLine());
        }
        public void Area()
        {
            area = pi * radius * radius;
            Console.WriteLine("\nAREA =" + area);
        }

        public void Perimeter()
        {
            perimeter = 2 * pi * area;
            Console.WriteLine("\nPERIMETER =" + perimeter);
        }
    }
}
