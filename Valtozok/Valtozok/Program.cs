﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# alapok");

            //Változók
            //A C# erősen típusos nyelv, a változók típusát is meg kell adni.
            //a változó a program futása során valamilyen típusú adatot tárol

            //egész számok
            int a;
            a = 29;
            int b = 116;
            b = 88;
            int c = a + b;

            long d = 11433657;
            short e = 12333;

            Console.WriteLine($"A változó:{a}, B értéke:{b}, C értéke:{c}");

            Console.WriteLine($"{Int16.MinValue},{Int16.MaxValue}");
            Console.WriteLine($"{UInt16.MinValue},{UInt16.MaxValue}");

            Console.WriteLine($"{Int32.MinValue},{Int32.MaxValue}");
            Console.WriteLine($"{UInt32.MinValue},{UInt32.MaxValue}");

            Console.WriteLine($"{Int64.MinValue},{Int64.MaxValue}");
            Console.WriteLine($"{UInt64.MinValue},{UInt64.MaxValue}");

            byte bajt = 122;

            Console.WriteLine($"{Byte.MinValue},{Byte.MaxValue}");

            //Nem egész, azaz lebegőpontos számok
            float l1 = 19.12345678901234567890123456789f;
            double l2 = 19.12345678901234567890123456789;
            decimal l3 = 19.12345678901234567890123456789m;

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);

            //Szöveges adatok tárolása

            string szoveg = "Ez egy szöveg";
            
            Console.WriteLine(szoveg[0]);
            Console.WriteLine(szoveg[1]);

            Console.WriteLine(szoveg.Length);

            //Karakterek tárolása
            char kar = 'b';

            //Logikai érték
            bool logikai = true;

            logikai = false;





            Console.ReadKey();
        }
    }
}
