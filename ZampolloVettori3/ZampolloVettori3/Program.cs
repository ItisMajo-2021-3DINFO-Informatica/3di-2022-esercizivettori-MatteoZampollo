using System;

namespace ZampolloVettori3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 30;
            int[] vettore = new int[dimensione];
            int somma = 0;
            int media = 0;

            for (int i = 0; i < dimensione; i++)
            {
                Random generatore = new Random();
                int numero = generatore.Next(0, 50);
                vettore[i] = numero;
                Console.WriteLine(vettore[i]);
                somma = somma + vettore[i];
            }

            media = somma / 30;
            Console.WriteLine($"La media degli elementi è {media}");
        }
    }
}
