using MindboxVacancy.FigureLibrary;

namespace MindboxVacancy.Tests
{
	[TestClass]
	public class FigureTests
	{
		[TestMethod]
		public void TriangleSquareCount()
		{
			Figure figure = FigureFactory.CreateFigure([5, 4, 3]);
			double result = figure.CountSquare();
			Assert.AreEqual(6, result);
		}
		[TestMethod]
		public void CircleSquareCount()
		{
			Figure figure = FigureFactory.CreateFigure([5]);
			double result = figure.CountSquare();
			Assert.AreEqual(78.54, result, 0.01);
		}
		[TestMethod]
		public void TriangleSquareAngle_False()
		{
			Triangle triangle = (Triangle)FigureFactory.CreateFigure([6, 4, 3]);

			bool result = triangle.IsSquareAngled();
			Assert.IsFalse(result);
		}
		[TestMethod]
		public void TriangleSquareAngle_True()
		{
			Triangle triangle = (Triangle)FigureFactory.CreateFigure([5, 4, 3]);

			bool result = triangle.IsSquareAngled();
			Assert.IsTrue(result);
		}
		/// <summary>
		/// по свойствам любая сторона треугольника меньше суммы двух других. 
		/// </summary>
		[TestMethod]
		public void TriangleIsRealBySides_False()
		{
			Figure figure = FigureFactory.CreateFigure([2, 2, 5]);
			
			Assert.IsNull(figure);
		}
		[TestMethod]
		public void TriangleIsReal_True()
		{
			Figure figure = FigureFactory.CreateFigure([2, 2, 3]);

			Assert.IsNotNull(figure);
		}
		[TestMethod]
		public void NullTest()
		{
			Figure figure = FigureFactory.CreateFigure([2, 2, 3, 0, 0]);

			Assert.IsNotNull(figure);
		}
		[TestMethod]
		public void FullNullTest()
		{
			Figure figure = FigureFactory.CreateFigure([0,0,0,0]);

			Assert.IsNull(figure);
		}
	}
}
