namespace Chatapp_Egen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverIp = new System.Windows.Forms.RichTextBox();
            this.serverPort = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.klientPort = new System.Windows.Forms.RichTextBox();
            this.klientIP = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Ip-adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Port";
            // 
            // serverIp
            // 
            this.serverIp.Location = new System.Drawing.Point(37, 32);
            this.serverIp.Name = "serverIp";
            this.serverIp.Size = new System.Drawing.Size(253, 34);
            this.serverIp.TabIndex = 2;
            this.serverIp.Text = "";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(296, 32);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(84, 34);
            this.serverPort.TabIndex = 3;
            this.serverPort.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // klientPort
            // 
            this.klientPort.Location = new System.Drawing.Point(296, 107);
            this.klientPort.Name = "klientPort";
            this.klientPort.Size = new System.Drawing.Size(84, 34);
            this.klientPort.TabIndex = 8;
            this.klientPort.Text = "";
            // 
            // klientIP
            // 
            this.klientIP.Location = new System.Drawing.Point(37, 107);
            this.klientIP.Name = "klientIP";
            this.klientIP.Size = new System.Drawing.Size(253, 34);
            this.klientIP.TabIndex = 7;
            this.klientIP.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Klient Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Klient Ip-adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.klientPort);
            this.Controls.Add(this.klientIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.serverIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox serverIp;
        private System.Windows.Forms.RichTextBox serverPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox klientPort;
        private System.Windows.Forms.RichTextBox klientIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

