using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    class Pomo : Henkilö
    {

        

        public override string Nimi { get ; set ; }
        public override string Työpaikka { get ; set; }
        public override int Palkaa { get ; set ; }

        public int bonus;

        public string auto;

        private static int instanssit = 0;

        public Pomo(string nimi, string työpaikka, int palkaa, int bonus, string auto)
        {
            if (instanssit > 0)
            {
                Console.WriteLine("Yksi Pomo On Joo Olemassa Ei Voidaan Lisätä Uusi");
                return;
            }
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkaa = palkaa;
            this.bonus = bonus;
            this.auto = auto;

            instanssit++;
        }
        public static new void KuinkaMonta()
        {
            Console.WriteLine("Pomo on " + instanssit);
        }
    }
}
