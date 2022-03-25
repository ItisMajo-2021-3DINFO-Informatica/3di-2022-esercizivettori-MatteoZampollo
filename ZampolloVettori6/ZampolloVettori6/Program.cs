using System;

namespace ZampolloVettori6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 8;
            int[] tempi = new int[dimensione];
            int min = 0;
            int scarti;

            for(int i = 0; i < dimensione; i++)
            {
                Console.WriteLine($"Inserire il tempo dell'atleta nella corsia {i} ");
                tempi[i] = Convert.ToInt32(Console.ReadLine());
            }

            min = tempi[0];

            for (int i = 0; i < dimensione; i++)
            {
                if (min < tempi[i])
                {
                    min = tempi[i];
                    scarti = tempi[i] - min;

                    
                }
            }

            Console.WriteLine($"L'atleta con il tempo minore è l'atleta in corsia {i}");
            


        }
    }
}
