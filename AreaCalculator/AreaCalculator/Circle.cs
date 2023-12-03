using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle( double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be greater than zero.");
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
