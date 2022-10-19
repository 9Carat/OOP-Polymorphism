using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    class Cirkel : Geometri
    {
        protected double Radius { get; set; }

        public Cirkel()
        {
            Radius = 5;
            area = Area();
        }

        public override double Area()
        {
            double area = Radius * Radius * Pi;
            return area;
        }
    }
}
