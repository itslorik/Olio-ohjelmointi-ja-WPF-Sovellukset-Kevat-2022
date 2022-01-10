using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public int hinta;

        private List<Kappale> kappaleet = new List<Kappale>();

        public Albumi(string artisti, string nimi, string genre, int hinta)
        {
            Artisti = artisti;
            Nimi = nimi;
            Genre = genre;
            this.hinta = hinta;
        }

        public void LisääKappale(Kappale uusiKappale)
        {
            kappaleet.Add(uusiKappale);
        }

        public void TulostaKappaleet()
        {
            foreach  (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + "," + kappale.Pituus);
            }
        }

        public void TulostaAlbumi()
        {
            
            Console.WriteLine("Artisit = " + Artisti);
            Console.WriteLine("Nimi = " + Nimi);
            Console.WriteLine("Genre = " + Genre);
            Console.WriteLine("Hinta = " + hinta);
        }
    }
}
