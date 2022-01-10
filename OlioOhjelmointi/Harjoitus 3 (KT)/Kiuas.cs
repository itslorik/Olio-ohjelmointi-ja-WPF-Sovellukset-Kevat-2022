using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_3__KT_
{
    class Kiuas
    {
        // Kiukaan ominaisuudet 
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;

        // Kiukaan "Tila", eli tällä määritetään onko kiuas päällä / pois päältä (true / false)
        public bool Tila = false;

        // Kiukaan konstruktori
        public Kiuas(string _nimi, int _lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpötila = _lämpötila;
            Kosteus = _kosteus;
        }

        // Näytetään kiukaan tiedot
        public void NäytäTiedot()
        {
            // jos kiuas ON päällä (true)
            if (Tila) // <-- if (Tila == true)
            {
                // tulostetaan kiukaan kaikki tiedot
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            } else
            {
                // Jos kiuas EI OLE päällä (false) tulostetaan ettei se ole päällä
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }
        }

        // Kutsumalla tätä muutetaan kiukaan lämpötilaa
        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;
        }

        // kutsumalla tätä muutetaan kiukaan kosteutta
        public void SäädäKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
        }
    }
}
