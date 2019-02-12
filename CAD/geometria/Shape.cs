using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test.CAD.geometria
{
    abstract class Shape
    {
        protected Graphics location = null;
        protected Color color;
        protected bool solid = false;
        protected Pen pen = null;

        public Shape(Color color)
        {
            this.color = color;

            pen = new Pen(color);
        }

        public Color Color
        {
	        get { return color; }
	        set
	        {
		        color = value;
		        pen = new Pen(color);
	        }
        }

        public abstract void Draw(Graphics where);

        public abstract float GetArea();

        public abstract float GetPerimeter();

        public virtual void Save(StreamWriter f)
        {
	        f.WriteLine(this.GetType().ToString());
	        f.WriteLine(color.ToArgb());
			}

    }
}
