using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibTest
{
    [TestClass]
    public class RightTriangleTest
    {
        static double[] RightTriangle = new double[] { 3, 4, 5 };

        Figure FigureRightTtriangle = new Figure(RightTriangle);

        /// <summary>
        /// Проверка вычисления площади прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void FigureRightTriangleSidesTest()
        {
            Assert.AreEqual(FigureRightTtriangle.GetFigureSides, RightTriangle);
        }

        [TestMethod]
        public void FigureRightTriangleSidesCountTest()
        {
            Assert.AreEqual(FigureRightTtriangle.GetfigureSidesCount, 3);
        }

        [TestMethod]
        public void FigureRightTriangleIsRightTriangleTest()
        {
            Assert.AreEqual(FigureRightTtriangle.GetIsRightTriangle, true);
        }

        [TestMethod]
        public void FigureRightTriangleMaxSideTest()
        {
            Assert.AreEqual(FigureRightTtriangle.GetMaxSide, 5);
        }

        [TestMethod]
        public void FigureRightTriangleAreaTest()
        {
            Assert.AreEqual(FigureRightTtriangle.GetArea(), 3.0 * 4.0 / 2.0);
        }
    }
}
