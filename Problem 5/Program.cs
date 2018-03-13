//CONFRIMED from MihailYordanov
using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {    // We recieve from the console this ints and read them...
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());
              //this strings merch by chars strings, to recieve the current health and energy
            string currentHealt = "|" + new string('|', health) + new string('.', healthMax - health) + "|";
            string currentEnergy = "|" + new string('|', energy) + new string('.', energyMax - energy) + "|";
                // We console print the name, currenthealt and currentEnergy...
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {currentHealt}");
            Console.Write($"Energy: {currentEnergy}");
        }
    }
}

