using FigureLibrary;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Figure figure = FigureFactory.CreateFigure(new double[] {5,4,3});
            double result = figure.CountSquare();
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void Test2()
        {
            Figure figure = FigureFactory.CreateFigure(new double[] {5});
            double result = figure.CountSquare();
            Assert.AreEqual(78.5398, result, 0.01);
        }
        [TestMethod]
        public void Test3()
        {
            Triangle figure = new Triangle(6, 4, 3);
         
            bool result = figure.IsSquareAngeled();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test4()
        {
            Triangle figure = new Triangle(5, 4, 3);
         
            bool result = figure.IsSquareAngeled();
            Assert.AreEqual(true, result);
        }
    }
}
