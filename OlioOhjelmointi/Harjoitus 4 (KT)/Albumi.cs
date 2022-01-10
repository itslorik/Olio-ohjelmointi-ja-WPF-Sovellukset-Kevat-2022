using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Albumi
    {
        // Albumi luokan ominaisuudet, esim Artisti, Albumi Nimi, Genre, Hinta

        private List<Kappale> kappaleet = new List<Kappale>();

        public void LisääKappale(Kappale uusiKappale)
        {
            kappaleet.Add(uusiKappale);
        }

        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ", " + kappale.Pituus);
            }
        }
    }
}
