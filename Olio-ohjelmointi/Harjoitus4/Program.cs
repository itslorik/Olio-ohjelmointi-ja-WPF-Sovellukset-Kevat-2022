using System;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("Emínem","Lorik", "Old School", 5 );

            albumi.LisääKappale(new Kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new Kappale("Kappale 2", "02:15"));
            albumi.LisääKappale(new Kappale("Kappale  3", "03:00"));

            
            albumi.TulostaAlbumi();
        }
    }
}
