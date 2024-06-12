namespace MindboxVacancy.FigureLibrary
{
	public class Circle : Figure
	{
		private readonly double r;		
		internal Circle(double r) //ограничим возможность создания фигур до internal, чтоб создавали всегда через Factory, где и проверяются все свойства фигур
		{
			this.r = r;
		}

		public override double CountSquare()
		{
			return Math.PI * r * r;
		}
	}
}
