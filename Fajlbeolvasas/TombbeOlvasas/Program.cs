using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombbeOlvasas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            try
            {
                var sorok = File.ReadAllLines(@"g:\snooker.txt",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {                  
                    versenyzok.Add(new Versenyzo(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"A lista elemeinek száma:{versenyzok.Count}");

            //foreach (var i in versenyzok)
            //{
            //    Console.WriteLine($"{i.Nev}:{i.Nyeremeny}");
            //}

            var angolok = versenyzok.FindAll(x=>x.Orszag=="Anglia");

            

            try
            {
                FileStream fajl = new FileStream("angolok.txt",FileMode.Create);
                StreamWriter wr = new StreamWriter(fajl,Encoding.UTF8);

                wr.WriteLine($"Név,Helyezés,Ország,Nyeremény");
                foreach (var i in angolok)
                {
                    wr.WriteLine($"{i.Nev},{i.Helyezes},{i.Orszag},{i.Nyeremeny}");
                }

                wr.Close();

                Console.WriteLine("Fájlba írás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
