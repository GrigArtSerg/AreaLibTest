using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibTest
{
    [TestClass]
    public class TriangleTest
    {
        static double[] Triangle = new double[] { 3, 4, 6 };
        Figure FigureTriangle = new Figure(Triangle);

        /// <summary>
        /// Проверка вычисления площади обычного треугольника
        /// </summary>
        [TestMethod]
        public void FigureTriangleSidesTest()
        {
            Assert.AreEqual(FigureTriangle.GetFigureSides, Triangle);
        }

        [TestMethod]
        public void FigureTriangleSidesCountTest()
        {
            Assert.AreEqual(FigureTriangle.GetfigureSidesCount, 3);
        }

        [TestMethod]
        public void FigureTriangleIsRightTriangleTest()
        {
            Assert.AreEqual(FigureTriangle.GetIsRightTriangle, false);
        }

        [TestMethod]
        public void FigureTriangleMaxSideTest()
        {
            Assert.AreEqual(FigureTriangle.GetMaxSide, 6);
        }

        [TestMethod]
        public void FigureTriangleFigureAreaTest()
        {
            Assert.AreEqual(FigureTriangle.GetArea(), 5.332682251925386);
        }
    }
}
