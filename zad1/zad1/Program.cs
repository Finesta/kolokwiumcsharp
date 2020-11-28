using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, delta,x1,x2;
            Console.WriteLine("Obliczanie delty.");
            Console.WriteLine("a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = double.Parse(Console.ReadLine());
          

            delta = ((-2*b) * (-2*b)) - (4 * a * (-4));

            Console.WriteLine("Delta wynosi: ");
            Console.WriteLine(Math.Round(delta, 2));

            if (delta < 0)
            {
                Console.Write("brak pierwiastków rzeczywistych.");
            }
            else if (delta == 0)
            {
                x1 = (2*(-b)) / (2 * a);
                Console.Write("Pierwiastek to,{0}: ",x1);
            }
            else
            {
                x1 = (((2*(b)) - Math.Sqrt(delta)) / (2 * a));
                x2 = (((2*(b)) + Math.Sqrt(delta))/ (2 * a));
                Console.Write("Pierwiastek x1 to,{0}: ", x1);
                Console.Write("Pierwiastek x2 to,{0}: ", x2);

            }

                    Console.ReadKey();

        }
    }
}