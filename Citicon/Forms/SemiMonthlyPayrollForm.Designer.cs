namespace Citicon.Forms
{
    partial class SemiMonthlyPayrollForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemiMonthlyPayrollForm));
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.CutOffLabel = new System.Windows.Forms.Label();
            this.CutOffBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CutOffToLabel = new System.Windows.Forms.Label();
            this.CutOffEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SemiMonthlyPayrollEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.SemiMonthlyPayrollEmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_EmployeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_DailyRateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_BasicPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_GrossPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_NetPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemiMonthlyPayrollEmployee_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.TimeLogCalculationsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpecialHolidayOvertimeWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.SpecialHolidayOvertimeWorkingHoursLabel = new System.Windows.Forms.Label();
            this.SpecialHolidayWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.SpecialHolidayWorkingHoursLabel = new System.Windows.Forms.Label();
            this.NightDifferentialWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.NightDifferentialWorkingHoursLabel = new System.Windows.Forms.Label();
            this.SundayWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.SundayWorkingHoursLabel = new System.Windows.Forms.Label();
            this.RegularOvertimeWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.RegularOvertimeWorkingHoursLabel = new System.Windows.Forms.Label();
            this.RegularWorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.RegularWorkingHoursLabel = new System.Windows.Forms.Label();
            this.EarningsGroupBox = new System.Windows.Forms.GroupBox();
            this.OvertimeAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.OvertimeAllowanceLabel = new System.Windows.Forms.Label();
            this.AllowanceTextBox = new System.Windows.Forms.TextBox();
            this.AllowanceLabel = new System.Windows.Forms.Label();
            this.BasicPayTextBox = new System.Windows.Forms.TextBox();
            this.BasicPayLabel = new System.Windows.Forms.Label();
            this.DailyRateTextBox = new System.Windows.Forms.TextBox();
            this.DailyRateLabel = new System.Windows.Forms.Label();
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
            this.SavePrintButton = new System.Windows.Forms.Button();
            this.ViewTimeLogsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SemiMonthlyPayrollEmployeesDataGridView)).BeginInit();
            this.PersonalDetailsGroupBox.SuspendLayout();
            this.TimeLogCalculationsGroupBox.SuspendLayout();
            this.EarningsGroupBox.SuspendLayout();
            this.DeductionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(13, 13);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(47, 17);
            this.BranchLabel.TabIndex = 0;
            this.BranchLabel.Text = "Branch";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(16, 34);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(197, 25);
            this.BranchComboBox.TabIndex = 1;
            // 
            // CutOffLabel
            // 
            this.CutOffLabel.AutoSize = true;
            this.CutOffLabel.Location = new System.Drawing.Point(216, 13);
            this.CutOffLabel.Name = "CutOffLabel";
            this.CutOffLabel.Size = new System.Drawing.Size(50, 17);
            this.CutOffLabel.TabIndex = 2;
            this.CutOffLabel.Text = "Cut-Off";
            // 
            // CutOffBeginDateTimePicker
            // 
            this.CutOffBeginDateTimePicker.CustomFormat = "MMMM d, yyyy";
            this.CutOffBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CutOffBeginDateTimePicker.Location = new System.Drawing.Point(219, 34);
            this.CutOffBeginDateTimePicker.Name = "CutOffBeginDateTimePicker";
            this.CutOffBeginDateTimePicker.Size = new System.Drawing.Size(197, 25);
            this.CutOffBeginDateTimePicker.TabIndex = 3;
            // 
            // CutOffToLabel
            // 
            this.CutOffToLabel.AutoSize = true;
            this.CutOffToLabel.Location = new System.Drawing.Point(425, 40);
            this.CutOffToLabel.Name = "CutOffToLabel";
            this.CutOffToLabel.Size = new System.Drawing.Size(20, 17);
            this.CutOffToLabel.TabIndex = 4;
            this.CutOffToLabel.Text = "to";
            // 
            // CutOffEndDateTimePicker
            // 
            this.CutOffEndDateTimePicker.CustomFormat = "MMMM d, yyyy";
            this.CutOffEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CutOffEndDateTimePicker.Location = new System.Drawing.Point(451, 34);
            this.CutOffEndDateTimePicker.Name = "CutOffEndDateTimePicker";
            this.CutOffEndDateTimePicker.Size = new System.Drawing.Size(197, 25);
            this.CutOffEndDateTimePicker.TabIndex = 5;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Red;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Location = new System.Drawing.Point(654, 25);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 40);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SemiMonthlyPayrollEmployeesDataGridView
            // 
            this.SemiMonthlyPayrollEmployeesDataGridView.AllowUserToAddRows = false;
            this.SemiMonthlyPayrollEmployeesDataGridView.AllowUserToDeleteRows = false;
            this.SemiMonthlyPayrollEmployeesDataGridView.AllowUserToResizeColumns = false;
            this.SemiMonthlyPayrollEmployeesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SemiMonthlyPayrollEmployeesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SemiMonthlyPayrollEmployeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SemiMonthlyPayrollEmployeesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SemiMonthlyPayrollEmployeesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SemiMonthlyPayrollEmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.SemiMonthlyPayrollEmployeesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SemiMonthlyPayrollEmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SemiMonthlyPayrollEmployeesDataGridView.ColumnHeadersHeight = 50;
            this.SemiMonthlyPayrollEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SemiMonthlyPayrollEmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SemiMonthlyPayrollEmployeeColumn,
            this.SemiMonthlyPayrollEmployee_EmployeeColumn,
            this.SemiMonthlyPayrollEmployee_DailyRateColumn,
            this.SemiMonthlyPayrollEmployee_BasicPayColumn,
            this.SemiMonthlyPayrollEmployee_GrossPayColumn,
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn,
            this.SemiMonthlyPayrollEmployee_NetPayColumn,
            this.SemiMonthlyPayrollEmployee_ExtraColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SemiMonthlyPayrollEmployeesDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.SemiMonthlyPayrollEmployeesDataGridView.EnableHeadersVisualStyles = false;
            this.SemiMonthlyPayrollEmployeesDataGridView.GridColor = System.Drawing.Color.Red;
            this.SemiMonthlyPayrollEmployeesDataGridView.Location = new System.Drawing.Point(16, 71);
            this.SemiMonthlyPayrollEmployeesDataGridView.Name = "SemiMonthlyPayrollEmployeesDataGridView";
            this.SemiMonthlyPayrollEmployeesDataGridView.ReadOnly = true;
            this.SemiMonthlyPayrollEmployeesDataGridView.RowHeadersVisible = false;
            this.SemiMonthlyPayrollEmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SemiMonthlyPayrollEmployeesDataGridView.Size = new System.Drawing.Size(807, 716);
            this.SemiMonthlyPayrollEmployeesDataGridView.TabIndex = 7;
            // 
            // SemiMonthlyPayrollEmployeeColumn
            // 
            this.SemiMonthlyPayrollEmployeeColumn.HeaderText = "Semi-Monthly Payroll Employee";
            this.SemiMonthlyPayrollEmployeeColumn.Name = "SemiMonthlyPayrollEmployeeColumn";
            this.SemiMonthlyPayrollEmployeeColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployeeColumn.Visible = false;
            // 
            // SemiMonthlyPayrollEmployee_EmployeeColumn
            // 
            this.SemiMonthlyPayrollEmployee_EmployeeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SemiMonthlyPayrollEmployee_EmployeeColumn.HeaderText = "Employee";
            this.SemiMonthlyPayrollEmployee_EmployeeColumn.Name = "SemiMonthlyPayrollEmployee_EmployeeColumn";
            this.SemiMonthlyPayrollEmployee_EmployeeColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_EmployeeColumn.Width = 89;
            // 
            // SemiMonthlyPayrollEmployee_DailyRateColumn
            // 
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.HeaderText = "Daily Rate";
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.Name = "SemiMonthlyPayrollEmployee_DailyRateColumn";
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_DailyRateColumn.Width = 83;
            // 
            // SemiMonthlyPayrollEmployee_BasicPayColumn
            // 
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "#,##0.00";
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.HeaderText = "Basic Pay";
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.Name = "SemiMonthlyPayrollEmployee_BasicPayColumn";
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_BasicPayColumn.Width = 78;
            // 
            // SemiMonthlyPayrollEmployee_GrossPayColumn
            // 
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "#,##0.00";
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.HeaderText = "Gross Pay";
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.Name = "SemiMonthlyPayrollEmployee_GrossPayColumn";
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_GrossPayColumn.Width = 83;
            // 
            // SemiMonthlyPayrollEmployee_TotalDeductionColumn
            // 
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "#,##0.00";
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.HeaderText = "Total Deduction";
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.Name = "SemiMonthlyPayrollEmployee_TotalDeductionColumn";
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_TotalDeductionColumn.Width = 113;
            // 
            // SemiMonthlyPayrollEmployee_NetPayColumn
            // 
            this.SemiMonthlyPayrollEmployee_NetPayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "#,##0.00";
            this.SemiMonthlyPayrollEmployee_NetPayColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.SemiMonthlyPayrollEmployee_NetPayColumn.HeaderText = "Net Pay";
            this.SemiMonthlyPayrollEmployee_NetPayColumn.Name = "SemiMonthlyPayrollEmployee_NetPayColumn";
            this.SemiMonthlyPayrollEmployee_NetPayColumn.ReadOnly = true;
            this.SemiMonthlyPayrollEmployee_NetPayColumn.Width = 53;
            // 
            // SemiMonthlyPayrollEmployee_ExtraColumn
            // 
            this.SemiMonthlyPayrollEmployee_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SemiMonthlyPayrollEmployee_ExtraColumn.HeaderText = "";
            this.SemiMonthlyPayrollEmployee_ExtraColumn.Name = "SemiMonthlyPayrollEmployee_ExtraColumn";
            this.SemiMonthlyPayrollEmployee_ExtraColumn.ReadOnly = true;
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
            this.PersonalDetailsGroupBox.Location = new System.Drawing.Point(829, 71);
            this.PersonalDetailsGroupBox.Name = "PersonalDetailsGroupBox";
            this.PersonalDetailsGroupBox.Size = new System.Drawing.Size(404, 178);
            this.PersonalDetailsGroupBox.TabIndex = 8;
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
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SpecialHolidayOvertimeWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SpecialHolidayOvertimeWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SpecialHolidayWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SpecialHolidayWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.NightDifferentialWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.NightDifferentialWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SundayWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.SundayWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.RegularOvertimeWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.RegularOvertimeWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.RegularWorkingHoursTextBox);
            this.TimeLogCalculationsGroupBox.Controls.Add(this.RegularWorkingHoursLabel);
            this.TimeLogCalculationsGroupBox.Location = new System.Drawing.Point(829, 255);
            this.TimeLogCalculationsGroupBox.Name = "TimeLogCalculationsGroupBox";
            this.TimeLogCalculationsGroupBox.Size = new System.Drawing.Size(404, 175);
            this.TimeLogCalculationsGroupBox.TabIndex = 9;
            this.TimeLogCalculationsGroupBox.TabStop = false;
            this.TimeLogCalculationsGroupBox.Text = "Time-Log Results";
            // 
            // SpecialHolidayOvertimeWorkingHoursTextBox
            // 
            this.SpecialHolidayOvertimeWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialHolidayOvertimeWorkingHoursTextBox.Location = new System.Drawing.Point(187, 137);
            this.SpecialHolidayOvertimeWorkingHoursTextBox.Name = "SpecialHolidayOvertimeWorkingHoursTextBox";
            this.SpecialHolidayOvertimeWorkingHoursTextBox.ReadOnly = true;
            this.SpecialHolidayOvertimeWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.SpecialHolidayOvertimeWorkingHoursTextBox.TabIndex = 16;
            // 
            // SpecialHolidayOvertimeWorkingHoursLabel
            // 
            this.SpecialHolidayOvertimeWorkingHoursLabel.AutoSize = true;
            this.SpecialHolidayOvertimeWorkingHoursLabel.Location = new System.Drawing.Point(184, 117);
            this.SpecialHolidayOvertimeWorkingHoursLabel.Name = "SpecialHolidayOvertimeWorkingHoursLabel";
            this.SpecialHolidayOvertimeWorkingHoursLabel.Size = new System.Drawing.Size(138, 17);
            this.SpecialHolidayOvertimeWorkingHoursLabel.TabIndex = 15;
            this.SpecialHolidayOvertimeWorkingHoursLabel.Text = "Special Holidays (O.T.)";
            // 
            // SpecialHolidayWorkingHoursTextBox
            // 
            this.SpecialHolidayWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialHolidayWorkingHoursTextBox.Location = new System.Drawing.Point(6, 137);
            this.SpecialHolidayWorkingHoursTextBox.Name = "SpecialHolidayWorkingHoursTextBox";
            this.SpecialHolidayWorkingHoursTextBox.ReadOnly = true;
            this.SpecialHolidayWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.SpecialHolidayWorkingHoursTextBox.TabIndex = 14;
            // 
            // SpecialHolidayWorkingHoursLabel
            // 
            this.SpecialHolidayWorkingHoursLabel.AutoSize = true;
            this.SpecialHolidayWorkingHoursLabel.Location = new System.Drawing.Point(6, 117);
            this.SpecialHolidayWorkingHoursLabel.Name = "SpecialHolidayWorkingHoursLabel";
            this.SpecialHolidayWorkingHoursLabel.Size = new System.Drawing.Size(103, 17);
            this.SpecialHolidayWorkingHoursLabel.TabIndex = 13;
            this.SpecialHolidayWorkingHoursLabel.Text = "Special Holidays";
            // 
            // NightDifferentialWorkingHoursTextBox
            // 
            this.NightDifferentialWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NightDifferentialWorkingHoursTextBox.Location = new System.Drawing.Point(187, 89);
            this.NightDifferentialWorkingHoursTextBox.Name = "NightDifferentialWorkingHoursTextBox";
            this.NightDifferentialWorkingHoursTextBox.ReadOnly = true;
            this.NightDifferentialWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.NightDifferentialWorkingHoursTextBox.TabIndex = 12;
            // 
            // NightDifferentialWorkingHoursLabel
            // 
            this.NightDifferentialWorkingHoursLabel.AutoSize = true;
            this.NightDifferentialWorkingHoursLabel.Location = new System.Drawing.Point(184, 69);
            this.NightDifferentialWorkingHoursLabel.Name = "NightDifferentialWorkingHoursLabel";
            this.NightDifferentialWorkingHoursLabel.Size = new System.Drawing.Size(113, 17);
            this.NightDifferentialWorkingHoursLabel.TabIndex = 11;
            this.NightDifferentialWorkingHoursLabel.Text = "Night Differentials";
            // 
            // SundayWorkingHoursTextBox
            // 
            this.SundayWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SundayWorkingHoursTextBox.Location = new System.Drawing.Point(6, 89);
            this.SundayWorkingHoursTextBox.Name = "SundayWorkingHoursTextBox";
            this.SundayWorkingHoursTextBox.ReadOnly = true;
            this.SundayWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.SundayWorkingHoursTextBox.TabIndex = 10;
            // 
            // SundayWorkingHoursLabel
            // 
            this.SundayWorkingHoursLabel.AutoSize = true;
            this.SundayWorkingHoursLabel.Location = new System.Drawing.Point(6, 69);
            this.SundayWorkingHoursLabel.Name = "SundayWorkingHoursLabel";
            this.SundayWorkingHoursLabel.Size = new System.Drawing.Size(56, 17);
            this.SundayWorkingHoursLabel.TabIndex = 9;
            this.SundayWorkingHoursLabel.Text = "Sundays";
            // 
            // RegularOvertimeWorkingHoursTextBox
            // 
            this.RegularOvertimeWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegularOvertimeWorkingHoursTextBox.Location = new System.Drawing.Point(187, 41);
            this.RegularOvertimeWorkingHoursTextBox.Name = "RegularOvertimeWorkingHoursTextBox";
            this.RegularOvertimeWorkingHoursTextBox.ReadOnly = true;
            this.RegularOvertimeWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.RegularOvertimeWorkingHoursTextBox.TabIndex = 8;
            // 
            // RegularOvertimeWorkingHoursLabel
            // 
            this.RegularOvertimeWorkingHoursLabel.AutoSize = true;
            this.RegularOvertimeWorkingHoursLabel.Location = new System.Drawing.Point(184, 21);
            this.RegularOvertimeWorkingHoursLabel.Name = "RegularOvertimeWorkingHoursLabel";
            this.RegularOvertimeWorkingHoursLabel.Size = new System.Drawing.Size(80, 17);
            this.RegularOvertimeWorkingHoursLabel.TabIndex = 7;
            this.RegularOvertimeWorkingHoursLabel.Text = "Regular O.T.";
            // 
            // RegularWorkingHoursTextBox
            // 
            this.RegularWorkingHoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegularWorkingHoursTextBox.Location = new System.Drawing.Point(6, 41);
            this.RegularWorkingHoursTextBox.Name = "RegularWorkingHoursTextBox";
            this.RegularWorkingHoursTextBox.ReadOnly = true;
            this.RegularWorkingHoursTextBox.Size = new System.Drawing.Size(175, 25);
            this.RegularWorkingHoursTextBox.TabIndex = 6;
            // 
            // RegularWorkingHoursLabel
            // 
            this.RegularWorkingHoursLabel.AutoSize = true;
            this.RegularWorkingHoursLabel.Location = new System.Drawing.Point(6, 21);
            this.RegularWorkingHoursLabel.Name = "RegularWorkingHoursLabel";
            this.RegularWorkingHoursLabel.Size = new System.Drawing.Size(53, 17);
            this.RegularWorkingHoursLabel.TabIndex = 2;
            this.RegularWorkingHoursLabel.Text = "Regular";
            // 
            // EarningsGroupBox
            // 
            this.EarningsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EarningsGroupBox.Controls.Add(this.OvertimeAllowanceTextBox);
            this.EarningsGroupBox.Controls.Add(this.OvertimeAllowanceLabel);
            this.EarningsGroupBox.Controls.Add(this.AllowanceTextBox);
            this.EarningsGroupBox.Controls.Add(this.AllowanceLabel);
            this.EarningsGroupBox.Controls.Add(this.BasicPayTextBox);
            this.EarningsGroupBox.Controls.Add(this.BasicPayLabel);
            this.EarningsGroupBox.Controls.Add(this.DailyRateTextBox);
            this.EarningsGroupBox.Controls.Add(this.DailyRateLabel);
            this.EarningsGroupBox.Location = new System.Drawing.Point(829, 436);
            this.EarningsGroupBox.Name = "EarningsGroupBox";
            this.EarningsGroupBox.Size = new System.Drawing.Size(404, 125);
            this.EarningsGroupBox.TabIndex = 10;
            this.EarningsGroupBox.TabStop = false;
            this.EarningsGroupBox.Text = "Earnings";
            // 
            // OvertimeAllowanceTextBox
            // 
            this.OvertimeAllowanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OvertimeAllowanceTextBox.Location = new System.Drawing.Point(187, 89);
            this.OvertimeAllowanceTextBox.Name = "OvertimeAllowanceTextBox";
            this.OvertimeAllowanceTextBox.Size = new System.Drawing.Size(175, 25);
            this.OvertimeAllowanceTextBox.TabIndex = 14;
            // 
            // OvertimeAllowanceLabel
            // 
            this.OvertimeAllowanceLabel.AutoSize = true;
            this.OvertimeAllowanceLabel.Location = new System.Drawing.Point(187, 69);
            this.OvertimeAllowanceLabel.Name = "OvertimeAllowanceLabel";
            this.OvertimeAllowanceLabel.Size = new System.Drawing.Size(123, 17);
            this.OvertimeAllowanceLabel.TabIndex = 13;
            this.OvertimeAllowanceLabel.Text = "Overtime Allowance";
            // 
            // AllowanceTextBox
            // 
            this.AllowanceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowanceTextBox.Location = new System.Drawing.Point(6, 89);
            this.AllowanceTextBox.Name = "AllowanceTextBox";
            this.AllowanceTextBox.Size = new System.Drawing.Size(175, 25);
            this.AllowanceTextBox.TabIndex = 12;
            // 
            // AllowanceLabel
            // 
            this.AllowanceLabel.AutoSize = true;
            this.AllowanceLabel.Location = new System.Drawing.Point(6, 69);
            this.AllowanceLabel.Name = "AllowanceLabel";
            this.AllowanceLabel.Size = new System.Drawing.Size(66, 17);
            this.AllowanceLabel.TabIndex = 11;
            this.AllowanceLabel.Text = "Allowance";
            // 
            // BasicPayTextBox
            // 
            this.BasicPayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasicPayTextBox.Location = new System.Drawing.Point(187, 41);
            this.BasicPayTextBox.Name = "BasicPayTextBox";
            this.BasicPayTextBox.ReadOnly = true;
            this.BasicPayTextBox.Size = new System.Drawing.Size(175, 25);
            this.BasicPayTextBox.TabIndex = 10;
            // 
            // BasicPayLabel
            // 
            this.BasicPayLabel.AutoSize = true;
            this.BasicPayLabel.Location = new System.Drawing.Point(187, 21);
            this.BasicPayLabel.Name = "BasicPayLabel";
            this.BasicPayLabel.Size = new System.Drawing.Size(61, 17);
            this.BasicPayLabel.TabIndex = 9;
            this.BasicPayLabel.Text = "Basic Pay";
            // 
            // DailyRateTextBox
            // 
            this.DailyRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DailyRateTextBox.Location = new System.Drawing.Point(6, 41);
            this.DailyRateTextBox.Name = "DailyRateTextBox";
            this.DailyRateTextBox.ReadOnly = true;
            this.DailyRateTextBox.Size = new System.Drawing.Size(175, 25);
            this.DailyRateTextBox.TabIndex = 8;
            // 
            // DailyRateLabel
            // 
            this.DailyRateLabel.AutoSize = true;
            this.DailyRateLabel.Location = new System.Drawing.Point(6, 21);
            this.DailyRateLabel.Name = "DailyRateLabel";
            this.DailyRateLabel.Size = new System.Drawing.Size(66, 17);
            this.DailyRateLabel.TabIndex = 7;
            this.DailyRateLabel.Text = "Daily Rate";
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
            this.DeductionsGroupBox.Location = new System.Drawing.Point(829, 567);
            this.DeductionsGroupBox.Name = "DeductionsGroupBox";
            this.DeductionsGroupBox.Size = new System.Drawing.Size(404, 174);
            this.DeductionsGroupBox.TabIndex = 11;
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
            // SavePrintButton
            // 
            this.SavePrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePrintButton.BackColor = System.Drawing.Color.Red;
            this.SavePrintButton.FlatAppearance.BorderSize = 0;
            this.SavePrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePrintButton.ForeColor = System.Drawing.Color.White;
            this.SavePrintButton.Location = new System.Drawing.Point(1108, 747);
            this.SavePrintButton.Name = "SavePrintButton";
            this.SavePrintButton.Size = new System.Drawing.Size(125, 40);
            this.SavePrintButton.TabIndex = 12;
            this.SavePrintButton.Text = "Save && Print";
            this.SavePrintButton.UseVisualStyleBackColor = false;
            this.SavePrintButton.Click += new System.EventHandler(this.SavePrintButton_Click);
            // 
            // ViewTimeLogsButton
            // 
            this.ViewTimeLogsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewTimeLogsButton.BackColor = System.Drawing.Color.Red;
            this.ViewTimeLogsButton.FlatAppearance.BorderSize = 0;
            this.ViewTimeLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTimeLogsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTimeLogsButton.ForeColor = System.Drawing.Color.White;
            this.ViewTimeLogsButton.Location = new System.Drawing.Point(977, 747);
            this.ViewTimeLogsButton.Name = "ViewTimeLogsButton";
            this.ViewTimeLogsButton.Size = new System.Drawing.Size(125, 40);
            this.ViewTimeLogsButton.TabIndex = 13;
            this.ViewTimeLogsButton.Text = "View Time-Logs";
            this.ViewTimeLogsButton.UseVisualStyleBackColor = false;
            this.ViewTimeLogsButton.Click += new System.EventHandler(this.ViewTimeLogsButton_Click);
            // 
            // SemiMonthlyPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 799);
            this.Controls.Add(this.ViewTimeLogsButton);
            this.Controls.Add(this.SavePrintButton);
            this.Controls.Add(this.DeductionsGroupBox);
            this.Controls.Add(this.EarningsGroupBox);
            this.Controls.Add(this.TimeLogCalculationsGroupBox);
            this.Controls.Add(this.PersonalDetailsGroupBox);
            this.Controls.Add(this.SemiMonthlyPayrollEmployeesDataGridView);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.CutOffEndDateTimePicker);
            this.Controls.Add(this.CutOffToLabel);
            this.Controls.Add(this.CutOffBeginDateTimePicker);
            this.Controls.Add(this.CutOffLabel);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.BranchLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SemiMonthlyPayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semi-Monthly Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SemiMonthlyPayrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemiMonthlyPayrollEmployeesDataGridView)).EndInit();
            this.PersonalDetailsGroupBox.ResumeLayout(false);
            this.PersonalDetailsGroupBox.PerformLayout();
            this.TimeLogCalculationsGroupBox.ResumeLayout(false);
            this.TimeLogCalculationsGroupBox.PerformLayout();
            this.EarningsGroupBox.ResumeLayout(false);
            this.EarningsGroupBox.PerformLayout();
            this.DeductionsGroupBox.ResumeLayout(false);
            this.DeductionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BranchLabel;
        public System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.Label CutOffLabel;
        public System.Windows.Forms.DateTimePicker CutOffBeginDateTimePicker;
        private System.Windows.Forms.Label CutOffToLabel;
        public System.Windows.Forms.DateTimePicker CutOffEndDateTimePicker;
        private System.Windows.Forms.Button GenerateButton;
        public System.Windows.Forms.DataGridView SemiMonthlyPayrollEmployeesDataGridView;
        private System.Windows.Forms.GroupBox PersonalDetailsGroupBox;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.GroupBox TimeLogCalculationsGroupBox;
        private System.Windows.Forms.Label RegularWorkingHoursLabel;
        private System.Windows.Forms.Label RegularOvertimeWorkingHoursLabel;
        private System.Windows.Forms.Label NightDifferentialWorkingHoursLabel;
        private System.Windows.Forms.Label SundayWorkingHoursLabel;
        private System.Windows.Forms.Label SpecialHolidayOvertimeWorkingHoursLabel;
        private System.Windows.Forms.Label SpecialHolidayWorkingHoursLabel;
        private System.Windows.Forms.GroupBox EarningsGroupBox;
        private System.Windows.Forms.Label DailyRateLabel;
        private System.Windows.Forms.Label OvertimeAllowanceLabel;
        private System.Windows.Forms.Label AllowanceLabel;
        private System.Windows.Forms.Label BasicPayLabel;
        private System.Windows.Forms.GroupBox DeductionsGroupBox;
        public System.Windows.Forms.TextBox EmployeeNameTextBox;
        public System.Windows.Forms.TextBox DepartmentTextBox;
        public System.Windows.Forms.TextBox PositionTextBox;
        public System.Windows.Forms.TextBox RegularOvertimeWorkingHoursTextBox;
        public System.Windows.Forms.TextBox RegularWorkingHoursTextBox;
        public System.Windows.Forms.TextBox NightDifferentialWorkingHoursTextBox;
        public System.Windows.Forms.TextBox SundayWorkingHoursTextBox;
        public System.Windows.Forms.TextBox SpecialHolidayOvertimeWorkingHoursTextBox;
        public System.Windows.Forms.TextBox SpecialHolidayWorkingHoursTextBox;
        public System.Windows.Forms.TextBox DailyRateTextBox;
        public System.Windows.Forms.TextBox OvertimeAllowanceTextBox;
        public System.Windows.Forms.TextBox AllowanceTextBox;
        public System.Windows.Forms.TextBox BasicPayTextBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_EmployeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_DailyRateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_BasicPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_GrossPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_TotalDeductionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_NetPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SemiMonthlyPayrollEmployee_ExtraColumn;
        private System.Windows.Forms.Button SavePrintButton;
        private System.Windows.Forms.Button ViewTimeLogsButton;
    }
}