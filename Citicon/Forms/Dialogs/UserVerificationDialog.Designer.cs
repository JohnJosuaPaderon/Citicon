namespace Citicon.Forms.Dialogs
{
    partial class UserVerificationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserVerificationDialog));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.CancelVerifyButton = new System.Windows.Forms.Button();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(46, 129);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(67, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(49, 149);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(318, 25);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(49, 197);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(318, 25);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(46, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // MessageLabel
            // 
            this.MessageLabel.Location = new System.Drawing.Point(46, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(321, 120);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.Text = "User not be the current logged-in user.";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelVerifyButton
            // 
            this.CancelVerifyButton.BackColor = System.Drawing.Color.White;
            this.CancelVerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelVerifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelVerifyButton.ForeColor = System.Drawing.Color.Red;
            this.CancelVerifyButton.Location = new System.Drawing.Point(267, 228);
            this.CancelVerifyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelVerifyButton.Name = "CancelVerifyButton";
            this.CancelVerifyButton.Size = new System.Drawing.Size(100, 35);
            this.CancelVerifyButton.TabIndex = 123;
            this.CancelVerifyButton.Text = "CANCEL";
            this.CancelVerifyButton.UseVisualStyleBackColor = false;
            this.CancelVerifyButton.Click += new System.EventHandler(this.CancelVerifyButton_Click);
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.Red;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Location = new System.Drawing.Point(159, 228);
            this.VerifyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(100, 35);
            this.VerifyButton.TabIndex = 122;
            this.VerifyButton.Text = "VERIFY";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // UserVerificationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 293);
            this.Controls.Add(this.CancelVerifyButton);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserVerificationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Verification";
            this.Load += new System.EventHandler(this.UserVerificationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button CancelVerifyButton;
        private System.Windows.Forms.Button VerifyButton;
    }
}