using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErtekEsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;

            Console.WriteLine($"A:{a},B:{b}");

            b = 27;

            Console.WriteLine($"A:{a},B:{b}");

            a = 78;

            Console.WriteLine($"A:{a},B:{b}");

            int[] t1 = { 23, 45, 66, 89 };
            int[] t2 = { 110, 5, 44, 234 };

            t2[0] = 88;
            t1[1] = 129;
            t2[2] = 669;

            //t1??
            for (int i = 0; i < t1.Length; i++)
            {
                Console.WriteLine(t1[i]);
            }

            //A változók lehetnek érték típusúak, ilyenek
            //pl. a primitív típusok
            //A másik típus az ún. referencia típus


            Console.ReadKey();
        }
    }
}
