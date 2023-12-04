using static System.Console;
using ShapeAreaCalculator;
using System.Runtime.InteropServices;

namespace TestConsoleCalc
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Calculator<Shape> calc = new();
            IShapeFactory shapeFactory = new ShapeFactory();

            Shape shape1 = shapeFactory.CreateShape(1);
            Shape shape2 = shapeFactory.CreateShape(2, 3, 4);

            double areaShape1 = calc.areaMeth(shape1);
            double areaShape2 = calc.areaMeth(shape2);

            WriteLine(areaShape1);
            WriteLine(areaShape2);
            



        }


    }
}