﻿namespace Arv
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSpecies = new System.Windows.Forms.Label();
            this.lbCanFly = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNames
            // 
            this.cbNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNames.FormattingEnabled = true;
            this.cbNames.Location = new System.Drawing.Point(88, 12);
            this.cbNames.Name = "cbNames";
            this.cbNames.Size = new System.Drawing.Size(121, 24);
            this.cbNames.TabIndex = 0;
            this.cbNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Art";
            // 
            // lbSpecies
            // 
            this.lbSpecies.AutoSize = true;
            this.lbSpecies.Location = new System.Drawing.Point(85, 76);
            this.lbSpecies.Name = "lbSpecies";
            this.lbSpecies.Size = new System.Drawing.Size(0, 17);
            this.lbSpecies.TabIndex = 3;
            // 
            // lbCanFly
            // 
            this.lbCanFly.AutoSize = true;
            this.lbCanFly.Location = new System.Drawing.Point(24, 389);
            this.lbCanFly.Name = "lbCanFly";
            this.lbCanFly.Size = new System.Drawing.Size(94, 17);
            this.lbCanFly.TabIndex = 4;
            this.lbCanFly.Text = "Kan inte flyga";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cat.jpg");
            this.imageList1.Images.SetKeyName(1, "dog.jpg");
            this.imageList1.Images.SetKeyName(2, "bird.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCanFly);
            this.Controls.Add(this.lbSpecies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Djur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSpecies;
        private System.Windows.Forms.Label lbCanFly;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

