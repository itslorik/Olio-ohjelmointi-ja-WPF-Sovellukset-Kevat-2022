
using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    abstract class Eläin
    {
        private static int instanssit = 0; // instassi laskuri, eli kuinka monta eläintä on olemassa.

        public Eläin()
        {
            instanssit++; // aina kun uusi eläin luodaan, lisätään instasseihin yksi lisää
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä on elossa: " + instanssit);
        }

        public abstract void Ääntele(); 
    }
}
