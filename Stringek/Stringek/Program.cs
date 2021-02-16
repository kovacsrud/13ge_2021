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
         

            Console.ReadKey();
        }
    }
}
