using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adatbevitel a billentyűzetről.

            Console.Write("Adjon meg egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy nem egész számot:");
            double nemegesz = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine($"A begépelt értékek:{szam}|{nemegesz}");




            Console.ReadKey();
        }
    }
}
