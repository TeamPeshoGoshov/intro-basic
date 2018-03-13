using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is width and height of rectangle.
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //Rectangle area.
            double area = a * b;

            //Print rectangle area.
            Console.WriteLine($"{area:f2}");
        }
    }
}
