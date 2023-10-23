using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : Figure
    {
        private double x;
        private double y;
        private double z;
        public Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool IsSquareAngeled()
        {
            return x > y && x > z && x * x == y * y + z * z ||
                y > x && y > z && y * y == x * x + z * z ||
                z > y && z > x && z * z == y * y + x * x;
        }

        public override double CountSquare()
        {
            double semiPerimeter = (x + y + z) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - x) * (semiPerimeter - y) * (semiPerimeter - z));
        }
    }
}
