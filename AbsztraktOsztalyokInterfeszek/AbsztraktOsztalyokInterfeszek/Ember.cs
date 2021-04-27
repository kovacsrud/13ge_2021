using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyokInterfeszek
{
    public abstract class Ember
    {
        

        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        protected Ember(string nev, int szuletesiEv, int magassag, int suly)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
            Magassag = magassag;
            Suly = suly;
        }

        public abstract void Eszik();

        public abstract void Iszik();

        public abstract void Mozog();
        
        public int GetEletkor()
        {
            return DateTime.Now.Year - SzuletesiEv;
        }
     

    }
}
