using System;

namespace ZampolloGolfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 4;
            int[] colpi = new int[dimensione];
            int min = 0;
            int giocatoreMigl = 0;

            for (int i = 0; i < dimensione; i++)
            {
                do
                {
                    Console.WriteLine($"Inserisci numero di colpi del giocatore numero {i}: ");
                    colpi[i] = Convert.ToInt32(Console.ReadLine());
                } while (colpi[i] < 18);
            }

            min = colpi[0];

            for(int i = 0; i < dimensione; i++)
            {
                if (colpi[i] < min)
                {
                    min = colpi[i];
                    giocatoreMigl = i;
                }
            }

            Console.WriteLine($"Il giocatore migliore è il giocatore {giocatoreMigl} con {min} colpi");
        }
    }
}
