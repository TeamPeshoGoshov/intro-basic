//CONFIRMED from VladiSavova
using System;

namespace MilesToKilometers
{
    class Problem3
    {
        static void Main(string[] args)
        {
            
            double milesValue = double.Parse(Console.ReadLine()); //This is the input

            double kilometersValue = milesValue * 1.60934; // Here the user calculates,kilometers in miles

            Console.WriteLine($"{kilometersValue:f2}"); // The result
        }
    }
}
