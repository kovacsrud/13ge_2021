using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ez is azonos típusú elemeket tároló adatszerkezet.
            //Az elemek számát nem kell megadni. 
            List<int> szamok = new List<int>();

            //elemek hozzáadása a listához
            szamok.Add(123);
            szamok.Add(34);
            szamok.Add(69);

            //A lista elemszámának meghatározása
            Console.WriteLine(szamok.Count);

            //Egy adott elem elérése a listában
            Console.WriteLine(szamok[1]);
            Console.WriteLine(szamok.ElementAt(2));
            //A lista első elemének elérése
            Console.WriteLine(szamok.First());

            //A lista utolsó elemének elérése
            Console.WriteLine(szamok.Last());
            Console.WriteLine("------------------------");    
            //A teljes lista kiíratása
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.WriteLine(szamok[i]);
            }
            Console.WriteLine("------------------------");

            //A foreach ciklussal nem lehet módosítani a lista vagy tömb
            //egy adott elemét!!

            //Törlés a listáról index szerint
            szamok.RemoveAt(0);

            //Törlés a listáról az elem értéke szerint
            szamok.Remove(34);

            //A lista összes elemének törlése
            szamok.Clear();

            foreach (var i in szamok)
            {
                Console.WriteLine(i);
            }

            


            Console.ReadKey();
        }
    }
}
