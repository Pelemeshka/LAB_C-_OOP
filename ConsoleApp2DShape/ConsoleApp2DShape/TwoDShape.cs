using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2DShape
{
    abstract class TwoDShape
    {
        double p_width;     // Поле ширина.
        double p_height;    // Поле высота.

        public TwoDShape()          // Конструктор по умолчанию - ширина и высота равны 0, имя - null.
        {
            Width = Height = 0.0;
            Name = "null";
        }

        public TwoDShape(double w, double h, string n)  // Параметризированный конструктор.
        {
            Width = w;
            Height = h;
            Name = n;
        }

        public TwoDShape(double z, string n)        // Конструктор объекта равной ширины и высоты.
        {
            Width = Height = z;
            Name = n;
        }

        
        public TwoDShape (TwoDShape ob)      // Конструктор копии объекта TwoDShape.
        {
            Width = ob.Width;
            Height = ob.Height;
            Name = ob.Name;
        }

        public double Width     // Свойства ширины и высоты объекта.
        {
            get { return p_width; }
            set { p_width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return p_height; }
            set { p_height = value < 0 ? -value : value; }
        }

        public string Name { get; set; }       // Свойство названия.

        public void ShowDim()
        {
            Console.WriteLine("Width equals {0} and Height equals {1}", Width, Height);
        }

        public abstract double Area();      // Абстрактный метод Area (площадь).
    }
}
