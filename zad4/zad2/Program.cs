using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbe n w przedziale 1 <= n<= 150");
            n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

                if (n >= 1 && n <= 150)
                    {
                        for (int i = 0; i < tab.Length; i++)
                            { 
                            Random r = new Random();
                            tab[i] = r.Next(-1000, 1000);
                            Console.WriteLine(tab[i]);
                            }
                       
                    }
                else
                    {
                    Console.WriteLine("Zly przedzial!");
                    }

            int ujemne = 0;

            for (int j = 0; j < tab.Length; j++)
            {

                if (tab[j] < 0)
                {
                    ujemne += tab[j];
                }
            }

            Console.WriteLine("\nSuma ujemnych to: {0}",ujemne);


            int dodatnie = 0;

            for (int j = 0; j < tab.Length; j++)
            {

                if (tab[j] > 0)
                {
                    dodatnie += tab[j];
                }
            }

            Console.WriteLine("Suma dodatnich to: {0}",dodatnie);
        }
    }
}

