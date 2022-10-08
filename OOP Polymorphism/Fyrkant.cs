using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    class Fyrkant : Tekning
    {
        public double Side { get; set; }

        public Fyrkant()
        {
            Side = 8;
            area = Area();
        }

        public override double Area()
        {
            double area = Math.Pow(Side, 2);
            return area;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Area Fyrkant: " + area);
        }
    }
}
