﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktiivisuus
{
    class Opiskelija : Henkilö
    {
        public override string Nimi { get; set; }

        public override void Puhu()
        {
            Console.WriteLine(Nimi + " Puhuu opiskelija luokassa");
        }
    }
}
