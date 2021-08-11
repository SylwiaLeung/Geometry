using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry.Containers
{
    /// <summary>
    ///     Shape Collection class
    /// </summary>
    public sealed class ShapeCollection
    {
        private readonly List<Shape> _shapes;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeCollection"/> class.
        /// </summary>
        public ShapeCollection()
        {
            _shapes = new List<Shape>();
        }

        /// <summary>
        ///     Gets elements of the Shape list.
        /// </summary>
        /// <returns>Shape list</returns>
        public List<Shape> Shapes
        {
            get { return _shapes.ToList(); }
        }

        /// <summary>
        ///     Gets elements of the Shape list along with the Perimeter value.
        /// </summary>
        /// <returns>Shape list in a string format</returns>
        /// <param name="shapes">List of shapes added by the user</param>
        public static string GetShapesTable(List<Shape> shapes)
        {
            StringBuilder shapesAsString = new StringBuilder();
            foreach (Shape s in shapes)
            {
                shapesAsString.Append($"{s} Perimeter: {s.Perimeter}\n");
            }

            return shapesAsString.ToString();
        }

        /// <summary>
        ///     Adds element to the Shape list.
        /// </summary>
        /// <param name="shape">Shape class object</param>
        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

        /// <summary>
        ///     Gets the biggest element by its Perimeter.
        /// </summary>
        /// <returns>Shape instance with the largest Perimeter</returns>
        public Shape GetLargestShapeByPerimeter()
        {
            List<Shape> shapesByPerimeter = _shapes.OrderByDescending(s => s.Perimeter).ToList();
            return shapesByPerimeter[0];
        }

        /// <summary>
        ///     Gets the biggest element by its Area.
        /// </summary>
        /// <returns>Shape instance with the largest Area</returns>
        public Shape GetLargestShapeByArea()
        {
            List<Shape> shapesByArea = _shapes.OrderByDescending(s => s.Area).ToList();
            return shapesByArea[0];
        }
    }
}
