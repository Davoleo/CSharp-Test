﻿namespace CSharp_Test.SQL
{
    partial class SQLMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReleaseYear = new System.Windows.Forms.DateTimePicker();
            this.txbOS = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.comboPlaces = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD TO DATABASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OS Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average License Price";
            // 
            // dtpReleaseYear
            // 
            this.dtpReleaseYear.Location = new System.Drawing.Point(150, 52);
            this.dtpReleaseYear.Name = "dtpReleaseYear";
            this.dtpReleaseYear.Size = new System.Drawing.Size(135, 20);
            this.dtpReleaseYear.TabIndex = 4;
            // 
            // txbOS
            // 
            this.txbOS.Location = new System.Drawing.Point(150, 12);
            this.txbOS.Name = "txbOS";
            this.txbOS.Size = new System.Drawing.Size(135, 20);
            this.txbOS.TabIndex = 5;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(150, 92);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(135, 20);
            this.txbPrice.TabIndex = 8;
            // 
            // comboPlaces
            // 
            this.comboPlaces.FormattingEnabled = true;
            this.comboPlaces.Location = new System.Drawing.Point(150, 135);
            this.comboPlaces.Name = "comboPlaces";
            this.comboPlaces.Size = new System.Drawing.Size(135, 21);
            this.comboPlaces.TabIndex = 9;
            this.comboPlaces.SelectedIndexChanged += new System.EventHandler(this.comboPlaces_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Next Convention Place";
            // 
            // SQLMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 214);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPlaces);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.txbOS);
            this.Controls.Add(this.dtpReleaseYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "SQLMain";
            this.Text = "SQLMain";
            this.Load += new System.EventHandler(this.SQLMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReleaseYear;
        private System.Windows.Forms.TextBox txbOS;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.ComboBox comboPlaces;
        private System.Windows.Forms.Label label4;
    }
}