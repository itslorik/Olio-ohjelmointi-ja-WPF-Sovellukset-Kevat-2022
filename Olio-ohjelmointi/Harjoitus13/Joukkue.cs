using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkue
    {
        public string Nimi;
        public string Kotikaupunki;
        public int Pelaajat;

        public void TulostaTiedot()
        {
            Console.WriteLine("Joukkue Nimi : " +  Nimi + ". Kotikaupunki: " + Kotikaupunki + ". Pelaajat: ");

        }
    }
}
