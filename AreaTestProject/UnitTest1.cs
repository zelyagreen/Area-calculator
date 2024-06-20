using AreaCalculator;

namespace AreaTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void CreateTriangleWithWrongParameters()
        {
            //Arrange
            double a = 11;
            double b = 1.2;
            double c = 0.2;
            //Act and Assert
            try
            {
                new Triangle(a, b, c);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Fail("Одна из сторон больше суммы двух других, такого треугольника не существует");
            }
        }

        [Fact]
        public void CalculateTriangleAreaTest()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            double area = triangle.Area();
            //Assert
            Assert.True(area <= 6.0 && area > 5.99);
        }

        [Fact]
        public void CheckIfTriangleIsRight()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool testResult = triangle.CheckRightTriangle();
            //Assert
            Assert.True(testResult);
        }

        [Fact]
        public void CalculateCircleAreaTest()
        {
            //Arrange
            double radius = 3.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(3, 2);
            //Act
            double area = circle.Area();
            //Assert
            Assert.Equal(expectedArea, area);
        }
    }
}