using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        private static readonly string _perimeter = "Regular Pentgon perimeter formula: 5 * a";
        private static readonly string _area = "Regular Pentagon area formula: 0.5 * P * apothem";
        private readonly double _Side;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularPentagon"/> class.
        /// </summary>
        /// <param name="side">Value for shape's side</param>
        public RegularPentagon(double side)
        {
            if (CheckIfArgsAreGreaterThanZero(side))
            {
                _Side = side;
            }
        }

        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public static new string PerimeterFormula
        {
            get { return _perimeter; }
        }

        /// <summary>
        ///     Counts the Perimeter value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public double CountPerimeter()
        {
            return 5 * Side;
        }

        /// <summary>
        ///     Counts the Area value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public double CountArea()
        {
            return 1.72 * Math.Pow(Side, 2);
        }

        /// <inheritdoc/>
        public override double Area
        {
            get { return CountArea(); }
        }

        /// <inheritdoc/>
        public override double Perimeter
        {
            get { return CountPerimeter(); }
        }

        /// <summary>
        ///     Gets private field _Side.
        /// </summary>
        public double Side
        {
            get { return _Side; }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Regular Pentagon, a = {Side}.";
        }
    }
}
