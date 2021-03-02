using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenSzam
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(-100,100+1));

            int[] szamok = new int[200];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-100, 100 + 1);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+" ");
            }

            Console.WriteLine("------------------");
            Console.WriteLine(szamok.Max());

            Console.ReadKey();
        }
    }
}
