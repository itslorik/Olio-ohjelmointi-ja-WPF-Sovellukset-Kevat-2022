using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Albumi
    {
        // TEHTÄVÄ EI VALMIS, LISÄÄ VIELÄ SEURAAVAT:
        // Albumi luokan ominaisuudet, esim Artisti, Albumi Nimi, Genre, Hinta
        // Toiminto jolla tulostetaan yllä olevat tiedot, esim "TulostaAlbumi"

        // Lista kappaleista
        private List<Kappale> kappaleet = new List<Kappale>();

        // Lisätään uusi kappale, parametriksi annetaan Kappale joka lisätään
        public void LisääKappale(Kappale uusiKappale)
        {
            // Lisätään listaan uusi kappale
            kappaleet.Add(uusiKappale);
        }

        // Tulostaa albumissa olevat kappaleet
        public void TulostaKappaleet()
        {
            // Käy läpi "kappaleet" listan ja tulostaa jokaisen kappaleen nimen ja pituuden
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ", " + kappale.Pituus);
            }
        }
    }
}
