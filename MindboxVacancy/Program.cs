using MindboxVacancy.FigureLibrary;

namespace MindboxVacancy
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			try
			{
				Figure figure = FigureFactory.CreateFigure(InputAndParcing() ?? []);
				Console.WriteLine(figure.CountSquare());
			}
			catch (SystemException e)
			{
				Console.WriteLine(e.Message); 				
			}			
		}

		private static double[]? InputAndParcing()
		{
			bool sucsess = false;
			double[]? doubles = null;
			Console.WriteLine("Введите числа единой строкой. Между числами ставьте \";\"." + Environment.NewLine +
					"Если хотите получить площадь круга - введите одно число. Треугольник - три числа.");
			while (!sucsess)
			{
				sucsess = true;
				Console.Write("Введите числа: ");
				string[] inputs = (Console.ReadLine() ?? "").Split(';');
				if (inputs.Length != 1 && inputs.Length != 3)
				{
					sucsess = false;
					Console.WriteLine("Неверное число введённых чисел!");
					continue;
				}
				doubles = new double[inputs.Length];
				for (int i = 0; i < inputs.Length; i++)
				{
					sucsess = double.TryParse(inputs[i], out doubles[i]);
					if (!sucsess)
					{
						Console.WriteLine($"Неверный ввод {i + 1}-го числа");
					}
				}
			}
			return doubles;
		}
	}
}
