using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas("Kastor", 60, 40);
            Kiuas kiuas2 = new Kiuas("Helo", 90, 10);
            Kiuas kiuas3 = new Kiuas("Veto", 30, 70);

            kiuas1.NäytäTiedot();
            kiuas2.NäytäTiedot();
            kiuas3.NäytäTiedot();
        }
    }
}
