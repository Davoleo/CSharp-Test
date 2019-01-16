using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.CAD.geometria
{
    class Line : Shape
    {
        private Point start, end;

        public Line(Point start, Point end, Color color) : base(color)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw(Graphics @where)
        {
            where.DrawLine(pen, start.X, start.Y, end.X, end.Y);
        }

        public override float GetPerimeter()
        {
            return (float) Math.Sqrt(
                (Math.Pow(Math.Abs(start.X - end.X), 2) + (Math.Pow(Math.Abs(start.Y - end.Y), 2))));
        }

        public override float GetArea()
        {
            return 0;
        }
    }
}
