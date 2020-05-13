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
            this.serverPort = new System.Windows.Forms.RichTextBox();
            this.serverConnect = new System.Windows.Forms.Button();
            this.clientConnect = new System.Windows.Forms.Button();
            this.klientPort = new System.Windows.Forms.RichTextBox();
            this.clientBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverBox = new System.Windows.Forms.RichTextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Ip-adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Port";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(263, 26);
            this.serverPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(75, 28);
            this.serverPort.TabIndex = 3;
            this.serverPort.Text = "";
            // 
            // serverConnect
            // 
            this.serverConnect.Location = new System.Drawing.Point(343, 26);
            this.serverConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverConnect.Name = "serverConnect";
            this.serverConnect.Size = new System.Drawing.Size(87, 27);
            this.serverConnect.TabIndex = 4;
            this.serverConnect.Text = "Connect";
            this.serverConnect.UseVisualStyleBackColor = true;
            // 
            // clientConnect
            // 
            this.clientConnect.Location = new System.Drawing.Point(343, 86);
            this.clientConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientConnect.Name = "clientConnect";
            this.clientConnect.Size = new System.Drawing.Size(87, 27);
            this.clientConnect.TabIndex = 9;
            this.clientConnect.Text = "Connect";
            this.clientConnect.UseVisualStyleBackColor = true;
            // 
            // klientPort
            // 
            this.klientPort.Location = new System.Drawing.Point(263, 86);
            this.klientPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klientPort.Name = "klientPort";
            this.klientPort.Size = new System.Drawing.Size(75, 28);
            this.klientPort.TabIndex = 8;
            this.klientPort.Text = "";
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(33, 86);
            this.clientBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(225, 28);
            this.clientBox.TabIndex = 7;
            this.clientBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Klient Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Klient Ip-adress";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(33, 26);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(225, 27);
            this.serverBox.TabIndex = 10;
            this.serverBox.Text = "";
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(33, 131);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(397, 125);
            this.chatBox.TabIndex = 11;
            this.chatBox.Text = "";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(33, 262);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(305, 41);
            this.messageTextBox.TabIndex = 12;
            this.messageTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(344, 262);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(86, 41);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 360);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.clientConnect);
            this.Controls.Add(this.klientPort);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverConnect);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox serverPort;
        private System.Windows.Forms.Button serverConnect;
        private System.Windows.Forms.Button clientConnect;
        private System.Windows.Forms.RichTextBox klientPort;
        private System.Windows.Forms.RichTextBox clientBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox serverBox;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

