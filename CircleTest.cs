using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibTest
{
    [TestClass]
    public class CircleTest
    {
        static double[] Circle = new double[] { 5 };
        Figure FigureCircle = new Figure(Circle);

        /// <summary>
        /// Проверка вычисления площади круга
        /// </summary>
        [TestMethod]
        public void FigureCircleSidesTest()
        {
            Assert.AreEqual(FigureCircle.GetFigureSides, Circle);
        }

        [TestMethod]
        public void FigureCircleSidesCountTest()
        {
            Assert.AreEqual(FigureCircle.GetfigureSidesCount, 1);
        }

        [TestMethod]
        public void FigureCircleAreaTest()
        {
            Assert.AreEqual(FigureCircle.GetArea(), 5 * 5 * System.Math.PI);
        }
    }
}
