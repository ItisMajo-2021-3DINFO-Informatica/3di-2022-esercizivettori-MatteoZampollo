using System;

namespace ZampolloPasswordGeneratoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generatore di Password");

            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2;
            numeri[2] = 3;
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6;
            numeri[6] = 7;
            numeri[7] = 8;
            numeri[8] = 9;
            numeri[9] = 10;

            char[] lettere = new char[26];


            lettere[0] = 'a';
            lettere[1] = 'b';
            lettere[2] = 'c';
            lettere[3] = 'd';
            lettere[4] = 'e';
            lettere[5] = 'f';
            lettere[6] = 'g';
            lettere[7] = 'h';
            lettere[8] = 'i';
            lettere[9] = 'j';
            lettere[10] = 'k';
            lettere[11] = 'l';
            lettere[12] = 'm';
            lettere[13] = 'n';
            lettere[14] = 'o';
            lettere[15] = 'p';
            lettere[16] = 'q';
            lettere[17] = 'r';
            lettere[18] = 's';
            lettere[19] = 't';
            lettere[20] = 'u';
            lettere[21] = 'v';
            lettere[22] = 'w';
            lettere[23] = 'x';
            lettere[24] = 'y';
            lettere[25] = 'z';

            char[] simboli = new char[10];
            simboli[0] = ',';
            simboli[1] = '.';
            simboli[2] = ';';
            simboli[3] = '+';
            simboli[4] = '-';
            simboli[5] = '@';
            simboli[6] = '*';
            simboli[7] = '§';


            Console.WriteLine("Inserisci lunghezza password: ");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            string nuovaPassword = "";
             
            Random generatore = new Random();

            for (int i = 0; i < lunghezza; i++)
            {
                int indicecasuale = generatore.Next(0, 25);
                nuovaPassword = nuovaPassword + lettere[indicecasuale];

                int sceltaSimboli;
                                                                                              
                if(sceltaMazzo = g
            }
            Console.WriteLine($"La tua password è {nuovaPassword} ");
        }

    }
}

