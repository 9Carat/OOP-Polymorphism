using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    class Tekning
    {
        protected double area;
        protected double Pi { get; set; }

        public Tekning()
        {
            Pi = 3.14;
        }

        public virtual double Area()
        {
            return area;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Area Tekning: " + area);
        }
    }
}
