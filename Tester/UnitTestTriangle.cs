using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tester
{
    //класс для тестирования прямоугольного треугольника
    [TestClass]
    public class UnitTestTriangle
    {
        //тестирования правильного порядка сторон
        [TestMethod]
        public void TestCorrectOrder()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRectangular());
        }

        //тестирование неправильного порядка сторон
        [TestMethod]
        public void TestIncorrectOrder()
        {
            Triangle triangle = new Triangle(5, 4, 3);

            Assert.IsTrue(triangle.IsRectangular());
        }

        //тестирование заведомо непрямоугольного треугольника
        [TestMethod]
        public void TestNonRectangular()
        {
            Triangle triangle = new Triangle(5, 4, 5);

            Assert.IsFalse(triangle.IsRectangular());
        }

        //тестирование несуществующего треугольника
        [TestMethod]
        public void TestIncorrectTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(5, 1, 2);
            });
        }
    }
}