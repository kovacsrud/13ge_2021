using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            //String típus és műveletei

            string szoveg = "ValAmi SzöVeg";

            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());
            
            //Ebben az esetben számít a kis/nagybetű
            Console.WriteLine(szoveg.Contains("ami"));

            //Itt már nem számít, mert a szöveget először
            //kisbetűssé alakítjuk, és utána vizsgáljuk
            Console.WriteLine(szoveg.ToLower().Contains("ami"));

            //Az adott szöveggel kezdődik a változó?
            Console.WriteLine(szoveg.StartsWith("Val"));

            //Ha nem akarjuk, hogy számítson a kis és nagybetű
            Console.WriteLine(szoveg.ToLower().StartsWith("val"));

            //Az adott szövegre végződik  a string?
            Console.WriteLine(szoveg.EndsWith("egg"));

            string datum = "2021.02.16";

            string ev = datum.Substring(0, 4);

            Console.WriteLine(ev);

            string honap = datum.Substring(5, 2);

            Console.WriteLine(honap);

            string nap = datum.Substring(8,2);

            Console.WriteLine(nap);

            string[] datumElemek = datum.Split('.');

            Console.WriteLine(datumElemek[0]);
            Console.WriteLine(datumElemek[1]);
            Console.WriteLine(datumElemek[2]);

            string cserel = "Ennek a szövegnek cseréljük a betűit.";

            //e betűk cseréje x-re
            Console.WriteLine(cserel.Replace('e','x'));

            //e betűk cseréje "semmire" azaz az e eltüntetése 
            //a szövegből

            Console.WriteLine(cserel.Replace("e", ""));

            Console.WriteLine(cserel.Replace(" ", ""));

            string szam = "145.678";
            double szamertek = Convert.ToDouble(szam.Replace('.',','));

            Console.WriteLine(szamertek);

            string levagando = "# &  @    valami adat      @  &&  <";

            //Felesleges szóközök és egyéb karakterek eltávolítása
            //a szöveg elejéről és végéről

            //Egy karakter tömbben felsorolhatjuk azokat a karaktereket
            // amelyeket el akarunk távolítani a szöveg elejéről
            // vagy végéről.

            char[] betuk = {'#','&',' ','@','<'};
            Console.WriteLine(levagando.Trim(betuk));
            Console.WriteLine(levagando.TrimStart(betuk));
            Console.WriteLine(levagando.TrimEnd(betuk));

            char betu = '3';

            Console.WriteLine(Char.IsWhiteSpace(betu));
            Console.WriteLine(Char.IsUpper(betu));
            Console.WriteLine(Char.IsDigit(betu));


            Console.ReadKey();
        }
    }
}
