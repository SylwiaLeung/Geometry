using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        private static readonly string _perimeter = "Equilateral triangle perimeter formula: 3 * s";
        private static readonly string _area = "Equilateral triangle area formula: s^2 * (√3 / 4)";
        private readonly double _Side;

        /// <summary>
        /// Initializes a new instance of the <see cref="EquilateralTriangle"/> class.
        /// </summary>
        /// <param name="side">Value for shape's side</param>
        public EquilateralTriangle(double side)
            : base(side, side, side)
        {
            if (CheckIfArgsAreGreaterThanZero(side))
            {
                _Side = side;
            }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the equilateral triangle as a string.
        /// </summary>
        public static new string PerimeterFormula
        {
            get { return _perimeter; }
        }

        /// <summary>
        ///     Gets formula for the area of the equilateral triangle as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets private field _Side.
        /// </summary>
        public double Side
        {
            get { return _Side; }
        }

        /// <inheritdoc/>
        public override double SideA
        {
            get { return Side; }
        }

        /// <inheritdoc/>
        public override double SideB
        {
            get { return Side; }
        }

        /// <inheritdoc/>
        public override double BaseC
        {
            get { return Side; }
        }

        /// <inheritdoc/>
        public override double CountPerimeter()
        {
            return 3 * Side;
        }

        /// <inheritdoc/>
        public override double CountArea()
        {
            return Math.Pow(Side, 2) * Math.Sqrt(3) / 4;
        }

        /// <inheritdoc/>
        public override double Perimeter
        {
            get { return CountPerimeter(); }
        }

        /// <inheritdoc/>
        public override double Area
        {
            get { return CountArea(); }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Equilateral Triangle, a = {Side}.";
        }
    }
}
