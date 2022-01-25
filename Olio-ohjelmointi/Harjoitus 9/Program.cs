using System;
using System.Collections.Generic;

namespace Harjoitus_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kanava> kanavat = new List<Kanava>();
            LisääKanavat(kanavat);
            Radio radio = new Radio();
            radio.KanavaanYhdistetty(kanavat);

            static void LisääKanavat(List<Kanava> kanavat)
            {
                kanavat.Add(new Kanava("Yle", 99.2f));
            }
        }
    }
}
