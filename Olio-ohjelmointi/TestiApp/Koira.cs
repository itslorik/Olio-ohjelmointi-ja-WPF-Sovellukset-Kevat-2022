using System;
using System.Collections.Generic;
using System.Text;

namespace TestiApp
{
    class Koira
    {
        public string nimi;
        public int ikä;
        public string rotu;

        //Tyhjä konstruktori
        public Koira() { }
        
        //Konstruktori, jonka avulla alustetaan kaikki uudet koira oliot
        public Koira(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            Hauku();
        }

        public void TulostaData()
        {
            Console.WriteLine("Koiran nimi: " + nimi + ". Ikä " + ". Rotu: " + rotu);
            Console.WriteLine("Koiran ikä: " + ikä + ". Rotu: " + rotu);
            //Console.WriteLine("Koiran nimi: {0}. Ikä: {1}. Rotu: {2}. ", nimi, ikä, rout)
        }

        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
