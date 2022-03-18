using System;

namespace ZampolloVettori2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;
            int[] vettore = new int[dimensione];

            for(int i=0; i < dimensione; i++)
            {
                Random Generatore = new Random();
                int numeri = Generatore.Next(1, 100);

                vettore[i] = numeri;
                if (vettore[i] > 50)
                {
                    Console.WriteLine(vettore[i]);
                }
            }
        }
    }
}
