namespace MindboxVacancy.FigureLibrary
{
	public class Triangle : Figure
	{
		private readonly double x;
		private readonly double y;
		private readonly double z;
		/// <summary>
		/// ограничим возможность создания фигур до internal, чтоб создавали всегда через Factory, где и проверяются все свойства фигур
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		internal Triangle(double x, double y, double z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public bool IsSquareAngled()
		{
			return x * x == y * y + z * z ||
				y * y == x * x + z * z ||
				z * z == y * y + x * x;
		}

		public override double CountSquare()
		{
			double semiPerimeter = (x + y + z) / 2;
			return Math.Sqrt(semiPerimeter * (semiPerimeter - x) * (semiPerimeter - y) * (semiPerimeter - z));
		}
	}
}
