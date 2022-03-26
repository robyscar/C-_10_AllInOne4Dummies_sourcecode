namespace NetworkTools
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NetStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDownload = new System.Windows.Forms.Button();
            this.EmailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.EmailStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SMTPServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NetStatus,
            this.PictureStatus,
            this.EmailStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NetStatus
            // 
            this.NetStatus.Name = "NetStatus";
            this.NetStatus.Size = new System.Drawing.Size(88, 17);
            this.NetStatus.Text = "Not Connected";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(284, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(12, 29);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(236, 20);
            this.EmailAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Type Your Emal Address:";
            // 
            // PictureStatus
            // 
            this.PictureStatus.Name = "PictureStatus";
            this.PictureStatus.Size = new System.Drawing.Size(97, 17);
            this.PictureStatus.Text = "Not Downloaded";
            // 
            // EmailStatus
            // 
            this.EmailStatus.Name = "EmailStatus";
            this.EmailStatus.Size = new System.Drawing.Size(81, 17);
            this.EmailStatus.Text = "No Email Sent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&SMTP Server:";
            // 
            // SMTPServer
            // 
            this.SMTPServer.Location = new System.Drawing.Point(13, 73);
            this.SMTPServer.Name = "SMTPServer";
            this.SMTPServer.Size = new System.Drawing.Size(236, 20);
            this.SMTPServer.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Username:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(13, 117);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(236, 20);
            this.Username.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(13, 161);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(236, 20);
            this.Password.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SMTPServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NetStatus;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox EmailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel PictureStatus;
        private System.Windows.Forms.ToolStripStatusLabel EmailStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SMTPServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
    }
}

