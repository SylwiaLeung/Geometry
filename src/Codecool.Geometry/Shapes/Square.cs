namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        private static readonly string _perimeter = "Square perimeter formula: 4 * a";
        private static readonly string _area = "Square area formula: a * a";
        private readonly double _Side;

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="side">Value for shape's side</param>
        public Square(double side)
            : base(side, side)
        {
            if (CheckIfArgsAreGreaterThanZero(side))
            {
                _Side = side;
            }
        }

        /// <summary>
        ///     Gets formula for the area of the square as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the square as a string.
        /// </summary>
        public static new string PerimeterFormula
        {
            get { return _perimeter; }
        }

        /// <summary>
        ///     Gets private field _Side
        /// </summary>
        public double Side
        {
            get { return _Side; }
        }

        /// <inheritdoc/>
        public override double Length
        {
            get { return Side; }
        }

        /// <inheritdoc/>
        public override double Width
        {
            get { return Side; }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Square, a = {Side}.";
        }
    }
}
