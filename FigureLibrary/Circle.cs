namespace MindboxVacancy.FigureLibrary
{
	public class Circle : Figure
	{
		private readonly double r;
		/// <summary>
		/// ограничим возможность создания фигур до internal, чтоб создавали всегда через Factory, где и проверяются все свойства фигур
		/// </summary>
		/// <param name="r"></param>
		internal Circle(double r)
		{
			this.r = r;
		}

		public override double CountSquare()
		{
			return Math.PI * r * r;
		}
	}
}
