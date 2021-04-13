using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class JobbEmber
    {
        

        public string Nev { get; set; }
        public int SzuletesiEv { get; set; }

        private int magassag;
        public int Magassag {
            get { return magassag; }
            set 
            {
                if (value>=60 && value<=230)
                {
                    magassag = value;
                } else
                {
                    magassag = 170;
                    //throw new ArgumentException("Hibás magasság!");
                }
            }
        
        }
        public int Suly { get; set; }

        public JobbEmber(string nev, int szuletesiEv, int magassag, int suly)
        {
            Nev = nev;
            SzuletesiEv = szuletesiEv;
            Magassag = magassag;
            Suly = suly;
        }

        public JobbEmber()
        {

        }

        public int Eletkor()
        {
            var aktEv = DateTime.Now.Year;
            return aktEv - SzuletesiEv;
        }
    }
}
