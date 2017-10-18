using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_DB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad 6.1");
            double a = 14.5, b = 24.5;
            Console.Write("pierwsza: {0}\ndruga: {1}", a, b);
            Console.WriteLine();
            Console.WriteLine("Zad 6.2");
            Console.Write(" /---\\  |----\\ /----\\\n|     | |    | |\n|     | |    / |\n|-----| |----  |\n|     | |    \\ |\n|     | |    | |\n|     | |----/ \\----/\n");
            Console.WriteLine("");
            Console.WriteLine("Zad 6.3");
            Console.WriteLine("111\t+\t222\t=\t333\n +\t\t +\t\t +\n333\t+\t444\t=\t777\n =\t\t =\t\t =\n444\t+\t666\t=\t1110\n");
            Console.WriteLine();
            Console.WriteLine("Zad 7.6");
            int c = 154, d = 586;
            Console.WriteLine("przed zmianą c= {0}, d= {1}", c, d);
            c += d;
            d = c - d;
            c -= d;
            Console.WriteLine("PO zmianie c= {0}, d= {1}", c, d);
            Console.WriteLine("Zad 7.1");
            int e = 12, f = 5, g = 3;
            int wynik = e % f % g;
            Console.WriteLine("wynik e % f % g: {0}", wynik);
            Console.WriteLine();
            Console.WriteLine("Zad 7.2");
            int suwak = 256;
            Console.WriteLine("ZMIENNA={0}, przesunięcie w lewo: {1}, Przesunięty w prawo: {2}", suwak, suwak << 2, suwak >> 2);
            Console.WriteLine();
            Console.WriteLine("Zad 7.3");
            int h = 4, i = 6;
            Console.WriteLine("zmienne h={0}, i={1}, suma bitowa = {2}, iloczyn bitowy = {3}", h, i, h | i, h & i);
            Console.WriteLine("i uj :D nie wiem czemy to nie nie liczy :)");
            Console.WriteLine();
            Console.WriteLine("Zad 7.4");
            int j = 2 ^ 4;
            Console.WriteLine("XOR {0}", j);
            Console.WriteLine("potrzebna konwersja do bin, dec ???");

            Console.WriteLine("Zad 7.5");

            int zm = 1;
            Console.WriteLine("sposób 1: wartość początkowa: {0}, wartość po powiększeniu o 3: {1}", zm, zm << 2);
            Console.WriteLine("sposób 2: wartość początkowa: {0}, wartość po powiększeniu o 3: - brak pomysłu", zm);
            Console.WriteLine("sposób 3: wartość początkowa: {0}, wartość po powiększeniu o 3: - brak pomysłu", zm);

            //for (int zm = 1; zm<5;zm++)
            //{
            //    zm++;
            //    //Console.WriteLine("sp1: {0}", zm);
            //}

            //int zm1 = 1;
            //while (zm1 == 1)
            //{

            //    Console.WriteLine("sp2: {0}", zm1);
            //}


            Console.WriteLine();
            Console.WriteLine("Zadanie 8.1");
            int k = 4, l = 3;
            if (k % l == 0)
            {
                Console.WriteLine("reszta z dzielenia wynosi 0");
            }
            else
            {
                Console.WriteLine("reszta z dzielenia różna od 0");
            }

            Console.WriteLine("Zadanie 8.2");
            Console.WriteLine("do zrobienia");


            Console.WriteLine("Zadanie 8.3");
            Console.WriteLine("podaj liczbę: ");
            int ab = Int32.Parse(Console.ReadLine());

            if (ab < 0 )
            {
                Console.WriteLine("Wartość bezwzględna podanej liczby to: {0} ", -ab);
                
            }
            else
            {
                Console.WriteLine("Wartość bezwzględna podanej liczby to: {0}",  ab);
            }





            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
