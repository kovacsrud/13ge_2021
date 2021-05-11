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
                    var darabok = sorok[i].Split(';');
                    Versenyzo versenyzo = new Versenyzo {
                        Helyezes = Convert.ToInt32(darabok[0]),
                        Nev = darabok[1],
                        Orszag = darabok[2],
                        Nyeremeny = Convert.ToInt32(darabok[3])

                    };

                    versenyzok.Add(versenyzo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"A lista elemeinek száma:{versenyzok.Count}");

            foreach (var i in versenyzok)
            {
                Console.WriteLine($"{i.Nev}:{i.Nyeremeny}");
            }

            Console.ReadKey();
        }
    }
}
