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
            Tekning cirkel = new Cirkel();
            Tekning rektangel = new Rektangel();
            Tekning fyrkant = new Fyrkant();

            fyrkant.PrintInfo();
            rektangel.PrintInfo();
            cirkel.PrintInfo();

            Console.ReadKey();
        }
    }
}