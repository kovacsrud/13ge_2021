using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fajlbeolvasas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fajl = new FileStream(@"g:\snooker.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fajl,Encoding.Default);


                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }


                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
