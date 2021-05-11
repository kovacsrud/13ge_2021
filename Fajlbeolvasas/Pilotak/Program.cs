using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> pilotak = new List<Pilota>();
            try
            {
                var sorok = File.ReadAllLines("pilotak.csv",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    pilotak.Add(new Pilota(sorok[i],';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Adatsorok száma:{pilotak.Count}");

            //var utolso = pilotak[pilotak.Count - 1];
            var utolso = pilotak.Last();
            Console.WriteLine($"Utolsó pilóta:{utolso.Nev}");

            var multszazad = pilotak.FindAll(x=>x.SzulDatum.Year<1901);

            foreach (var i in multszazad)
            {
                Console.WriteLine($"{i.Nev},({i.SzulDatum.Year}.{i.SzulDatum.Month}.{i.SzulDatum.Day})");
            }

            var rajtszamosok = pilotak.FindAll(x=>x.Rajtszam!=-111);

            var minrajtszam = rajtszamosok.Find(x=>x.Rajtszam==rajtszamosok.Min(y=>y.Rajtszam));

            if (minrajtszam==null)
            {
                Console.WriteLine("Nincs ilyen!");
            } else
            {
                Console.WriteLine($"A legkisebb rajtszámú pilóta nemzetisége:{minrajtszam.Nemzetiseg}");
            }

            Console.ReadKey();
        }
    }
}
