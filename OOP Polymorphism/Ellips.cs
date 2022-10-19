using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double LargeAxle { get; set; }
        public double SmallAxle { get; set; }

        public Ellips()
        {
            LargeAxle = 6;
            SmallAxle = 3;
        }

        public override double Area()
        {
            double area = (LargeAxle / 2) * (SmallAxle / 2) * Pi;
            return area;
        }
    }
}
