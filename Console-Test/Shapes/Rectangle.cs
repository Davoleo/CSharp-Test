using System;

namespace Console_Test.Shapes
{
    class Rectangle : Shape
    {
        //Private width and height fields
        private double width;
        private double height;

        /// <summary>
        /// Creates a new Rectangle given 2 dimensions for the height and the width
        /// </summary>
        /// <param name="width">The width of the new Rectangle</param>
        /// <param name="height">The height of the new Rectangle</param>
        public Rectangle(double width, double height)
        {
            this.Name = "Rectangle";
            this.width = width;
            this.height = height;
        }

        /// <returns>The area of the rectangle</returns>
        public override double Area()
        {
            return width * height;
        }

        /// <returns>The perimeter of th rectangle</returns>
        public double Perimeter()
        {
            return (width + height) * 2;
        }

        /// <summary>
        /// Logs the information of this rectangle
        /// </summary>
        public override void LogShapeInfo()
        {
            base.LogShapeInfo();
            Console.WriteLine($"Width: {width}, Height: {height}");
        }

        //------------------------------ Operator Overloading ------------------------
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double newWidth = rect1.width + rect2.width;
            double newHeight = rect1.height + rect2.height;
            return new Rectangle(newWidth, newHeight);
        }
    }
}
