using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ubul = new Ember("Ubul",1991,178,86);
            //ubul.magassag = 178;
            //ubul.SetNev("Ubul");
            //ubul.suly = 86;
            //ubul.szuletesiev = 1991;

            Console.WriteLine(ubul.GetNev());
            Console.WriteLine(ubul.GetSzuletesiEv());

            Ember elek = new Ember("Elek",1986,198,69);
            //elek.magassag = 196;
            //elek.SetNev("Elek");
            //elek.suly = 69;
            //elek.szuletesiev = 1986;

            elek.SetNev("Elek Elek");
            Console.WriteLine(elek.GetNev());
            
            Console.WriteLine(elek.GetSzuletesiEv());

            JobbEmber jobb = new JobbEmber 
            {
                Nev="Jobb Ubul",
                Magassag=180,
                Suly=78,
                SzuletesiEv=1993
            };

            Console.WriteLine($"{jobb.Nev},{jobb.SzuletesiEv}");

            JobbEmber jobb2 = new JobbEmber("Jobb Elek", 1995, 10, 89);

            Console.WriteLine(jobb2.Magassag);
            Console.WriteLine($"{jobb2.Nev} {jobb2.Eletkor()} éves.");
            

            Console.ReadKey();
        }
    }
}
