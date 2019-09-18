﻿namespace CSharp_Test
{
    partial class Checkbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkbox));
            this.lblExample = new System.Windows.Forms.Label();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageListPicks = new System.Windows.Forms.ImageList(this.components);
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkRandomImage = new System.Windows.Forms.CheckBox();
            this.checkListFormats = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.Location = new System.Drawing.Point(112, 9);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(178, 25);
            this.lblExample.TabIndex = 0;
            this.lblExample.Text = "Testo di ESEMPIO";
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.BackColor = System.Drawing.SystemColors.Control;
            this.checkBold.Location = new System.Drawing.Point(12, 73);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(71, 17);
            this.checkBold.TabIndex = 1;
            this.checkBold.Text = "Grassetto";
            this.checkBold.UseVisualStyleBackColor = false;
            this.checkBold.CheckedChanged += new System.EventHandler(this.checkBold_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bottone di servizio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageListPicks
            // 
            this.imageListPicks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPicks.ImageStream")));
            this.imageListPicks.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPicks.Images.SetKeyName(0, "adamantine_pick.png");
            this.imageListPicks.Images.SetKeyName(1, "astral_silver_pick.png");
            this.imageListPicks.Images.SetKeyName(2, "atlarus_pick.png");
            this.imageListPicks.Images.SetKeyName(3, "black_steel_pick.png");
            this.imageListPicks.Images.SetKeyName(4, "carmot_pick.png");
            this.imageListPicks.Images.SetKeyName(5, "celenegil_pick.png");
            this.imageListPicks.Images.SetKeyName(6, "deep_iron_pick.png");
            this.imageListPicks.Images.SetKeyName(7, "haderoth_pick.png");
            this.imageListPicks.Images.SetKeyName(8, "mithril_pick.png");
            this.imageListPicks.Images.SetKeyName(9, "orichalcum_pick.png");
            this.imageListPicks.Images.SetKeyName(10, "oureclase_pick.png");
            this.imageListPicks.Images.SetKeyName(11, "prometheum_pick.png");
            this.imageListPicks.Images.SetKeyName(12, "quicksilver_pick.png");
            this.imageListPicks.Images.SetKeyName(13, "tartarite_pick.png");
            // 
            // checkBox4
            // 
            this.checkBox4.ImageIndex = 0;
            this.checkBox4.ImageList = this.imageListPicks;
            this.checkBox4.Location = new System.Drawing.Point(34, 139);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 28);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.ImageIndex = 1;
            this.checkBox1.ImageList = this.imageListPicks;
            this.checkBox1.Location = new System.Drawing.Point(82, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(42, 28);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.ImageIndex = 2;
            this.checkBox2.ImageList = this.imageListPicks;
            this.checkBox2.Location = new System.Drawing.Point(130, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(42, 28);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.ImageIndex = 3;
            this.checkBox3.ImageList = this.imageListPicks;
            this.checkBox3.Location = new System.Drawing.Point(178, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(42, 28);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.ImageIndex = 13;
            this.checkBox5.ImageList = this.imageListPicks;
            this.checkBox5.Location = new System.Drawing.Point(229, 139);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(42, 28);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkRandomImage
            // 
            this.checkRandomImage.ImageIndex = 8;
            this.checkRandomImage.ImageList = this.imageListPicks;
            this.checkRandomImage.Location = new System.Drawing.Point(366, 212);
            this.checkRandomImage.Name = "checkRandomImage";
            this.checkRandomImage.Size = new System.Drawing.Size(44, 24);
            this.checkRandomImage.TabIndex = 11;
            this.checkRandomImage.UseVisualStyleBackColor = true;
            // 
            // checkListFormats
            // 
            this.checkListFormats.CheckOnClick = true;
            this.checkListFormats.FormatString = "f";
            this.checkListFormats.FormattingEnabled = true;
            this.checkListFormats.HorizontalScrollbar = true;
            this.checkListFormats.Location = new System.Drawing.Point(290, 43);
            this.checkListFormats.Name = "checkListFormats";
            this.checkListFormats.Size = new System.Drawing.Size(120, 154);
            this.checkListFormats.TabIndex = 12;
            // 
            // Strumenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 248);
            this.Controls.Add(this.checkListFormats);
            this.Controls.Add(this.checkRandomImage);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBold);
            this.Controls.Add(this.lblExample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Strumenti";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Strumenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageListPicks;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkRandomImage;
        private System.Windows.Forms.CheckedListBox checkListFormats;
    }
}