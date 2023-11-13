using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class AreaCalculator
    {
        public double CalculateArea<T>(params double[] parameters) where T : Shape
        {
            Shape shape = null;
            try
            {

                if (typeof(T) == typeof(Triangle))
                {
                    shape = new Triangle(parameters[0], parameters[1], parameters[2]);

                    if (parameters[0] + parameters[1] <= parameters[2] || 
                        parameters[0] + parameters[2] <= parameters[1] || 
                        parameters[1] + parameters[2] <= parameters[0])
                    {
                        throw new Exception("Треугольника с такими сторонами не существует");
                    }
                    else 
                    {
                        if (parameters[0] == parameters[1] || 
                            parameters[1] == parameters[2] || 
                            parameters[0] == parameters[2])

                            if (parameters[0] == parameters[1] && 
                                parameters[1] == parameters[2])
                            {
                                Console.WriteLine("Равносторонний треугольник");
                            }
                            else
                            {
                                Console.WriteLine("Треугольник равнобедренный");
                            }

                    }
            
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                throw;
            }
            return shape?.CalculateArea() ?? 0;
            
        }
    }
}
