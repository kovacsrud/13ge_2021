using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static string Nagybetus(string szoveg)
        {
            return szoveg.ToUpper();
        }

        static int Szoveghossz(string szoveg)
        {
            return szoveg.Length;
        }

        static int Kisebb(int a,int b)
        {
            if (a<b)
            {
                return a;
            } else if(b<a)
            {
                return b;
            } else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            //Írjon függvényt, amely kap egy szöveget
            //és visszatér ennek a nagybetűs alakjával
            Console.WriteLine(Nagybetus("függvény gyakorlás"));


            //Írjon függvényt, amely kap egy szöveget
            // és visszatér ennek a szövegnek a hosszával
            Console.WriteLine(Szoveghossz("függvény gyakorlás"));

            //Írjon függvényt, amely kap két számot, és a kettő
            //közül visszaadja a kisebbet,
            //egyenlőség esetén pedig -1 értéket
            Console.WriteLine(Kisebb(8,10));
            Console.WriteLine(Kisebb(98,10));
            Console.WriteLine(Kisebb(8,8));

            //Írjon függvényt, amely kap egy szöveget, és két
            //karaktert. A függvény cserélje ki a szövegben
            //az egyik karakter, a másikra.
            //Pl. (valami,a,e) eredménye velemi lesz


            Console.ReadKey();
        }
    }
}
