namespace CSharp_Test.CAD
{
    partial class MainCAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCAD));
            this.btnFillPoints = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.colorSelection = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnFillPoints
            // 
            this.btnFillPoints.Location = new System.Drawing.Point(12, 293);
            this.btnFillPoints.Name = "btnFillPoints";
            this.btnFillPoints.Size = new System.Drawing.Size(75, 23);
            this.btnFillPoints.TabIndex = 1;
            this.btnFillPoints.Text = "Fill w/ Points";
            this.btnFillPoints.UseVisualStyleBackColor = true;
            this.btnFillPoints.Click += new System.EventHandler(this.btnFillPoints_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(93, 293);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Points Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // MainCAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 328);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnFillPoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCAD";
            this.Text = "Click on the form to draw!";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFillPoints;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ColorDialog colorSelection;
    }
}