using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Kissa : Eläin
    {

        public string Väri;
        public int Ikä;

        public static int instanssit = 0;

        public Kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissa on elossa: " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("MOWE MOEW");
        }
    }
}
