using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DShape
{ 
    class Rectangle : TwoDShape     // Класс прямоугольников - дочерний от класса TwoDShape
    {
        public Rectangle (double w, double h) : base (w, h, "rectangle")   // Конструктор для класса Rectangle.
        { 
        }

        public Rectangle (double x) : base (x, "rectangle")   // Конструктор квадрата.
        { 
        }

        public Rectangle (Rectangle ob) : base (ob)     // Конструктор копии объекта типа Rectangle.
        {                                               // Наследование от абстрактного родительского класса.
        }   

        public bool IsSquare()  // Метод определения квадрата.
        {
            if (Width == Height) 
                return true;   // Если ширина = высоте - прямоугольник является квадратом.
            return false;
        }

        
        public override double Area()       // Метод  вычисления площади Area().
        {
            return Width * Height;
        }
    }
}
