using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyokInterfeszek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sportolo kajakozo = new Sportolo
            //{
            //    Magassag=180,
            //    Nev="Kiss Elek",
            //    Sportag="Kajak-kenu",
            //    Suly=85,
            //    SzuletesiEv=1992
            //};

            Sportolo kajakozo = new Sportolo("Kiss Elek", 1992, 180, 85, "kajak-kenu");

            Console.WriteLine($"A sportoló életkora:{kajakozo.GetEletkor()}");

            Teglalap t1 = new Teglalap(12, 10);
            Teglalap t2 = new Teglalap(18.91, 34.78);

            Kor k1 = new Kor(33.78);
            Kor k2 = new Kor(78.43);

            Console.WriteLine($"Kerület:{k1.Kerulet()},Terület:{k1.Terulet()}");

            Console.ReadKey();
        }
    }
}
