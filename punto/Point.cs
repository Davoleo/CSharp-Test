using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.punto
{
    class Point
    {
        private int x = 0, y = 0;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

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
