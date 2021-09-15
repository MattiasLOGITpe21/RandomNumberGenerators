using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndnumber = rnd.Next(1, 11); //number 1 kuni 10

            Console.WriteLine($"Sinu juhuslik number on {rndnumber}");

            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number > 5, siis programm kuvab "..., see on suurem, kui 5
            //kui on väiksem, siis programm kuvab "..., see on väiksem,kui 5
            //(< - väiksem kui) , (> - suurem kui) , (== - võrdne)

            if (rndnumber > 5)
            {
                Console.WriteLine($"Sinu juhuslik number on {rndnumber}, see on suurem kui 5");
            }
            else if (rndnumber < 5)
            {
                Console.WriteLine($"Sinu juhuslik number on {rndnumber}, see on väiksem kui 5");
            }
            else
            {
                Console.WriteLine($"Sinu juhuslik number on {rndnumber}");
            }
            Console.ReadLine();
        }
    }
}
