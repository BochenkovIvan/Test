using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        private double Area { get; set; }



        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CalculateArea();

        }

        public override double CalculateArea()
        {
            double halfP = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(halfP * (halfP - Side1) * (halfP - Side2) * (halfP - Side3));
            return Area;
        }

        public bool IsRightTriangle()
        {
            var sides = new[] { Side1, Side2, Side3 };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.000001;

        }

        public bool IsTriangleExist()
        {
            if (Side1 + Side2 > Side3 && 
                Side1 + Side3 > Side2 && 
                Side2 + Side3 > Side1)
                return true;
            else
                return false;
        }

        public bool IsTriangleIsosceles()
        {
            return (Side1 == Side2) || (Side1 == Side3) || (Side2 == Side3);
        }
    }
}
