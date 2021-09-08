using System;

namespace RandomNumerGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(1, 7);

            //programm genereerib juhuslikku numbrit 1-10
            //programm kontrollib, kas genereeritud number on suurem kui 5
            // kui see number on suurem kui 5 siis konsool kuvab "juhuslik number on {MyRandomNumber},
            // suurem on suurem, kui 5";


            Console.WriteLine(MyRandomNumber);
            if(MyRandomNumber > 5)
            {
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}, see on suurem, kui 5");
            }
            else if(MyRandomNumber < 5)
            {
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}, see on väiksem, kui 5");
            }
            else
            {
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}");
            }       




        }
    }
}
