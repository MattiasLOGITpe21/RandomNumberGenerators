using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängivad 2 mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kes rohkem viskas
            //programm kuulutab võitja

            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Console.WriteLine("Vajuta [Enter], et täringut visata[Player1]");
            Console.ReadLine();
            Console.WriteLine($"Sa veeretasid {dice}");

            Console.WriteLine("Vajuta [Enter], et täringut visata[Player2]");
            Console.ReadLine();
            Console.WriteLine($"Sa veeretasid {dice2}");

            if (dice > dice2)
            {
                Console.WriteLine("Võitja on [Player1]");
            }
            else
            {
                Console.WriteLine("Võitja on [Player2]");
            }
            Console.ReadLine();


        }
    }
}
