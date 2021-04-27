using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyokInterfeszek
{
    public class Sportolo:Ember
    {
        public Sportolo(string nev, int szuletesiEv, int magassag, int suly,string sportag) : base(nev, szuletesiEv, magassag, suly)
        {
            Sportag = sportag;
        }

        public string Sportag { get; set; }

        public void Edz()
        {
            Console.WriteLine("A sportoló edz.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló sokat eszik");
        }

        public override void Iszik()
        {
            Console.WriteLine("A sportoló sportitalt iszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló lendületesen mozog.");
        }
    }
}
