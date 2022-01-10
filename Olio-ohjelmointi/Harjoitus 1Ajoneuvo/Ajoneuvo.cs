using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_1Ajoneuvo
{
    class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public void TulostaData()
        {
            
            Console.WriteLine(Nimi + " nopeus: " + Nopeus);
            Console.WriteLine(Nimi + " renkaiden määrä " + Renkaat);
        }

    }
}
