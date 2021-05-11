using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombbeOlvasas
{
    public class Versenyzo
    {
        public int Helyezes { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public int Nyeremeny { get; set; }

        public Versenyzo(string sor,char hatarolo)
        {
            var darabok = sor.Split(hatarolo);
            Helyezes = Convert.ToInt32(darabok[0]);
            Nev = darabok[1];
            Orszag = darabok[2];
            Nyeremeny = Convert.ToInt32(darabok[3]);
        }
    }
}
