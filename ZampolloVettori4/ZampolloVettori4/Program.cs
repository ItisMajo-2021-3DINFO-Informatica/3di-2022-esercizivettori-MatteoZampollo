using System;

namespace ZampolloVettori4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 100;
            int[] vettore = new int[dimensione];
            int max = 0;
            int min = 4000;


            for (int i = 0; i < dimensione; i++)
            {
                Random Generatore = new Random();
                int numeri = Generatore.Next(1000,3000);

                vettore[i] = numeri;
                Console.WriteLine(vettore[i]);

                if (vettore[i] > max)
                {
                    max = vettore[i];
                    
                }

                if (vettore[i] < min)
                {
                    min = vettore[i];
                }

               
            }
            Console.WriteLine($"Il numero più grande è {max}");
            Console.WriteLine($"Il numero più piccolo è {min}");

        }
    }
}

