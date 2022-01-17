using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue joukkue1 = new Joukkue();
            Pelaajat pelaajat1 = new Pelaajat();

            joukkue1.TulostaTiedot();
            pelaajat1.TulostaData();

            Console.WriteLine("--------------");
            Console.WriteLine("HaePelaaja");
            Console.WriteLine(" LisääPelaaja: ");
            Console.WriteLine(" PoistaPelaaja: ");
            Console.WriteLine(" LisääPelaaja: ");
            Console.WriteLine("1.  LisääPelaaja: ");
        }



        static void HaePelaaja()
        {
            Pelaajat uusipelaajat = new Pelaajat();
            while (true)
            {
                Console.WriteLine("Anna uudelle opiskelijalle tiedot: ");
                Console.WriteLine("Etunimi: ");
                uusipelaajat.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusipelaajat.Sukunimi = Console.ReadLine();
                Console.WriteLine("R: ");
                uusipelaajat.PelaajanNumero = Console.ReadLine();
                Console.WriteLine("OpiskelijaID");
                uusiOpiskelija.OpiskelijaNumero = Convert.ToInt32(Console.ReadLine());

                arvoit uudestaan
                if (opiskelijat.ContainsKey(uusiOpiskelija.OpiskelijaNumero))
                {
                    Console.WriteLine("Opiskelija sanakirjassa on opiskelija samalla ID:llä");
                    continue;
                }
                else
                {
                    opiskelijat.Add(uusiOpiskelija.OpiskelijaNumero, uusiOpiskelija);
                    break;
                }
            }
        }
    }
