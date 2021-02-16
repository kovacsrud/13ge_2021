using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezetek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vezérlési szerkezetek
            //elágazások
            //ismételt tevékenységek (ciklusok)

            string sz1 = "KovÁcS";
            string sz2 = "koVáCs";

            //Egyszeres egyágú
            if (sz1.ToLower()==sz2.ToLower())
            {
                Console.WriteLine("A nevek megegyeznek!");  
            }

            //Egyszeres kétágú elágazás (szelekció)
            if (sz1==sz2)
            {
                Console.WriteLine("A nevek megegyeznek!");

            } else
            {
                Console.WriteLine("A nevek nem egyeznek meg!");
            }

            Console.Write("Adjon meg egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            //Állapítsuk meg, hogy a szám pozitív, vagy negatív!

            if (szam>0)
            {
                Console.WriteLine("A szám pozitív!");
                
            } else
            {
                Console.WriteLine("Negatív!");
            }





            Console.ReadKey();
        }
    }
}
