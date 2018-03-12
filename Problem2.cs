using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is width and height of rectangle.
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Rectangle area.
            double rectangleArea = width * height;

            //Print rectangle area.
            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
