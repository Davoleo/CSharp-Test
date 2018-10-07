namespace CSharp_Test
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSomma = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbProva = new System.Windows.Forms.TextBox();
            this.buttonFast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSomma
            // 
            this.buttonSomma.Location = new System.Drawing.Point(12, 12);
            this.buttonSomma.Name = "buttonSomma";
            this.buttonSomma.Size = new System.Drawing.Size(75, 23);
            this.buttonSomma.TabIndex = 0;
            this.buttonSomma.Text = "Somma";
            this.buttonSomma.UseVisualStyleBackColor = true;
            this.buttonSomma.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tests";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbProva
            // 
            this.txbProva.Location = new System.Drawing.Point(265, 12);
            this.txbProva.Multiline = true;
            this.txbProva.Name = "txbProva";
            this.txbProva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbProva.Size = new System.Drawing.Size(100, 94);
            this.txbProva.TabIndex = 2;
            this.txbProva.Text = "12345\r\n67890";
            // 
            // buttonFast
            // 
            this.buttonFast.Location = new System.Drawing.Point(12, 165);
            this.buttonFast.Name = "buttonFast";
            this.buttonFast.Size = new System.Drawing.Size(75, 23);
            this.buttonFast.TabIndex = 3;
            this.buttonFast.Text = "Io fuggo";
            this.buttonFast.UseVisualStyleBackColor = true;
            this.buttonFast.MouseHover += new System.EventHandler(this.buttonFast_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 200);
            this.Controls.Add(this.buttonFast);
            this.Controls.Add(this.txbProva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSomma);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSomma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbProva;
        private System.Windows.Forms.Button buttonFast;
    }
}

