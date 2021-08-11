using System;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry.Utils
{
    /// <summary>
    ///     This is a subsidary class holding additional methods for the Program class
    /// </summary>
    public static class ShapeOperator
    {
        /// <summary>
        ///     Choses an option from the shapes menu.
        /// </summary>
        /// <returns>Chosen option in a string format</returns>
        public static string ChoseShape()
        {
            Console.WriteLine("chose shape: \n1 - Circle \n2 - Equliteral Triangle \n3 - Rectangle \n4 - Regular Pentagon \n5 - Square \n6 - Triangle");
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        ///     Generates a new shape based on choice from the shape menu
        /// </summary>
        /// <returns>Generated shape</returns>
        public static Shape GenerateShape()
        {
            ShapeEnum chosenShape = (ShapeEnum)Enum.Parse(typeof(ShapeEnum), ChoseShape());
            switch (chosenShape)
            {
                case ShapeEnum.Circle:
                    Console.WriteLine("Please insert radius of the circle in cm: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());
                    Shape newCircle = new Circle(circleRadius);
                    return newCircle;
                case ShapeEnum.EquilateralTriangle:
                    Console.WriteLine("Please insert side of the equilateral triangle in cm: ");
                    double etriangleSide = Convert.ToDouble(Console.ReadLine());
                    Shape newTriangle = new EquilateralTriangle(etriangleSide);
                    return newTriangle;
                case ShapeEnum.Rectangle:
                    Console.WriteLine("Please insert length of the rectangle in cm: ");
                    double rectangleLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please insert width of the rectangle in cm: ");
                    double rectangleWidth = Convert.ToDouble(Console.ReadLine());
                    Shape newRectangle = new Rectangle(rectangleLength, rectangleWidth);
                    return newRectangle;
                case ShapeEnum.RegularPentagon:
                    Console.WriteLine("Please insert side of the pentagon in cm: ");
                    double pentagonSide = Convert.ToDouble(Console.ReadLine());
                    Shape newPentagon = new RegularPentagon(pentagonSide);
                    return newPentagon;
                case ShapeEnum.Square:
                    Console.WriteLine("Please insert side of the square in cm: ");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    Shape newSquare = new Square(squareSide);
                    return newSquare;
                case ShapeEnum.Triangle:
                    Console.WriteLine("Please insert length of side A of the triangle: ");
                    double triangleSideA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please insert length of side B of the triangle: ");
                    double triangleSideB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please insert length of base C of the triangle: ");
                    double triangleBaseC = Convert.ToDouble(Console.ReadLine());
                    Shape triangle = new Triangle(triangleSideA, triangleSideB, triangleBaseC);
                    return triangle;
            }

            return null;
        }

        /// <summary>
        ///     Generates formula for shape's area and perimeter based on choice from the shape menu
        /// </summary>
        /// <returns>Formula for shape's area and perimeter in a string format</returns>
        public static string GenerateFormula()
        {
            ShapeEnum chosenShape = (ShapeEnum)Enum.Parse(typeof(ShapeEnum), ChoseShape());
            switch (chosenShape)
            {
                case ShapeEnum.Circle:
                    return $"{Circle.AreaFormula} \n{Circle.PerimeterFormula}";
                case ShapeEnum.EquilateralTriangle:
                    return $"{EquilateralTriangle.AreaFormula} \n{EquilateralTriangle.PerimeterFormula}";
                case ShapeEnum.Rectangle:
                    return $"{Rectangle.AreaFormula} \n{Rectangle.PerimeterFormula}";
                case ShapeEnum.RegularPentagon:
                    return $"{RegularPentagon.AreaFormula} \n{RegularPentagon.PerimeterFormula}";
                case ShapeEnum.Square:
                    return $"{Square.AreaFormula} \n{Square.PerimeterFormula}";
                case ShapeEnum.Triangle:
                    return $"{Triangle.AreaFormula} \n{Triangle.PerimeterFormula}";
                default:
                    break;
            }

            return null;
        }
    }
}
