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
			this.colorSelection = new System.Windows.Forms.ColorDialog();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnPoints = new System.Windows.Forms.ToolStripButton();
			this.btnLines = new System.Windows.Forms.ToolStripButton();
			this.btnRectangles = new System.Windows.Forms.ToolStripButton();
			this.btnSquares = new System.Windows.Forms.ToolStripButton();
			this.btnEllipsis = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.continuousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dashedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fillWPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointsCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.totalAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.applyOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPoints,
            this.btnLines,
            this.btnRectangles,
            this.btnSquares,
            this.btnEllipsis});
			this.toolStrip1.Location = new System.Drawing.Point(0, 3);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(37, 206);
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
			this.btnPoints.Size = new System.Drawing.Size(35, 36);
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
			this.btnLines.Size = new System.Drawing.Size(35, 36);
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
			this.btnRectangles.Size = new System.Drawing.Size(35, 36);
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
			this.btnSquares.Size = new System.Drawing.Size(35, 36);
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
			this.btnEllipsis.Size = new System.Drawing.Size(35, 36);
			this.btnEllipsis.Text = "ELLIPSIS";
			this.btnEllipsis.Click += new System.EventHandler(this.ShapeChoice_Click);
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(669, 398);
			this.toolStripContainer1.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainCAD_Paint);
			this.toolStripContainer1.ContentPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseClick);
			this.toolStripContainer1.ContentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseDown);
			this.toolStripContainer1.ContentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseMove);
			this.toolStripContainer1.ContentPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseUp);
			this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// toolStripContainer1.LeftToolStripPanel
			// 
			this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(706, 398);
			this.toolStripContainer1.TabIndex = 5;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.otherToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(706, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + O";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// shapesToolStripMenuItem
			// 
			this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.toolStripComboBox1});
			this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
			this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.shapesToolStripMenuItem.Text = "Shapes";
			// 
			// pointToolStripMenuItem
			// 
			this.pointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pointToolStripMenuItem.Image")));
			this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
			this.pointToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.pointToolStripMenuItem.Text = "Point";
			this.pointToolStripMenuItem.ToolTipText = "Draw a Point";
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continuousToolStripMenuItem,
            this.brokenToolStripMenuItem,
            this.dashedToolStripMenuItem});
			this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.lineToolStripMenuItem.Text = "Line";
			// 
			// continuousToolStripMenuItem
			// 
			this.continuousToolStripMenuItem.Name = "continuousToolStripMenuItem";
			this.continuousToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.continuousToolStripMenuItem.Text = "Continuous";
			// 
			// brokenToolStripMenuItem
			// 
			this.brokenToolStripMenuItem.Name = "brokenToolStripMenuItem";
			this.brokenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.brokenToolStripMenuItem.Text = "Broken";
			// 
			// dashedToolStripMenuItem
			// 
			this.dashedToolStripMenuItem.Name = "dashedToolStripMenuItem";
			this.dashedToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.dashedToolStripMenuItem.Text = "Dashed";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Triangle",
            "Rectangle",
            "Square",
            "Pentagon"});
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "Triangle",
            "Rectangle",
            "Square",
            "Pentagon"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
			this.toolStripComboBox1.Text = "Polygon";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.applyOptionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.optionsToolStripMenuItem.Text = "Options...";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// otherToolStripMenuItem
			// 
			this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillWPointsToolStripMenuItem,
            this.pointsCountToolStripMenuItem,
            this.totalAreaToolStripMenuItem});
			this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
			this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.otherToolStripMenuItem.Text = "Other";
			// 
			// fillWPointsToolStripMenuItem
			// 
			this.fillWPointsToolStripMenuItem.Name = "fillWPointsToolStripMenuItem";
			this.fillWPointsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.fillWPointsToolStripMenuItem.Text = "Fill w/ Points";
			this.fillWPointsToolStripMenuItem.Click += new System.EventHandler(this.fillWPointsToolStripMenuItem_Click);
			// 
			// pointsCountToolStripMenuItem
			// 
			this.pointsCountToolStripMenuItem.Name = "pointsCountToolStripMenuItem";
			this.pointsCountToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.pointsCountToolStripMenuItem.Text = "Count Points";
			this.pointsCountToolStripMenuItem.Click += new System.EventHandler(this.pointsCountToolStripMenuItem_Click);
			// 
			// totalAreaToolStripMenuItem
			// 
			this.totalAreaToolStripMenuItem.Name = "totalAreaToolStripMenuItem";
			this.totalAreaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.totalAreaToolStripMenuItem.Text = "Total Area";
			this.totalAreaToolStripMenuItem.Click += new System.EventHandler(this.totalAreaToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "MiniCADFile ";
			// 
			// applyOptionsToolStripMenuItem
			// 
			this.applyOptionsToolStripMenuItem.Name = "applyOptionsToolStripMenuItem";
			this.applyOptionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.applyOptionsToolStripMenuItem.Text = "Apply Options";
			this.applyOptionsToolStripMenuItem.Click += new System.EventHandler(this.applyOptionsToolStripMenuItem_Click);
			// 
			// MainCAD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 422);
			this.Controls.Add(this.toolStripContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainCAD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Click on the form to draw!";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainCAD_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainCAD_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainCAD_KeyUp);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainCAD_MouseUp);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
			this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorSelection;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPoints;
        private System.Windows.Forms.ToolStripButton btnLines;
        private System.Windows.Forms.ToolStripButton btnRectangles;
        private System.Windows.Forms.ToolStripButton btnSquares;
        private System.Windows.Forms.ToolStripButton btnEllipsis;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem continuousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem brokenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dashedToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fillWPointsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointsCountToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem totalAreaToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem applyOptionsToolStripMenuItem;
	}
}