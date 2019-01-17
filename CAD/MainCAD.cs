using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Test.CAD.geometria;
using Point = CSharp_Test.CAD.geometria.Point;
using Rectangle = CSharp_Test.CAD.geometria.Rectangle;

namespace CSharp_Test.CAD
{
    public partial class MainCAD : Form
    {
        public MainCAD()
        {
            InitializeComponent();
        }

        public enum Shapes {Point, Line, Rectangle, Square, Ellipsis}

        private Shapes chosenShape = Shapes.Point;
        private Color chosenColor = Color.Black;

        //Beginning and End point coordinates to draw shapes on the form 
        private int xStart = -1, yStart = -1, xEnd = -1, yEnd = -1;

        private void btnDrawPoint_Click(object sender, EventArgs e)
        {
            Point p = new Point((e as MouseEventArgs).X, (e as MouseEventArgs).Y, Color.Aqua);
            p.Draw(CreateGraphics());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Point.PointsCount();
        }

        private void MainCAD_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && chosenShape != Shapes.Point)
            {
                xStart = e.X;
                yStart = e.Y;
                xEnd = -1;
                yEnd = -1;
            }
        }

        private void MainCAD_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && chosenShape != Shapes.Point)
            {
                xEnd = e.X;
                yEnd = e.Y;
                int deltaX = xEnd - xStart;
                int deltaY = yEnd - yStart;

                switch (chosenShape)
                {
                    case Shapes.Line:
                        Point start = new Point(xStart, yStart);
                        Point end = new Point(xEnd, yEnd);
                        Line line = new Line(start, end, chosenColor);
                        line.Draw(CreateGraphics());
                        break;

                    case Shapes.Rectangle:
							  start = new Point(xStart, yStart);
							  Rectangle rectangle = new Rectangle(chosenColor, start, deltaX, deltaY);
							  rectangle.Draw(CreateGraphics());
                        break;

                    case Shapes.Square:
                        break;

                    case Shapes.Ellipsis:
                        break;
                }
            }
        }

        private void MainCAD_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y, chosenColor);
                p.Draw(CreateGraphics());
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (colorSelection.ShowDialog() == DialogResult.OK)
                    chosenColor = colorSelection.Color;
            }
        }

        private void btnFillPoints_Click(object sender, EventArgs e)
        {
            Point p;
            Random r = new Random();

            for (int i = 0; i < 10000; i++)
            {
                p = new Point((int)Math.Ceiling(r.NextDouble() * Width), (int)Math.Ceiling(r.NextDouble() * Width), Color.Chartreuse);
                p.Draw(CreateGraphics());
            }
        }

        private void ShapeChoice_Click(object sender, EventArgs e)
        {
            foreach (ToolStripButton button in toolStrip1.Items)
                    button.Checked = false;

            (sender as ToolStripButton).Checked = true;

            switch ((sender as ToolStripButton).Text)
            {
                case "POINTS":
                    chosenShape = Shapes.Point;
                    break;

                case "LINES":
                    chosenShape = Shapes.Line;
                    break;

                case "RECTANGLES":
                    chosenShape = Shapes.Rectangle;
                    break;

                case "SQUARES":
                    chosenShape = Shapes.Square;
                    break;

                case "ELLIPSIS":
                    chosenShape = Shapes.Ellipsis;
                    break;
                    
                default:
                    chosenShape = Shapes.Point;
                    break;
            }

        }
    }
}
