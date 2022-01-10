using System;

namespace TestiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira();//Ensimmäinen koira olio
            koira1.nimi = "Seppo";
            koira1.ikä = 5;
            koira1.rotu = "Saksanpaimenkoira";


            koira1.Hauku();
            koira1.TulostaData();

            Koira koira2 = new Koira();
            koira2.nimi = "asd";
            koira2.ikä = 2;
            koira2.rotu = "Mopsi";

            koira2.TulostaData();
        }
    }
}
