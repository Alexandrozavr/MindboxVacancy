namespace MindboxVacancy.FigureLibrary
{
	public class FigureFactory
	{
		public static Figure CreateFigure(IList<double> input)
		{

			/*if (input.Contains(0.0)) 			
				return null;*/

			//мы можем по разному реагировать на неправильный ввод. я буду возвращать null рассчитывая на обработку данного исхода в вызывающем методе
			//ни одна из сторон фигуры не может быть равна 0 . следовательно мы можем либо прервать выполнение(return null), либо удалить все значения 0 из коллекции как я и сделаю
			input = input.Where(x => x!= 0.0).ToList();
			switch (input.Count)
			{
				case 1:
					return new Circle(input[0]);
				case 3:
					// // по свойствам любая сторона треугольника меньше суммы двух других
					if (input[0] >= input[1] + input[2]
							|| input[1] >= input[0] + input[2]
							|| input[2] >= input[0] + input[1])
						return null;

					return new Triangle(input[0], input[1], input[2]);

				default:
					return null;
			}
		}
	}
}
