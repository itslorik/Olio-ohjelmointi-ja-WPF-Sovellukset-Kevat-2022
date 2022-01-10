using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija 
    {
        private string nimi;
        private string opiskelijaID;
        private int opintopisteet;

        public Opiskelija(string _nimi, string __opiskelijaid, int _opintopisteet)
        {
            nimi = _nimi;
            opiskelijaID = __opiskelijaid;
            opintopisteet = _opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine(nimi + ". ID: " + opiskelijaID + ". Opintopisteet: " + opintopisteet);
        }


        public void MuokkaOpintopisteitä(int määrä)
        {
            //Lisätään opiskelijalle opintopisteitä "määrä" -parametrin verran
            opintopisteet += määrä;
        }

    }
}
