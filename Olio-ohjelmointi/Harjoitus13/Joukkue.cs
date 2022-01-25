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

        public Joukkue(string nimi, string kotikaupunki, int pelaajat)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = pelaajat;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("Joukkue Nimi : " +  Nimi + ". Kotikaupunki: " + Kotikaupunki + ". Pelaajat: ");

        }
    }
}
