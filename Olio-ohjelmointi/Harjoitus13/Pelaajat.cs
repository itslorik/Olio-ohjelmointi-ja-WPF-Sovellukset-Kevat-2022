using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Pelaajat
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajanNumero;

        public void TulostaData()
        {
            Console.WriteLine("Pelaaja nimi: " + Etunimi + ". Pelaajan Sukunimi: " + Sukunimi + ". Pelaajan Numero: " + PelaajanNumero);
        }
    }
}
