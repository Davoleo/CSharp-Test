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
            this.btnStrumenti = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.listFestivities = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDateTimePicker = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.buttonFast.Location = new System.Drawing.Point(12, 199);
            this.buttonFast.Name = "buttonFast";
            this.buttonFast.Size = new System.Drawing.Size(75, 23);
            this.buttonFast.TabIndex = 3;
            this.buttonFast.Text = "Io fuggo";
            this.buttonFast.UseVisualStyleBackColor = true;
            this.buttonFast.MouseHover += new System.EventHandler(this.buttonFast_MouseHover);
            // 
            // btnStrumenti
            // 
            this.btnStrumenti.Location = new System.Drawing.Point(12, 41);
            this.btnStrumenti.Name = "btnStrumenti";
            this.btnStrumenti.Size = new System.Drawing.Size(75, 23);
            this.btnStrumenti.TabIndex = 4;
            this.btnStrumenti.Text = "Strumenti";
            this.btnStrumenti.UseVisualStyleBackColor = true;
            this.btnStrumenti.Click += new System.EventHandler(this.btnStrumenti_Click);
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(265, 199);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(100, 23);
            this.buttonDate.TabIndex = 5;
            this.buttonDate.Text = "Oggetto Date";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // listFestivities
            // 
            this.listFestivities.FormattingEnabled = true;
            this.listFestivities.Location = new System.Drawing.Point(265, 112);
            this.listFestivities.Name = "listFestivities";
            this.listFestivities.Size = new System.Drawing.Size(100, 82);
            this.listFestivities.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ComboBox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnDateTimePicker
            // 
            this.btnDateTimePicker.Location = new System.Drawing.Point(93, 70);
            this.btnDateTimePicker.Name = "btnDateTimePicker";
            this.btnDateTimePicker.Size = new System.Drawing.Size(99, 23);
            this.btnDateTimePicker.TabIndex = 8;
            this.btnDateTimePicker.Text = "DateTimePicker";
            this.btnDateTimePicker.UseVisualStyleBackColor = true;
            this.btnDateTimePicker.Click += new System.EventHandler(this.btnDateTimePicker_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "CAD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 10;
            this.button4.Text = "DBTest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 234);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDateTimePicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listFestivities);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.btnStrumenti);
            this.Controls.Add(this.buttonFast);
            this.Controls.Add(this.txbProva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSomma);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSomma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbProva;
        private System.Windows.Forms.Button buttonFast;
        private System.Windows.Forms.Button btnStrumenti;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.ListBox listFestivities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

