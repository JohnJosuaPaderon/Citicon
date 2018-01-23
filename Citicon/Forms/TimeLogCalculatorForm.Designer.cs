namespace Citicon.Forms
{
    partial class TimeLogCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeLogCalculatorForm));
            this.SearchEmployeeLabel = new System.Windows.Forms.Label();
            this.SearchEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchEmployeeLabel
            // 
            this.SearchEmployeeLabel.AutoSize = true;
            this.SearchEmployeeLabel.Location = new System.Drawing.Point(13, 13);
            this.SearchEmployeeLabel.Name = "SearchEmployeeLabel";
            this.SearchEmployeeLabel.Size = new System.Drawing.Size(108, 17);
            this.SearchEmployeeLabel.TabIndex = 0;
            this.SearchEmployeeLabel.Text = "Search Employee";
            // 
            // SearchEmployeeTextBox
            // 
            this.SearchEmployeeTextBox.Location = new System.Drawing.Point(16, 34);
            this.SearchEmployeeTextBox.Name = "SearchEmployeeTextBox";
            this.SearchEmployeeTextBox.Size = new System.Drawing.Size(318, 25);
            this.SearchEmployeeTextBox.TabIndex = 1;
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.AllowUserToAddRows = false;
            this.EmployeesDataGridView.AllowUserToDeleteRows = false;
            this.EmployeesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EmployeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EmployeesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.EmployeesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeesDataGridView.ColumnHeadersHeight = 50;
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeColumn,
            this.Employee_DepartmentColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeesDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EmployeesDataGridView.Location = new System.Drawing.Point(16, 64);
            this.EmployeesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeesDataGridView.MultiSelect = false;
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.ReadOnly = true;
            this.EmployeesDataGridView.RowHeadersVisible = false;
            this.EmployeesDataGridView.RowTemplate.Height = 30;
            this.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(414, 730);
            this.EmployeesDataGridView.TabIndex = 104;
            // 
            // EmployeeColumn
            // 
            this.EmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EmployeeColumn.HeaderText = "Employees";
            this.EmployeeColumn.Name = "EmployeeColumn";
            this.EmployeeColumn.ReadOnly = true;
            this.EmployeeColumn.Width = 95;
            // 
            // Employee_DepartmentColumn
            // 
            this.Employee_DepartmentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Employee_DepartmentColumn.HeaderText = "Department";
            this.Employee_DepartmentColumn.Name = "Employee_DepartmentColumn";
            this.Employee_DepartmentColumn.ReadOnly = true;
            this.Employee_DepartmentColumn.Width = 101;
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.BackColor = System.Drawing.Color.Red;
            this.SearchEmployeeButton.FlatAppearance.BorderSize = 0;
            this.SearchEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.SearchEmployeeButton.Location = new System.Drawing.Point(340, 34);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.Size = new System.Drawing.Size(90, 25);
            this.SearchEmployeeButton.TabIndex = 105;
            this.SearchEmployeeButton.Text = "SEARCH";
            this.SearchEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // TimeLogCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 805);
            this.Controls.Add(this.SearchEmployeeButton);
            this.Controls.Add(this.EmployeesDataGridView);
            this.Controls.Add(this.SearchEmployeeTextBox);
            this.Controls.Add(this.SearchEmployeeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TimeLogCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time-Log Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchEmployeeLabel;
        private System.Windows.Forms.TextBox SearchEmployeeTextBox;
        public System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_DepartmentColumn;
        public System.Windows.Forms.Button SearchEmployeeButton;
    }
}