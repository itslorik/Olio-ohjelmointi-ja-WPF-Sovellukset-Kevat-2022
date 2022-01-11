using System;

namespace StatciEsimerkki
{
    class Program
    {
        static void Main(string[] args)
        {

            float km = 45f; // 45"kilometriä"
            //Muutetaan kilometrit maileiksi kutsumalla staattista Muuntaja -luokkaa
            float mailit = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + "kilometriä on yhtä kuin " + mailit + "mailia");


        }
    }
}
