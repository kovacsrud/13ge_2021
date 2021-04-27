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

            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
            Console.WriteLine(k1.ToString());
            Console.WriteLine(k2.ToString());

            List<Sikidom> sikidomok = new List<Sikidom>();
            sikidomok.Add(t1);
            sikidomok.Add(t2);
            sikidomok.Add(k1);
            sikidomok.Add(k2);

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap t = (Teglalap)i;
                    Console.WriteLine($"{t.Aoldal};{t.Boldal}");
                }
                if (i.GetType() == typeof(Kor))
                {
                    Kor k = (Kor)i;
                    Console.WriteLine($"{k.Sugar}");
                }
            }
            //Mennyi az összes síkidom területe?
            var osszterulet = sikidomok.Sum(x=>x.Terulet());
            Console.WriteLine($"Az összterület:{osszterulet}");

            //Mennyi a körök összes területe?
            

            Console.ReadKey();
        }
    }
}
