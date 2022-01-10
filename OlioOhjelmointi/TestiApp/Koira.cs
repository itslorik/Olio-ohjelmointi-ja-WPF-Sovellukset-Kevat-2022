using System;
using System.Collections.Generic;
using System.Text;

namespace TestiApp
{
    class Koira
    {
        public string nimi; // julkinen muuttuja koiran nimelle
        public int ikä; // Koiran ikä
        public string rotu; // koiran rotu

        // Tyhjä konstruktori
        public Koira() { }

        // Konstruktori, jonka avulla alustetaan kaikki uudet koira oliot
        public Koira(string _nimi, int _ikä, string _rotu) // <-- sulkujen sisälle laitetaan kaikki tiedot mitä halutaan "pakottaa" uudelle oliolle
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

            // Konstruktorin sisälle voidaan myös lisätä muita toimintoja
            Hauku();
        }

        public void TulostaData() // Tätä metodia kutsumalla Program.cs ohjelmasta tulostetaan koira -olion tiedot
        {
            Console.WriteLine("Koiran nimi: " + nimi + ". Ikä: " + ikä + ". Rotu: " + rotu);
            //Console.WriteLine("Koiran nimi: {0}. Ikä: {1}. Rotu: {2}.", nimi, ikä, rotu);
        }

        public void Hauku() // Tätä metodia kutsumalla Program.cs ohjelmasta koira haukkuu
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
