using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömbök
            //A tömb több azonos típusú érték tárolására
            //szolgáló adatszerkezet
            //
            //deklaráció
            int[] szamok1 = new int[5];
            szamok1[0] = 116;
            szamok1[1] = 23;
            szamok1[2] = 67;
            szamok1[3] = 4456;
            szamok1[4] = 69;

            

            for (int i = 0; i < szamok1.Length; i++)
            {
                Console.WriteLine(szamok1[i]);
            }

            for (int i = 0; i < szamok1.Length; i++)
            {
                Console.Write("Elem:");
                szamok1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < szamok1.Length; i++)
            {
                Console.WriteLine(szamok1[i]);
            }

            string szoveg = "Asztali alkalmazások";

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.Write(szoveg[i]+" ");
            }


            Console.ReadKey();
        }
    }
}
