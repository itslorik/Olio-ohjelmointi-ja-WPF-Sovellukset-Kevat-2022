using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 90, 50); // Luodaan uusi Kiuas konstruktorin avulla

            harvia.NäytäTiedot(); // Tulostetaan kiukaan tiedot
            harvia.Tila = true; // laitetaan kiuas "päälle"
            harvia.NäytäTiedot(); // tulostetaan kiukaan tiedot
            harvia.SäädäLämpötila(100); // Muutetaan kiukaan lämpötilaa
            harvia.SäädäLämpötila(60); // Muutetaan kiukaan kosteutta
            harvia.NäytäTiedot(); // tulostetaan kiukaan tiedot
            harvia.Tila = false; // laitetaan kiuas "pois päältä"
        }
    }
}
