using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciklus, iteráció, ismételt tevékenység

            //előírt lépésszámú ciklus (for)

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //elöltesztelő ciklus
            int a= 95;
            while (a<=100)
            {
                Console.WriteLine(a);
                a++;
                //a+=1;
                //a=a+1;
            }
            Console.WriteLine("-----------------");
            a = 98;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a<100);

            Console.ReadKey();
        }
    }
}
