using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, minmax;

            Console.WriteLine("Podaj ilosc elementow tablicy");
            n = int.Parse(Console.ReadLine());
            int []tablica = new int[n];

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Podaj cyfre numer {0}",i+1);
                tablica[i] = int.Parse(Console.ReadLine());
            }

            minmax = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (minmax < tablica[i])
                {
                    minmax = tablica[i];
                }
            }

            Console.WriteLine("Najwiekszy element w tablicy :" + minmax);

            minmax = tablica[0];
            for (int i = 1; i < tablica.Length; i++)
            {
                if (minmax > tablica[i])
                {
                    minmax = tablica[i];
                }
            }

            Console.WriteLine("Najmniejszy element w tablicy: " + minmax);


           


        }
    }
}
