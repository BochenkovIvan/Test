using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class ShapeFactory : IShapeFactory
    {
        public Shape CreateShape(double radius)
        {
            return new Circle(radius);
        }

        public Shape CreateShape(double side1, double side2, double side3) 
        { 
            return new Triangle(side1, side2, side3);
        }
    }
}
