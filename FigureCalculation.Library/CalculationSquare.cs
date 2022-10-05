using FigureCalculation.Library.Figures;

namespace FigureCalculation.Library
{
    public static class FigureSquareCalculator
    {
        public static double GetSquare(IEnumerable<double> sides)
        {
            Figure figure;
            switch (sides.Count())
            {
                case 1:
                    figure = new Circle(sides);
                    break;
                case 2:
                    figure = new Rectangle(sides);
                    break;
                case 3:
                    figure = new Triangle(sides);
                    break;
                default:
                    throw new ArgumentException("Unsupported count sides");
            }
            return figure.Square;
        }
    }
}
