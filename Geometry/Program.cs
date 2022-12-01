using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.CIRCLE 2.SQUARE 3.RECTANGLE 4.EXIT");

            Console.WriteLine("\nEnter the Choice");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Circle circle = new Circle();
                    circle.Area();
                    circle.Perimeter();
                    break;

                case 2:
                    Square square = new Square();
                    square.Area();
                    square.Perimeter();
                    break;
                    
                case 3:
                    Rectangle rectangle = new Rectangle();
                    rectangle.Area();
                    rectangle.Perimeter();
                    break;

                case 4:
                    return;

            }
        }
    }
}
