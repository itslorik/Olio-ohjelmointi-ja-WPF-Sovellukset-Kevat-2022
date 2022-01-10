using System;

namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Pekka", "12345", 0); // Luodaan uusi opiskelija konstruktorin avulla
            opiskelija1.TulostaData(); // Tulostetaan tiedot
            opiskelija1.MuokkaaOpintopisteitä(10); // lisätään opiskelijalle 10 opintopistettä
            opiskelija1.MuokkaaOpintopisteitä(15); // lisätään opiskelijalle 15 opintopistettä
            opiskelija1.TulostaData(); // tulostetaan tiedot
        }
    }
}
