namespace Citicon.Forms
{
    partial class DriverPayrollForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverPayrollForm));
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.ChangeCutOffLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CutOffTextBox = new System.Windows.Forms.TextBox();
            this.CutOffLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DriverPayrollEmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.DriverPayrollEmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPayrollEmployee_EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPayrollEmployee_GrossPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPayrollEmployee_TotalDeductionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPayrollEmployee_NetPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverPayrollEmployee_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.TimeLogCalculationsGroupBox = new System.Windows.Forms.GroupBox();
            this.HolidaysTextBox = new System.Windows.Forms.TextBox();
            this.HolidaysLabel = new System.Windows.Forms.Label();
            this.WorkDaysTextBox = new System.Windows.Forms.TextBox();
            this.WorkDaysLabel = new System.Windows.Forms.Label();
            this.DeductionsGroupBox = new System.Windows.Forms.GroupBox();
            this.PhilHealthTextBox = new System.Windows.Forms.TextBox();
            this.PhilHealthLabel = new System.Windows.Forms.Label();
            this.PagibigTextBox = new System.Windows.Forms.TextBox();
            this.PagibigLabel = new System.Windows.Forms.Label();
            this.SssErTextBox = new System.Windows.Forms.TextBox();
            this.SssErLabel = new System.Windows.Forms.Label();
            this.SssEcTextBox = new System.Windows.Forms.TextBox();
            this.SssEcLabel = new System.Windows.Forms.Label();
            this.SssTextBox = new System.Windows.Forms.TextBox();
            this.SssLabel = new System.Windows.Forms.Label();
            this.WithholdingTaxTextBox = new System.Windows.Forms.TextBox();
            this.WithholdingTaxLabel = new System.Windows.Forms.Label();
            this.AdditionsComboBox = new System.Windows.Forms.GroupBox();
            this.ShopRateTextBox = new System.Windows.Forms.TextBox();
            this.ShopRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriverPayrollEmployeeDataGridView)).BeginInit();
            this.PersonalDetailsGroupBox.SuspendLayout();
            this.TimeLogCalculationsGroupBox.SuspendLayout();
            this.DeductionsGroupBox.SuspendLayout();
            this.AdditionsComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(15, 30);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(197, 25);
            this.BranchComboBox.TabIndex = 3;
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(12, 9);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(47, 17);
            this.BranchLabel.TabIndex = 2;
            this.BranchLabel.Text = "Branch";
            // 
            // ChangeCutOffLinkLabel
            // 
            this.ChangeCutOffLinkLabel.AutoSize = true;
            this.ChangeCutOffLinkLabel.Location = new System.Drawing.Point(428, 5);
            this.ChangeCutOffLinkLabel.Name = "ChangeCutOffLinkLabel";
            this.ChangeCutOffLinkLabel.Size = new System.Drawing.Size(52, 17);
            this.ChangeCutOffLinkLabel.TabIndex = 18;
            this.ChangeCutOffLinkLabel.TabStop = true;
            this.ChangeCutOffLinkLabel.Text = "Change";
            this.ChangeCutOffLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeCutOffLinkLabel_LinkClicked);
            // 
            // CutOffTextBox
            // 
            this.CutOffTextBox.Location = new System.Drawing.Point(218, 30);
            this.CutOffTextBox.Name = "CutOffTextBox";
            this.CutOffTextBox.ReadOnly = true;
            this.CutOffTextBox.Size = new System.Drawing.Size(262, 25);
            this.CutOffTextBox.TabIndex = 17;
            // 
            // CutOffLabel
            // 
            this.CutOffLabel.AutoSize = true;
            this.CutOffLabel.Location = new System.Drawing.Point(215, 9);
            this.CutOffLabel.Name = "CutOffLabel";
            this.CutOffLabel.Size = new System.Drawing.Size(50, 17);
            this.CutOffLabel.TabIndex = 16;
            this.CutOffLabel.Text = "Cut-Off";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Red;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(486, 15);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 40);
            this.GenerateButton.TabIndex = 19;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // DriverPayrollEmployeeDataGridView
            // 
            this.DriverPayrollEmployeeDataGridView.AllowUserToAddRows = false;
            this.DriverPayrollEmployeeDataGridView.AllowUserToDeleteRows = false;
            this.DriverPayrollEmployeeDataGridView.AllowUserToResizeColumns = false;
            this.DriverPayrollEmployeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DriverPayrollEmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DriverPayrollEmployeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriverPayrollEmployeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DriverPayrollEmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DriverPayrollEmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DriverPayrollEmployeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DriverPayrollEmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DriverPayrollEmployeeDataGridView.ColumnHeadersHeight = 50;
            this.DriverPayrollEmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DriverPayrollEmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverPayrollEmployeeColumn,
            this.DriverPayrollEmployee_EmployeeColumn,
            this.DriverPayrollEmployee_GrossPayColumn,
            this.DriverPayrollEmployee_TotalDeductionColumn,
            this.DriverPayrollEmployee_NetPayColumn,
            this.DriverPayrollEmployee_ExtraColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DriverPayrollEmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DriverPayrollEmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.DriverPayrollEmployeeDataGridView.GridColor = System.Drawing.Color.Red;
            this.DriverPayrollEmployeeDataGridView.Location = new System.Drawing.Point(15, 61);
            this.DriverPayrollEmployeeDataGridView.Name = "DriverPayrollEmployeeDataGridView";
            this.DriverPayrollEmployeeDataGridView.ReadOnly = true;
            this.DriverPayrollEmployeeDataGridView.RowHeadersVisible = false;
            this.DriverPayrollEmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DriverPayrollEmployeeDataGridView.Size = new System.Drawing.Size(625, 673);
            this.DriverPayrollEmployeeDataGridView.TabIndex = 20;
            // 
            // DriverPayrollEmployeeColumn
            // 
            this.DriverPayrollEmployeeColumn.HeaderText = "Driver Payroll Employee";
            this.DriverPayrollEmployeeColumn.Name = "DriverPayrollEmployeeColumn";
            this.DriverPayrollEmployeeColumn.ReadOnly = true;
            this.DriverPayrollEmployeeColumn.Visible = false;
            // 
            // DriverPayrollEmployee_EmployeeColumn
            // 
            this.DriverPayrollEmployee_EmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DriverPayrollEmployee_EmployeeColumn.HeaderText = "Employee";
            this.DriverPayrollEmployee_EmployeeColumn.Name = "DriverPayrollEmployee_EmployeeColumn";
            this.DriverPayrollEmployee_EmployeeColumn.ReadOnly = true;
            this.DriverPayrollEmployee_EmployeeColumn.Width = 89;
            // 
            // DriverPayrollEmployee_GrossPayColumn
            // 
            this.DriverPayrollEmployee_GrossPayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.DriverPayrollEmployee_GrossPayColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DriverPayrollEmployee_GrossPayColumn.HeaderText = "Gross Pay";
            this.DriverPayrollEmployee_GrossPayColumn.Name = "DriverPayrollEmployee_GrossPayColumn";
            this.DriverPayrollEmployee_GrossPayColumn.ReadOnly = true;
            this.DriverPayrollEmployee_GrossPayColumn.Width = 83;
            // 
            // DriverPayrollEmployee_TotalDeductionColumn
            // 
            this.DriverPayrollEmployee_TotalDeductionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "#,##0.00";
            this.DriverPayrollEmployee_TotalDeductionColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DriverPayrollEmployee_TotalDeductionColumn.HeaderText = "Total Deduction";
            this.DriverPayrollEmployee_TotalDeductionColumn.Name = "DriverPayrollEmployee_TotalDeductionColumn";
            this.DriverPayrollEmployee_TotalDeductionColumn.ReadOnly = true;
            this.DriverPayrollEmployee_TotalDeductionColumn.Width = 113;
            // 
            // DriverPayrollEmployee_NetPayColumn
            // 
            this.DriverPayrollEmployee_NetPayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "#,##0.00";
            this.DriverPayrollEmployee_NetPayColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.DriverPayrollEmployee_NetPayColumn.HeaderText = "Net Pay";
            this.DriverPayrollEmployee_NetPayColumn.Name = "DriverPayrollEmployee_NetPayColumn";
            this.DriverPayrollEmployee_NetPayColumn.ReadOnly = true;
            this.DriverPayrollEmployee_NetPayColumn.Width = 53;
            // 
            // DriverPayrollEmployee_ExtraColumn
            // 
            this.DriverPayrollEmployee_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DriverPayrollEmployee_ExtraColumn.HeaderText = "";
            this.DriverPayrollEmployee_ExtraColumn.Name = "DriverPayrollEmployee_ExtraColumn";
            this.DriverPayrollEmployee_ExtraColumn.ReadOnly = true;
            // 
            // PersonalDetailsGroupBox
            // 
            this.PersonalDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonalDetailsGroupBox.Controls.Add(this.PositionTextBox);
            this.PersonalDetailsGroupBox.Controls.Add(this.PositionLabel);
            this.PersonalDetailsGroupBox.Controls.Add(this.DepartmentTextBox);
            this.PersonalDetailsGroupBox.Controls.Add(this.DepartmentLabel);
            this.PersonalDetailsGroupBox.Controls.Add(this.EmployeeNameLabel);
            this.PersonalDetailsGroupBox.Controls.Add(this.EmployeeNameTextBox);
            this.PersonalDetailsGroupBox.Location = new System.Drawing.Point(646, 61);
            this.PersonalDetailsGroupBox.Name = "PersonalDetailsGroupBox";
            this.PersonalDetailsGroupBox.Size = new System.Drawing.Size(404, 178);
            this.PersonalDetailsGroupBox.TabIndex = 21;
            this.PersonalDetailsGroupBox.TabStop = false;
            this.PersonalDetailsGroupBox.Text = "Personal Details";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(6, 137);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.ReadOnly = true;
            this.PositionTextBox.Size = new System.Drawing.Size(386, 25);
            this.PositionTextBox.TabIndex = 5;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(6, 117);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(54, 17);
            this.PositionLabel.TabIndex = 4;
            this.PositionLabel.Text = "Position";
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentTextBox.Location = new System.Drawing.Point(6, 89);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.ReadOnly = true;
            this.DepartmentTextBox.Size = new System.Drawing.Size(386, 25);
            this.DepartmentTextBox.TabIndex = 3;
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(6, 69);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(77, 17);
            this.DepartmentLabel.TabIndex = 2;
            this.DepartmentLabel.Text = "Department";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(6, 21);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(43, 17);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(6, 41);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.ReadOnly = true;
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(386, 25);
            this.EmployeeNameTextBox.TabIndex = 0;
            // 
            // TimeLogCalculationsGroupBox
            // 
            this.TimeLogCalculationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLogCalculationsGroupBox.Controls.Add(this.HolidaysTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.HolidaysLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.WorkDaysTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.WorkDaysLabel);
            this.TimeLogCalculationsGroupBox.Location = new System.Drawing.Point(646, 245);
            this.TimeLogCalculationsGroupBox.Name = "TimeLogCalculationsGroupBox";
            this.TimeLogCalculationsGroupBox.Size = new System.Drawing.Size(404, 80);
            this.TimeLogCalculationsGroupBox.TabIndex = 22;
            this.TimeLogCalculationsGroupBox.TabStop = false;
            this.TimeLogCalculationsGroupBox.Text = "Time-Log Results";
            // 
            // HolidaysTextBox
            // 
            this.HolidaysTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HolidaysTextBox.Location = new System.Drawing.Point(187, 41);
            this.HolidaysTextBox.Name = "HolidaysTextBox";
            this.HolidaysTextBox.ReadOnly = true;
            this.HolidaysTextBox.Size = new System.Drawing.Size(175, 25);
            this.HolidaysTextBox.TabIndex = 8;
            // 
            // HolidaysLabel
            // 
            this.HolidaysLabel.AutoSize = true;
            this.HolidaysLabel.Location = new System.Drawing.Point(184, 21);
            this.HolidaysLabel.Name = "HolidaysLabel";
            this.HolidaysLabel.Size = new System.Drawing.Size(58, 17);
            this.HolidaysLabel.TabIndex = 7;
            this.HolidaysLabel.Text = "Holidays";
            // 
            // WorkDaysTextBox
            // 
            this.WorkDaysTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkDaysTextBox.Location = new System.Drawing.Point(6, 41);
            this.WorkDaysTextBox.Name = "WorkDaysTextBox";
            this.WorkDaysTextBox.ReadOnly = true;
            this.WorkDaysTextBox.Size = new System.Drawing.Size(175, 25);
            this.WorkDaysTextBox.TabIndex = 6;
            // 
            // WorkDaysLabel
            // 
            this.WorkDaysLabel.AutoSize = true;
            this.WorkDaysLabel.Location = new System.Drawing.Point(6, 21);
            this.WorkDaysLabel.Name = "WorkDaysLabel";
            this.WorkDaysLabel.Size = new System.Drawing.Size(85, 17);
            this.WorkDaysLabel.TabIndex = 2;
            this.WorkDaysLabel.Text = "Days Worked";
            // 
            // DeductionsGroupBox
            // 
            this.DeductionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionsGroupBox.Controls.Add(this.PhilHealthTextBox);
            this.DeductionsGroupBox.Controls.Add(this.PhilHealthLabel);
            this.DeductionsGroupBox.Controls.Add(this.PagibigTextBox);
            this.DeductionsGroupBox.Controls.Add(this.PagibigLabel);
            this.DeductionsGroupBox.Controls.Add(this.SssErTextBox);
            this.DeductionsGroupBox.Controls.Add(this.SssErLabel);
            this.DeductionsGroupBox.Controls.Add(this.SssEcTextBox);
            this.DeductionsGroupBox.Controls.Add(this.SssEcLabel);
            this.DeductionsGroupBox.Controls.Add(this.SssTextBox);
            this.DeductionsGroupBox.Controls.Add(this.SssLabel);
            this.DeductionsGroupBox.Controls.Add(this.WithholdingTaxTextBox);
            this.DeductionsGroupBox.Controls.Add(this.WithholdingTaxLabel);
            this.DeductionsGroupBox.Location = new System.Drawing.Point(646, 417);
            this.DeductionsGroupBox.Name = "DeductionsGroupBox";
            this.DeductionsGroupBox.Size = new System.Drawing.Size(404, 174);
            this.DeductionsGroupBox.TabIndex = 23;
            this.DeductionsGroupBox.TabStop = false;
            this.DeductionsGroupBox.Text = "Deductions";
            // 
            // PhilHealthTextBox
            // 
            this.PhilHealthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhilHealthTextBox.Location = new System.Drawing.Point(187, 137);
            this.PhilHealthTextBox.Name = "PhilHealthTextBox";
            this.PhilHealthTextBox.Size = new System.Drawing.Size(175, 25);
            this.PhilHealthTextBox.TabIndex = 24;
            // 
            // PhilHealthLabel
            // 
            this.PhilHealthLabel.AutoSize = true;
            this.PhilHealthLabel.Location = new System.Drawing.Point(187, 117);
            this.PhilHealthLabel.Name = "PhilHealthLabel";
            this.PhilHealthLabel.Size = new System.Drawing.Size(65, 17);
            this.PhilHealthLabel.TabIndex = 23;
            this.PhilHealthLabel.Text = "PhilHealth";
            // 
            // PagibigTextBox
            // 
            this.PagibigTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagibigTextBox.Location = new System.Drawing.Point(6, 137);
            this.PagibigTextBox.Name = "PagibigTextBox";
            this.PagibigTextBox.Size = new System.Drawing.Size(175, 25);
            this.PagibigTextBox.TabIndex = 22;
            // 
            // PagibigLabel
            // 
            this.PagibigLabel.AutoSize = true;
            this.PagibigLabel.Location = new System.Drawing.Point(6, 117);
            this.PagibigLabel.Name = "PagibigLabel";
            this.PagibigLabel.Size = new System.Drawing.Size(52, 17);
            this.PagibigLabel.TabIndex = 21;
            this.PagibigLabel.Text = "Pagibig";
            // 
            // SssErTextBox
            // 
            this.SssErTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SssErTextBox.Location = new System.Drawing.Point(187, 89);
            this.SssErTextBox.Name = "SssErTextBox";
            this.SssErTextBox.Size = new System.Drawing.Size(175, 25);
            this.SssErTextBox.TabIndex = 20;
            // 
            // SssErLabel
            // 
            this.SssErLabel.AutoSize = true;
            this.SssErLabel.Location = new System.Drawing.Point(187, 69);
            this.SssErLabel.Name = "SssErLabel";
            this.SssErLabel.Size = new System.Drawing.Size(48, 17);
            this.SssErLabel.TabIndex = 19;
            this.SssErLabel.Text = "SSS ER";
            // 
            // SssEcTextBox
            // 
            this.SssEcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SssEcTextBox.Location = new System.Drawing.Point(6, 89);
            this.SssEcTextBox.Name = "SssEcTextBox";
            this.SssEcTextBox.Size = new System.Drawing.Size(175, 25);
            this.SssEcTextBox.TabIndex = 18;
            // 
            // SssEcLabel
            // 
            this.SssEcLabel.AutoSize = true;
            this.SssEcLabel.Location = new System.Drawing.Point(6, 69);
            this.SssEcLabel.Name = "SssEcLabel";
            this.SssEcLabel.Size = new System.Drawing.Size(48, 17);
            this.SssEcLabel.TabIndex = 17;
            this.SssEcLabel.Text = "SSS EC";
            // 
            // SssTextBox
            // 
            this.SssTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SssTextBox.Location = new System.Drawing.Point(187, 41);
            this.SssTextBox.Name = "SssTextBox";
            this.SssTextBox.Size = new System.Drawing.Size(175, 25);
            this.SssTextBox.TabIndex = 16;
            // 
            // SssLabel
            // 
            this.SssLabel.AutoSize = true;
            this.SssLabel.Location = new System.Drawing.Point(187, 21);
            this.SssLabel.Name = "SssLabel";
            this.SssLabel.Size = new System.Drawing.Size(29, 17);
            this.SssLabel.TabIndex = 15;
            this.SssLabel.Text = "SSS";
            // 
            // WithholdingTaxTextBox
            // 
            this.WithholdingTaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WithholdingTaxTextBox.Location = new System.Drawing.Point(6, 41);
            this.WithholdingTaxTextBox.Name = "WithholdingTaxTextBox";
            this.WithholdingTaxTextBox.Size = new System.Drawing.Size(175, 25);
            this.WithholdingTaxTextBox.TabIndex = 14;
            // 
            // WithholdingTaxLabel
            // 
            this.WithholdingTaxLabel.AutoSize = true;
            this.WithholdingTaxLabel.Location = new System.Drawing.Point(6, 21);
            this.WithholdingTaxLabel.Name = "WithholdingTaxLabel";
            this.WithholdingTaxLabel.Size = new System.Drawing.Size(101, 17);
            this.WithholdingTaxLabel.TabIndex = 13;
            this.WithholdingTaxLabel.Text = "Withholding Tax";
            // 
            // AdditionsComboBox
            // 
            this.AdditionsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionsComboBox.Controls.Add(this.ShopRateTextBox);
            this.AdditionsComboBox.Controls.Add(this.ShopRateLabel);
            this.AdditionsComboBox.Location = new System.Drawing.Point(646, 331);
            this.AdditionsComboBox.Name = "AdditionsComboBox";
            this.AdditionsComboBox.Size = new System.Drawing.Size(404, 80);
            this.AdditionsComboBox.TabIndex = 23;
            this.AdditionsComboBox.TabStop = false;
            this.AdditionsComboBox.Text = "Additions";
            // 
            // ShopRateTextBox
            // 
            this.ShopRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShopRateTextBox.Location = new System.Drawing.Point(6, 41);
            this.ShopRateTextBox.Name = "ShopRateTextBox";
            this.ShopRateTextBox.ReadOnly = true;
            this.ShopRateTextBox.Size = new System.Drawing.Size(175, 25);
            this.ShopRateTextBox.TabIndex = 6;
            // 
            // ShopRateLabel
            // 
            this.ShopRateLabel.AutoSize = true;
            this.ShopRateLabel.Location = new System.Drawing.Point(6, 21);
            this.ShopRateLabel.Name = "ShopRateLabel";
            this.ShopRateLabel.Size = new System.Drawing.Size(68, 17);
            this.ShopRateLabel.TabIndex = 2;
            this.ShopRateLabel.Text = "Shop Rate";
            // 
            // DriverPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 746);
            this.Controls.Add(this.AdditionsComboBox);
            this.Controls.Add(this.DeductionsGroupBox);
            this.Controls.Add(this.TimeLogCalculationsGroupBox);
            this.Controls.Add(this.PersonalDetailsGroupBox);
            this.Controls.Add(this.DriverPayrollEmployeeDataGridView);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ChangeCutOffLinkLabel);
            this.Controls.Add(this.CutOffTextBox);
            this.Controls.Add(this.CutOffLabel);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.BranchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverPayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver-Payroll";
            this.Load += new System.EventHandler(this.DriverPayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DriverPayrollEmployeeDataGridView)).EndInit();
            this.PersonalDetailsGroupBox.ResumeLayout(false);
            this.PersonalDetailsGroupBox.PerformLayout();
            this.TimeLogCalculationsGroupBox.ResumeLayout(false);
            this.TimeLogCalculationsGroupBox.PerformLayout();
            this.DeductionsGroupBox.ResumeLayout(false);
            this.DeductionsGroupBox.PerformLayout();
            this.AdditionsComboBox.ResumeLayout(false);
            this.AdditionsComboBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.LinkLabel ChangeCutOffLinkLabel;
        public System.Windows.Forms.TextBox CutOffTextBox;
        private System.Windows.Forms.Label CutOffLabel;
        private System.Windows.Forms.Button GenerateButton;
        public System.Windows.Forms.DataGridView DriverPayrollEmployeeDataGridView;
        private System.Windows.Forms.GroupBox PersonalDetailsGroupBox;
        public System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label PositionLabel;
        public System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        public System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.GroupBox TimeLogCalculationsGroupBox;
        public System.Windows.Forms.TextBox HolidaysTextBox;
        private System.Windows.Forms.Label HolidaysLabel;
        public System.Windows.Forms.TextBox WorkDaysTextBox;
        private System.Windows.Forms.Label WorkDaysLabel;
        private System.Windows.Forms.GroupBox DeductionsGroupBox;
        public System.Windows.Forms.TextBox PhilHealthTextBox;
        private System.Windows.Forms.Label PhilHealthLabel;
        public System.Windows.Forms.TextBox PagibigTextBox;
        private System.Windows.Forms.Label PagibigLabel;
        public System.Windows.Forms.TextBox SssErTextBox;
        private System.Windows.Forms.Label SssErLabel;
        public System.Windows.Forms.TextBox SssEcTextBox;
        private System.Windows.Forms.Label SssEcLabel;
        public System.Windows.Forms.TextBox SssTextBox;
        private System.Windows.Forms.Label SssLabel;
        public System.Windows.Forms.TextBox WithholdingTaxTextBox;
        private System.Windows.Forms.Label WithholdingTaxLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployee_EmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployee_GrossPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployee_TotalDeductionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployee_NetPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverPayrollEmployee_ExtraColumn;
        private System.Windows.Forms.GroupBox AdditionsComboBox;
        public System.Windows.Forms.TextBox ShopRateTextBox;
        private System.Windows.Forms.Label ShopRateLabel;
    }
}