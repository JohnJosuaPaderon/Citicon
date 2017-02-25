namespace Citicon.PayrollIntegration.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemiMonthlyPayrollForm));
            this.gbxSelectRange = new System.Windows.Forms.GroupBox();
            this.dtpSelectRange_To = new System.Windows.Forms.DateTimePicker();
            this.lblSelectRange_To = new System.Windows.Forms.Label();
            this.dtpSelectRange_From = new System.Windows.Forms.DateTimePicker();
            this.lblSelectRange_From = new System.Windows.Forms.Label();
            this.btnGeneratePayroll = new System.Windows.Forms.Button();
            this.dgvPayrollItems = new System.Windows.Forms.DataGridView();
            this.colPayrollItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_VacationLeaveSickLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_BasicPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_RegularWorkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_NightDifferentialHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_SundayHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_SpecialHolidayHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayrollItem_SpecialHolidayOvertimeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectPLant = new System.Windows.Forms.Label();
            this.cmbxSelectPlant = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbxSelectRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSelectRange
            // 
            this.gbxSelectRange.Controls.Add(this.dtpSelectRange_To);
            this.gbxSelectRange.Controls.Add(this.lblSelectRange_To);
            this.gbxSelectRange.Controls.Add(this.dtpSelectRange_From);
            this.gbxSelectRange.Controls.Add(this.lblSelectRange_From);
            this.gbxSelectRange.Location = new System.Drawing.Point(12, 12);
            this.gbxSelectRange.Name = "gbxSelectRange";
            this.gbxSelectRange.Size = new System.Drawing.Size(424, 73);
            this.gbxSelectRange.TabIndex = 0;
            this.gbxSelectRange.TabStop = false;
            this.gbxSelectRange.Text = "Select Range";
            // 
            // dtpSelectRange_To
            // 
            this.dtpSelectRange_To.CustomFormat = "MMMM dd, yyyy";
            this.dtpSelectRange_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectRange_To.Location = new System.Drawing.Point(212, 37);
            this.dtpSelectRange_To.Name = "dtpSelectRange_To";
            this.dtpSelectRange_To.Size = new System.Drawing.Size(200, 23);
            this.dtpSelectRange_To.TabIndex = 3;
            // 
            // lblSelectRange_To
            // 
            this.lblSelectRange_To.AutoSize = true;
            this.lblSelectRange_To.Location = new System.Drawing.Point(212, 19);
            this.lblSelectRange_To.Name = "lblSelectRange_To";
            this.lblSelectRange_To.Size = new System.Drawing.Size(20, 15);
            this.lblSelectRange_To.TabIndex = 2;
            this.lblSelectRange_To.Text = "To";
            // 
            // dtpSelectRange_From
            // 
            this.dtpSelectRange_From.CustomFormat = "MMMM dd, yyyy";
            this.dtpSelectRange_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectRange_From.Location = new System.Drawing.Point(6, 37);
            this.dtpSelectRange_From.Name = "dtpSelectRange_From";
            this.dtpSelectRange_From.Size = new System.Drawing.Size(200, 23);
            this.dtpSelectRange_From.TabIndex = 1;
            // 
            // lblSelectRange_From
            // 
            this.lblSelectRange_From.AutoSize = true;
            this.lblSelectRange_From.Location = new System.Drawing.Point(6, 19);
            this.lblSelectRange_From.Name = "lblSelectRange_From";
            this.lblSelectRange_From.Size = new System.Drawing.Size(35, 15);
            this.lblSelectRange_From.TabIndex = 0;
            this.lblSelectRange_From.Text = "From";
            // 
            // btnGeneratePayroll
            // 
            this.btnGeneratePayroll.BackColor = System.Drawing.Color.Red;
            this.btnGeneratePayroll.FlatAppearance.BorderSize = 0;
            this.btnGeneratePayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePayroll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePayroll.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePayroll.Location = new System.Drawing.Point(682, 35);
            this.btnGeneratePayroll.Name = "btnGeneratePayroll";
            this.btnGeneratePayroll.Size = new System.Drawing.Size(125, 50);
            this.btnGeneratePayroll.TabIndex = 1;
            this.btnGeneratePayroll.Text = "Generate Payroll";
            this.btnGeneratePayroll.UseVisualStyleBackColor = false;
            this.btnGeneratePayroll.Click += new System.EventHandler(this.btnGeneratePayroll_Click);
            // 
            // dgvPayrollItems
            // 
            this.dgvPayrollItems.AllowUserToAddRows = false;
            this.dgvPayrollItems.AllowUserToDeleteRows = false;
            this.dgvPayrollItems.AllowUserToResizeColumns = false;
            this.dgvPayrollItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPayrollItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayrollItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayrollItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayrollItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayrollItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayrollItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPayrollItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayrollItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayrollItems.ColumnHeadersHeight = 50;
            this.dgvPayrollItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayrollItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPayrollItem,
            this.colPayrollItem_Employee,
            this.colPayrollItem_VacationLeaveSickLeave,
            this.colPayrollItem_Rate,
            this.colPayrollItem_BasicPay,
            this.colPayrollItem_RegularWorkingHours,
            this.colPayrollItem_NightDifferentialHours,
            this.colPayrollItem_SundayHours,
            this.colPayrollItem_SpecialHolidayHours,
            this.colPayrollItem_SpecialHolidayOvertimeHours});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayrollItems.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPayrollItems.EnableHeadersVisualStyles = false;
            this.dgvPayrollItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPayrollItems.Location = new System.Drawing.Point(12, 91);
            this.dgvPayrollItems.Name = "dgvPayrollItems";
            this.dgvPayrollItems.ReadOnly = true;
            this.dgvPayrollItems.RowHeadersVisible = false;
            this.dgvPayrollItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayrollItems.Size = new System.Drawing.Size(1192, 590);
            this.dgvPayrollItems.TabIndex = 2;
            // 
            // colPayrollItem
            // 
            this.colPayrollItem.HeaderText = "Payroll Item";
            this.colPayrollItem.Name = "colPayrollItem";
            this.colPayrollItem.ReadOnly = true;
            this.colPayrollItem.Visible = false;
            this.colPayrollItem.Width = 87;
            // 
            // colPayrollItem_Employee
            // 
            this.colPayrollItem_Employee.HeaderText = "Employee";
            this.colPayrollItem_Employee.MinimumWidth = 150;
            this.colPayrollItem_Employee.Name = "colPayrollItem_Employee";
            this.colPayrollItem_Employee.ReadOnly = true;
            this.colPayrollItem_Employee.Width = 150;
            // 
            // colPayrollItem_VacationLeaveSickLeave
            // 
            this.colPayrollItem_VacationLeaveSickLeave.HeaderText = "VL/SL";
            this.colPayrollItem_VacationLeaveSickLeave.MinimumWidth = 100;
            this.colPayrollItem_VacationLeaveSickLeave.Name = "colPayrollItem_VacationLeaveSickLeave";
            this.colPayrollItem_VacationLeaveSickLeave.ReadOnly = true;
            // 
            // colPayrollItem_Rate
            // 
            dataGridViewCellStyle3.Format = "##,##0.00";
            dataGridViewCellStyle3.NullValue = null;
            this.colPayrollItem_Rate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPayrollItem_Rate.HeaderText = "Rate";
            this.colPayrollItem_Rate.MinimumWidth = 100;
            this.colPayrollItem_Rate.Name = "colPayrollItem_Rate";
            this.colPayrollItem_Rate.ReadOnly = true;
            // 
            // colPayrollItem_BasicPay
            // 
            dataGridViewCellStyle4.Format = "##,##0.00";
            this.colPayrollItem_BasicPay.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPayrollItem_BasicPay.HeaderText = "Basic Pay";
            this.colPayrollItem_BasicPay.MinimumWidth = 100;
            this.colPayrollItem_BasicPay.Name = "colPayrollItem_BasicPay";
            this.colPayrollItem_BasicPay.ReadOnly = true;
            // 
            // colPayrollItem_RegularWorkingHours
            // 
            dataGridViewCellStyle5.Format = "#,##0.##";
            this.colPayrollItem_RegularWorkingHours.DefaultCellStyle = dataGridViewCellStyle5;
            this.colPayrollItem_RegularWorkingHours.HeaderText = "Reg. Hrs.";
            this.colPayrollItem_RegularWorkingHours.MinimumWidth = 100;
            this.colPayrollItem_RegularWorkingHours.Name = "colPayrollItem_RegularWorkingHours";
            this.colPayrollItem_RegularWorkingHours.ReadOnly = true;
            // 
            // colPayrollItem_NightDifferentialHours
            // 
            dataGridViewCellStyle6.Format = "#,##0.##";
            this.colPayrollItem_NightDifferentialHours.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPayrollItem_NightDifferentialHours.HeaderText = "ND Hrs.";
            this.colPayrollItem_NightDifferentialHours.MinimumWidth = 100;
            this.colPayrollItem_NightDifferentialHours.Name = "colPayrollItem_NightDifferentialHours";
            this.colPayrollItem_NightDifferentialHours.ReadOnly = true;
            // 
            // colPayrollItem_SundayHours
            // 
            dataGridViewCellStyle7.Format = "#,##0.##";
            this.colPayrollItem_SundayHours.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPayrollItem_SundayHours.HeaderText = "Sun. Hrs.";
            this.colPayrollItem_SundayHours.MinimumWidth = 100;
            this.colPayrollItem_SundayHours.Name = "colPayrollItem_SundayHours";
            this.colPayrollItem_SundayHours.ReadOnly = true;
            // 
            // colPayrollItem_SpecialHolidayHours
            // 
            dataGridViewCellStyle8.Format = "#,##0.##";
            this.colPayrollItem_SpecialHolidayHours.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPayrollItem_SpecialHolidayHours.HeaderText = "Spcl. Hol. Hrs.";
            this.colPayrollItem_SpecialHolidayHours.MinimumWidth = 100;
            this.colPayrollItem_SpecialHolidayHours.Name = "colPayrollItem_SpecialHolidayHours";
            this.colPayrollItem_SpecialHolidayHours.ReadOnly = true;
            // 
            // colPayrollItem_SpecialHolidayOvertimeHours
            // 
            dataGridViewCellStyle9.Format = "#,##0.##";
            this.colPayrollItem_SpecialHolidayOvertimeHours.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPayrollItem_SpecialHolidayOvertimeHours.HeaderText = "Spcl. Hol. OT Hrs.";
            this.colPayrollItem_SpecialHolidayOvertimeHours.MinimumWidth = 100;
            this.colPayrollItem_SpecialHolidayOvertimeHours.Name = "colPayrollItem_SpecialHolidayOvertimeHours";
            this.colPayrollItem_SpecialHolidayOvertimeHours.ReadOnly = true;
            // 
            // lblSelectPLant
            // 
            this.lblSelectPLant.AutoSize = true;
            this.lblSelectPLant.Location = new System.Drawing.Point(442, 31);
            this.lblSelectPLant.Name = "lblSelectPLant";
            this.lblSelectPLant.Size = new System.Drawing.Size(68, 15);
            this.lblSelectPLant.TabIndex = 3;
            this.lblSelectPLant.Text = "Select Plant";
            // 
            // cmbxSelectPlant
            // 
            this.cmbxSelectPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectPlant.FormattingEnabled = true;
            this.cmbxSelectPlant.Location = new System.Drawing.Point(445, 49);
            this.cmbxSelectPlant.Name = "cmbxSelectPlant";
            this.cmbxSelectPlant.Size = new System.Drawing.Size(231, 23);
            this.cmbxSelectPlant.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Red;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1079, 687);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 50);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // SemiMonthlyPayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1216, 749);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbxSelectPlant);
            this.Controls.Add(this.lblSelectPLant);
            this.Controls.Add(this.dgvPayrollItems);
            this.Controls.Add(this.btnGeneratePayroll);
            this.Controls.Add(this.gbxSelectRange);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SemiMonthlyPayrollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semi-Monthly Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SemiMonthlyPayrollForm_Load);
            this.gbxSelectRange.ResumeLayout(false);
            this.gbxSelectRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayrollItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSelectRange;
        private System.Windows.Forms.Label lblSelectRange_From;
        private System.Windows.Forms.DateTimePicker dtpSelectRange_From;
        private System.Windows.Forms.DateTimePicker dtpSelectRange_To;
        private System.Windows.Forms.Label lblSelectRange_To;
        private System.Windows.Forms.Button btnGeneratePayroll;
        private System.Windows.Forms.DataGridView dgvPayrollItems;
        private System.Windows.Forms.Label lblSelectPLant;
        private System.Windows.Forms.ComboBox cmbxSelectPlant;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_VacationLeaveSickLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_BasicPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_RegularWorkingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_NightDifferentialHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_SundayHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_SpecialHolidayHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayrollItem_SpecialHolidayOvertimeHours;
    }
}