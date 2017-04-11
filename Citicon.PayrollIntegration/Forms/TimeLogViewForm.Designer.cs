namespace Citicon.PayrollIntegration.Forms
{
    partial class TimeLogViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLogViewForm));
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeRangeLabel = new System.Windows.Forms.Label();
            this.TimeRangeStartDdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeRangeToLabel = new System.Windows.Forms.Label();
            this.TimeRangeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TimeLogDataGridView = new System.Windows.Forms.DataGridView();
            this.TimeLogColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_LogoutColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLog_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLogDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveTimeLogChangesButton = new System.Windows.Forms.Button();
            this.TimeLogDetails_LogoutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLogDetails_LogoutLabel = new System.Windows.Forms.Label();
            this.TimeLogDetails_LoginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeLogDetails_LoginLabel = new System.Windows.Forms.Label();
            this.DeleteTimeLogButton = new System.Windows.Forms.Button();
            this.InsertTimeLogButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogDataGridView)).BeginInit();
            this.TimeLogDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.EmployeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGridView.ColumnHeadersHeight = 60;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeeDataGridView.Location = new System.Drawing.Point(12, 109);
            this.EmployeeDataGridView.MultiSelect = false;
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            this.EmployeeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.EmployeeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeDataGridView.RowTemplate.Height = 40;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(470, 632);
            this.EmployeeDataGridView.TabIndex = 105;
            this.EmployeeDataGridView.SelectionChanged += new System.EventHandler(this.EmployeeDataGridView_SelectionChanged);
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeColumn.HeaderText = "EMPLOYEES";
            this.EmployeeColumn.MinimumWidth = 100;
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.ReadOnly = true;
            // 
            // TimeRangeLabel
            // 
            this.TimeRangeLabel.AutoSize = true;
            this.TimeRangeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeRangeLabel.Name = "TimeRangeLabel";
            this.TimeRangeLabel.Size = new System.Drawing.Size(115, 17);
            this.TimeRangeLabel.TabIndex = 106;
            this.TimeRangeLabel.Text = "Select Time Range";
            // 
            // TimeRangeStartDdateTimePicker
            // 
            this.TimeRangeStartDdateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.TimeRangeStartDdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeRangeStartDdateTimePicker.Location = new System.Drawing.Point(15, 29);
            this.TimeRangeStartDdateTimePicker.Name = "TimeRangeStartDdateTimePicker";
            this.TimeRangeStartDdateTimePicker.Size = new System.Drawing.Size(220, 25);
            this.TimeRangeStartDdateTimePicker.TabIndex = 107;
            // 
            // TimeRangeToLabel
            // 
            this.TimeRangeToLabel.AutoSize = true;
            this.TimeRangeToLabel.Location = new System.Drawing.Point(238, 35);
            this.TimeRangeToLabel.Name = "TimeRangeToLabel";
            this.TimeRangeToLabel.Size = new System.Drawing.Size(20, 17);
            this.TimeRangeToLabel.TabIndex = 108;
            this.TimeRangeToLabel.Text = "to";
            // 
            // TimeRangeEndDateTimePicker
            // 
            this.TimeRangeEndDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.TimeRangeEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeRangeEndDateTimePicker.Location = new System.Drawing.Point(262, 29);
            this.TimeRangeEndDateTimePicker.Name = "TimeRangeEndDateTimePicker";
            this.TimeRangeEndDateTimePicker.Size = new System.Drawing.Size(220, 25);
            this.TimeRangeEndDateTimePicker.TabIndex = 109;
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(12, 57);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(47, 17);
            this.BranchLabel.TabIndex = 110;
            this.BranchLabel.Text = "Branch";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(15, 78);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(220, 25);
            this.BranchComboBox.TabIndex = 111;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(382, 68);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 35);
            this.SearchButton.TabIndex = 113;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TimeLogDataGridView
            // 
            this.TimeLogDataGridView.AllowUserToAddRows = false;
            this.TimeLogDataGridView.AllowUserToDeleteRows = false;
            this.TimeLogDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLogDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TimeLogDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TimeLogDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TimeLogDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeLogDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.TimeLogDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLogDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TimeLogDataGridView.ColumnHeadersHeight = 60;
            this.TimeLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TimeLogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeLogColumn,
            this.TimeLog_LoginColumn,
            this.TimeLog_LogoutColumn,
            this.TimeLog_TypeColumn,
            this.TimeLog_ExtraColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TimeLogDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.TimeLogDataGridView.EnableHeadersVisualStyles = false;
            this.TimeLogDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TimeLogDataGridView.Location = new System.Drawing.Point(488, 109);
            this.TimeLogDataGridView.MultiSelect = false;
            this.TimeLogDataGridView.Name = "TimeLogDataGridView";
            this.TimeLogDataGridView.ReadOnly = true;
            this.TimeLogDataGridView.RowHeadersVisible = false;
            this.TimeLogDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.TimeLogDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.TimeLogDataGridView.RowTemplate.Height = 40;
            this.TimeLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TimeLogDataGridView.Size = new System.Drawing.Size(689, 632);
            this.TimeLogDataGridView.TabIndex = 114;
            this.TimeLogDataGridView.SelectionChanged += new System.EventHandler(this.TimeLogDataGridView_SelectionChanged);
            // 
            // TimeLogColumn
            // 
            this.TimeLogColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeLogColumn.HeaderText = "Time Log";
            this.TimeLogColumn.MinimumWidth = 100;
            this.TimeLogColumn.Name = "TimeLogColumn";
            this.TimeLogColumn.ReadOnly = true;
            this.TimeLogColumn.Visible = false;
            // 
            // TimeLog_LoginColumn
            // 
            this.TimeLog_LoginColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "MMMM dd, yyyy hh:mm:ss tt";
            this.TimeLog_LoginColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.TimeLog_LoginColumn.HeaderText = "LOGIN";
            this.TimeLog_LoginColumn.Name = "TimeLog_LoginColumn";
            this.TimeLog_LoginColumn.ReadOnly = true;
            this.TimeLog_LoginColumn.Width = 70;
            // 
            // TimeLog_LogoutColumn
            // 
            this.TimeLog_LogoutColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Format = "MMMM dd, yyyy hh:mm:ss tt";
            this.TimeLog_LogoutColumn.DefaultCellStyle = dataGridViewCellStyle8;
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
            // TimeLogDetailsGroupBox
            // 
            this.TimeLogDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLogDetailsGroupBox.Controls.Add(this.DeleteTimeLogButton);
            this.TimeLogDetailsGroupBox.Controls.Add(this.SaveTimeLogChangesButton);
            this.TimeLogDetailsGroupBox.Controls.Add(this.TimeLogDetails_LogoutDateTimePicker);
            this.TimeLogDetailsGroupBox.Controls.Add(this.TimeLogDetails_LogoutLabel);
            this.TimeLogDetailsGroupBox.Controls.Add(this.TimeLogDetails_LoginDateTimePicker);
            this.TimeLogDetailsGroupBox.Controls.Add(this.TimeLogDetails_LoginLabel);
            this.TimeLogDetailsGroupBox.Location = new System.Drawing.Point(1183, 150);
            this.TimeLogDetailsGroupBox.Name = "TimeLogDetailsGroupBox";
            this.TimeLogDetailsGroupBox.Size = new System.Drawing.Size(335, 164);
            this.TimeLogDetailsGroupBox.TabIndex = 115;
            this.TimeLogDetailsGroupBox.TabStop = false;
            this.TimeLogDetailsGroupBox.Text = "Time Log Details";
            // 
            // SaveTimeLogChangesButton
            // 
            this.SaveTimeLogChangesButton.BackColor = System.Drawing.Color.Red;
            this.SaveTimeLogChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveTimeLogChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTimeLogChangesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTimeLogChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveTimeLogChangesButton.Location = new System.Drawing.Point(203, 120);
            this.SaveTimeLogChangesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveTimeLogChangesButton.Name = "SaveTimeLogChangesButton";
            this.SaveTimeLogChangesButton.Size = new System.Drawing.Size(125, 35);
            this.SaveTimeLogChangesButton.TabIndex = 114;
            this.SaveTimeLogChangesButton.Text = "SAVE CHANGES";
            this.SaveTimeLogChangesButton.UseVisualStyleBackColor = false;
            this.SaveTimeLogChangesButton.Click += new System.EventHandler(this.SaveTimeLogChangesButton_Click);
            // 
            // TimeLogDetails_LogoutDateTimePicker
            // 
            this.TimeLogDetails_LogoutDateTimePicker.CustomFormat = "MMMM dd, yyyy hh:mm:ss tt";
            this.TimeLogDetails_LogoutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeLogDetails_LogoutDateTimePicker.Location = new System.Drawing.Point(9, 89);
            this.TimeLogDetails_LogoutDateTimePicker.Name = "TimeLogDetails_LogoutDateTimePicker";
            this.TimeLogDetails_LogoutDateTimePicker.Size = new System.Drawing.Size(319, 25);
            this.TimeLogDetails_LogoutDateTimePicker.TabIndex = 110;
            // 
            // TimeLogDetails_LogoutLabel
            // 
            this.TimeLogDetails_LogoutLabel.AutoSize = true;
            this.TimeLogDetails_LogoutLabel.Location = new System.Drawing.Point(6, 69);
            this.TimeLogDetails_LogoutLabel.Name = "TimeLogDetails_LogoutLabel";
            this.TimeLogDetails_LogoutLabel.Size = new System.Drawing.Size(49, 17);
            this.TimeLogDetails_LogoutLabel.TabIndex = 109;
            this.TimeLogDetails_LogoutLabel.Text = "Logout";
            // 
            // TimeLogDetails_LoginDateTimePicker
            // 
            this.TimeLogDetails_LoginDateTimePicker.CustomFormat = "MMMM dd, yyyy hh:mm:ss tt";
            this.TimeLogDetails_LoginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeLogDetails_LoginDateTimePicker.Location = new System.Drawing.Point(9, 41);
            this.TimeLogDetails_LoginDateTimePicker.Name = "TimeLogDetails_LoginDateTimePicker";
            this.TimeLogDetails_LoginDateTimePicker.Size = new System.Drawing.Size(319, 25);
            this.TimeLogDetails_LoginDateTimePicker.TabIndex = 108;
            // 
            // TimeLogDetails_LoginLabel
            // 
            this.TimeLogDetails_LoginLabel.AutoSize = true;
            this.TimeLogDetails_LoginLabel.Location = new System.Drawing.Point(6, 21);
            this.TimeLogDetails_LoginLabel.Name = "TimeLogDetails_LoginLabel";
            this.TimeLogDetails_LoginLabel.Size = new System.Drawing.Size(40, 17);
            this.TimeLogDetails_LoginLabel.TabIndex = 107;
            this.TimeLogDetails_LoginLabel.Text = "Login";
            // 
            // DeleteTimeLogButton
            // 
            this.DeleteTimeLogButton.BackColor = System.Drawing.Color.Red;
            this.DeleteTimeLogButton.FlatAppearance.BorderSize = 0;
            this.DeleteTimeLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTimeLogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTimeLogButton.ForeColor = System.Drawing.Color.White;
            this.DeleteTimeLogButton.Location = new System.Drawing.Point(95, 120);
            this.DeleteTimeLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteTimeLogButton.Name = "DeleteTimeLogButton";
            this.DeleteTimeLogButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteTimeLogButton.TabIndex = 115;
            this.DeleteTimeLogButton.Text = "DELETE";
            this.DeleteTimeLogButton.UseVisualStyleBackColor = false;
            this.DeleteTimeLogButton.Click += new System.EventHandler(this.DeleteTimeLogButton_Click);
            // 
            // InsertTimeLogButton
            // 
            this.InsertTimeLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertTimeLogButton.BackColor = System.Drawing.Color.Red;
            this.InsertTimeLogButton.FlatAppearance.BorderSize = 0;
            this.InsertTimeLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertTimeLogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertTimeLogButton.ForeColor = System.Drawing.Color.White;
            this.InsertTimeLogButton.Location = new System.Drawing.Point(1183, 109);
            this.InsertTimeLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InsertTimeLogButton.Name = "InsertTimeLogButton";
            this.InsertTimeLogButton.Size = new System.Drawing.Size(150, 35);
            this.InsertTimeLogButton.TabIndex = 116;
            this.InsertTimeLogButton.Text = "INSERT TIME LOG";
            this.InsertTimeLogButton.UseVisualStyleBackColor = false;
            // 
            // TimeLogViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1530, 754);
            this.Controls.Add(this.InsertTimeLogButton);
            this.Controls.Add(this.TimeLogDetailsGroupBox);
            this.Controls.Add(this.TimeLogDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.TimeRangeEndDateTimePicker);
            this.Controls.Add(this.TimeRangeToLabel);
            this.Controls.Add(this.TimeRangeStartDdateTimePicker);
            this.Controls.Add(this.TimeRangeLabel);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeLogViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Time Logs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TimeLogViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLogDataGridView)).EndInit();
            this.TimeLogDetailsGroupBox.ResumeLayout(false);
            this.TimeLogDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Label TimeRangeLabel;
        private System.Windows.Forms.DateTimePicker TimeRangeStartDdateTimePicker;
        private System.Windows.Forms.Label TimeRangeToLabel;
        private System.Windows.Forms.DateTimePicker TimeRangeEndDateTimePicker;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeColumn;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView TimeLogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLogColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_LoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_LogoutColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLog_ExtraColumn;
        private System.Windows.Forms.GroupBox TimeLogDetailsGroupBox;
        private System.Windows.Forms.Label TimeLogDetails_LoginLabel;
        private System.Windows.Forms.DateTimePicker TimeLogDetails_LoginDateTimePicker;
        private System.Windows.Forms.DateTimePicker TimeLogDetails_LogoutDateTimePicker;
        private System.Windows.Forms.Label TimeLogDetails_LogoutLabel;
        private System.Windows.Forms.Button SaveTimeLogChangesButton;
        private System.Windows.Forms.Button DeleteTimeLogButton;
        private System.Windows.Forms.Button InsertTimeLogButton;
    }
}