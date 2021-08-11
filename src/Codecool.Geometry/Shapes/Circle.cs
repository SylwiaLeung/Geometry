using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        private static readonly string _perimeter = "Circle perimeter formula: 2 * Pi * r";
        private static readonly string _area = "Circle area formula: Pi * r^2";
        private readonly double _Radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">Value for shape's radius.</param>
        public Circle(double radius)
        {
            if (CheckIfArgsAreGreaterThanZero(radius))
            {
                _Radius = radius;
            }
        }

        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
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
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        ///     Counts the Area value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public double CountArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <inheritdoc />
        public override double Area
        {
            get { return CountArea(); }
        }

        /// <inheritdoc />
        public override double Perimeter
        {
            get { return CountPerimeter(); }
        }

        /// <summary>
        ///     Gets private field _Radius.
        /// </summary>
        public double Radius
        {
            get { return _Radius; }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Circle, r = {Radius}.";
        }
    }
}
