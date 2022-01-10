using System;

namespace Harjoitus_4__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi();

            albumi.LisääKappale(new Kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new Kappale("Kappale 2", "02:55"));
            albumi.LisääKappale(new Kappale("Kappale 3", "05:12"));

            albumi.TulostaKappaleet();
        }
    }
}
