using Calculating;

namespace CalculatingCirclePerimeterAndCircumferenceTests
{
    public class CalculatingCirclePerimeterAndCircumferenceTests
    {
        [Theory]
        [InlineData(1, 2 * Math.PI)]
        [InlineData(2, 4 * Math.PI)]
        public void CalculatingPerimeter_WithInputRadius_ReturnsCorrectPerimeter(double radius, double expected)
        {
            double result = CalculatingCirclePerimeterAndCircumference.CalculatingPerimeter(radius);
            Assert.Equal(expected, result, 2);
        }
        public void CalculatingCircumference_WithInputRadius_ReturnsCorrectCircumference(double radius, double expected)
        {
            double result = CalculatingCirclePerimeterAndCircumference.CalculatingCircumference(radius);
            Assert.Equal(expected, result, 2);
        }
    }
}