using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Test
{
    public partial class DTPicker : Form
    {
        public DTPicker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dtPicker1.Value;
            MessageBox.Show(date.ToShortDateString());
            dtPicker1.Value = new DateTime(2014, 1, 1);
        }

        private void dtPicker1_SizeChanged(object sender, EventArgs e)
        {
            if (dtPicker1.Size.Width > 150)
                dtPicker1.CustomFormat = "dd-MM-yyyy / HH:mm";
            else
                dtPicker1.CustomFormat = "dd-MM";
        }
    }
}
