using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOroklodes
{
    public class Allat
    {
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public virtual void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public override string ToString()
        {
            return $"Súly:{Suly},Magasság:{Magassag}";
        }

    }
}
