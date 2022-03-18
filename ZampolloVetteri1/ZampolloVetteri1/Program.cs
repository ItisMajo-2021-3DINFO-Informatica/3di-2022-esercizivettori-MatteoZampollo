using System;

namespace ZampolloVetteri1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;
            int[] Vettore = new int[dimensione];
            

            for(int i = 0; i < dimensione; i++)
            {
                Random Generatore = new Random();
                int numeri = Generatore.Next(1, 100);
                Vettore[i] = numeri;

                if (Vettore[i] > 50)
                {
                    Console.WriteLine(Vettore[i]);
                }
            }
        }
    }
}
