using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSharp_Test
{
    //partial class, metà controllata da noi metà dall'IDE (FormSomma.Designer.cs)
    public partial class FormSomma : Form
    {
        public FormSomma()
        {
            InitializeComponent();
            txbResult.Text = "Risultato";
        }

        private void sommaBtn_Click(object sender, EventArgs e)
        {
            //variabili
            int num1 = 0;
            int num2 = 0;

            if (txbNum1.Text == "" || txbNum2.Text == "")
                MessageBox.Show("Ehi! pensi davvero di lasciare una delle due caselle vuote???", Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                num1 = Convert.ToInt32(txbNum1.Text);
                num2 = Convert.ToInt32(txbNum2.Text);
            }

            //TryParse lavora su una copia del valore di txbNum1        
            //out: evita il passaggio per copia consegna direttamente la variabile (modifica diretta dei parametri)

            //Struttura if() else(if() else() (A cascata) 
            //Struttura if( if ( if else()) else()) else()   (Annidata)


            txbNum1.BackColor = txbNum2.BackColor = TextBox.DefaultBackColor;
            int num3 = num1 + num2;
            txbResult.Text = Convert.ToString(num3);

        }


        private void FormSomma_Load(object sender, EventArgs e)
        { 

            Random random = new Random();
            BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            txbNum1.AutoCompleteCustomSource.Clear();

            StreamReader reader = new StreamReader(@"suggestion_list.txt");
            String row = "";

            while (!reader.EndOfStream)
            {
                row = reader.ReadLine();
                txbNum1.AutoCompleteCustomSource.Add(row);
            }

            reader.Close();

            /*for (int i = 0; i < 500; i += 5)
                txbNum1.AutoCompleteCustomSource.Add(i.ToString().PadLeft(3, '0'));*/
        }

        private void txbNum1_MouseEnter(object sender, EventArgs e)
        {
            txbNum1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void txbNum1_MouseLeave(object sender, EventArgs e)
        {
            txbNum1.BorderStyle = BorderStyle.Fixed3D;
        }


        //Validations
        private void txbNum1_Validating(object sender, CancelEventArgs e)
        {
            int num1 = 0;

            if (!int.TryParse(txbNum1.Text, out num1))
            {
                MessageBox.Show("Warning: il primo numero inserito non è un numero!", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNum1.Clear();
                txbNum1.Focus();
                txbNum1.BackColor = Color.Red;
            }

            if (num1 < 0)
            {
                MessageBox.Show("Warning: Uno o due dei numeri inseriti è molto pessimistico!", "Avvertenza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbNum1.BackColor = Color.Yellow;
                txbNum1.Focus();
            }
        }

        private void txbNum2_Validating(object sender, CancelEventArgs e)
        {

            int num2 = 0;

            if (!int.TryParse(txbNum2.Text, out num2))
            {
                MessageBox.Show("Warning: Il secondo numero inserito non è un numero!", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNum2.Clear();
                txbNum2.Focus();
                txbNum2.BackColor = Color.Red;
            }
            else
            {
                if (num2 < 0)
                {
                    MessageBox.Show("Warning: Il secondo numero inserito è molto pessimistico!", "Avvertenza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbNum2.BackColor = Color.Yellow;
                    txbNum2.Focus();
                }
            }
        }
    }
}

   
