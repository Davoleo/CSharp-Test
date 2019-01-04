namespace CSharp_Test
{
    partial class ComboBox
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
            this.CBbirthDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BToString = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.txbRow = new System.Windows.Forms.TextBox();
            this.BtnSelectedText = new System.Windows.Forms.Button();
            this.UDrow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExtra = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnExtra2 = new System.Windows.Forms.Button();
            this.CBcities = new System.Windows.Forms.ComboBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UDrow)).BeginInit();
            this.SuspendLayout();
            // 
            // CBbirthDate
            // 
            this.CBbirthDate.FormattingEnabled = true;
            this.CBbirthDate.Location = new System.Drawing.Point(15, 27);
            this.CBbirthDate.Name = "CBbirthDate";
            this.CBbirthDate.Size = new System.Drawing.Size(64, 21);
            this.CBbirthDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birth Date";
            // 
            // BToString
            // 
            this.BToString.Location = new System.Drawing.Point(221, 38);
            this.BToString.Name = "BToString";
            this.BToString.Size = new System.Drawing.Size(75, 23);
            this.BToString.TabIndex = 2;
            this.BToString.Text = "Date String";
            this.BToString.UseVisualStyleBackColor = true;
            this.BToString.Click += new System.EventHandler(this.BToString_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(12, 112);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(84, 23);
            this.BtnExport.TabIndex = 4;
            this.BtnExport.Text = "Export Row....";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(221, 67);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(75, 23);
            this.BtnIndex.TabIndex = 5;
            this.BtnIndex.Text = "Date Index";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(12, 141);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(84, 23);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Delete Row...";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txbRow
            // 
            this.txbRow.Location = new System.Drawing.Point(221, 12);
            this.txbRow.Name = "txbRow";
            this.txbRow.Size = new System.Drawing.Size(75, 20);
            this.txbRow.TabIndex = 7;
            // 
            // BtnSelectedText
            // 
            this.BtnSelectedText.Location = new System.Drawing.Point(221, 96);
            this.BtnSelectedText.Name = "BtnSelectedText";
            this.BtnSelectedText.Size = new System.Drawing.Size(75, 37);
            this.BtnSelectedText.TabIndex = 8;
            this.BtnSelectedText.Text = "Selected Text";
            this.BtnSelectedText.UseVisualStyleBackColor = true;
            this.BtnSelectedText.Click += new System.EventHandler(this.BtnSelectedText_Click);
            // 
            // UDrow
            // 
            this.UDrow.Location = new System.Drawing.Point(85, 28);
            this.UDrow.Name = "UDrow";
            this.UDrow.Size = new System.Drawing.Size(36, 20);
            this.UDrow.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Index";
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(12, 170);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(84, 23);
            this.BtnInsert.TabIndex = 11;
            this.BtnInsert.Text = "Insert After...";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 199);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(84, 23);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 228);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExtra
            // 
            this.BtnExtra.Location = new System.Drawing.Point(12, 347);
            this.BtnExtra.Name = "BtnExtra";
            this.BtnExtra.Size = new System.Drawing.Size(80, 39);
            this.BtnExtra.TabIndex = 14;
            this.BtnExtra.Text = "EXTRA";
            this.BtnExtra.UseVisualStyleBackColor = true;
            this.BtnExtra.Click += new System.EventHandler(this.BtnExtra_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(296, 386);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 11);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // BtnExtra2
            // 
            this.BtnExtra2.Location = new System.Drawing.Point(98, 347);
            this.BtnExtra2.Name = "BtnExtra2";
            this.BtnExtra2.Size = new System.Drawing.Size(80, 39);
            this.BtnExtra2.TabIndex = 16;
            this.BtnExtra2.Text = "EXTRA 2";
            this.BtnExtra2.UseVisualStyleBackColor = true;
            this.BtnExtra2.Click += new System.EventHandler(this.BtnExtra2_Click);
            // 
            // CBcities
            // 
            this.CBcities.FormattingEnabled = true;
            this.CBcities.Items.AddRange(new object[] {
            "Milano",
            "Torino",
            "Bologna",
            "Roma",
            "Ravenna",
            "Cremona",
            "Bergamo"});
            this.CBcities.Location = new System.Drawing.Point(221, 170);
            this.CBcities.Name = "CBcities";
            this.CBcities.Size = new System.Drawing.Size(74, 21);
            this.CBcities.TabIndex = 17;
            this.CBcities.SelectedIndexChanged += new System.EventHandler(this.CBcities_SelectedIndexChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 83);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(84, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Delete All";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddCity
            // 
            this.BtnAddCity.Location = new System.Drawing.Point(221, 197);
            this.BtnAddCity.Name = "BtnAddCity";
            this.BtnAddCity.Size = new System.Drawing.Size(74, 23);
            this.BtnAddCity.TabIndex = 18;
            this.BtnAddCity.Text = "ADD";
            this.BtnAddCity.UseVisualStyleBackColor = true;
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 398);
            this.Controls.Add(this.BtnAddCity);
            this.Controls.Add(this.CBcities);
            this.Controls.Add(this.BtnExtra2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnExtra);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UDrow);
            this.Controls.Add(this.BtnSelectedText);
            this.Controls.Add(this.txbRow);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BToString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBbirthDate);
            this.Name = "ComboBox";
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.ComboBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UDrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBbirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BToString;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnIndex;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.TextBox txbRow;
        private System.Windows.Forms.Button BtnSelectedText;
        private System.Windows.Forms.NumericUpDown UDrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExtra;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnExtra2;
        private System.Windows.Forms.ComboBox CBcities;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAddCity;
    }
}