using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string PlayerOne = "Sina";
            string PlayerTwo = "Arvuti";

            int MyRandomNumber = rnd.Next(1, 7);
            Console.WriteLine($"{PlayerOne}, veeretasid {MyRandomNumber}.");
            int Myrandom = rnd.Next(1, 7);
            Console.WriteLine($"{PlayerTwo}, veeretas {Myrandom}.");
            if(MyRandomNumber > Myrandom)
            {
                Console.WriteLine($"{PlayerOne} Võitsid!");
            }
            else if(MyRandomNumber < Myrandom)
            {
                Console.WriteLine($"{PlayerTwo} Võitis!");
            }
            else
            {
                Console.WriteLine("Viik, Proovige uuesti");
            }
            






        }
    }
}
