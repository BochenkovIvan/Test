using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {

            AreaCalculator areaCalculator = new AreaCalculator();
            double circleArea = areaCalculator.CalculateArea<Circle>(5);
            double triangleArea = areaCalculator.CalculateArea<Triangle>(3, 20, 5);
            
        }
    }
}