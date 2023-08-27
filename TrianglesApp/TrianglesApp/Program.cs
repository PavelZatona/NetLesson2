namespace TrianglesApp
{
    public class Program
    {
        static void Main(string[] args)
        {
/*            var p1 = new Point(0, 0);
            var p2 = new Point(0, 1);
            var p3 = new Point(1, 0);

            var triangle = new Triangle(p1, p2, p3);
            triangle.PrintPoints();

            Console.WriteLine($"Периметр: { triangle.GetPerimeter() }");

            var p4 = Point.CreatePointFromConsole();
            p4.PrintCoordinates();*/


            var tr = Triangle.CreateTriangle();
            Console.WriteLine($"Периметр: { tr.GetPerimeter() }");

            Console.ReadLine();
        }
    }
}