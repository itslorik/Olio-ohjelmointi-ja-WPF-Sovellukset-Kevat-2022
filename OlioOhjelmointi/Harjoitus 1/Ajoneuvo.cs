using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_1
{
    class Ajoneuvo
    {
        // ajoneuvon perus tiedot (ominaisuudet)
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public void TulostaData() // tätä metodia kutsumalla voidaan tulostaa ajoneuvon tiedot
        {
            Console.WriteLine("Ajoneuvon nimi: " + Nimi);
            Console.WriteLine("Ajoneuvon nopeus: " + Nopeus);
            Console.WriteLine("Ajoneuvon renkaiden määrä: " + Renkaat);
        }

        public string ToString() // Tätä metodia kutsumalla PALAUTETAAN (return) ajoneuvon tiedot merkkijonona
        {
            return "Ajoneuvo: " + Nimi + ". Nopeus: " + Nopeus + ". Renkaiden määrä: " + Renkaat;
        }
    }
}
