﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    public class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant()
        {
            Side = 8;
        }

        public override double Area()
        {
            double area = Math.Pow(Side, 2);
            return area;
        }
    }
}
