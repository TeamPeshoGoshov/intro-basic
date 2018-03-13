//CONFIRMED from Insert000
using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //receives 4 integers on the console 
            //changed variable firstNumber -> firstNum
            int firstNum = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            //prints them in 4-digit debit card format
            Console.WriteLine($"{firstNum:D4} {secondNumber:D4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
