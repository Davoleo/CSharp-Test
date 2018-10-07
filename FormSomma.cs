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


            //num1 = Convert.ToInt32(txbNum1.Text);
            //num2 = Convert.ToInt32(txbNum2.Text);

            //TryParse lavora su una copia del valore di txbNum1        
            //out: evita il passaggio per copia consegna direttamente la variabile (modifica diretta dei parametri)

            //Struttura if() else(if() else() (A cascata) 
            //Struttura if( if ( if else()) else()) else()   (Annidata)

            if (!int.TryParse(txbNum1.Text, out num1))
            {
                MessageBox.Show("Warning: il primo numero inserito non è un numero!", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNum1.Clear();
                txbNum1.Focus();
                txbNum1.BackColor = Color.Red;
            }
            else { 
                if (!int.TryParse(txbNum2.Text, out num2))
                {
                    MessageBox.Show("Warning: Il secondo numero inserito non è un numero!", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNum2.Clear();
                    txbNum2.Focus();
                    txbNum2.BackColor = Color.Red;
                }
            else { 
                if(num1 < 0 || num2 < 0)
                {
                    MessageBox.Show("Warning: Uno o due dei numeri inseriti è molto pessimistico!", "Avvertenza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbNum1.Text = txbNum2.Text = "";
                    txbNum1.Focus();
                }
                else
                    {
                        txbNum1.BackColor = txbNum2.BackColor = TextBox.DefaultBackColor;
                        int num3 = num1 + num2;
                        txbResult.Text = Convert.ToString(num3);
                    }

                    }
            }

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
    }
}
