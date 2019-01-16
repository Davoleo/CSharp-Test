using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Test.CAD.geometria;

namespace CSharp_Test.punto
{
    class Point : Shape
    {
        private int x = 0, y = 0;
        private static int count = 0;

        public Point() : this(0, 0, Color.Black) {}

        public Point(int x, int y) : this(x, y, Color.Black) {}
        
        public Point(int x, int y, Color color) : base(color)
        {
            this.x = x;
            this.y = y;
            ++count;
        }

        public override void Draw(Graphics where)
        {
            where.DrawRectangle(pen, x, y, 1, 1);
        }

        public override float GetPerimeter()
        {
            return 0;
        }
        public override float GetArea()
        {
            return 0;
        }

        public static void PointsCount()
        {
            MessageBox.Show("The count of the points that have been created is: " + count.ToString(), "CAD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Color Color { get; set; } = Color.Black;

        public override string ToString()
        {
            return "X: " + x + " - " + "Y: " + y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Point p = (Point)obj;

            return x == p.x && y == p.y;
        }
    }
}
