namespace FigureCalculation.Library.Figures
{
    public class Rectangle : Figure
    {

        public Rectangle(IEnumerable<double> sides)
        {

            if (sides.Count() != 2)
            {
                throw new ArgumentException($"Unsupported sides count - {sides.Count()}");
            }

            if (!ValidatePossitiveNumbers(sides))
            {
                throw new ArgumentException("Incorrect sides");
            }
            Sides = sides.ToArray();
        }

        public override double Square
        {
            get => Sides[0] * Sides[1];
        }
    }
}
