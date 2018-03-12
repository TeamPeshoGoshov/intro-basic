using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            string currentHealt = "|" + new string('|', health) + new string('.', healthMax - health) + "|";
            string currentEnergy = "|" + new string('|', energy) + new string('.', energyMax - energy) + "|";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: {currentHealt}");
            Console.Write($"Energy: {currentEnergy}");
        }
    }
}

