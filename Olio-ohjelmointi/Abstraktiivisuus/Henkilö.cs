using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktiivisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu(); //HUOM! Abstraktit metodit suljetaan ;. Aaltosulkuja ei kätyös
    }
}
