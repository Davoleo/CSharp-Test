namespace CSharp_Test
{
    partial class FormSomma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.menuStripRisultato = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAggiungiMemoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRichiamaMemoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancellaMemoria = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.menuStripRisultato.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbResult
            // 
            this.txbResult.ContextMenuStrip = this.menuStripRisultato;
            this.txbResult.Location = new System.Drawing.Point(185, 12);
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(54, 20);
            this.txbResult.TabIndex = 10;
            // 
            // menuStripRisultato
            // 
            this.menuStripRisultato.BackgroundImage = global::CSharp_Test.Properties.Resources.fideduo05;
            this.menuStripRisultato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStripRisultato.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAggiungiMemoria,
            this.menuRichiamaMemoria,
            this.menuCancellaMemoria});
            this.menuStripRisultato.Name = "menuStripRisultato";
            this.menuStripRisultato.Size = new System.Drawing.Size(203, 70);
            // 
            // menuAggiungiMemoria
            // 
            this.menuAggiungiMemoria.Name = "menuAggiungiMemoria";
            this.menuAggiungiMemoria.Size = new System.Drawing.Size(202, 22);
            this.menuAggiungiMemoria.Text = "Aggiungi alla Memoria";
            // 
            // menuRichiamaMemoria
            // 
            this.menuRichiamaMemoria.Name = "menuRichiamaMemoria";
            this.menuRichiamaMemoria.Size = new System.Drawing.Size(202, 22);
            this.menuRichiamaMemoria.Text = "Richiama dalla Memoria";
            // 
            // menuCancellaMemoria
            // 
            this.menuCancellaMemoria.Name = "menuCancellaMemoria";
            this.menuCancellaMemoria.Size = new System.Drawing.Size(202, 22);
            this.menuCancellaMemoria.Text = "Cancella Memoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // txbNum1
            // 
            this.txbNum1.AutoCompleteCustomSource.AddRange(new string[] {
            "1005",
            "1010",
            "1015",
            "1020",
            "2000",
            "2005",
            "2010",
            "2015",
            "2020"});
            this.txbNum1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbNum1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbNum1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNum1.Location = new System.Drawing.Point(12, 12);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(51, 20);
            this.txbNum1.TabIndex = 8;
            this.txbNum1.MouseEnter += new System.EventHandler(this.txbNum1_MouseEnter);
            this.txbNum1.MouseLeave += new System.EventHandler(this.txbNum1_MouseLeave);
            this.txbNum1.Validating += new System.ComponentModel.CancelEventHandler(this.txbNum1_Validating);
            // 
            // txbNum2
            // 
            this.txbNum2.BackColor = System.Drawing.SystemColors.Window;
            this.txbNum2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNum2.Location = new System.Drawing.Point(104, 12);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(51, 20);
            this.txbNum2.TabIndex = 7;
            this.txbNum2.Validating += new System.ComponentModel.CancelEventHandler(this.txbNum2_Validating);
            // 
            // btnSomma
            // 
            this.btnSomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomma.ForeColor = System.Drawing.Color.Red;
            this.btnSomma.Location = new System.Drawing.Point(69, 6);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(29, 28);
            this.btnSomma.TabIndex = 6;
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.sommaBtn_Click);
            // 
            // FormSomma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 45);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNum1);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.btnSomma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSomma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Somma";
            this.Load += new System.EventHandler(this.FormSomma_Load);
            this.menuStripRisultato.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.ContextMenuStrip menuStripRisultato;
        private System.Windows.Forms.ToolStripMenuItem menuAggiungiMemoria;
        private System.Windows.Forms.ToolStripMenuItem menuRichiamaMemoria;
        private System.Windows.Forms.ToolStripMenuItem menuCancellaMemoria;
    }
}