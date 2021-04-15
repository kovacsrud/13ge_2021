using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOroklodes
{
    public class Macska:Allat
    {
        public string Nev { get; set; }
        public string Fajta { get; set; }
        
        public void Nyavog()
        {
            Console.WriteLine("A macska nyávog");
        }



    }
}
