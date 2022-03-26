
namespace SecureButton
{
    partial class SecureButtonTest
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
            this.SalesButton = new System.Windows.Forms.Button();
            this.AccountingButton = new System.Windows.Forms.Button();
            this.ManagerButton = new System.Windows.Forms.Button();
            this.MinimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(12, 12);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(102, 23);
            this.SalesButton.TabIndex = 0;
            this.SalesButton.Text = "&Sales Menu";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Visible = false;
            // 
            // AccountingButton
            // 
            this.AccountingButton.Location = new System.Drawing.Point(12, 41);
            this.AccountingButton.Name = "AccountingButton";
            this.AccountingButton.Size = new System.Drawing.Size(102, 23);
            this.AccountingButton.TabIndex = 1;
            this.AccountingButton.Text = "&Accounting Menu";
            this.AccountingButton.UseVisualStyleBackColor = true;
            this.AccountingButton.Visible = false;
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(12, 70);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(102, 23);
            this.ManagerButton.TabIndex = 2;
            this.ManagerButton.Text = "&Manager Menu";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Visible = false;
            // 
            // MinimalButton
            // 
            this.MinimalButton.Location = new System.Drawing.Point(12, 99);
            this.MinimalButton.Name = "MinimalButton";
            this.MinimalButton.Size = new System.Drawing.Size(102, 23);
            this.MinimalButton.TabIndex = 3;
            this.MinimalButton.Text = "M&inmal Menu";
            this.MinimalButton.UseVisualStyleBackColor = true;
            this.MinimalButton.Visible = false;
            // 
            // SecureButtonTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 315);
            this.Controls.Add(this.MinimalButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.AccountingButton);
            this.Controls.Add(this.SalesButton);
            this.Name = "SecureButtonTest";
            this.Text = "Secure Button Test";
            this.Load += new System.EventHandler(this.SecureButtonTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button AccountingButton;
        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button MinimalButton;
    }
}

