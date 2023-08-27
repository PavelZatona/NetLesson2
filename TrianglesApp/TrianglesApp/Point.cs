using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesApp
{
    /// <summary>
    /// Класс, описывающий точку
    /// </summary>
    public class Point
    {
        /// <summary>
        /// X-координата. get - читать может кто угодно. Private set - устанавливать можно только изнутри класса
        /// </summary>
        public double X { get; private set; }

        /// <summary>
        /// Y-координата
        /// </summary>
        public double Y { get; private set; }

        /// <summary>
        /// Это - конструктор. Он вызывается когда создаётся объект данного класса.
        /// А объекты создаются ключевым словом new
        /// </summary>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Point CreatePointFromConsole()
        {
            Console.WriteLine("Введите координату X");

            // Тут мы вводим координату X
            string StringEnteredX = Console.ReadLine();
            
            double enteredX = double.Parse(StringEnteredX );

            Console.WriteLine("Введите координату Y");

            // Тут мы вводим координату Y
            string StringEnteredY = Console.ReadLine();
            
            double enteredY = double.Parse(StringEnteredY);

            return new Point(enteredX, enteredY);
        }

        /// <summary>
        /// Распечатать координаты точки
        /// </summary>
        public void PrintCoordinates()
        {
            Console.WriteLine($"X: { X }, Y: { Y }");
        }

        /// <summary>
        /// Здесь мы переопределяем (override) метод, доставшийся нам от предка всех классов - класса Object
        /// </summary>
        public override string ToString()
        {
            return $"X: { X }, Y: { Y }";
        }

        /// <summary>
        /// Вычисляет расстояние до другой точки
        /// </summary>
        public double DistanceTo(Point anotherPoint)
        {
            _ = anotherPoint ?? throw new ArgumentNullException(nameof(anotherPoint), "Точка, до который измеряется расстояние, не указана!");

            return Math.Sqrt(Math.Pow((X - anotherPoint.X), 2) + Math.Pow((Y - anotherPoint.Y), 2));
        }
    }
}
