using System;

namespace Console_Test.Shapes
{
    class Circle : Shape
    {
        /// <summary>
        /// The radius of the circle
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Creates a circle given the value of the radius 
        /// </summary>
        /// <param name="radius">The radius of the circle</param>
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        /// <summary>
        /// The method to calculate the area of a specific circle
        /// </summary>
        /// <returns>The area of the circle of a specific Radius</returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void LogShapeInfo()
        {
            base.LogShapeInfo();
            Console.WriteLine($"Radius: {Radius}");
        }
    }
}
