﻿using System;
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
    public partial class Main : Form
    {
        Date data = new Date();

        public Main()
        {
            InitializeComponent();
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
            MessageBox.Show(data.GetGiorno().ToString());

            data.mm = 11;
            MessageBox.Show(data.mm.ToString());
        }
    }
}
