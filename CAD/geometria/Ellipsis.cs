using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.CAD.geometria
{
	class Ellipsis : Shape
	{

		private Point centre = null, upSx = null;
		protected int b = 0, h = 0;

		public Ellipsis(Color color, Point upSx, int b, int h) : base(color)
		{
			this.b = b;
			this.h = h;
			this.upSx = upSx;
			centre = new Point(upSx.X + b/2, upSx.Y + h/2, color);
		}

		public override float GetArea()
		{
			return (float)Math.PI * b / 2 * h / 2;
		}

		public override float GetPerimeter()
		{
			return (float)(2 * Math.PI * (Math.Sqrt((Math.Pow(b / 2, 2) + Math.Pow(h / 2, 2)) / 2)));
		}

		public override void Draw(Graphics @where)
		{
			where.DrawEllipse(pen, upSx.X, upSx.Y, b, h);
		}
	}
}
