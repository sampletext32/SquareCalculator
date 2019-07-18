using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tester
{
    //класс для тестирования площадей
    [TestClass]
    public class UnitTestSquareCalculation
    {
        //тестирование круга
        [TestMethod]
        public void TestCircle()
        {
            ISquareCalculatable circle = new Circle(5);

            double circleSquare = circle.GetSquare();

            Assert.AreEqual(circleSquare, 78.539816, 0.000001);
        }

        //тестирование треугольника
        [TestMethod]
        public void TestTriangle()
        {
            ISquareCalculatable triangle = new Triangle(3, 4, 5);

            double triangleSquare = triangle.GetSquare();

            Assert.AreEqual(triangleSquare, 6);
        }
    }
}