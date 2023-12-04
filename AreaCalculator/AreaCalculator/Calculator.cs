using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class Calculator<T> where T : Shape
    {
       public Func<T, double> areaMeth = a => a.CalculateArea();
       
    }
}
