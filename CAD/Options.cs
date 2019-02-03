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
			if (comboShapes.Items.Count == 0)
			{
				foreach (ToolStripButton b in (Application.OpenForms[0] as MainCAD).toolStrip1.Items)
				{
					comboShapes.Items.Add(b);

					checkBoxes.Add(new Checkbox());
					(checkBoxes[checkBoxes.Count - 1] as Checkbox).Location = new Point(140, 16 + checkBoxes.Count * 20);
					(checkBoxes[checkBoxes.Count - 1] as Checkbox).Name = "check" + b.Text;
					(checkBoxes[checkBoxes.Count - 1] as Checkbox).Text = b.Text;
					(checkBoxes[checkBoxes.Count - 1] as Checkbox).Size = new Size(100, 17);
					Controls.Add(checkBoxes[checkBoxes.Count - 1] as Control);
				}
			}
		}
	}
}
