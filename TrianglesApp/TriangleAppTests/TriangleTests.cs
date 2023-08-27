using TrianglesApp;

namespace TriangleAppTests
{
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Проверяем вычисление периметра
        /// </summary>
        [TestMethod]
        public void TestPerimetr()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(1, 0);
            var p3 = new Point(0, 1);

            var tr = new Triangle(p1, p2, p3);

            var actualPerimeter = tr.GetPerimeter();

            Assert.AreEqual(3.4, actualPerimeter, 0.1);
        }
    }
}