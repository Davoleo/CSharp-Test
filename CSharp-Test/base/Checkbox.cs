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
    public partial class Checkbox : Form
    {
        Random r = new Random();
        string[] formati = { "txt", "docx", "ppt", "pptx", "jpg", "svg", "png", "gif", "pdf", "wav", "java", "ogg", "py" };

        public Checkbox()
        {
            InitializeComponent();

            DateTime oggi = DateTime.Now;

            for(int giorni = 0; giorni<15; giorni++)
            {
                checkListFormats.Items.Add(oggi);
                oggi = oggi.AddDays(1);
            }

            /*foreach (string formato in formati)
                checkListFormats.Items.Add(formato);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBold.Checked = true;
        }

        private void checkBold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBold.Checked)
                lblExample.Font = new Font(lblExample.Font, FontStyle.Bold);
            else
                lblExample.Font = new Font(lblExample.Font, FontStyle.Regular);

        }

        private void Strumenti_Load(object sender, EventArgs e)
        {
            string[] elencoImmagini = Directory.GetFiles(Environment.CurrentDirectory + "../../../Resources");

            for (int immagine = 0; immagine < elencoImmagini.Count(); immagine++)
                imageListPicks.Images.Add(Image.FromFile(elencoImmagini[immagine]));


            checkRandomImage.ImageIndex = r.Next(imageListPicks.Images.Count);
        }
    }
}
