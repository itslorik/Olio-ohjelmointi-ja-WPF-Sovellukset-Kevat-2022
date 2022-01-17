using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue1 = new Joukkue();
            Pelaajat pelaajat1 = new Pelaajat();

            joukkue1.TulostaTiedot();
            pelaajat1.TulostaData();


        }
    }
}
