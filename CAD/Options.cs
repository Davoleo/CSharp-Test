using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Test.CAD
{
	public partial class Options : Form
	{

		private ArrayList checkBoxes = new ArrayList();
		public Options()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void Options_Load(object sender, EventArgs e)
		{
			int i = 0;
			if (comboShapes.Items.Count == 0)
			{
				foreach (ToolStripButton b in (Application.OpenForms["MainCAD"] as MainCAD).toolStrip1.Items)
				{
					comboShapes.Items.Add(b);

					/*++i;
					Checkbox cb = new Checkbox();
					cb.Location = new Point(10, 16 + i * 20);
					cb.Name = "check" + b.Text;
					cb.Text = b.Text;
					cb.Size = new Size(30, 17);
					cb.TopLevel = false;
					groupBox1.Controls.Add(cb);*/
				}
			}
		}
	}
}
