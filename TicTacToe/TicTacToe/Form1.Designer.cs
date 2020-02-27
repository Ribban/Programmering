namespace TicTacToe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serverBox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.clientPort = new System.Windows.Forms.RichTextBox();
            this.serverConnect = new System.Windows.Forms.Button();
            this.clientConnect = new System.Windows.Forms.Button();
            this.playerMove = new System.Windows.Forms.RichTextBox();
            this.gameStatus = new System.Windows.Forms.RichTextBox();
            this.makeMove = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.PictureBox();
            this.a2 = new System.Windows.Forms.PictureBox();
            this.a3 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.c1 = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Server IP";
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(12, 40);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(263, 21);
            this.serverBox.TabIndex = 1;
            this.serverBox.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Client IP";
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(12, 105);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(263, 22);
            this.clientBox.TabIndex = 3;
            this.clientBox.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Port";
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(282, 39);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(130, 22);
            this.serverPort.TabIndex = 5;
            this.serverPort.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(281, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Port";
            // 
            // clientPort
            // 
            this.clientPort.Location = new System.Drawing.Point(281, 105);
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(131, 22);
            this.clientPort.TabIndex = 7;
            this.clientPort.Text = "";
            // 
            // serverConnect
            // 
            this.serverConnect.Location = new System.Drawing.Point(418, 38);
            this.serverConnect.Name = "serverConnect";
            this.serverConnect.Size = new System.Drawing.Size(75, 23);
            this.serverConnect.TabIndex = 8;
            this.serverConnect.Text = "Connect";
            this.serverConnect.UseVisualStyleBackColor = true;
            // 
            // clientConnect
            // 
            this.clientConnect.Location = new System.Drawing.Point(418, 105);
            this.clientConnect.Name = "clientConnect";
            this.clientConnect.Size = new System.Drawing.Size(75, 23);
            this.clientConnect.TabIndex = 9;
            this.clientConnect.Text = "Connect";
            this.clientConnect.UseVisualStyleBackColor = true;
            // 
            // playerMove
            // 
            this.playerMove.Location = new System.Drawing.Point(121, 133);
            this.playerMove.Name = "playerMove";
            this.playerMove.Size = new System.Drawing.Size(276, 39);
            this.playerMove.TabIndex = 19;
            this.playerMove.Text = "";
            // 
            // gameStatus
            // 
            this.gameStatus.Location = new System.Drawing.Point(13, 664);
            this.gameStatus.Name = "gameStatus";
            this.gameStatus.Size = new System.Drawing.Size(318, 38);
            this.gameStatus.TabIndex = 20;
            this.gameStatus.Text = "";
            // 
            // makeMove
            // 
            this.makeMove.Location = new System.Drawing.Point(337, 664);
            this.makeMove.Name = "makeMove";
            this.makeMove.Size = new System.Drawing.Size(156, 38);
            this.makeMove.TabIndex = 21;
            this.makeMove.Text = "Make Move";
            this.makeMove.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(12, 178);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(156, 156);
            this.a1.TabIndex = 22;
            this.a1.TabStop = false;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(174, 178);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(156, 156);
            this.a2.TabIndex = 23;
            this.a2.TabStop = false;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(337, 178);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(156, 156);
            this.a3.TabIndex = 24;
            this.a3.TabStop = false;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 340);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(156, 156);
            this.b1.TabIndex = 25;
            this.b1.TabStop = false;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(174, 340);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(156, 156);
            this.b2.TabIndex = 26;
            this.b2.TabStop = false;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(337, 340);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(156, 156);
            this.b3.TabIndex = 27;
            this.b3.TabStop = false;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 502);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(156, 156);
            this.c1.TabIndex = 28;
            this.c1.TabStop = false;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(174, 502);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(156, 156);
            this.c2.TabIndex = 29;
            this.c2.TabStop = false;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(337, 502);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(156, 156);
            this.c3.TabIndex = 30;
            this.c3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 730);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.makeMove);
            this.Controls.Add(this.gameStatus);
            this.Controls.Add(this.playerMove);
            this.Controls.Add(this.clientConnect);
            this.Controls.Add(this.serverConnect);
            this.Controls.Add(this.clientPort);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox serverBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox clientBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox serverPort;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox clientPort;
        private System.Windows.Forms.Button serverConnect;
        private System.Windows.Forms.Button clientConnect;
        private System.Windows.Forms.RichTextBox playerMove;
        private System.Windows.Forms.RichTextBox gameStatus;
        private System.Windows.Forms.Button makeMove;
        private System.Windows.Forms.PictureBox a1;
        private System.Windows.Forms.PictureBox a2;
        private System.Windows.Forms.PictureBox a3;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox c1;
        private System.Windows.Forms.PictureBox c2;
        private System.Windows.Forms.PictureBox c3;
    }
}

