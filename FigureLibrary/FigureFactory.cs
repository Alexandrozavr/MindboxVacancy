﻿namespace MindboxVacancy.FigureLibrary
{
	public class FigureFactory
	{
		public static Figure CreateFigure(IList<double> input)
		{

			/*if (input.Contains(0.0)) 			
				return null;*/

			//мы можем по разному реагировать на неправильный ввод. можно возвращать null. я кидать соответстующий Exeption рассчитывая на обработку данного исхода в вызывающем методе или 
			//ни одна из сторон фигуры не может быть меньше 0. следовательно мы можем либо прервать выполнение(throw ArgumentException), либо удалить все значения < 0 из коллекции как я и сделаю
			input = input.Where(x => x > 0.0).ToList();
			switch (input.Count)
			{
				case 0:
					throw new ArgumentException("Не введено ни одного подходящего числа");
				case 1:					
					return new Circle(input[0]);
				case 3:
					// // по свойствам любая сторона треугольника меньше суммы двух других
					if (input[0] >= input[1] + input[2]
							|| input[1] >= input[0] + input[2]
							|| input[2] >= input[0] + input[1])
						throw new ArgumentException("Не выполняется свойство треугольника: \"Kюбая сторона треугольника должна быть меньше суммы двух других\"");

					return new Triangle(input[0], input[1], input[2]);

				default:
					throw new NotImplementedException("Неправильное число сторон у фигуры"); //так как можно добавлять другие фигуры, то оставлю тут NotImplementedException
			}
		}
	}
}
