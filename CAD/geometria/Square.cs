using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.CAD.geometria
{
	class Square : Rectangle
	{

		public Square(Color color, Point upSx, int l) : base(color, upSx, l, l)
		{

		}

		public override float GetPerimeter()
		{
			return 4 * b;
		}

		public override float GetArea()
		{
			return (float)Math.Pow(b, 2);
		}
	}
}
