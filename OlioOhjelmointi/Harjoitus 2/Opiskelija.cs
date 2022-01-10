using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_2
{
    class Opiskelija
    {
        // alustetaan PRIVATE ominaisuudet opiskelijalle
        // private ominaisuuksia EI voida muuttaa Program.cs ohjelmasta suoraan
        private string nimi;
        private string opiskelijaID;
        private int opintopisteet;

        // Luodaan opiskelijalle konstruktori, josa määritetään uudelle opiskelijalle tiedot
        public Opiskelija(string _nimi, string _opiskelijaID, int _opintopisteet)
        {
            nimi = _nimi;
            opiskelijaID = _opiskelijaID;
            opintopisteet = _opintopisteet;
        }

        public void TulostaData() // tulostetaan opiskelijat tiedot konsoliin
        {
            Console.WriteLine(nimi + ". ID: " + opiskelijaID + ". Opintopisteet: " + opintopisteet);
        }

        // Kutsumalla tätä metodia muokataan opiskelija opintopisteistä
        public void MuokkaaOpintopisteitä(int määrä)
        {
            // Lisätään opiskelijalle opintopisteitä "määrä" -parametrin verran
            opintopisteet += määrä;
        }
    }
}
