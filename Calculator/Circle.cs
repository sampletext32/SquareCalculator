using System;

namespace Calculator
{
    //класс круг, реализующий получение площади
    public class Circle : ISquareCalculatable
    {
        //радиус круга
        private double _radius;

        //конструктор
        public Circle(double radius)
        {
            _radius = radius;
        }

        //реализация получения площади
        public double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }
    }
}