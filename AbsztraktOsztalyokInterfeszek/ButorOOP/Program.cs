using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Butor> butorok = new List<Butor>();
            Asztal a = new Asztal
            {
                Anyag="fa",
                AsztallapAlak="kör",
                Fiokos=false,
                MaxMagassag=50,
                Suly=20
            };

            butorok.Add(a);

            Console.ReadKey();
        }
    }
}
