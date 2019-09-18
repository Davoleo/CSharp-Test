using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Test.CAD;

namespace CSharp_Test
{
    public partial class Main : Form
    {
        Date data = new Date();
        public static MainCAD cad = new MainCAD();

		public Main()
        {
            InitializeComponent();
            cad.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormSomma somma = new FormSomma();
            somma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txbProva.CharacterCasing = CharacterCasing.Upper;

            txbProva.Cursor = Cursors.NoMove2D;

            MessageBox.Show(txbProva.Font.Bold.ToString());

            txbProva.Font = new Font("Comics", 8, FontStyle.Bold);

            MessageBox.Show(txbProva.Lines[0]);
        }

        private void buttonFast_MouseHover(object sender, EventArgs e)
        {
            Random n = new Random();
            Main main = new Main();

            buttonFast.Location = new Point(n.Next(main.Width), n.Next(main.Height));
        }

        private void btnStrumenti_Click(object sender, EventArgs e)
        {
            Checkbox tools = new Checkbox();
            tools.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date date = new Date(30, 11, 2018);

            MessageBox.Show(date++.ToString());

            MessageBox.Show((date += 50).ToString());

            MessageBox.Show((date += 400).ToString());

            Date d1 = new Date(7, 1, 2020);
            Date d2 = new Date(1, 1, 2020);

            if (d1 > d2)
                MessageBox.Show("d1 è maggiore di d2");
            else
                MessageBox.Show("d1 non è maggiore di d2");

            MessageBox.Show(date.GetMonthName());

            foreach (Date d in Date.GetFestivityList())
                listFestivities.Items.Add(d);

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ComboBox comboBoxForm = new ComboBox();
            comboBoxForm.ShowDialog();
        }

        private void btnDateTimePicker_Click(object sender, EventArgs e)
        {
            DTPicker dtPicker = new DTPicker();
            dtPicker.ShowDialog();
        }
    }
}
