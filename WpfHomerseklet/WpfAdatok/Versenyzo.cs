﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAdatok
{
    public class Versenyzo
    {
        public int Helyezes { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public int Nyeremeny { get; set; }

        public Versenyzo(string sor,char hatarolo)
        {
            var e = sor.Split(hatarolo);
            Helyezes = Convert.ToInt32(e[0]);
            Nev = e[1];
            Orszag = e[2];
            Nyeremeny = Convert.ToInt32(e[3]);
        }
    }
}
