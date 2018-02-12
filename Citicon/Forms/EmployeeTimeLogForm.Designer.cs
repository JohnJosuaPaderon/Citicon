namespace Citicon.Forms
{
    partial class EmployeeTimeLogForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeTimeLogForm));
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.TimeLogsDataGridView = new System.Windows.Forms.DataGridView();
            this.TimeLogColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_LogoutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LogoutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LogoutLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(13, 13);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(65, 17);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeTextBox.Location = new System.Drawing.Point(16, 33);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.ReadOnly = true;
            this.EmployeeTextBox.Size = new System.Drawing.Size(402, 25);
            this.EmployeeTextBox.TabIndex = 1;
            // 
            // TimeLogsDataGridView
            // 
            this.TimeLogsDataGridView.AllowUserToAddRows = false;
            this.TimeLogsDataGridView.AllowUserToDeleteRows = false;
            this.TimeLogsDataGridView.AllowUserToResizeColumns = false;
            this.TimeLogsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TimeLogsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TimeLogsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLogsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TimeLogsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLogsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TimeLogsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLogsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TimeLogsDataGridView.ColumnHeadersHeight = 50;
            this.TimeLogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TimeLogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeLogColumn,
            this.TimeLog_LoginColumn,
            this.TimeLog_LogoutColumn,
            this.TimeLog_TypeColumn,
            this.TimeLog_ExtraColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeLogsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.TimeLogsDataGridView.EnableHeadersVisualStyles = false;
            this.TimeLogsDataGridView.GridColor = System.Drawing.Color.Red;
            this.TimeLogsDataGridView.Location = new System.Drawing.Point(16, 64);
            this.TimeLogsDataGridView.Name = "TimeLogsDataGridView";
            this.TimeLogsDataGridView.ReadOnly = true;
            this.TimeLogsDataGridView.RowHeadersVisible = false;
            this.TimeLogsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeLogsDataGridView.Size = new System.Drawing.Size(402, 556);
            this.TimeLogsDataGridView.TabIndex = 8;
            // 
            // TimeLogColumn
            // 
            this.TimeLogColumn.HeaderText = "Time-Log";
            this.TimeLogColumn.Name = "TimeLogColumn";
            this.TimeLogColumn.ReadOnly = true;
            this.TimeLogColumn.Visible = false;
            // 
            // TimeLog_LoginColumn
            // 
            this.TimeLog_LoginColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "MMM. d, yyyy HH:mm";
            this.TimeLog_LoginColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.TimeLog_LoginColumn.HeaderText = "LOGIN";
            this.TimeLog_LoginColumn.Name = "TimeLog_LoginColumn";
            this.TimeLog_LoginColumn.ReadOnly = true;
            this.TimeLog_LoginColumn.Width = 70;
            // 
            // TimeLog_LogoutColumn
            // 
            this.TimeLog_LogoutColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "MMM. d, yyyy HH:mm";
            this.TimeLog_LogoutColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.TimeLog_LogoutColumn.HeaderText = "LOGOUT";
            this.TimeLog_LogoutColumn.Name = "TimeLog_LogoutColumn";
            this.TimeLog_LogoutColumn.ReadOnly = true;
            this.TimeLog_LogoutColumn.Width = 83;
            // 
            // TimeLog_TypeColumn
            // 
            this.TimeLog_TypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TimeLog_TypeColumn.HeaderText = "TYPE";
            this.TimeLog_TypeColumn.Name = "TimeLog_TypeColumn";
            this.TimeLog_TypeColumn.ReadOnly = true;
            this.TimeLog_TypeColumn.Width = 60;
            // 
            // TimeLog_ExtraColumn
            // 
            this.TimeLog_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeLog_ExtraColumn.HeaderText = "";
            this.TimeLog_ExtraColumn.Name = "TimeLog_ExtraColumn";
            this.TimeLog_ExtraColumn.ReadOnly = true;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(13, 623);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(40, 17);
            this.LoginLabel.TabIndex = 9;
            this.LoginLabel.Text = "Login";
            // 
            // LoginDateTimePicker
            // 
            this.LoginDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginDateTimePicker.CustomFormat = "MMM. d, yyyy HH:mm";
            this.LoginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LoginDateTimePicker.Location = new System.Drawing.Point(16, 643);
            this.LoginDateTimePicker.Name = "LoginDateTimePicker";
            this.LoginDateTimePicker.Size = new System.Drawing.Size(193, 25);
            this.LoginDateTimePicker.TabIndex = 10;
            // 
            // LogoutDateTimePicker
            // 
            this.LogoutDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutDateTimePicker.CustomFormat = "MMM. d, yyyy HH:mm";
            this.LogoutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LogoutDateTimePicker.Location = new System.Drawing.Point(225, 643);
            this.LogoutDateTimePicker.Name = "LogoutDateTimePicker";
            this.LogoutDateTimePicker.Size = new System.Drawing.Size(193, 25);
            this.LogoutDateTimePicker.TabIndex = 11;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Location = new System.Drawing.Point(222, 623);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(49, 17);
            this.LogoutLabel.TabIndex = 12;
            this.LogoutLabel.Text = "Logout";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(318, 675);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(212, 675);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 40);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.BackColor = System.Drawing.Color.Red;
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangesButton.Location = new System.Drawing.Point(81, 675);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(125, 40);
            this.SaveChangesButton.TabIndex = 15;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // EmployeeTimeLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 727);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.LogoutDateTimePicker);
            this.Controls.Add(this.LoginDateTimePicker);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.TimeLogsDataGridView);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.EmployeeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeTimeLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Time-Logs";
            this.Load += new System.EventHandler(this.EmployeeTimeLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        public System.Windows.Forms.TextBox EmployeeTextBox;
        public System.Windows.Forms.DataGridView TimeLogsDataGridView;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label LogoutLabel;
        public System.Windows.Forms.DateTimePicker LoginDateTimePicker;
        public System.Windows.Forms.DateTimePicker LogoutDateTimePicker;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLogColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_LogoutColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_ExtraColumn;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}