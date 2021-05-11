using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteAll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy szöveget:");
            var szoveg = Console.ReadLine();

            string[] szovegek = { "hétfő", "kedd", "szerda" };
           
            try
            {
                File.WriteAllText("gepeles.txt", szoveg);
                File.WriteAllLines("szovegek.txt", szovegek);
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                 
            }

            



            Console.ReadKey();
        }
    }
}
