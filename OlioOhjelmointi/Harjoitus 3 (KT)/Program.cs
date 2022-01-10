using System;

namespace Harjoitus_3__KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Harvia", 90, 50);

            harvia.NäytäTiedot();
            harvia.Tila = true;
            harvia.NäytäTiedot();
            harvia.SäädäLämpötila(100);
            harvia.NäytäTiedot();
        }
    }
}
