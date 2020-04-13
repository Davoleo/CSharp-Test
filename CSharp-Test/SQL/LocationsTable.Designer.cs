namespace CSharp_Test.SQL
{
    partial class LocationsTable
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
            this.dataGridPlaces = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPlaces
            // 
            this.dataGridPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPlaces.Location = new System.Drawing.Point(0, 88);
            this.dataGridPlaces.Name = "dataGridPlaces";
            this.dataGridPlaces.Size = new System.Drawing.Size(208, 358);
            this.dataGridPlaces.TabIndex = 0;
            this.dataGridPlaces.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPlaces_CellValueChanged);
            this.dataGridPlaces.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridPlaces_RowsAdded);
            this.dataGridPlaces.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridPlaces_UserDeletingRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FILTER";
            // 
            // txbFilter
            // 
            this.txbFilter.Location = new System.Drawing.Point(62, 12);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(134, 20);
            this.txbFilter.TabIndex = 2;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 38);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(184, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // LocationsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 446);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPlaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(224, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(224, 333);
            this.Name = "LocationsTable";
            this.Text = "LocationsTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationsTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Button buttonSave;
    }
}