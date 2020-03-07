using System;

namespace Console_Test.Shapes
{
    class Triangle : Shape
    {
        private double @base;
        private double height;

        /// <summary>
        /// Creates a new Triangle given the length of the base and the height
        /// </summary>
        /// <param name="base">Base length of the new Triangle</param>
        /// <param name="height">Height of the new Triangle</param>
        public Triangle(double @base, double height)
        {
            this.Name = "Triangle";
            this.@base = @base;
            this.height = height;
        }

        public override double Area()
        {
            return (@base * height) / 2;
        }

        public override void LogShapeInfo()
        {
            base.LogShapeInfo();
            Console.WriteLine($"Base: {@base}, Height: {height}");
        }
    }
}
