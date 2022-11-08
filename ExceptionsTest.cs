using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace AreaLibTest
{
    [TestClass]
    public class ExceptionsTest
    {
        [TestMethod]
        public void EmptyFigureTest()
        {
            double[] Empty = new double[0];
            Assert.ThrowsException<System.Exception>(() =>
            { Figure EmptyFigure = new Figure(Empty); });
        }

        [TestMethod]
        public void UndefinedFigureTest()
        {
            double[] Undefined = new double[] { 1, 2 };
            Assert.ThrowsException<System.Exception>(() =>
            { Figure UndefinedFigure = new Figure(Undefined); });
        }

        [TestMethod]
        public void ValuesExceptionFigureTest()
        {
            double[] ValuesException = new double[] { 0, 1, 2 };
            Assert.ThrowsException<System.Exception>(() =>
            { Figure ValuesExceptionFigure = new Figure(ValuesException); });
        }

        [TestMethod]
        public void FalseTriangleExceptionFigureTest()
        {
            double[] FalseTriangle = new double[] { 2, 3, 7 };
            Assert.ThrowsException<System.Exception>(() =>
            { Figure FalseTriangleFigure = new Figure(FalseTriangle); });
        }
    }
}
