using System;
using System.Collections.Generic;

namespace Harjoitus11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();
            string syöte;

            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. lisää - Lisää opiskelijan kokoelmat");
                Console.WriteLine("2. poista - Poistaa opiskelijan kokoelmat");
                Console.WriteLine("3. tulosta - Tulostaa opiskelijan kokoelmat");
                Console.WriteLine("4. poistuu - Poistuu sovelluksesta");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "lisää":
                        
                        LisääOpiskelija(opiskelijat);
                        break;
                    case "poista":
                        //Kun käyttäjä antaa syötteeksi poista, käydään tämä läpi
                        PoistaOpiskelija(opiskelijat);
                        break;
                    case "tulosta":
                        //Kun käyttäjä antaa syötteelso tulosta, käydään tämä läpi
                        TulostaOpiskelija(opiskelijat);
                        break;
                    case "poistu":
                        //Kun käyttäjä ei ole antanut yllä olevia "case" syötteeksi, käydään tämä läpi
                        return;
                    default:

                        break;
 
                }
            }
        }

        static void LisääOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Opiskelija uusiOpiskelija = new Opiskelija();

            while (true)
            {
                Console.WriteLine("Anna uudelle opiskelijalle tiedot: ");
                Console.WriteLine("Etunimi: ");
                uusiOpiskelija.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusiOpiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine("Ryhmätunnus: ");
                uusiOpiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine("OpiskelijaID");
                uusiOpiskelija.OpiskelijaNumero = Convert.ToInt32(Console.ReadLine());

                //JOS opiskelijat sanakirjassa on samalainen opiskelijanumero, niin kysytään arvoit uudestaan
                if (opiskelijat.ContainsKey(uusiOpiskelija.OpiskelijaNumero))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    continue; //Continue skippaa nykyisen iteraation silmukasta ja aloitta lausta
                }
                else
                {
                    opiskelijat.Add(uusiOpiskelija.OpiskelijaNumero, uusiOpiskelija);
                    break;
                }
            }
        }

        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan opiskelijaID jonka haluat poistaa: ");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelija " + opiskelijat[syöte].Etunimi + "poistettu");
            }
            else
            {
                Console.WriteLine("Opiskelijaa ID:llä " + syöte + " ei löydetty kokelmasta");
            }

            opiskelijat.Remove(syöte);
        }

        static void TulostaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            foreach (Opiskelija item in opiskelijat.Values)
            {
                item.TulostaTiedot();
            }

        }
    }
}
