using FigureCalculation.Library;
using FigureCalculation.Library.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureSquareCalculationTest
{
    [TestClass]
    public class FigureCalculationTest
    {
        [TestMethod]
        public void CircleNegativeRadiusTest()
        {
            var figure = new double[] { -10 };
            Assert.ThrowsException<ArgumentException>(() => new Circle(figure));
        }

        /// <summary>
        /// Тестируем отрицательные стороны треугольника
        /// </summary>
        [TestMethod]
        [DataRow(new double[] { -10, 0, 0 })]
        [DataRow(new double[] { 0, -10, 0 })]
        [DataRow(new double[] { 0, 0, -10 })]
        [DataRow(new double[] { -10, -10, -10 })]
        public void TriangleNegativeSidesTest(IEnumerable<double> sidesToTest)
        {

            Assert.ThrowsException<ArgumentException>(() => new Triangle(sidesToTest));
        }

        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [TestMethod]
        public void CircleSqrCalculationTest()
        {
            //Arrange
            var figure = new double[] { 10 };
            var expectedSquare = 314.15926535897931;

            //Act
            var resultSquare = new Circle(figure).Square;

            //Assert
            Assert.AreEqual(expectedSquare, resultSquare);
        }

        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [TestMethod]
        public void TriangleSqrCalculationTest()
        {
            //Arrange
            var figure = new double[] { 3, 4, 5 };
            var expectedSquare = 6;

            //Act
            var resultSquare = new Triangle(figure).Square;

            //Assert
            Assert.AreEqual(expectedSquare, resultSquare);
        }

        /// <summary>
        /// Тестируем прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var figure = new double[] { 3, 4, 5 };
            var expectedResult = true;

            //Act
            var result = new Triangle(figure).IsRectangular();

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        /// <summary>
        /// Тестируем не прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void NotRightAngleTriangleTest()
        {
            //Arrange
            var figure = new double[] { 6, 2, 5 };
            var expectedResult = false;

            //Act
            var result = new Triangle(figure).IsRectangular();

            //Assert
            Assert.AreEqual(expectedResult, result);
           
        }

        /// <summary>
        /// Тестируем отрицательные стороны
        /// </summary>
        [TestMethod]
        [DataRow(new double[] { -10, 0, 0 })]
        [DataRow(new double[] { -1, -2 })]
        [DataRow(new double[] { -1 })]
        [DataRow(new double[] { 1, 0, -15, 16 })]
        [DataRow(new double[] { 1, 0, -15, 16, 58 })]
        public void NotRightAngleTest(IEnumerable<double> sidesToTest)
        {
            Assert.ThrowsException<ArgumentException>(() => FigureSquareCalculator.GetSquare(sidesToTest));
        }

        [TestMethod]
        public void RectangleSqrCalculationTest()
        {
            //Arrange
            var figure = new double[] { 2, 6 };
            var expectedSquare = 12;

            //Act
            var resultSquare = FigureSquareCalculator.GetSquare(figure);

            //Assert
            Assert.AreEqual(expectedSquare, resultSquare);
        }

        [TestMethod]
        public void TriangleSqrCalculationTest2()
        {
            //Arrange
            var figure = new double[] { 3, 4, 5 };
            var expectedSquare = 6;

            //Act
            var resultSquare = FigureSquareCalculator.GetSquare(figure);

            //Assert
            Assert.AreEqual(expectedSquare, resultSquare);
        }

        [TestMethod]
        public void CircleSqrCalculationTest2()
        {
            //Arrange
            var figure = new double[] { 10 };
            var expectedSquare = 314.15926535897931;

            //Act
            var resultSquare = FigureSquareCalculator.GetSquare(figure);

            //Assert
            Assert.AreEqual(expectedSquare, resultSquare);
        }
    }
}