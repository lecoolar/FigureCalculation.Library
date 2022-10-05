namespace FigureCalculation.Library.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(IEnumerable<double> sides)
        {
            if(sides.Count() != 1)
            {
                throw new ArgumentException($"Unsupported sides count - {sides.Count()}");
            }

            if(!ValidatePossitiveNumbers(sides))
            {
                throw new ArgumentException("Incorrect sides");
            }

            Sides = sides.ToArray();
            Radius = sides.First();
        }

        public override double Square
        {
            get => Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
