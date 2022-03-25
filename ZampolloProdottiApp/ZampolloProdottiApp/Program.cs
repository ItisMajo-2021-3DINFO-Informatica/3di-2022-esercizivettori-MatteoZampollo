using System;

namespace ZampolloProdottiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 4;
            int[] prodotti = new int[dimensione];
            int sconto;
            int prezzoScontato;

            for(int i = 0; i < dimensione; i++)
            {
                Console.Write($"Inserisci prezzo del prodotto {i}: ");
                prodotti[i] = Convert.ToInt32(Console.ReadLine());
            }


            for(int i = 0; i < dimensione; i++)
            {
                sconto = (prodotti[i] * 22) / 100;
                prezzoScontato = prodotti[i] - sconto;
                Console.WriteLine($"Il prezzo del prodotto {i} scontato è {prezzoScontato}");
            }

        }
    }
}
