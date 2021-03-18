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

            Console.ReadKey();
        }
    }
}
