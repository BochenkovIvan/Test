using static System.Console;
using ShapeAreaCalculator;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        IShapeFactory shapeFactory = new ShapeFactory();

        Shape shape1 = shapeFactory.CreateShape(25);

        double areaShape1 = shape1.CalculateArea();

        Console.WriteLine(areaShape1);
    }
}