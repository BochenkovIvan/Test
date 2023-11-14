using ShapeAreaCalculator;
using Xunit;

namespace ShapeTest
{
    public class ShapeTest
    {
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(1, 1, 2, false)]
        [InlineData(5, 12, 13, true)]
        public void TestIsTriangleExist(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var result = triangle.IsTriangleExist();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(5, 5, 5, false)]
        [InlineData(2, 2, 3, false)]
        public void TestIsRightTriangle(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 4, 5, 6.0)]
        [InlineData(5, 12, 13, 30.0)]
        public void TestTriangleArea(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            var result = triangle.CalculateArea();

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, 3, 2, true)]
        [InlineData(3, 2, 3, true)]
        [InlineData(2, 3, 3, true)]
        [InlineData(5, 5, 5, true)]
        [InlineData(2, 2, 3, true)]
        [InlineData(3, 4, 5, false)]
        public void TestIsTriangleIsosceles(double a, double b, double c, bool expected)
        {
            var triangle = new Triangle(a, b, c);
            var result = triangle.IsTriangleIsosceles();
            Assert.Equal(expected, result);
        }
    }
}