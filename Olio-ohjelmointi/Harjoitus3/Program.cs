using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas("Kastor", 60, 40);

            kiuas1.NäytäTiedot();
            kiuas1.Tila = true;
            kiuas1.NäytäTiedot();
            kiuas1.SäädäLämpötila(100);
            kiuas1.NäytäTiedot();

            Kiuas kiuas2 = new Kiuas("Helo", 90, 10);
            kiuas2.NäytäTiedot();
            kiuas2.Tila = true;
            kiuas2.NäytäTiedot();
            kiuas2.SäädäLämpötila(100);
            kiuas2.NäytäTiedot();
            
        }
    }
}
