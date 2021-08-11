using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        private static readonly string _perimeter = "Rectangle perimeter formula: 2 * (l + w)";
        private static readonly string _area = "Rectangle area formula: l * w";
        private readonly double _Length;
        private readonly double _Width;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">Provides value for private readonly field _Length.</param>
        /// <param name="width">Provides value for private readonly field _Width.</param>
        public Rectangle(double length, double width)
        {
            if (CheckIfArgsAreGreaterThanZero(length, width))
            {
                _Length = length;
                _Width = width;
            }
        }

        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public static new string PerimeterFormula
        {
            get { return _perimeter; }
        }

        /// <summary>
        ///     Gets private field _Length.
        /// </summary>
        public virtual double Length
        {
            get { return _Length; }
        }

        /// <summary>
        ///     Gets private field _Width.
        /// </summary>
        public virtual double Width
        {
            get { return _Width; }
        }

        /// <summary>
        ///     Counts the Perimeter value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public double CountPerimeter()
        {
            return 2 * (Length + Width);
        }

        /// <summary>
        ///     Counts the Area value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public double CountArea()
        {
            return Length * Width;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Rectangle, w = {Width}, l = {Length}.";
        }
    }
}
