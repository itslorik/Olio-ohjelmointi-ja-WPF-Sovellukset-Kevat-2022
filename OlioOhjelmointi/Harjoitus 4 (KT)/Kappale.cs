using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Kappale
    {
        // Kappaleen nimi
        public string Nimi;
        // Kappaaleen pituus/kesto
        public string Pituus;

        // Kappaleen Konstruktori
        public Kappale(string _nimi, string _pituus)
        {
            Nimi = _nimi;
            Pituus = _pituus;
        }
    }
}
