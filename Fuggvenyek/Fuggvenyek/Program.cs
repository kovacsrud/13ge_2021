﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        public static void Kiir()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }

        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        public static void Kiir(string szoveg1,string szoveg2)
        {
            Console.WriteLine($"{szoveg1},{szoveg2}");
        }
        //függvény túlterhelés(overloading) 
        //A függvény túlterhelés során ugyanazzal a névvel,
        //de eltérő paraméterlistával hozunk létre függvényeket
        public static int Osszead(int a,int b)
        {
            return a + b;
        }

        public static double Osszead(double a,double b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            Kiir();
            Kiir("Valami szöveg");
            Kiir("másik szöveg");
            Kiir("egy", "kettő");
            Console.WriteLine(Osszead(12,21));
            int szam = 39 + Osszead(38,32);
            Console.WriteLine(szam);
            Console.WriteLine(Osszead(56.443,49.4432));

            Console.ReadKey();
        }

    }
}
