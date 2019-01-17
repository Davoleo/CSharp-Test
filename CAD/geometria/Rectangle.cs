using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.CAD.geometria
{
	class Rectangle : Shape
	{
		private Point upSx = null;
		private int b = 0, h = 0;

		public Rectangle(Color color, Point upSx, int b, int h) : base(color)
		{
			this.b = b;
			this.h = h;
			this.upSx = upSx;
		}

		public override float GetPerimeter()
		{
			return (b + h) * 2;
		}

		public override float GetArea()
		{
			return b * h;
		}

		public override void Draw(Graphics @where)
		{
			where.DrawRectangle(pen, upSx.X, upSx.Y, b, h);
		}
	}
}
