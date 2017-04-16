namespace Citicon.Forms.Dialogs
{
    partial class AddTimeLogDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTimeLogDialog));
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.LoginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LogoutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelCloseButton = new System.Windows.Forms.Button();
            this.LoginCheckBox = new System.Windows.Forms.CheckBox();
            this.LogoutCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(12, 9);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(65, 17);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.BackColor = System.Drawing.Color.White;
            this.EmployeeTextBox.Location = new System.Drawing.Point(15, 29);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.ReadOnly = true;
            this.EmployeeTextBox.Size = new System.Drawing.Size(389, 25);
            this.EmployeeTextBox.TabIndex = 1;
            // 
            // LoginDateTimePicker
            // 
            this.LoginDateTimePicker.CustomFormat = "MMMM dd, yyyy HH:mm:ss";
            this.LoginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LoginDateTimePicker.Location = new System.Drawing.Point(15, 97);
            this.LoginDateTimePicker.Name = "LoginDateTimePicker";
            this.LoginDateTimePicker.Size = new System.Drawing.Size(400, 25);
            this.LoginDateTimePicker.TabIndex = 3;
            // 
            // LogoutDateTimePicker
            // 
            this.LogoutDateTimePicker.CustomFormat = "MMMM dd, yyyy HH:mm:ss";
            this.LogoutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LogoutDateTimePicker.Location = new System.Drawing.Point(15, 155);
            this.LogoutDateTimePicker.Name = "LogoutDateTimePicker";
            this.LogoutDateTimePicker.Size = new System.Drawing.Size(400, 25);
            this.LogoutDateTimePicker.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(207, 190);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 115;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelCloseButton
            // 
            this.CancelCloseButton.BackColor = System.Drawing.Color.White;
            this.CancelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelCloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCloseButton.ForeColor = System.Drawing.Color.Red;
            this.CancelCloseButton.Location = new System.Drawing.Point(315, 190);
            this.CancelCloseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelCloseButton.Name = "CancelCloseButton";
            this.CancelCloseButton.Size = new System.Drawing.Size(100, 35);
            this.CancelCloseButton.TabIndex = 116;
            this.CancelCloseButton.Text = "CANCEL";
            this.CancelCloseButton.UseVisualStyleBackColor = false;
            this.CancelCloseButton.Click += new System.EventHandler(this.CancelCloseButton_Click);
            // 
            // LoginCheckBox
            // 
            this.LoginCheckBox.AutoSize = true;
            this.LoginCheckBox.Checked = true;
            this.LoginCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoginCheckBox.Location = new System.Drawing.Point(15, 70);
            this.LoginCheckBox.Name = "LoginCheckBox";
            this.LoginCheckBox.Size = new System.Drawing.Size(59, 21);
            this.LoginCheckBox.TabIndex = 117;
            this.LoginCheckBox.Text = "Login";
            this.LoginCheckBox.UseVisualStyleBackColor = true;
            this.LoginCheckBox.CheckedChanged += new System.EventHandler(this.LoginCheckBox_CheckedChanged);
            // 
            // LogoutCheckBox
            // 
            this.LogoutCheckBox.AutoSize = true;
            this.LogoutCheckBox.Checked = true;
            this.LogoutCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogoutCheckBox.Location = new System.Drawing.Point(15, 128);
            this.LogoutCheckBox.Name = "LogoutCheckBox";
            this.LogoutCheckBox.Size = new System.Drawing.Size(68, 21);
            this.LogoutCheckBox.TabIndex = 118;
            this.LogoutCheckBox.Text = "Logout";
            this.LogoutCheckBox.UseVisualStyleBackColor = true;
            this.LogoutCheckBox.CheckedChanged += new System.EventHandler(this.LogoutCheckBox_CheckedChanged);
            // 
            // AddTimeLogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 237);
            this.Controls.Add(this.LogoutCheckBox);
            this.Controls.Add(this.LoginCheckBox);
            this.Controls.Add(this.CancelCloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LogoutDateTimePicker);
            this.Controls.Add(this.LoginDateTimePicker);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.EmployeeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddTimeLogDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Time Log";
            this.Load += new System.EventHandler(this.AddTimeLogDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.DateTimePicker LoginDateTimePicker;
        private System.Windows.Forms.DateTimePicker LogoutDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelCloseButton;
        private System.Windows.Forms.CheckBox LoginCheckBox;
        private System.Windows.Forms.CheckBox LogoutCheckBox;
    }
}