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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int mostRecentYear = currentYear - 12;
            int leastRecentYear = currentYear - 82;

            for (int aa = mostRecentYear; aa >= leastRecentYear; aa--)
            {
                CBbirthDate.Items.Add(aa);
            }

            CBbirthDate.SelectedIndex = 0;
            //L'indice -1 sta per elemento nullo
            CBbirthDate.SelectedIndex = -1;

            UDrow.Minimum = 0;
            UDrow.Maximum = CBbirthDate.Items.Count - 1;

        }

        private void BToString_Click(object sender, EventArgs e)
        {
            txbRow.Text = CBbirthDate.Text;
        }

        private void BtnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CBbirthDate.SelectedIndex.ToString());
        }

        private void BtnSelectedText_Click(object sender, EventArgs e)
        {
            if (CBbirthDate.SelectedIndex != -1)
                txbRow.Text = CBbirthDate.Items[CBbirthDate.SelectedIndex].ToString();
            else
                MessageBox.Show("Selected Text is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CBbirthDate.Items.Clear();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            CBbirthDate.Items.RemoveAt((int) UDrow.Value);
            UDrow.Maximum--;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            txbRow.Text = CBbirthDate.Items[(int)UDrow.Value].ToString();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            CBbirthDate.Items.Insert((int)UDrow.Value + 1, txbRow.Text);
            UDrow.Maximum++;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CBbirthDate.Items.Add(txbRow.Text);
            UDrow.Maximum++;

            /*decimal oldValue = UDrow.Value;
            UDrow.Value = UDrow.Maximum;
            BtnIndex_Click(sender, e);
            UDrow.Value = oldValue;*/
       
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int value = -1;
            if (Int32.TryParse(txbRow.Text, out value))
                CBbirthDate.Items.Remove(Convert.ToInt32(txbRow.Text));
        }

        private void BtnExtra_Click(object sender, EventArgs e)
        {
            //Per evitare l'aggiornamento a video ad ogni istruzione
            //Per evitare flickering a video su computer poco performanti
            //PauseUpdates
            CBbirthDate.BeginUpdate();
            //...
            //Istruzioni pesanti
            //...
            //ResumeUpdates
            CBbirthDate.EndUpdate();

            CBbirthDate.Items.Clear();
            string[] weekDays = {"Lunedi", "Martedi", "Mercoledi", "Giovedi", "Venerdi", "Sabato", "Domenica"};
            CBbirthDate.Items.AddRange(weekDays);

            richTextBox1.LoadFile("suggestion_list.txt", RichTextBoxStreamType.PlainText);
            CBbirthDate.Items.AddRange(richTextBox1.Lines);
                
        }

        private void BtnExtra2_Click(object sender, EventArgs e)
        {
            CBbirthDate.Items.Clear();
            Random r = new Random();

            for (int i = 0; i < 20; i++)
                CBbirthDate.Items.Add(new Point(r.Next(1000), r.Next(1000)));

            Point toFind = new Point(2000, 2000);
            CBbirthDate.Items.Add(toFind);


        }

        private void CBcities_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Intex: " + CBcities.SelectedIndex);
        }
    }
}
