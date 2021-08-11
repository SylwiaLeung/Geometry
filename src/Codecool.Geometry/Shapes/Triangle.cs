using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        private static readonly string _perimeter = "Triangle perimeter formula: a + b + c";
        private static readonly string _area = "Triangle area formula: √p(p−a)(p−b)(p−c)";
        private readonly double _SideA;
        private readonly double _SideB;
        private readonly double _BaseC;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="sideA">Value for shape's side A</param>
        /// <param name="sideB">Value for shape's side B</param>
        /// <param name="baseC">Value for shape's base</param>
        public Triangle(double sideA, double sideB, double baseC)
        {
            if (CheckIfArgsAreGreaterThanZero(sideA, sideB, baseC))
            {
                _SideA = sideA;
                _SideB = sideB;
                _BaseC = baseC;
            }
        }

        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public static new string AreaFormula
        {
            get { return _area; }
        }

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public static new string PerimeterFormula
        {
            get { return _perimeter; }
        }

        /// <summary>
        ///     Gets private field _SideA.
        /// </summary>
        public virtual double SideA
        {
            get { return _SideA; }
        }

        /// <summary>
        ///     Gets private field _SideB.
        /// </summary>
        public virtual double SideB
        {
            get { return _SideB; }
        }

        /// <summary>
        ///     Gets private field _BaseC.
        /// </summary>
        public virtual double BaseC
        {
            get { return _BaseC; }
        }

        /// <summary>
        ///     Counts the Perimeter value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public virtual double CountPerimeter()
        {
            return SideA + SideB + BaseC;
        }

        /// <summary>
        ///     Counts the Area value.
        /// </summary>
        /// <returns>Value of shape's perimeter</returns>
        public virtual double CountArea()
        {
            double halfPerimeter = 0.5 * CountPerimeter();
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - BaseC));
        }

        /// <inheritdoc/>
        public override double Perimeter
        {
            get { return CountPerimeter(); }
        }

        /// <inheritdoc />
        public override double Area
        {
            get { return CountArea(); }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Triangle, a = {SideA}, b = {SideB}, c = {BaseC}.";
        }
    }
}
