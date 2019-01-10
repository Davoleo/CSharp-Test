using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Test.punto;
using Point = CSharp_Test.punto.Point;

namespace CSharp_Test.CAD
{
    public partial class MainCAD : Form
    {
        public MainCAD()
        {
            InitializeComponent();
        }

        private Color chosenColor = Color.Black;

        private void btnDrawPoint_Click(object sender, EventArgs e)
        {
            Point p = new Point((e as MouseEventArgs).X, (e as MouseEventArgs).Y, Color.Aqua);
            p.Draw(CreateGraphics());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Point.PointsCount();
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
    }
}
