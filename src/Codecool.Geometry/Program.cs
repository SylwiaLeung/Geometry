using System;
using Codecool.Geometry.Containers;
using Codecool.Geometry.Shapes;
using Codecool.Geometry.Utils;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            ShapeCollection c = new ShapeCollection();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nPlease chose your option: " + "\n1 - Add new shape" + "\n2 - Show added shapes" + "\n3 - Show shape with the largest perimeter" + "\n4 - Show shape with the largest area" + "\n5 - Show formulas for your shapes" + "\n0 - Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Shape shape = ShapeOperator.GenerateShape();
                        c.AddShape(shape);
                        break;
                    case 2:
                        Console.WriteLine(ShapeCollection.GetShapesTable(c.Shapes));
                        break;
                    case 3:
                        Console.WriteLine(c.GetLargestShapeByPerimeter());
                        break;
                    case 4:
                        Console.WriteLine(c.GetLargestShapeByArea());
                        break;
                    case 5:
                        Console.WriteLine(ShapeOperator.GenerateFormula());
                        break;
                    case 0:
                        Console.WriteLine("Thank you for using Shapes. Goodbye!");
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
