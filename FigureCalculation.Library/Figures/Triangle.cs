namespace FigureCalculation.Library.Figures
{
    public class Triangle : Figure
    {
        public Triangle(IEnumerable<double> sides)
        {
            if (sides.Count() != 3)
            {
                throw new ArgumentException($"Unsupported sides count - {sides.Count()}");
            }
            if(!ValidatePossitiveNumbers(sides))
            {
                throw new ArgumentException("Incorrect sides");
                
            }
            Sides = sides.ToArray();
        }

        public bool IsRectangular()
        {
            if (Math.Pow(Sides[0], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2))
            {
                return true;
            }
            else if (Math.Pow(Sides[1], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2))
            {
                return true;
            }
            else if (Math.Pow(Sides[2], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))
            {
                return true;
            }

            return false;
        }

        public override double Square
        {
            get
            {
                double semiPerimeter = (Sides.Sum()) / 2;
                var result = Math.Sqrt(semiPerimeter * (semiPerimeter - Sides[0])
                    * (semiPerimeter - Sides[1]) * (semiPerimeter - Sides[2]));
                return result;
            }
        }
    }
}
