namespace UDP_Chatapp
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
            this.serverBox = new System.Windows.Forms.RichTextBox();
            this.portBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(215, 12);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(204, 44);
            this.serverBox.TabIndex = 0;
            this.serverBox.Text = "";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(215, 81);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(204, 44);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serverns IP-Adress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serverns portnummer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(17, 176);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(402, 125);
            this.messageBox.TabIndex = 4;
            this.messageBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sänd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.serverBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox serverBox;
        private System.Windows.Forms.RichTextBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button button1;
    }
}

