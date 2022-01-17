using System;
using System.Collections.Generic;

namespace Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------LISTA-------");

            List<string> lista = new List<string>();
            lista.Add("Pekka"); //indeksi 0
            lista.Add("Matti"); //indeksi 1
            lista.Add("Juha");  //indeksi 2

            lista.Remove("Matti");
            //lista.RemoveAt(1);

            //Käydään läpi lista
            //Tyyppi - nimi ja kokoelma

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------PINO-------");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1"); //Pushiilla lisätään pinon päällimäiseksi uusi objekti
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek());

            pino.Pop(); //Poistetaan päällimäinen objekti pinosta

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek());

            Console.WriteLine("-------JONO-------");
            Queue<string> jono = new Queue<string>();
            jono.Enqueue("Matti");
            jono.Enqueue("Pekka");
            jono.Enqueue("Juha");

            Console.WriteLine("Jonossa on " + jono.Count + "henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            jono.Dequeue();

            Console.WriteLine("Jonossa on " + jono.Count + "henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("-------SANAKIRJA-------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("4523119-8976", "Matti");
            sanakirja.Add("8675931-3254", "Pekka");

            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + "henkilöä");

            Console.WriteLine("Etsitään sanakirjasta avaimella '4523119-8976', Haettu henkilöä on:  " + sanakirja["4523119-8976"]);


            sanakirja.Add("4523119-8976", "Juha"); 
        }
    }
}
