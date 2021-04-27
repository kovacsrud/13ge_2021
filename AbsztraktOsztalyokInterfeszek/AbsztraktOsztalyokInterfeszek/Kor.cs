using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyokInterfeszek
{
    public class Kor : Sikidom
    {
        

        public double Sugar { get; set; }
        public Kor(double sugar)
        {
            Sugar = sugar;
        }

        public override double Kerulet()
        {
            return 2 * Sugar * Math.PI;
        }

        public override double Terulet()
        {
            return Sugar * Sugar * Math.PI;
        }

        public override string ToString()
        {
            return $"Kör,Sugár:{Sugar},Kerület:{Kerulet():0.00},Terület:{Terulet():0.00}";
        }
    }
}
