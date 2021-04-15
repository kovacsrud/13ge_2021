using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat
            {
                Magassag = 40,
                Suly = 12
            };
            allat.Eszik();
            allat.Iszik();
            allat.Mozog();
            Console.WriteLine(allat.ToString());

            Kutya kutya = new Kutya
            {
                Magassag = 30,
                Suly = 25,
                Fajta="komondor",
                Nev="Ubul"
            };

            kutya.Mozog();
            kutya.Iszik();
            kutya.Ugat();
            Console.WriteLine(kutya.ToString());

            Macska macska = new Macska
            {
                Magassag=12,
                Suly=2,
                Nev="Tigris",
                Fajta="sziámi"
            };

            macska.Nyavog();
            macska.Mozog();
            Console.WriteLine(macska.ToString());
            Console.ReadKey();
        }
    }
}
