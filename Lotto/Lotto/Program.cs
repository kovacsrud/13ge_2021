using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bekérjük, hogy hány számot sorsolunk (5,7..)
            //Bekérjük, hogy hány számmal játszunk (45,90...)

            //Tippek bekérése, ugyanaz a tipp nem szerepelhet 
            //kétszer, a tippnek a megadott határok között
            //kell lennie. Csak a megfelelő tipp kerülhet a
            //tárolt tippek közé

            //nyerőszámok sorsolása, véletlenszámokkal, ha olyan
            //véletlen számot kapunk, ami már a nyerőszámok között van,
            //akkor újat sorsolunk

            //találatok számának meghatározása

            //kiíratás
            //Bekérés
            Console.Write("Hány számot húzunk?:");
            int szamDb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból húzunk?:");
            int osszSzam = Convert.ToInt32(Console.ReadLine());
            
            //Tömbök létrehozása
            int[] tippek = new int[szamDb];
            int[] nyeroSzamok = new int[szamDb];
            Random rand = new Random();

            //Tippelés
            for (int i = 0; i < szamDb; i++)
            {
                Console.Write($"Adja meg a(z) {i+1}. tippet:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp<1 || temp>osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás tipp!{i+1}.tipp újra:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;

            }
            //Tippek listázása
            for (int i = 0; i < tippek.Length; i++)
            {
                Console.Write(tippek[i]+" ");
            }
            Console.WriteLine();

            //Nyerőszámok sorsolása
            for (int i = 0; i < szamDb; i++)
            {
                int temp = rand.Next(1, osszSzam + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }

            for (int i = 0; i < nyeroSzamok.Length; i++)
            {
                Console.Write(nyeroSzamok[i]+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
