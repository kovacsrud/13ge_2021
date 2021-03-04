using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulacio
{
    class Program
    {
        static void Main(string[] args)
        {
            //A string típus egy megváltoztathatatlan típus
            //Ha új értéket adunk neki, akkor a háttérben egy új 
            //változó jön létre

            string szoveg = "ValAmI SzÖvEg";
            //Változtassuk a betűk írásmódját a jelenlegivel ellentétesre
            Console.WriteLine(szoveg);

            char[] szovegch = szoveg.ToCharArray();

            for (int i = 0; i < szovegch.Length; i++)
            {
                if (Char.IsLower(szovegch[i]))
                {
                    szovegch[i] = Char.ToUpper(szovegch[i]);
                } else
                {
                    szovegch[i] = Char.ToLower(szovegch[i]);
                }
                //Console.Write(szovegch[i]);
            }

            szoveg = new string(szovegch);

            Console.WriteLine(szoveg);

            Console.ReadKey();
        }
    }
}
