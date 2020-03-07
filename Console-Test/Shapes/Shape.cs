using System;

namespace Console_Test.Shapes
{
    abstract class Shape
    {
        /// <summary>
        /// The name of the shape
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Abstract method that doesn't have a body in the abstract class but is to be overridden by child classes to implement it
        /// </summary>
        /// <returns>The area of the shape</returns>
        public abstract double Area();

        /// <summary>
        /// Virtual method that should be overridden in child classes
        /// Logs the information of a shape in the console
        /// </summary>
        public virtual void LogShapeInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
    }
}
