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
            Ember ubul = new Ember();
            ubul.magassag = 178;
            ubul.SetNev("Ubul");
            ubul.suly = 86;
            ubul.szuletesiev = 1991;

            Console.WriteLine(ubul.GetNev());

            Ember elek = new Ember();
            elek.magassag = 196;
            elek.SetNev("Elek");
            elek.suly = 69;
            elek.szuletesiev = 1986;

            Console.WriteLine(elek.GetNev());

            

            Console.ReadKey();
        }
    }
}
