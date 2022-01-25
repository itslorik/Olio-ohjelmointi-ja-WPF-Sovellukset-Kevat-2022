using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_9
{
    class Kanava
    {
        public string Nimi;
        public float Taajus;

        public Kanava(string nimi, float taajus)
        {
            Nimi = nimi;
            Taajus = taajus;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("Kanava " + Nimi + "taajuudella" + Taajus);
        }
    }
}
