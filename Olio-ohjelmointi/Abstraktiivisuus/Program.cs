﻿using System;

namespace Abstraktiivisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija();
            opiskelija.Nimi = "Lorik";

            opiskelija.Puhu();
        }
    }
}
