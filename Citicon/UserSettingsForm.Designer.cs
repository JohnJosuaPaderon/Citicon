namespace Citicon
{
    partial class UserSettingsForm
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
            this.Header = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.ckbxEditUsername = new System.Windows.Forms.CheckBox();
            this.ckbxChangePassword = new System.Windows.Forms.CheckBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.tbxCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxReTypePassword = new System.Windows.Forms.TextBox();
            this.lblReTypePassword = new System.Windows.Forms.Label();
            this.tbxDisplayName = new System.Windows.Forms.TextBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.ckbxEditDisplayName = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(785, 100);
            this.Header.TabIndex = 11;
            this.Header.Text = "User Settings";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(43, 144);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 25);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUsername.Enabled = false;
            this.tbxUsername.Location = new System.Drawing.Point(146, 142);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(450, 33);
            this.tbxUsername.TabIndex = 13;
            this.tbxUsername.TextChanged += new System.EventHandler(this.TbxUsername_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Location = new System.Drawing.Point(146, 181);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(450, 33);
            this.tbxPassword.TabIndex = 15;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 25);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // ckbxEditUsername
            // 
            this.ckbxEditUsername.AutoSize = true;
            this.ckbxEditUsername.Location = new System.Drawing.Point(602, 144);
            this.ckbxEditUsername.Name = "ckbxEditUsername";
            this.ckbxEditUsername.Size = new System.Drawing.Size(63, 29);
            this.ckbxEditUsername.TabIndex = 17;
            this.ckbxEditUsername.Text = "Edit";
            this.ckbxEditUsername.UseVisualStyleBackColor = true;
            this.ckbxEditUsername.CheckedChanged += new System.EventHandler(this.CkbxEditUsername_CheckedChanged);
            // 
            // ckbxChangePassword
            // 
            this.ckbxChangePassword.AutoSize = true;
            this.ckbxChangePassword.Location = new System.Drawing.Point(602, 182);
            this.ckbxChangePassword.Name = "ckbxChangePassword";
            this.ckbxChangePassword.Size = new System.Drawing.Size(96, 29);
            this.ckbxChangePassword.TabIndex = 18;
            this.ckbxChangePassword.Text = "Change";
            this.ckbxChangePassword.UseVisualStyleBackColor = true;
            this.ckbxChangePassword.CheckedChanged += new System.EventHandler(this.CkbxChangePassword_CheckedChanged);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Enabled = false;
            this.lblCurrentPassword.Location = new System.Drawing.Point(142, 222);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(160, 25);
            this.lblCurrentPassword.TabIndex = 19;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // tbxCurrentPassword
            // 
            this.tbxCurrentPassword.BackColor = System.Drawing.Color.White;
            this.tbxCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCurrentPassword.Enabled = false;
            this.tbxCurrentPassword.Location = new System.Drawing.Point(309, 220);
            this.tbxCurrentPassword.Name = "tbxCurrentPassword";
            this.tbxCurrentPassword.Size = new System.Drawing.Size(450, 33);
            this.tbxCurrentPassword.TabIndex = 20;
            this.tbxCurrentPassword.UseSystemPasswordChar = true;
            this.tbxCurrentPassword.TextChanged += new System.EventHandler(this.TbxCurrentPassword_TextChanged);
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackColor = System.Drawing.Color.White;
            this.tbxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(309, 259);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(450, 33);
            this.tbxNewPassword.TabIndex = 22;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            this.tbxNewPassword.TextChanged += new System.EventHandler(this.TbxNewPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Enabled = false;
            this.lblNewPassword.Location = new System.Drawing.Point(168, 261);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(134, 25);
            this.lblNewPassword.TabIndex = 21;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbxReTypePassword
            // 
            this.tbxReTypePassword.BackColor = System.Drawing.Color.White;
            this.tbxReTypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxReTypePassword.Enabled = false;
            this.tbxReTypePassword.Location = new System.Drawing.Point(309, 298);
            this.tbxReTypePassword.Name = "tbxReTypePassword";
            this.tbxReTypePassword.Size = new System.Drawing.Size(450, 33);
            this.tbxReTypePassword.TabIndex = 24;
            this.tbxReTypePassword.UseSystemPasswordChar = true;
            this.tbxReTypePassword.TextChanged += new System.EventHandler(this.TbxReTypePassword_TextChanged);
            // 
            // lblReTypePassword
            // 
            this.lblReTypePassword.AutoSize = true;
            this.lblReTypePassword.Enabled = false;
            this.lblReTypePassword.Location = new System.Drawing.Point(141, 300);
            this.lblReTypePassword.Name = "lblReTypePassword";
            this.lblReTypePassword.Size = new System.Drawing.Size(160, 25);
            this.lblReTypePassword.TabIndex = 23;
            this.lblReTypePassword.Text = "Re-type Password";
            // 
            // tbxDisplayName
            // 
            this.tbxDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDisplayName.Enabled = false;
            this.tbxDisplayName.Location = new System.Drawing.Point(146, 103);
            this.tbxDisplayName.Name = "tbxDisplayName";
            this.tbxDisplayName.Size = new System.Drawing.Size(450, 33);
            this.tbxDisplayName.TabIndex = 26;
            this.tbxDisplayName.TextChanged += new System.EventHandler(this.TbxDisplayName_TextChanged);
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(12, 105);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(128, 25);
            this.lblDisplayName.TabIndex = 25;
            this.lblDisplayName.Text = "Display Name";
            // 
            // ckbxEditDisplayName
            // 
            this.ckbxEditDisplayName.AutoSize = true;
            this.ckbxEditDisplayName.Location = new System.Drawing.Point(602, 104);
            this.ckbxEditDisplayName.Name = "ckbxEditDisplayName";
            this.ckbxEditDisplayName.Size = new System.Drawing.Size(63, 29);
            this.ckbxEditDisplayName.TabIndex = 27;
            this.ckbxEditDisplayName.Text = "Edit";
            this.ckbxEditDisplayName.UseVisualStyleBackColor = true;
            this.ckbxEditDisplayName.CheckedChanged += new System.EventHandler(this.CkbxEditDisplayName_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(648, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChanges.BackColor = System.Drawing.Color.Red;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(467, 456);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 50);
            this.btnSaveChanges.TabIndex = 81;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNewUser.BackColor = System.Drawing.Color.Red;
            this.btnAddNewUser.FlatAppearance.BorderSize = 0;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(11, 456);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(175, 50);
            this.btnAddNewUser.TabIndex = 82;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.BtnAddNewUser_Click);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 518);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ckbxEditDisplayName);
            this.Controls.Add(this.tbxDisplayName);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.tbxReTypePassword);
            this.Controls.Add(this.lblReTypePassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbxCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.ckbxChangePassword);
            this.Controls.Add(this.ckbxEditUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon | User Settings";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox ckbxEditUsername;
        private System.Windows.Forms.CheckBox ckbxChangePassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox tbxCurrentPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxReTypePassword;
        private System.Windows.Forms.Label lblReTypePassword;
        private System.Windows.Forms.TextBox tbxDisplayName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.CheckBox ckbxEditDisplayName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}