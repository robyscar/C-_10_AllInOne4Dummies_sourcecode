namespace Cribbage
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
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player1Points = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player2Points = new System.Windows.Forms.Label();
            this.WinMessage = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.LinkLabel();
            this.PrintMe = new System.Windows.Forms.LinkLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Location = new System.Drawing.Point(12, 229);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(100, 20);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "0";
            this.Player1.Leave += new System.EventHandler(this.Player1_Leave);
            // 
            // Player2
            // 
            this.Player2.Location = new System.Drawing.Point(752, 229);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(100, 20);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "0";
            this.Player2.Leave += new System.EventHandler(this.Player2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1";
            // 
            // Player1Points
            // 
            this.Player1Points.AutoSize = true;
            this.Player1Points.Location = new System.Drawing.Point(77, 213);
            this.Player1Points.Name = "Player1Points";
            this.Player1Points.Size = new System.Drawing.Size(13, 13);
            this.Player1Points.TabIndex = 3;
            this.Player1Points.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 2";
            // 
            // Player2Points
            // 
            this.Player2Points.AutoSize = true;
            this.Player2Points.Location = new System.Drawing.Point(817, 213);
            this.Player2Points.Name = "Player2Points";
            this.Player2Points.Size = new System.Drawing.Size(13, 13);
            this.Player2Points.TabIndex = 5;
            this.Player2Points.Text = "0";
            // 
            // WinMessage
            // 
            this.WinMessage.AutoSize = true;
            this.WinMessage.Location = new System.Drawing.Point(377, 213);
            this.WinMessage.Name = "WinMessage";
            this.WinMessage.Size = new System.Drawing.Size(87, 13);
            this.WinMessage.TabIndex = 6;
            this.WinMessage.Text = "Somebody Wins!";
            this.WinMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(333, 229);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(100, 23);
            this.StartGame.TabIndex = 7;
            this.StartGame.TabStop = true;
            this.StartGame.Text = "New Game";
            this.StartGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartGame_LinkClicked);
            // 
            // PrintMe
            // 
            this.PrintMe.AutoSize = true;
            this.PrintMe.Location = new System.Drawing.Point(439, 234);
            this.PrintMe.Name = "PrintMe";
            this.PrintMe.Size = new System.Drawing.Size(76, 13);
            this.PrintMe.TabIndex = 8;
            this.PrintMe.TabStop = true;
            this.PrintMe.Text = "Print My Score";
            this.PrintMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PrintMe_LinkClicked);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 261);
            this.Controls.Add(this.PrintMe);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.WinMessage);
            this.Controls.Add(this.Player2Points);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Player1Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cribbage";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CribbageBoard_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Player1Points;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Player2Points;
        private System.Windows.Forms.Label WinMessage;
        private System.Windows.Forms.LinkLabel StartGame;
        private System.Windows.Forms.LinkLabel PrintMe;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

