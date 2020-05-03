using System;

namespace Console_Test.CustomClasses
{
    class Box
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public Box() : this(1, 1, 1)
        { }

        public Box(double width, double height, double depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }

        //Overridable operators: + - * / % ! == != > < >= <= ++ --
        public static Box operator +(Box box1, Box box2)
        {
            Box boxSum = new Box(
                box1.Width + box2.Width,
                box1.Height + box2.Height,
                box1.Depth + box2.Depth);

            return boxSum;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            return box1.Width == box2.Width && box1.Height == box2.Height && box1.Depth == box2.Depth;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            return box1.Width != box2.Width || box1.Height != box2.Height || box1.Depth != box2.Depth;
        }

        public override string ToString()
        {
            return $"Box Dimensions - Width: {Width}, Height: {Height}, Depth: {Depth}";
        }

        /// <summary>
        /// Override the cast operation behaviour
        /// convert the box to an int
        /// </summary>
        public static explicit operator int(Box box)
        {
            return (int) (box.Width + box.Height + box.Depth) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
