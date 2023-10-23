using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : Figure
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public override double CountSquare()
        {
            return Math.PI * r * r;
        }
    }
}
