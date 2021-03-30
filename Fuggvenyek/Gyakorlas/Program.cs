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
        
        /// <summary>
        /// A függvény a szoveg változóban cseréli a értékét b-re
        /// </summary>
        /// <param name="szoveg">A szöveg, amiben cserélünk</param>
        /// <param name="a">Ez a változó lesz a szövegben lecserélve</param>
        /// <param name="b">Erre a változóra cserélünk</param>
        /// <returns></returns>
        static string Csere(string szoveg,char a,char b)
        {
            string eredmeny = szoveg.Replace(a, b);
            return eredmeny;
        }

        static void Koszon(string nev)
        {
            int ora = DateTime.Now.Hour;

            if (ora>=0 && ora<=5)
            {
                Console.WriteLine($"Szia {nev}, jó éjszakát!");
            } else if(ora>5 && ora<=9)
            {
                Console.WriteLine($"Szia {nev}, jó reggelt!");
            } else if (ora>9 && ora<19)
            {
                Console.WriteLine($"Szia {nev}, jó napot!");
            } else if(ora>19 && ora<22)
            {
                Console.WriteLine($"Szia {nev}, jó estét!");
            } else
            {
                Console.WriteLine($"Szia {nev}, jó éjszakát!");
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
            Console.WriteLine(Csere("valami",'a','x'));
            Koszon("Rudolf");

            //Írjon függvényt, amely kap egy szöveget, és két
            //karaktert. A függvény cserélje ki a szövegben
            //az egyik karakter, a másikra.
            //Pl. (valami,a,e) eredménye velemi lesz


            //Készítsünk egy függvényt, amely bekér egy
            // nevet, majd ezt a nevet felhasználva a 
            //napszaknak megfelelően köszön!
            

            Console.ReadKey();
        }
    }
}
