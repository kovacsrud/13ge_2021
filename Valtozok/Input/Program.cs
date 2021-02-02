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

            //Console.Write("Adjon meg egy számot:");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Adjon meg egy nem egész számot:");
            //double nemegesz = Convert.ToDouble(Console.ReadLine());



            //Console.WriteLine($"A begépelt értékek:{szam}|{nemegesz}");

            Console.Write("A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:");
            int b = Convert.ToInt32(Console.ReadLine());

            //Amikor egész számokat osztunk, az eredmény is egész lesz,
            //még akkor is, van maradék
            //"kényszeríthetjük" a műveletet arra, hogy a benne lévő 
            //változók típusától eltérő típusú eredményt adjon vissza

            //double c = (double)a / b;

            //automatikus típus hozzárendelés a változóhoz a var 
            //kulcsszóval

            var c = a / b;





            Console.WriteLine($"C={c}");



            Console.ReadKey();
        }
    }
}
