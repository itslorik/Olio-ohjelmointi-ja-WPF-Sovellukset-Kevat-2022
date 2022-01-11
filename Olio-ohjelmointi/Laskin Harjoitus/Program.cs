using System;

namespace Laskin_Harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 30;
            float b = 25;

            Console.WriteLine(Harjoitus5.Erotus(a, b));
            Console.WriteLine(Harjoitus5.lasku(a, b));
            Console.WriteLine(Harjoitus5.Jakolasku(a, b));
            Console.WriteLine(Harjoitus5.Kertolasku(a, b));
        }
    }
}
