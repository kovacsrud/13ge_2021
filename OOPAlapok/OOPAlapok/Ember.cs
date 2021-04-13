using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Ember
    {
        private string nev;
        private int szuletesiev;
        private int magassag;
        private int suly;

        public Ember(string nev,int szuletesiev,int magassag,int suly)
        {
            this.nev = nev;
            this.szuletesiev = szuletesiev;
            this.magassag = magassag;
            this.suly = suly;
        }

        public Ember()
        {

        }
        

        public string GetNev()
        {
            return nev;
        }

        public int GetSzuletesiEv()
        {
            return szuletesiev;
        }

        public void SetNev(string benev)
        {
            if (benev.Length>2)
            {
                nev = benev;
            } else
            {
                nev = "alapérték";
            }
            
        }

    }
}
