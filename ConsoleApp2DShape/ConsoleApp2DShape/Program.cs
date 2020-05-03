using System;

namespace ConsoleApp2DShape
{ 
    class Program
    {
        static void Main()
        {
            TwoDShape[] shapes = new TwoDShape[3];  // Массив из трех объектов класса TwoDShape
            shapes[0] = new Triangle("right", 8.0, 12.0);   // Прямоугольный треугольник.
            shapes[1] = new Rectangle(6);     // Квадрат. 
            shapes[2] = new Rectangle(3, 5);  // Прямоугольник

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Shape of object is {0}.", shapes[i].Name);
                Console.WriteLine("Area equal {0}.", shapes[i].Area());
                Console.WriteLine();
            }
        }
    }
}
