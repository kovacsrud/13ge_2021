using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tomb2d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Két dimenziós tömb táblázatra visszavezethető

            //deklarálás
            int[,] szamok = new int[10, 10];

            Random rand = new Random();

            //a 2 dimenziós tömb feltöltése értékekkel

            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    szamok[i, j] = rand.Next(10,100);
                }

            }

            //A 2 dimenziós tömb elemeinek kiíratása
            for (int i = 0; i < szamok.GetLength(0); i++)
            {
                for (int j = 0; j < szamok.GetLength(1); j++)
                {
                    Console.Write(szamok[i,j]+" ");
                    //fél másodperc várakozás beiktatása
                    Thread.Sleep(500);
                }
                Console.WriteLine();
            }

            Console.WriteLine(szamok.Length);

           

            Console.ReadKey();
        }
    }
}
