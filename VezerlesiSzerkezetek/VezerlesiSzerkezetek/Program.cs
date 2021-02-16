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

            string sz1 = "Kovács";
            string sz2 = "kovács";

            //Egyszeres egyágú
            if (sz1==sz2)
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




            Console.ReadKey();
        }
    }
}
