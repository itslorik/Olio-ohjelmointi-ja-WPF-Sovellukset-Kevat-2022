using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    class Työntekijä : Henkilö
    {


        private static int instanssit = 0;

        public override string Nimi { get ; set ; }
        public override string Työpaikka { get; set ; }
        public override int Palkaa { get ; set ; }

        public int Työviiko;

        public Työntekijä(string nimi, string työpaikka, int palkaa, int työviiko)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkaa = palkaa;
            Työviiko = työviiko;

            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Työntekijä " + instanssit);
        }
    }
}
