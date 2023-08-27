namespace TrianglesApp
{
    public class Triangle
    {
        /// <summary>
        /// Вершина один
        /// </summary>
        public Point P1 { get; private set; }

        /// <summary>
        /// Вершина два
        /// </summary>
        public Point P2 { get; private set; }

        /// <summary>
        /// Вершина 3
        /// </summary>
        public Point P3 { get; private set; }

        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1 ?? throw new ArgumentNullException(nameof(p1));
            P2 = p2 ?? throw new ArgumentNullException(nameof(p2));
            P3 = p3 ?? throw new ArgumentNullException(nameof(p3));
        }

        public void PrintPoints()
        {
            Console.WriteLine($"Вершина 1: {P1}");

            Console.WriteLine($"Вершина 2: {P2}");

            Console.WriteLine($"Вершина 2: {P3}");
        }

        public double GetPerimeter()
        {
            return P1.DistanceTo(P2) + P2.DistanceTo(P3) + P3.DistanceTo(P1);
        }

        public static Triangle CreateTriangle()
        {
            Console.WriteLine("Введите вершину 1:");
            var a = Point.CreatePointFromConsole();

            Console.WriteLine("Введите вершину 2:");
            var b = Point.CreatePointFromConsole();

            Console.WriteLine("Введите вершину 3:");
            var c = Point.CreatePointFromConsole();

            return new Triangle(a, b, c);
        }
    }
}