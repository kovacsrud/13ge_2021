using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kicsoda
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string[] nevek = {"Áron","Géza","Éva","Klára","Egon","Ella" };

            Console.WriteLine("Ki vigye le a szemetet?");
            int valasztas = rand.Next(nevek.Length);
            Console.WriteLine($"A választott név indexe:{valasztas}");
            Console.WriteLine($"A szemetet leviszi:{nevek[valasztas]}");


            Console.ReadKey();
        }
    }
}
