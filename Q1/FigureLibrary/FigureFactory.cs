namespace FigureLibrary
{    
    public class FigureFactory
    {
        public static Figure CreateFigure(double[] input)
        {
            switch (input.Length)
            {
                case 1:
                    return new Circle(input[0]);
                case 3:
                    return new Triangle(input[0], input[1], input[2]);
            }
            throw new NotImplementedException("необработанный случай");
        }
    }
}