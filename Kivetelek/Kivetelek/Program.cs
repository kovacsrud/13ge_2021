using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                Console.Write("A:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B:");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                try
                {
                    throw new ArgumentException("Érték hiba!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Beágyazott catch");                    
                }
                

                Console.WriteLine($"C értéke:{c}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Számot kell megadni!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nem lehet 0-val osztani!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                Console.WriteLine("Ez az ág mindig lefut.");
                a = -1;
                b = -1;
                c = -1;
            }

            Console.WriteLine($"A:{a},B:{b},C:{c}");
            

            Console.WriteLine("További utasítások...");

            Console.ReadKey();
        }
    }
}
