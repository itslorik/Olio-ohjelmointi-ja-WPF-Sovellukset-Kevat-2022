using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            Koira koira1 = new Koira("Seppo", 5);
            Koira koira2 = new Koira("Saksanpaimenkoira", 5);
            Kissa kissa1 = new Kissa("Oranssi", 2);
            Kissa kissa2 = new Kissa("Musta", 2);

            koira1.Ääntele();
            kissa1.Ääntele();

            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            koira2.Ääntele();
            kissa2.Ääntele();

        }
    }
}
