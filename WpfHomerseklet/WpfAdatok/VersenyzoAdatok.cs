using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatok
{
    public class VersenyzoAdatok
    {
        private List<Versenyzo> versenyzok;
        public List<Versenyzo> Versenyzok { get { return versenyzok; }  }

        public VersenyzoAdatok(string fajl,char hatarolo,int start=0)
        {
            versenyzok = new List<Versenyzo>();

            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                versenyzok.Add(new Versenyzo(sorok[i],hatarolo));
            }
        }
    }
}
