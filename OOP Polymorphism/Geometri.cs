using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Geometri
    {
        protected double area;
        protected double Pi { get; set; }

        public Geometri()
        {
            Pi = 3.14;
        }

        public virtual double Area()
        {
            return area;
        }
    }
}
