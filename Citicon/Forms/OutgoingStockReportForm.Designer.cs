namespace Citicon.Forms
{
    partial class OutgoingStockReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingStockReportForm));
            this.SearchFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.TransactionDateRangeEndFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateFilterLabel = new System.Windows.Forms.Label();
            this.TransactionDateRangeBeginFilterDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.VehicleFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.VehicleFilterComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.CompanyFilterComboBox = new System.Windows.Forms.ComboBox();
            this.BranchFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.BranchFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.OutgoingStockDataGridView = new System.Windows.Forms.DataGridView();
            this.OutgoingStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_IssuanceSlipNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_TransactionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_MeasurementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutgoingStock_VehicleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SearchFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutgoingStockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchFilterGroupBox
            // 
            this.SearchFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFilterGroupBox.Controls.Add(this.TransactionDateRangeEndFilterDateTimePicker);
            this.SearchFilterGroupBox.Controls.Add(this.TransactionDateFilterLabel);
            this.SearchFilterGroupBox.Controls.Add(this.TransactionDateRangeBeginFilterDateTimePicker);
            this.SearchFilterGroupBox.Controls.Add(this.TransactionDateFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.VehicleFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.VehicleFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.CompanyFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.CompanyFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.BranchFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.BranchFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.DescriptionFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.DescriptionFilterCheckBox);
            this.SearchFilterGroupBox.Location = new System.Drawing.Point(13, 13);
            this.SearchFilterGroupBox.Name = "SearchFilterGroupBox";
            this.SearchFilterGroupBox.Size = new System.Drawing.Size(970, 123);
            this.SearchFilterGroupBox.TabIndex = 0;
            this.SearchFilterGroupBox.TabStop = false;
            this.SearchFilterGroupBox.Text = "Search Filter";
            // 
            // TransactionDateRangeEndFilterDateTimePicker
            // 
            this.TransactionDateRangeEndFilterDateTimePicker.CustomFormat = "MMM d, yyyy";
            this.TransactionDateRangeEndFilterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateRangeEndFilterDateTimePicker.Location = new System.Drawing.Point(717, 55);
            this.TransactionDateRangeEndFilterDateTimePicker.Name = "TransactionDateRangeEndFilterDateTimePicker";
            this.TransactionDateRangeEndFilterDateTimePicker.Size = new System.Drawing.Size(130, 25);
            this.TransactionDateRangeEndFilterDateTimePicker.TabIndex = 13;
            // 
            // TransactionDateFilterLabel
            // 
            this.TransactionDateFilterLabel.AutoSize = true;
            this.TransactionDateFilterLabel.Location = new System.Drawing.Point(690, 58);
            this.TransactionDateFilterLabel.Name = "TransactionDateFilterLabel";
            this.TransactionDateFilterLabel.Size = new System.Drawing.Size(20, 17);
            this.TransactionDateFilterLabel.TabIndex = 12;
            this.TransactionDateFilterLabel.Text = "to";
            // 
            // TransactionDateRangeBeginFilterDateTimePicker
            // 
            this.TransactionDateRangeBeginFilterDateTimePicker.CustomFormat = "MMM d, yyyy";
            this.TransactionDateRangeBeginFilterDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateRangeBeginFilterDateTimePicker.Location = new System.Drawing.Point(552, 55);
            this.TransactionDateRangeBeginFilterDateTimePicker.Name = "TransactionDateRangeBeginFilterDateTimePicker";
            this.TransactionDateRangeBeginFilterDateTimePicker.Size = new System.Drawing.Size(130, 25);
            this.TransactionDateRangeBeginFilterDateTimePicker.TabIndex = 11;
            // 
            // TransactionDateFilterCheckBox
            // 
            this.TransactionDateFilterCheckBox.AutoSize = true;
            this.TransactionDateFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransactionDateFilterCheckBox.Location = new System.Drawing.Point(422, 57);
            this.TransactionDateFilterCheckBox.Name = "TransactionDateFilterCheckBox";
            this.TransactionDateFilterCheckBox.Size = new System.Drawing.Size(124, 21);
            this.TransactionDateFilterCheckBox.TabIndex = 10;
            this.TransactionDateFilterCheckBox.Text = "Transaction Date";
            this.TransactionDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // VehicleFilterCheckBox
            // 
            this.VehicleFilterCheckBox.AutoSize = true;
            this.VehicleFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VehicleFilterCheckBox.Location = new System.Drawing.Point(479, 26);
            this.VehicleFilterCheckBox.Name = "VehicleFilterCheckBox";
            this.VehicleFilterCheckBox.Size = new System.Drawing.Size(67, 21);
            this.VehicleFilterCheckBox.TabIndex = 9;
            this.VehicleFilterCheckBox.Text = "Vehicle";
            this.VehicleFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // VehicleFilterComboBox
            // 
            this.VehicleFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleFilterComboBox.FormattingEnabled = true;
            this.VehicleFilterComboBox.Location = new System.Drawing.Point(552, 24);
            this.VehicleFilterComboBox.Name = "VehicleFilterComboBox";
            this.VehicleFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.VehicleFilterComboBox.TabIndex = 8;
            // 
            // CompanyFilterCheckBox
            // 
            this.CompanyFilterCheckBox.AutoSize = true;
            this.CompanyFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompanyFilterCheckBox.Location = new System.Drawing.Point(17, 88);
            this.CompanyFilterCheckBox.Name = "CompanyFilterCheckBox";
            this.CompanyFilterCheckBox.Size = new System.Drawing.Size(82, 21);
            this.CompanyFilterCheckBox.TabIndex = 7;
            this.CompanyFilterCheckBox.Text = "Company";
            this.CompanyFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompanyFilterComboBox
            // 
            this.CompanyFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyFilterComboBox.FormattingEnabled = true;
            this.CompanyFilterComboBox.Location = new System.Drawing.Point(105, 86);
            this.CompanyFilterComboBox.Name = "CompanyFilterComboBox";
            this.CompanyFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.CompanyFilterComboBox.TabIndex = 6;
            // 
            // BranchFilterCheckBox
            // 
            this.BranchFilterCheckBox.AutoSize = true;
            this.BranchFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BranchFilterCheckBox.Location = new System.Drawing.Point(33, 57);
            this.BranchFilterCheckBox.Name = "BranchFilterCheckBox";
            this.BranchFilterCheckBox.Size = new System.Drawing.Size(66, 21);
            this.BranchFilterCheckBox.TabIndex = 5;
            this.BranchFilterCheckBox.Text = "Branch";
            this.BranchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // BranchFilterComboBox
            // 
            this.BranchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchFilterComboBox.FormattingEnabled = true;
            this.BranchFilterComboBox.Location = new System.Drawing.Point(105, 55);
            this.BranchFilterComboBox.Name = "BranchFilterComboBox";
            this.BranchFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.BranchFilterComboBox.TabIndex = 4;
            // 
            // DescriptionFilterComboBox
            // 
            this.DescriptionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptionFilterComboBox.FormattingEnabled = true;
            this.DescriptionFilterComboBox.Location = new System.Drawing.Point(105, 24);
            this.DescriptionFilterComboBox.Name = "DescriptionFilterComboBox";
            this.DescriptionFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.DescriptionFilterComboBox.TabIndex = 3;
            // 
            // DescriptionFilterCheckBox
            // 
            this.DescriptionFilterCheckBox.AutoSize = true;
            this.DescriptionFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DescriptionFilterCheckBox.Location = new System.Drawing.Point(6, 26);
            this.DescriptionFilterCheckBox.Name = "DescriptionFilterCheckBox";
            this.DescriptionFilterCheckBox.Size = new System.Drawing.Size(93, 21);
            this.DescriptionFilterCheckBox.TabIndex = 1;
            this.DescriptionFilterCheckBox.Text = "Description";
            this.DescriptionFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(868, 142);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 40);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // OutgoingStockDataGridView
            // 
            this.OutgoingStockDataGridView.AllowUserToAddRows = false;
            this.OutgoingStockDataGridView.AllowUserToDeleteRows = false;
            this.OutgoingStockDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OutgoingStockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OutgoingStockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutgoingStockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.OutgoingStockDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.OutgoingStockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutgoingStockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.OutgoingStockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutgoingStockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OutgoingStockDataGridView.ColumnHeadersHeight = 50;
            this.OutgoingStockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OutgoingStockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutgoingStockColumn,
            this.OutgoingStock_IssuanceSlipNumberColumn,
            this.OutgoingStock_TransactionDateColumn,
            this.OutgoingStock_CodeColumn,
            this.OutgoingStock_DescriptionColumn,
            this.OutgoingStock_QuantityColumn,
            this.OutgoingStock_MeasurementColumn,
            this.OutgoingStock_UnitCost,
            this.OutgoingStock_SupplierColumn,
            this.OutgoingStock_VehicleColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OutgoingStockDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.OutgoingStockDataGridView.EnableHeadersVisualStyles = false;
            this.OutgoingStockDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OutgoingStockDataGridView.Location = new System.Drawing.Point(13, 187);
            this.OutgoingStockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.OutgoingStockDataGridView.MultiSelect = false;
            this.OutgoingStockDataGridView.Name = "OutgoingStockDataGridView";
            this.OutgoingStockDataGridView.ReadOnly = true;
            this.OutgoingStockDataGridView.RowHeadersVisible = false;
            this.OutgoingStockDataGridView.RowTemplate.Height = 30;
            this.OutgoingStockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OutgoingStockDataGridView.Size = new System.Drawing.Size(970, 515);
            this.OutgoingStockDataGridView.TabIndex = 103;
            // 
            // OutgoingStockColumn
            // 
            this.OutgoingStockColumn.HeaderText = "";
            this.OutgoingStockColumn.Name = "OutgoingStockColumn";
            this.OutgoingStockColumn.ReadOnly = true;
            this.OutgoingStockColumn.Visible = false;
            this.OutgoingStockColumn.Width = 19;
            // 
            // OutgoingStock_IssuanceSlipNumberColumn
            // 
            this.OutgoingStock_IssuanceSlipNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_IssuanceSlipNumberColumn.HeaderText = "Issuance Slip No.";
            this.OutgoingStock_IssuanceSlipNumberColumn.Name = "OutgoingStock_IssuanceSlipNumberColumn";
            this.OutgoingStock_IssuanceSlipNumberColumn.ReadOnly = true;
            this.OutgoingStock_IssuanceSlipNumberColumn.Width = 101;
            // 
            // OutgoingStock_TransactionDateColumn
            // 
            this.OutgoingStock_TransactionDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_TransactionDateColumn.HeaderText = "Transaction Date";
            this.OutgoingStock_TransactionDateColumn.Name = "OutgoingStock_TransactionDateColumn";
            this.OutgoingStock_TransactionDateColumn.ReadOnly = true;
            this.OutgoingStock_TransactionDateColumn.Width = 118;
            // 
            // OutgoingStock_CodeColumn
            // 
            this.OutgoingStock_CodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_CodeColumn.HeaderText = "Code";
            this.OutgoingStock_CodeColumn.Name = "OutgoingStock_CodeColumn";
            this.OutgoingStock_CodeColumn.ReadOnly = true;
            this.OutgoingStock_CodeColumn.Width = 63;
            // 
            // OutgoingStock_DescriptionColumn
            // 
            this.OutgoingStock_DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_DescriptionColumn.HeaderText = "Description";
            this.OutgoingStock_DescriptionColumn.Name = "OutgoingStock_DescriptionColumn";
            this.OutgoingStock_DescriptionColumn.ReadOnly = true;
            this.OutgoingStock_DescriptionColumn.Width = 98;
            // 
            // OutgoingStock_QuantityColumn
            // 
            this.OutgoingStock_QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_QuantityColumn.HeaderText = "Quantity";
            this.OutgoingStock_QuantityColumn.Name = "OutgoingStock_QuantityColumn";
            this.OutgoingStock_QuantityColumn.ReadOnly = true;
            this.OutgoingStock_QuantityColumn.Width = 80;
            // 
            // OutgoingStock_MeasurementColumn
            // 
            this.OutgoingStock_MeasurementColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_MeasurementColumn.HeaderText = "Measurement";
            this.OutgoingStock_MeasurementColumn.Name = "OutgoingStock_MeasurementColumn";
            this.OutgoingStock_MeasurementColumn.ReadOnly = true;
            this.OutgoingStock_MeasurementColumn.Width = 112;
            // 
            // OutgoingStock_UnitCost
            // 
            this.OutgoingStock_UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_UnitCost.HeaderText = "Unit Cost";
            this.OutgoingStock_UnitCost.Name = "OutgoingStock_UnitCost";
            this.OutgoingStock_UnitCost.ReadOnly = true;
            this.OutgoingStock_UnitCost.Width = 78;
            // 
            // OutgoingStock_SupplierColumn
            // 
            this.OutgoingStock_SupplierColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_SupplierColumn.HeaderText = "Supplier";
            this.OutgoingStock_SupplierColumn.Name = "OutgoingStock_SupplierColumn";
            this.OutgoingStock_SupplierColumn.ReadOnly = true;
            this.OutgoingStock_SupplierColumn.Width = 80;
            // 
            // OutgoingStock_VehicleColumn
            // 
            this.OutgoingStock_VehicleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OutgoingStock_VehicleColumn.HeaderText = "Vehicle";
            this.OutgoingStock_VehicleColumn.Name = "OutgoingStock_VehicleColumn";
            this.OutgoingStock_VehicleColumn.ReadOnly = true;
            this.OutgoingStock_VehicleColumn.Width = 72;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.Color.Red;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(868, 707);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(115, 40);
            this.ExportButton.TabIndex = 104;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // OutgoingStockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 759);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.OutgoingStockDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchFilterGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutgoingStockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outgoing Stocks Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OutgoingStockReportForm_Load);
            this.SearchFilterGroupBox.ResumeLayout(false);
            this.SearchFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutgoingStockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchFilterGroupBox;
        private System.Windows.Forms.Label TransactionDateFilterLabel;
        public System.Windows.Forms.CheckBox DescriptionFilterCheckBox;
        public System.Windows.Forms.ComboBox DescriptionFilterComboBox;
        public System.Windows.Forms.CheckBox BranchFilterCheckBox;
        public System.Windows.Forms.ComboBox BranchFilterComboBox;
        public System.Windows.Forms.CheckBox CompanyFilterCheckBox;
        public System.Windows.Forms.ComboBox CompanyFilterComboBox;
        public System.Windows.Forms.CheckBox VehicleFilterCheckBox;
        public System.Windows.Forms.ComboBox VehicleFilterComboBox;
        public System.Windows.Forms.CheckBox TransactionDateFilterCheckBox;
        public System.Windows.Forms.DateTimePicker TransactionDateRangeBeginFilterDateTimePicker;
        public System.Windows.Forms.DateTimePicker TransactionDateRangeEndFilterDateTimePicker;
        public System.Windows.Forms.DataGridView OutgoingStockDataGridView;
        public System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_IssuanceSlipNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_TransactionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_MeasurementColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutgoingStock_VehicleColumn;
        public System.Windows.Forms.Button SearchButton;
    }
}