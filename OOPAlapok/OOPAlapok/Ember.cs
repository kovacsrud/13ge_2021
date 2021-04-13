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
        public int szuletesiev;
        public int magassag;
        public int suly;

        //public void GetNev()
        //{
        //    Console.WriteLine($"A nevem:{nev}");
        //}

        public string GetNev()
        {
            return nev;
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
