using System;

namespace Harjoitus_1Ajoneuvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo();
            auto.Nimi = "volkswagen";
            auto.Nopeus = 280;
            auto.Renkaat = 4;

            Ajoneuvo vene = new Ajoneuvo();
            vene.Nimi = "David";
            vene.Nopeus = 520;
            vene.Renkaat = 0;

            Ajoneuvo mopo = new Ajoneuvo();
            mopo.Nimi = "Yamaha";
            mopo.Nopeus = 160;
            mopo.Renkaat = 2;

            auto.TulostaData();
            vene.TulostaData();
            mopo.TulostaData();
        }
    }
}
