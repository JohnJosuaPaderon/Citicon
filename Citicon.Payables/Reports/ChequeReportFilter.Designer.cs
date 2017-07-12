namespace Citicon.Payables.Reports
{
    partial class ChequeReportFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Filter = new System.Windows.Forms.GroupBox();
            this.pnlTransactionDate = new System.Windows.Forms.Panel();
            this.dtpTransactionDate_End = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionDateTo = new System.Windows.Forms.Label();
            this.dtpTransactionDate_Start = new System.Windows.Forms.DateTimePicker();
            this.FilterByChequeTransactionDateCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterByCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.FilterByCompanyCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterByBranchComboBox = new System.Windows.Forms.ComboBox();
            this.FilterByBranchCheckBox = new System.Windows.Forms.CheckBox();
            this.cmbxSupplier = new System.Windows.Forms.ComboBox();
            this.ckbxSupplier = new System.Windows.Forms.CheckBox();
            this.pnlRangeDate = new System.Windows.Forms.Panel();
            this.dtpRangeDate_End = new System.Windows.Forms.DateTimePicker();
            this.lblRangeDateTo = new System.Windows.Forms.Label();
            this.dtpRangeDate_Start = new System.Windows.Forms.DateTimePicker();
            this.ckbxRangeDate = new System.Windows.Forms.CheckBox();
            this.Filter.SuspendLayout();
            this.pnlTransactionDate.SuspendLayout();
            this.pnlRangeDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.Controls.Add(this.pnlTransactionDate);
            this.Filter.Controls.Add(this.FilterByChequeTransactionDateCheckBox);
            this.Filter.Controls.Add(this.FilterByCompanyComboBox);
            this.Filter.Controls.Add(this.FilterByCompanyCheckBox);
            this.Filter.Controls.Add(this.FilterByBranchComboBox);
            this.Filter.Controls.Add(this.FilterByBranchCheckBox);
            this.Filter.Controls.Add(this.cmbxSupplier);
            this.Filter.Controls.Add(this.ckbxSupplier);
            this.Filter.Controls.Add(this.pnlRangeDate);
            this.Filter.Controls.Add(this.ckbxRangeDate);
            this.Filter.Location = new System.Drawing.Point(3, 3);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(999, 148);
            this.Filter.TabIndex = 0;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filter";
            // 
            // pnlTransactionDate
            // 
            this.pnlTransactionDate.Controls.Add(this.dtpTransactionDate_End);
            this.pnlTransactionDate.Controls.Add(this.lblTransactionDateTo);
            this.pnlTransactionDate.Controls.Add(this.dtpTransactionDate_Start);
            this.pnlTransactionDate.Enabled = false;
            this.pnlTransactionDate.Location = new System.Drawing.Point(156, 97);
            this.pnlTransactionDate.Name = "pnlTransactionDate";
            this.pnlTransactionDate.Size = new System.Drawing.Size(357, 29);
            this.pnlTransactionDate.TabIndex = 3;
            // 
            // dtpTransactionDate_End
            // 
            this.dtpTransactionDate_End.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionDate_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate_End.Location = new System.Drawing.Point(197, 0);
            this.dtpTransactionDate_End.Name = "dtpTransactionDate_End";
            this.dtpTransactionDate_End.Size = new System.Drawing.Size(160, 29);
            this.dtpTransactionDate_End.TabIndex = 2;
            this.dtpTransactionDate_End.ValueChanged += new System.EventHandler(this.dtpTransactionDate_End_ValueChanged);
            // 
            // lblTransactionDateTo
            // 
            this.lblTransactionDateTo.AutoSize = true;
            this.lblTransactionDateTo.Location = new System.Drawing.Point(166, 4);
            this.lblTransactionDateTo.Name = "lblTransactionDateTo";
            this.lblTransactionDateTo.Size = new System.Drawing.Size(25, 21);
            this.lblTransactionDateTo.TabIndex = 0;
            this.lblTransactionDateTo.Text = "To";
            // 
            // dtpTransactionDate_Start
            // 
            this.dtpTransactionDate_Start.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate_Start.Location = new System.Drawing.Point(0, 0);
            this.dtpTransactionDate_Start.Name = "dtpTransactionDate_Start";
            this.dtpTransactionDate_Start.Size = new System.Drawing.Size(160, 29);
            this.dtpTransactionDate_Start.TabIndex = 0;
            this.dtpTransactionDate_Start.ValueChanged += new System.EventHandler(this.dtpTransactionDate_Start_ValueChanged);
            // 
            // FilterByChequeTransactionDateCheckBox
            // 
            this.FilterByChequeTransactionDateCheckBox.AutoSize = true;
            this.FilterByChequeTransactionDateCheckBox.Location = new System.Drawing.Point(6, 100);
            this.FilterByChequeTransactionDateCheckBox.Name = "FilterByChequeTransactionDateCheckBox";
            this.FilterByChequeTransactionDateCheckBox.Size = new System.Drawing.Size(144, 25);
            this.FilterByChequeTransactionDateCheckBox.TabIndex = 8;
            this.FilterByChequeTransactionDateCheckBox.Text = "Transaction Date";
            this.FilterByChequeTransactionDateCheckBox.UseVisualStyleBackColor = true;
            this.FilterByChequeTransactionDateCheckBox.CheckedChanged += new System.EventHandler(this.FilterByChequeTransactionDate_CheckedChanged);
            // 
            // FilterByCompanyComboBox
            // 
            this.FilterByCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByCompanyComboBox.Enabled = false;
            this.FilterByCompanyComboBox.FormattingEnabled = true;
            this.FilterByCompanyComboBox.Location = new System.Drawing.Point(645, 62);
            this.FilterByCompanyComboBox.Name = "FilterByCompanyComboBox";
            this.FilterByCompanyComboBox.Size = new System.Drawing.Size(289, 29);
            this.FilterByCompanyComboBox.TabIndex = 7;
            this.FilterByCompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByCompanyComboBox_SelectedIndexChanged);
            // 
            // FilterByCompanyCheckBox
            // 
            this.FilterByCompanyCheckBox.AutoSize = true;
            this.FilterByCompanyCheckBox.Location = new System.Drawing.Point(543, 64);
            this.FilterByCompanyCheckBox.Name = "FilterByCompanyCheckBox";
            this.FilterByCompanyCheckBox.Size = new System.Drawing.Size(96, 25);
            this.FilterByCompanyCheckBox.TabIndex = 6;
            this.FilterByCompanyCheckBox.Text = "Company";
            this.FilterByCompanyCheckBox.UseVisualStyleBackColor = true;
            this.FilterByCompanyCheckBox.CheckedChanged += new System.EventHandler(this.FilterByCompanyCheckBox_CheckedChanged);
            // 
            // FilterByBranchComboBox
            // 
            this.FilterByBranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterByBranchComboBox.Enabled = false;
            this.FilterByBranchComboBox.FormattingEnabled = true;
            this.FilterByBranchComboBox.Location = new System.Drawing.Point(645, 27);
            this.FilterByBranchComboBox.Name = "FilterByBranchComboBox";
            this.FilterByBranchComboBox.Size = new System.Drawing.Size(289, 29);
            this.FilterByBranchComboBox.TabIndex = 5;
            this.FilterByBranchComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterByBranchComboBox_SelectedIndexChanged);
            // 
            // FilterByBranchCheckBox
            // 
            this.FilterByBranchCheckBox.AutoSize = true;
            this.FilterByBranchCheckBox.Location = new System.Drawing.Point(543, 30);
            this.FilterByBranchCheckBox.Name = "FilterByBranchCheckBox";
            this.FilterByBranchCheckBox.Size = new System.Drawing.Size(77, 25);
            this.FilterByBranchCheckBox.TabIndex = 4;
            this.FilterByBranchCheckBox.Text = "Branch";
            this.FilterByBranchCheckBox.UseVisualStyleBackColor = true;
            this.FilterByBranchCheckBox.CheckedChanged += new System.EventHandler(this.FilterByBranchCheckBox_CheckedChanged);
            // 
            // cmbxSupplier
            // 
            this.cmbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSupplier.Enabled = false;
            this.cmbxSupplier.FormattingEnabled = true;
            this.cmbxSupplier.Location = new System.Drawing.Point(156, 62);
            this.cmbxSupplier.Name = "cmbxSupplier";
            this.cmbxSupplier.Size = new System.Drawing.Size(357, 29);
            this.cmbxSupplier.TabIndex = 3;
            this.cmbxSupplier.SelectedIndexChanged += new System.EventHandler(this.CmbxSupplier_SelectedIndexChanged);
            // 
            // ckbxSupplier
            // 
            this.ckbxSupplier.AutoSize = true;
            this.ckbxSupplier.Location = new System.Drawing.Point(6, 65);
            this.ckbxSupplier.Name = "ckbxSupplier";
            this.ckbxSupplier.Size = new System.Drawing.Size(87, 25);
            this.ckbxSupplier.TabIndex = 2;
            this.ckbxSupplier.Text = "Supplier";
            this.ckbxSupplier.UseVisualStyleBackColor = true;
            this.ckbxSupplier.CheckedChanged += new System.EventHandler(this.CkbxSupplier_CheckedChanged);
            // 
            // pnlRangeDate
            // 
            this.pnlRangeDate.Controls.Add(this.dtpRangeDate_End);
            this.pnlRangeDate.Controls.Add(this.lblRangeDateTo);
            this.pnlRangeDate.Controls.Add(this.dtpRangeDate_Start);
            this.pnlRangeDate.Enabled = false;
            this.pnlRangeDate.Location = new System.Drawing.Point(156, 27);
            this.pnlRangeDate.Name = "pnlRangeDate";
            this.pnlRangeDate.Size = new System.Drawing.Size(357, 29);
            this.pnlRangeDate.TabIndex = 1;
            // 
            // dtpRangeDate_End
            // 
            this.dtpRangeDate_End.CustomFormat = "MMM dd, yyyy";
            this.dtpRangeDate_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRangeDate_End.Location = new System.Drawing.Point(197, 0);
            this.dtpRangeDate_End.Name = "dtpRangeDate_End";
            this.dtpRangeDate_End.Size = new System.Drawing.Size(160, 29);
            this.dtpRangeDate_End.TabIndex = 2;
            this.dtpRangeDate_End.ValueChanged += new System.EventHandler(this.DtpRangeDate_End_ValueChanged);
            // 
            // lblRangeDateTo
            // 
            this.lblRangeDateTo.AutoSize = true;
            this.lblRangeDateTo.Location = new System.Drawing.Point(166, 4);
            this.lblRangeDateTo.Name = "lblRangeDateTo";
            this.lblRangeDateTo.Size = new System.Drawing.Size(25, 21);
            this.lblRangeDateTo.TabIndex = 0;
            this.lblRangeDateTo.Text = "To";
            // 
            // dtpRangeDate_Start
            // 
            this.dtpRangeDate_Start.CustomFormat = "MMM dd, yyyy";
            this.dtpRangeDate_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRangeDate_Start.Location = new System.Drawing.Point(0, 0);
            this.dtpRangeDate_Start.Name = "dtpRangeDate_Start";
            this.dtpRangeDate_Start.Size = new System.Drawing.Size(160, 29);
            this.dtpRangeDate_Start.TabIndex = 0;
            this.dtpRangeDate_Start.ValueChanged += new System.EventHandler(this.DtpRangeDate_Start_ValueChanged);
            // 
            // ckbxRangeDate
            // 
            this.ckbxRangeDate.AutoSize = true;
            this.ckbxRangeDate.Location = new System.Drawing.Point(6, 31);
            this.ckbxRangeDate.Name = "ckbxRangeDate";
            this.ckbxRangeDate.Size = new System.Drawing.Size(109, 25);
            this.ckbxRangeDate.TabIndex = 0;
            this.ckbxRangeDate.Text = "Range Date";
            this.ckbxRangeDate.UseVisualStyleBackColor = true;
            this.ckbxRangeDate.CheckedChanged += new System.EventHandler(this.CkbxRangeDate_CheckedChanged);
            // 
            // ChequeReportFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Filter);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChequeReportFilter";
            this.Size = new System.Drawing.Size(1005, 154);
            this.Load += new System.EventHandler(this.ChequeReportFilter_Load);
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.pnlTransactionDate.ResumeLayout(false);
            this.pnlTransactionDate.PerformLayout();
            this.pnlRangeDate.ResumeLayout(false);
            this.pnlRangeDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.CheckBox ckbxRangeDate;
        private System.Windows.Forms.Panel pnlRangeDate;
        private System.Windows.Forms.DateTimePicker dtpRangeDate_Start;
        private System.Windows.Forms.DateTimePicker dtpRangeDate_End;
        private System.Windows.Forms.Label lblRangeDateTo;
        private System.Windows.Forms.CheckBox ckbxSupplier;
        private System.Windows.Forms.ComboBox cmbxSupplier;
        private System.Windows.Forms.ComboBox FilterByBranchComboBox;
        private System.Windows.Forms.CheckBox FilterByBranchCheckBox;
        private System.Windows.Forms.ComboBox FilterByCompanyComboBox;
        private System.Windows.Forms.CheckBox FilterByCompanyCheckBox;
        private System.Windows.Forms.Panel pnlTransactionDate;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate_End;
        private System.Windows.Forms.Label lblTransactionDateTo;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate_Start;
        private System.Windows.Forms.CheckBox FilterByChequeTransactionDateCheckBox;
    }
}
