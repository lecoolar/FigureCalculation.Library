namespace FigureCalculation.Library.Figures
{
    public abstract class Figure
    {
        public double[] Sides { get; protected set; }

        public abstract double Square { get; }

        protected bool ValidatePossitiveNumbers(IEnumerable<double> sides)
        {
            foreach (var c in sides)
            {
                if (c < 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
