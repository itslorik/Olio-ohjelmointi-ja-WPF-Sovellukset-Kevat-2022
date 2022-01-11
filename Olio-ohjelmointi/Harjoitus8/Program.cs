using System;

namespace Harjoitus8
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Pomo pomo1 = new Pomo("Seppo", "Careeria", 1800, 15, "BMW");
            Työntekijä työntekijä1 = new Työntekijä("Passi", "Careeria", 1800, 6);

            Pomo.KuinkaMonta();
            Työntekijä.KuinkaMonta();
            Henkilö.KuinkaMonta();


        }
    }
}
