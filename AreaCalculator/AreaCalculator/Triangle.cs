using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        private double _side1, _side2, _side3;


        public Triangle (double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override double CalculateArea()
        {
            double halfP = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(halfP * (halfP - _side1) * (halfP - _side2) * (halfP - _side3));
        }
    }
}
