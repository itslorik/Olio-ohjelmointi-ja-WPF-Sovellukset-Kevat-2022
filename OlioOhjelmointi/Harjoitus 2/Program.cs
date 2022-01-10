using System;

namespace Harjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Pekka", "12345", 0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteitä(10);
            opiskelija1.MuokkaaOpintopisteitä(15);
            opiskelija1.TulostaData();
        }
    }
}
