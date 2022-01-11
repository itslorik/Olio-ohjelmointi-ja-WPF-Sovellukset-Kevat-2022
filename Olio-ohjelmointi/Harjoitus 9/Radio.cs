using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_9
{
    class Radio
    {

        private int minTaajus;
        private int maxTaajus;
        private int minÄäni;
        private int maxÄäni;

        private int nykyinenTaajus;


        public Radio(int minTaajus, int maxTaajus)
        {
            this.minTaajus = minTaajus;
            this.maxTaajus = maxTaajus;

            nykyinenTaajus = minTaajus;
        }
        public int NykyinenKerros
        {
            get => nykyinenTaajus;
            set
            {
                if (value > maxTaajus || value < minTaajus)
                {
                    Console.WriteLine("Virheellinen Kerros!");
                }
                else
                {
                    nykyinenTaajus = value;
                }
            }
        }
    }
}
