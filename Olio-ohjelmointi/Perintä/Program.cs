using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Seppo", 20, 6894202); // Henkil olio. Henkil EI ole Opiskelija 
            Opiskelija opiskelija = new Opiskelija("Joel", 18, 2958539, 123456, "Careeria."); // Opsikelija olio. Opiskelija = Henkilö.
            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();

            henkilö.Syö();
            henkilö.Juo();

            Console.WriteLine();

            opiskelija.Opiskele();
            opiskelija.Juo();
            opiskelija.Syö();

            
        }
    }
}
