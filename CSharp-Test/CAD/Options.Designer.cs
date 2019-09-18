namespace CSharp_Test.CAD
{
	partial class Options
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
			this.btnClose = new System.Windows.Forms.Button();
			this.checkPoints = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkEllipsis = new System.Windows.Forms.CheckBox();
			this.checkSquares = new System.Windows.Forms.CheckBox();
			this.checkRectangles = new System.Windows.Forms.CheckBox();
			this.checkLines = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioFilled = new System.Windows.Forms.RadioButton();
			this.radioHollow = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.comboShapes = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(526, 187);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// checkPoints
			// 
			this.checkPoints.AutoSize = true;
			this.checkPoints.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
			this.checkPoints.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.checkPoints.Location = new System.Drawing.Point(6, 24);
			this.checkPoints.Name = "checkPoints";
			this.checkPoints.Size = new System.Drawing.Size(55, 17);
			this.checkPoints.TabIndex = 1;
			this.checkPoints.Text = "Points";
			this.checkPoints.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox1.Controls.Add(this.checkEllipsis);
			this.groupBox1.Controls.Add(this.checkPoints);
			this.groupBox1.Controls.Add(this.checkLines);
			this.groupBox1.Controls.Add(this.checkSquares);
			this.groupBox1.Controls.Add(this.checkRectangles);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(133, 198);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enabled Shapes";
			// 
			// checkEllipsis
			// 
			this.checkEllipsis.AutoSize = true;
			this.checkEllipsis.Location = new System.Drawing.Point(6, 116);
			this.checkEllipsis.Name = "checkEllipsis";
			this.checkEllipsis.Size = new System.Drawing.Size(57, 17);
			this.checkEllipsis.TabIndex = 6;
			this.checkEllipsis.Text = "Ellipsis";
			this.checkEllipsis.UseVisualStyleBackColor = true;
			// 
			// checkSquares
			// 
			this.checkSquares.AutoSize = true;
			this.checkSquares.Location = new System.Drawing.Point(6, 93);
			this.checkSquares.Name = "checkSquares";
			this.checkSquares.Size = new System.Drawing.Size(65, 17);
			this.checkSquares.TabIndex = 4;
			this.checkSquares.Text = "Squares";
			this.checkSquares.UseVisualStyleBackColor = true;
			// 
			// checkRectangles
			// 
			this.checkRectangles.AutoSize = true;
			this.checkRectangles.Location = new System.Drawing.Point(6, 70);
			this.checkRectangles.Name = "checkRectangles";
			this.checkRectangles.Size = new System.Drawing.Size(80, 17);
			this.checkRectangles.TabIndex = 3;
			this.checkRectangles.Text = "Rectangles";
			this.checkRectangles.UseVisualStyleBackColor = true;
			// 
			// checkLines
			// 
			this.checkLines.AutoSize = true;
			this.checkLines.Location = new System.Drawing.Point(6, 47);
			this.checkLines.Name = "checkLines";
			this.checkLines.Size = new System.Drawing.Size(51, 17);
			this.checkLines.TabIndex = 2;
			this.checkLines.Text = "Lines";
			this.checkLines.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox2.Controls.Add(this.radioFilled);
			this.groupBox2.Controls.Add(this.radioHollow);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(151, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(134, 198);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Shapes Mode";
			// 
			// radioFilled
			// 
			this.radioFilled.AutoSize = true;
			this.radioFilled.Location = new System.Drawing.Point(6, 45);
			this.radioFilled.Name = "radioFilled";
			this.radioFilled.Size = new System.Drawing.Size(49, 17);
			this.radioFilled.TabIndex = 9;
			this.radioFilled.TabStop = true;
			this.radioFilled.Text = "Filled";
			this.radioFilled.UseVisualStyleBackColor = true;
			// 
			// radioHollow
			// 
			this.radioHollow.AutoSize = true;
			this.radioHollow.Location = new System.Drawing.Point(6, 22);
			this.radioHollow.Name = "radioHollow";
			this.radioHollow.Size = new System.Drawing.Size(57, 17);
			this.radioHollow.TabIndex = 8;
			this.radioHollow.TabStop = true;
			this.radioHollow.Text = "Hollow";
			this.radioHollow.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox3.Controls.Add(this.comboShapes);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(291, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(124, 62);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Default Shape";
			// 
			// comboShapes
			// 
			this.comboShapes.BackColor = System.Drawing.SystemColors.Info;
			this.comboShapes.FormattingEnabled = true;
			this.comboShapes.Location = new System.Drawing.Point(6, 24);
			this.comboShapes.Name = "comboShapes";
			this.comboShapes.Size = new System.Drawing.Size(112, 21);
			this.comboShapes.TabIndex = 0;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(613, 222);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Options";
			this.ShowIcon = false;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.CheckBox checkPoints;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkEllipsis;
		private System.Windows.Forms.CheckBox checkSquares;
		private System.Windows.Forms.CheckBox checkRectangles;
		private System.Windows.Forms.CheckBox checkLines;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioFilled;
		private System.Windows.Forms.RadioButton radioHollow;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox comboShapes;
	}
}