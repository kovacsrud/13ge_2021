using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Összeg:{a+b}");
            Console.WriteLine($"Különbség:{a-b}");
            Console.WriteLine($"Szorzat:{a*b}");

            if (b==0)
            {
                Console.WriteLine("B nem lehet 0!");
            } else
            {
                Console.WriteLine($"Osztás:{(double)a/b}");
            }

            Console.Write("Adjon meg egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            int osszeg = 0;
            int darabszam = 0;

            while (szam!=0)
            {
                osszeg += szam;
                darabszam += 1;
                Console.Write("Adjon meg egy számot:");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Összeg:{osszeg},darabszám:{darabszam}");

            osszeg = 0;
            darabszam = 0;

            do
            {
                Console.Write("Adjon meg egy számot:");
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                darabszam += 1;

            } while (szam!=0);

            Console.WriteLine($"Összeg:{osszeg},darabszám:{darabszam}");

            Console.ReadKey();
        }
    }
}
