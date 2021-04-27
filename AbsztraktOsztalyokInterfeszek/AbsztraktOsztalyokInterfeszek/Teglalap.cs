using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsztraktOsztalyokInterfeszek
{
    public class Teglalap : Sikidom
    {
        

        public double Aoldal { get; set; }
        public double Boldal { get; set; }

        public Teglalap(double aoldal, double boldal)
        {
            Aoldal = aoldal;
            Boldal = boldal;
        }

        public override double Kerulet()
        {
            return (Aoldal + Boldal) * 2;
        }

        public override double Terulet()
        {
            return Aoldal * Boldal;
        }

        public override string ToString()
        {
            return $"Téglalap,A:{Aoldal},B:{Boldal},Kerület:{Kerulet():0.00},Terület:{Terulet():0.00}";
        }
    }
}
