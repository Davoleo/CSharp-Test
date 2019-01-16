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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPoints = new System.Windows.Forms.ToolStripButton();
            this.btnLines = new System.Windows.Forms.ToolStripButton();
            this.btnRectangles = new System.Windows.Forms.ToolStripButton();
            this.btnSquares = new System.Windows.Forms.ToolStripButton();
            this.btnEllipsis = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFillPoints
            // 
            this.btnFillPoints.Location = new System.Drawing.Point(12, 336);
            this.btnFillPoints.Name = "btnFillPoints";
            this.btnFillPoints.Size = new System.Drawing.Size(75, 23);
            this.btnFillPoints.TabIndex = 1;
            this.btnFillPoints.Text = "Fill w/ Points";
            this.btnFillPoints.UseVisualStyleBackColor = true;
            this.btnFillPoints.Click += new System.EventHandler(this.btnFillPoints_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(93, 336);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Points Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPoints,
            this.btnLines,
            this.btnRectangles,
            this.btnSquares,
            this.btnEllipsis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPoints
            // 
            this.btnPoints.Checked = true;
            this.btnPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPoints.Image = ((System.Drawing.Image)(resources.GetObject("btnPoints.Image")));
            this.btnPoints.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(36, 36);
            this.btnPoints.Text = "POINTS";
            this.btnPoints.Click += new System.EventHandler(this.ShapeChoice_Click);
            // 
            // btnLines
            // 
            this.btnLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLines.Image = ((System.Drawing.Image)(resources.GetObject("btnLines.Image")));
            this.btnLines.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(36, 36);
            this.btnLines.Text = "LINES";
            this.btnLines.Click += new System.EventHandler(this.ShapeChoice_Click);
            // 
            // btnRectangles
            // 
            this.btnRectangles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRectangles.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangles.Image")));
            this.btnRectangles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRectangles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRectangles.Name = "btnRectangles";
            this.btnRectangles.Size = new System.Drawing.Size(36, 36);
            this.btnRectangles.Text = "RECTANGLES";
            this.btnRectangles.Click += new System.EventHandler(this.ShapeChoice_Click);
            // 
            // btnSquares
            // 
            this.btnSquares.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSquares.Image = ((System.Drawing.Image)(resources.GetObject("btnSquares.Image")));
            this.btnSquares.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSquares.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSquares.Name = "btnSquares";
            this.btnSquares.Size = new System.Drawing.Size(36, 36);
            this.btnSquares.Text = "SQUARES";
            this.btnSquares.Click += new System.EventHandler(this.ShapeChoice_Click);
            // 
            // btnEllipsis
            // 
            this.btnEllipsis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEllipsis.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipsis.Image")));
            this.btnEllipsis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEllipsis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEllipsis.Name = "btnEllipsis";
            this.btnEllipsis.Size = new System.Drawing.Size(36, 36);
            this.btnEllipsis.Text = "ELLIPSIS";
            this.btnEllipsis.Click += new System.EventHandler(this.ShapeChoice_Click);
            // 
            // MainCAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 371);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnFillPoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCAD";
            this.Text = "Click on the form to draw!";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseClick);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFillPoints;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ColorDialog colorSelection;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPoints;
        private System.Windows.Forms.ToolStripButton btnLines;
        private System.Windows.Forms.ToolStripButton btnRectangles;
        private System.Windows.Forms.ToolStripButton btnSquares;
        private System.Windows.Forms.ToolStripButton btnEllipsis;
    }
}