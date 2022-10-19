using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Paralellogram : Geometri
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public Paralellogram()
        {
            Length = 7;
            Height = 4;
        }

        public override double Area()
        {
            double area = Length * Height;
            return area;
        }
    }
}
