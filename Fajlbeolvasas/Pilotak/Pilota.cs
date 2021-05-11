using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    public class Pilota
    {
        public string Nev { get; set; }
        public DateTime SzulDatum { get; set; }
        public string Nemzetiseg { get; set; }

        public int Rajtszam { get; set; }

        public Pilota(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Nev = e[0];
            SzulDatum = DateTime.Parse(e[1]);
            Nemzetiseg = e[2];

            if (e[3].Length>0)
            {
                Rajtszam = Convert.ToInt32(e[3]);
            } else
            {
                Rajtszam = -111;
            }

        }

    }
}
