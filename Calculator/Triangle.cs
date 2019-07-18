using System;

namespace Calculator
{
    //класс треугольник, реализующий получение площади
    public class Triangle : ISquareCalculatable
    {
        //стороны треугольника
        private double _side1;
        private double _side2;
        private double _side3;

        //конструктор
        public Triangle(double side1, double side2, double side3)
        {
            //проверка на возможность конструирования треугольника из переданных сторон
            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
            {
                throw new ArgumentException("Incorrect Sides");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        //проверка на прямоугольность
        public bool IsRectangular()
        {
            double sideMin = Math.Min(_side1, Math.Min(_side2, _side3));//минимальная сторона
            double sideMax = Math.Max(_side1, Math.Max(_side2, _side3));//максимальная сторона
            double sideMiddle = GetPerimeter() - sideMax - sideMin;//оставшаяся сторона

            //если стороны подчиняются формуле Пифагора, треугольник прямоугольный
            //т.к. используется сравнение с дробным числом, используем Floating-Point Comparison метод
            return Math.Abs(sideMax * sideMax - (sideMin * sideMin + sideMiddle * sideMiddle)) < 0.000001;
        }

        //функция получения периметра
        private double GetPerimeter()
        {
            return _side1 + _side2 + _side3;
        }

        //реализация получения площади
        public double GetSquare()
        {
            //используется формула Герона
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }
    }
}