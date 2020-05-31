using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2DShape
{ 
    [My(Author = "Lemeshkin Andrew")]
    class Program


    {

        public static Logger log = LogManager.GetCurrentClassLogger();
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
    
            Console.WriteLine("Enter the side of the square.");//Задаем сторону квадрата
            string siteSquare = Console.ReadLine();

            //        public static Logger log = LogManager.GetCurrentClassLogger();
            
            //Обработка исключений в виде не соответствия типу byte.
            try
            {
                byte с = byte.Parse(siteSquare);
            }
            catch(Exception c)
            {
                Console.WriteLine("Error input!{0}", c.Message);  
                log.Debug("Debug - error input format"); //Запись в лог
                return;
            }

            Rectangle newSquare = new Rectangle(byte.Parse(siteSquare));    // Прямоугольник пользователя.

            // Создание коллекции для примера - коллекция прямоугольников.
            SortedList<string, object> sortRectangles = new SortedList<string, object>();

            sortRectangles.Add("Square2", new Rectangle(newSquare));    
            sortRectangles.Add("Square1", shapes[1]);
            sortRectangles.Add("Rectangle1", shapes[2]);

            ICollection<string> keys = sortRectangles.Keys; // Коллекция ключей 

            //Вывод сортированного списка по значению ключа(в алфавитном порядке)
            foreach (string s  in keys)
            {
                Console.WriteLine("Object : {0}, Class this object: {1}", s, sortRectangles[s].ToString());
            }
        }
    }
}
