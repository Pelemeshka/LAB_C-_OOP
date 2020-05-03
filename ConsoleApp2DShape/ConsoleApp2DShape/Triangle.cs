using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DShape
{
    class Triangle : TwoDShape      // Класс треугольников - дочерний класса TwoDShape.
    {
        string Style;               // Поле названия

        public Triangle()       // Конструктор по умолчанию.
        {
            Style = "null";
        }

        // Конструктор для класса Triangle. Наследуется при помощи base от класса TwoDShape
        public Triangle (string s, double w, double h) : base (w, h, "triangle") 
        {
            Style = s;
        }

        public Triangle  (double y) : base (y, "triangle")      // Конструктор равнобедренного треугольника.
        {
            Style = "isosceles";
        }

        public Triangle (Triangle ob) : base (ob)       // Конструктор копии объекта типа Triangle.
        {
            Style = ob.Style;
        }

        public override double Area()   // Метод определения площади Area() для класса Triangle.
        {
            return Width * Height / 2;
        }

        public void ShowStyle()         // Метод отображения типа треугольника.
        {
            Console.WriteLine("{0} Triangle", Style);
        }
    }
}
