using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb2d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Két dimenziós tömb táblázatra visszavezethető

            //deklarálás
            int[,] szamok = new int[10, 20];

            Random rand = new Random();

            //a 2 dimenziós tömb feltöltése értékekkel

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    szamok[i, j] = rand.Next(10,100);
                }

            }

            //A 2 dimenziós tömb elemeinek kiíratása
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(szamok[i,j]+" ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
