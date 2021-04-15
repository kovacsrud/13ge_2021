using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOroklodes
{
    public class Kutya:Allat
    {
        public string Nev { get; set; }
        public string Fajta { get; set; }

        public void Ugat()
        {
            Console.WriteLine("A kutya ugat");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya habzsolva eszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A kutya gyorsan mozog");
        }


        public override string ToString()
        {
            return $"{base.ToString()},Név:{Nev},Fajta:{Fajta}";
        }
    }
}
