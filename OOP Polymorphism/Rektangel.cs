using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    class Rektangel : Tekning
    {
        protected double Length { get; set; }
        protected double Width { get; set; }

        public Rektangel()
        {
            Length = 4;
            Width = 8.5;
            area = Area();
        }

        public override double Area()
        {
            double area = Width * Length;
            return area;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Area Rektangel: " + area);
        }
    }
}
