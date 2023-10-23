using FigureLibrary;

namespace Q1
{    
    class Program
    {
        private static void Main(string[] args)
        {
            Figure figure = FigureFactory.CreateFigure(InputAndParcing());
            Console.WriteLine(figure.CountSquare());
        }

        private static double[] InputAndParcing()
        {
            bool sucsess = false;
            double[] doubles = null;
            Console.WriteLine("Введите числа единой строкой. между числами ставьте \";\"." + Environment.NewLine +
                    "Если хотите получить площадь круга - введите одно число, треугольник - три числа.");
            while (!sucsess)
            {
                sucsess = true;
                Console.Write("Введите числа: ");
                string[] inputs = Console.ReadLine().Split(';');
                if (inputs.Length != 1 && inputs.Length != 3)
                {
                    sucsess = false;
                    Console.WriteLine("Неверное колличество введеных чисел!");
                    continue;
                }
                doubles = new double[inputs.Length];
                for (int i = 0; i < inputs.Length; i++)
                {
                    sucsess = double.TryParse(inputs[i], out doubles[i]);
                    if (!sucsess)
                    {
                        Console.WriteLine($"Неверный ввод {i + 1}-го числа");
                        break;
                    }                                        
                }
            }
            return doubles;
        }
    }
}