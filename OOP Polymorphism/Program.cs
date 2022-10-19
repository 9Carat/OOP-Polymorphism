//Christoffer Ottestig
//NET22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri cirkel = new Cirkel();
            Geometri rektangel = new Rektangel();
            Geometri fyrkant = new Fyrkant();
            Geometri paralellogram = new Paralellogram();
            Geometri ellips = new Ellips();

            Console.WriteLine("Area cirkel: {0}", cirkel.Area());
            Console.WriteLine("Area rektangel: {0}", rektangel.Area());
            Console.WriteLine("Area fyrkant: {0}", fyrkant.Area());
            Console.WriteLine("Area paralellogram: {0}", paralellogram.Area());
            Console.WriteLine("Area ellips: {0}", ellips.Area());
        }
    }
}