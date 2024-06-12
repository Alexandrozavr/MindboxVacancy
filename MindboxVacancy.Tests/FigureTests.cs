using MindboxVacancy.FigureLibrary;

namespace MindboxVacancy.Tests
{
	[TestClass]
	public class FigureTests
	{
		/// <summary>
		/// проверка правильности вычислений площади у треугольника
		/// </summary>
		[TestMethod]
		public void TriangleSquareCount()
		{
			Figure figure = FigureFactory.CreateFigure([5, 4, 3]);
			double result = figure.CountSquare();
			Assert.AreEqual(6, result);
		}

		/// <summary>
		/// проверка правильности вычислений площади у круга
		/// </summary>
		[TestMethod]
		public void CircleSquareCount()
		{
			Figure figure = FigureFactory.CreateFigure([5]);
			double result = figure.CountSquare();
			Assert.AreEqual(78.54, result, 0.01);
		}

		/// <summary>
		/// проверка правильности вычисления прямоугольный ли треугольник. тест может неправильно сработать, если стороны будут < 0.01(точность сделал до 2 знаков после запятой)
		/// тут не прямоугольный
		/// </summary>
		[TestMethod]
		public void TriangleSquareAngle_False()
		{
			Triangle triangle = (Triangle)FigureFactory.CreateFigure([6, 4, 3]);

			bool result = triangle.IsSquareAngled();
			Assert.IsFalse(result);
		}

		/// <summary>
		/// проверка правильности вычисления прямоугольный ли треугольник. тест может неправильно сработать, если стороны будут < 0.01(точность сделал до 2 знаков после запятой)
		/// тут прямоугольный
		/// </summary>
		[TestMethod]
		public void TriangleSquareAngle_True()
		{
			Triangle triangle = (Triangle)FigureFactory.CreateFigure([5, 4, 3]);

			bool result = triangle.IsSquareAngled();
			Assert.IsTrue(result);
		}

		/// <summary>
		/// проверка выполнения свойства о сторонах треугольника
		/// не должно проходить
		/// </summary>
		/// <exception cref="AssertFailedException"></exception>
		[TestMethod]
		public void TriangleIsRealBySides_False()
		{
			try
			{
				Figure figure = FigureFactory.CreateFigure([2, 2, 5]);
				//дальше идти не должен
				throw new AssertFailedException("Ошибка. Создаёт треугольник который не выполняет свойства о сторонах треугольника");
			}
			catch (ArgumentException) { }
		}

		/// <summary>
		/// проверка выполнения свойства о сторонах треугольника
		/// не должно проходить
		/// </summary>
		[TestMethod]
		public void TriangleIsReal_True()
		{
			Figure figure = FigureFactory.CreateFigure([2, 2, 3]);			
		}

		/// <summary>
		/// проверка откидывания ввода неправильных элементов
		/// должно проходить
		/// </summary>
		[TestMethod]
		public void LessThenNullTest()
		{
			Figure figure = FigureFactory.CreateFigure([2, 2, 3, 0, -3]);			
		}

		/// <summary>
		/// проверка откидывания ввода неправильных элементов до 0 элементов
		/// не должно проходить
		/// </summary>
		/// <exception cref="AssertFailedException"></exception>
		[TestMethod]
		public void FullNullTest()
		{
			try
			{
				Figure figure = FigureFactory.CreateFigure([-1.0,-2,0,0]);
				//дальше идти не должен
				throw new AssertFailedException("Ошибка с отбрасыванием неверных вводных");
			}
			catch (ArgumentException) { } 
		}

		/// <summary>
		/// проверка откидывания ввода неправильных элементов
		/// должно проходить
		/// </summary>
		[TestMethod]
		public void RightInputTest()
		{
			Figure figure = FigureFactory.CreateFigure([3.3, -1.1, 0]);
			if (figure is not Circle)
			{
				throw new AssertFailedException("Ошибка с отбрасыванием неверных вводных.");
			}		
		}

		/// <summary>
		/// проверка неправильного числа вводных 
		/// не должно проходить
		/// </summary>
		/// <exception cref="AssertFailedException"></exception>
		[TestMethod]
		public void UnknownInputTest()
		{
			try
			{
				Figure figure = FigureFactory.CreateFigure([3.3, 2.5, 0]);
				//дальше идти не должен
				throw new AssertFailedException("Ошибка с отбрасыванием неверных вводных");
			}
			catch (NotImplementedException) { }
		}
	}
}
