using System;

namespace ZampolloVettori5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 1000;
            int[] vettore = new int[dimensione];
            int contaMaggiori = 0;
            float percentuale;

            for(int i = 0; i < dimensione; i++) 
            {
                Random generatore = new Random();
                int numeri = generatore.Next(1, 250);
                vettore[i] = numeri;
                Console.WriteLine(vettore[i]);

                if (vettore[i] < 175)
                {
                    contaMaggiori++;
                }
            
            }

            percentuale = (float)contaMaggiori / 1000;
            Console.WriteLine($"La percentuale degli elementi minori di 175 è {percentuale}");

        }
    }
}
