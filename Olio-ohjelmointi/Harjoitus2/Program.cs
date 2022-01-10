using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Seppo", "154", 0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaOpintopisteitä(20);
            opiskelija1.MuokkaOpintopisteitä(15);
            opiskelija1.TulostaData();
        }
    }
}
