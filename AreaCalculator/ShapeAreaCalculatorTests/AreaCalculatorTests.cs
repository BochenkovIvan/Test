using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ShapeAreaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            NUnit.Framework.Assert.AreEqual(Math.PI * 25, circle.CalculateArea());
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            NUnit.Framework.Assert.AreEqual(6, triangle.CalculateArea());
        }

        [Test]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            NUnit.Framework.Assert.IsTrue(triangle.IsRightTriangle());
        }
    }
}