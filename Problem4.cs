//CONFIRMED from vesy53
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //We recive from the Console the product name -> string;
            var drinkName = Console.ReadLine();
            /*In the next three lines, we recive volume,
             * energy and sugar content of our products,
             * as and integer */
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());
            //We calculate energy and sugar;
            double totalEnergy = energyPer100ml / 100.0 * volume;
            double totalSugar = sugarPer100ml * volume / 100.0;

            //We print
            Console.WriteLine("{0}ml {1}:", volume, drinkName);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);



        }
    }
}