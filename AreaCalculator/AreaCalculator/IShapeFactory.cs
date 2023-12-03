using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public interface IShapeFactory
    {
        Shape CreateShape(double radius);
        Shape CreateShape(double side1, double side2, double side3);
    }
}
