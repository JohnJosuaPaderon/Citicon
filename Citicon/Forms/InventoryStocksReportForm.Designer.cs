namespace Citicon.Forms
{
    partial class InventoryStocksReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryStocksReportForm));
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.DrNumberFilterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrNumberFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SiNumberFilterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SiNumberFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.DeliveryDateFilterEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDateFilterToLabel = new System.Windows.Forms.Label();
            this.DeliveryDateFilterBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.BranchFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.BranchFilterComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.SupplierFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.DescriptionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.StockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_ItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_SiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_DrNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_MrisNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_AddedStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_PaymentTermColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_BranchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportButton = new System.Windows.Forms.Button();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrNumberFilterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiNumberFilterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterGroupBox.Controls.Add(this.DrNumberFilterNumericUpDown);
            this.FilterGroupBox.Controls.Add(this.DrNumberFilterCheckBox);
            this.FilterGroupBox.Controls.Add(this.SiNumberFilterNumericUpDown);
            this.FilterGroupBox.Controls.Add(this.SiNumberFilterCheckBox);
            this.FilterGroupBox.Controls.Add(this.DeliveryDateFilterEndDateTimePicker);
            this.FilterGroupBox.Controls.Add(this.DeliveryDateFilterToLabel);
            this.FilterGroupBox.Controls.Add(this.DeliveryDateFilterBeginDateTimePicker);
            this.FilterGroupBox.Controls.Add(this.DeliveryDateFilterCheckBox);
            this.FilterGroupBox.Controls.Add(this.BranchFilterCheckBox);
            this.FilterGroupBox.Controls.Add(this.BranchFilterComboBox);
            this.FilterGroupBox.Controls.Add(this.SupplierFilterComboBox);
            this.FilterGroupBox.Controls.Add(this.DescriptionFilterComboBox);
            this.FilterGroupBox.Controls.Add(this.SupplierFilterCheckBox);
            this.FilterGroupBox.Controls.Add(this.DescriptionFilterCheckBox);
            this.FilterGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(1097, 123);
            this.FilterGroupBox.TabIndex = 0;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Search Filter";
            // 
            // DrNumberFilterNumericUpDown
            // 
            this.DrNumberFilterNumericUpDown.Enabled = false;
            this.DrNumberFilterNumericUpDown.Location = new System.Drawing.Point(538, 84);
            this.DrNumberFilterNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.DrNumberFilterNumericUpDown.Name = "DrNumberFilterNumericUpDown";
            this.DrNumberFilterNumericUpDown.Size = new System.Drawing.Size(314, 25);
            this.DrNumberFilterNumericUpDown.TabIndex = 121;
            // 
            // DrNumberFilterCheckBox
            // 
            this.DrNumberFilterCheckBox.AutoSize = true;
            this.DrNumberFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DrNumberFilterCheckBox.Location = new System.Drawing.Point(456, 88);
            this.DrNumberFilterCheckBox.Name = "DrNumberFilterCheckBox";
            this.DrNumberFilterCheckBox.Size = new System.Drawing.Size(75, 21);
            this.DrNumberFilterCheckBox.TabIndex = 120;
            this.DrNumberFilterCheckBox.Text = "D.R. No.";
            this.DrNumberFilterCheckBox.UseVisualStyleBackColor = true;
            this.DrNumberFilterCheckBox.CheckedChanged += new System.EventHandler(this.DrNumberFilterCheckBox_CheckedChanged);
            // 
            // SiNumberFilterNumericUpDown
            // 
            this.SiNumberFilterNumericUpDown.Enabled = false;
            this.SiNumberFilterNumericUpDown.Location = new System.Drawing.Point(538, 53);
            this.SiNumberFilterNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.SiNumberFilterNumericUpDown.Name = "SiNumberFilterNumericUpDown";
            this.SiNumberFilterNumericUpDown.Size = new System.Drawing.Size(314, 25);
            this.SiNumberFilterNumericUpDown.TabIndex = 119;
            // 
            // SiNumberFilterCheckBox
            // 
            this.SiNumberFilterCheckBox.AutoSize = true;
            this.SiNumberFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SiNumberFilterCheckBox.Location = new System.Drawing.Point(463, 57);
            this.SiNumberFilterCheckBox.Name = "SiNumberFilterCheckBox";
            this.SiNumberFilterCheckBox.Size = new System.Drawing.Size(68, 21);
            this.SiNumberFilterCheckBox.TabIndex = 118;
            this.SiNumberFilterCheckBox.Text = "S.I. No.";
            this.SiNumberFilterCheckBox.UseVisualStyleBackColor = true;
            this.SiNumberFilterCheckBox.CheckedChanged += new System.EventHandler(this.SiNumberFilterCheckBox_CheckedChanged);
            // 
            // DeliveryDateFilterEndDateTimePicker
            // 
            this.DeliveryDateFilterEndDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.DeliveryDateFilterEndDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DeliveryDateFilterEndDateTimePicker.Enabled = false;
            this.DeliveryDateFilterEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDateFilterEndDateTimePicker.Location = new System.Drawing.Point(709, 23);
            this.DeliveryDateFilterEndDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryDateFilterEndDateTimePicker.Name = "DeliveryDateFilterEndDateTimePicker";
            this.DeliveryDateFilterEndDateTimePicker.Size = new System.Drawing.Size(143, 25);
            this.DeliveryDateFilterEndDateTimePicker.TabIndex = 117;
            // 
            // DeliveryDateFilterToLabel
            // 
            this.DeliveryDateFilterToLabel.AutoSize = true;
            this.DeliveryDateFilterToLabel.Location = new System.Drawing.Point(684, 27);
            this.DeliveryDateFilterToLabel.Name = "DeliveryDateFilterToLabel";
            this.DeliveryDateFilterToLabel.Size = new System.Drawing.Size(20, 17);
            this.DeliveryDateFilterToLabel.TabIndex = 116;
            this.DeliveryDateFilterToLabel.Text = "to";
            // 
            // DeliveryDateFilterBeginDateTimePicker
            // 
            this.DeliveryDateFilterBeginDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.DeliveryDateFilterBeginDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DeliveryDateFilterBeginDateTimePicker.Enabled = false;
            this.DeliveryDateFilterBeginDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDateFilterBeginDateTimePicker.Location = new System.Drawing.Point(536, 23);
            this.DeliveryDateFilterBeginDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryDateFilterBeginDateTimePicker.Name = "DeliveryDateFilterBeginDateTimePicker";
            this.DeliveryDateFilterBeginDateTimePicker.Size = new System.Drawing.Size(143, 25);
            this.DeliveryDateFilterBeginDateTimePicker.TabIndex = 115;
            // 
            // DeliveryDateFilterCheckBox
            // 
            this.DeliveryDateFilterCheckBox.AutoSize = true;
            this.DeliveryDateFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeliveryDateFilterCheckBox.Location = new System.Drawing.Point(427, 26);
            this.DeliveryDateFilterCheckBox.Name = "DeliveryDateFilterCheckBox";
            this.DeliveryDateFilterCheckBox.Size = new System.Drawing.Size(104, 21);
            this.DeliveryDateFilterCheckBox.TabIndex = 6;
            this.DeliveryDateFilterCheckBox.Text = "Delivery Date";
            this.DeliveryDateFilterCheckBox.UseVisualStyleBackColor = true;
            this.DeliveryDateFilterCheckBox.CheckedChanged += new System.EventHandler(this.DeliveryDateFilterCheckBox_CheckedChanged);
            // 
            // BranchFilterCheckBox
            // 
            this.BranchFilterCheckBox.AutoSize = true;
            this.BranchFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BranchFilterCheckBox.Location = new System.Drawing.Point(33, 88);
            this.BranchFilterCheckBox.Name = "BranchFilterCheckBox";
            this.BranchFilterCheckBox.Size = new System.Drawing.Size(66, 21);
            this.BranchFilterCheckBox.TabIndex = 5;
            this.BranchFilterCheckBox.Text = "Branch";
            this.BranchFilterCheckBox.UseVisualStyleBackColor = true;
            this.BranchFilterCheckBox.CheckedChanged += new System.EventHandler(this.BranchFilterCheckBox_CheckedChanged);
            // 
            // BranchFilterComboBox
            // 
            this.BranchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchFilterComboBox.Enabled = false;
            this.BranchFilterComboBox.FormattingEnabled = true;
            this.BranchFilterComboBox.Location = new System.Drawing.Point(105, 86);
            this.BranchFilterComboBox.Name = "BranchFilterComboBox";
            this.BranchFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.BranchFilterComboBox.TabIndex = 4;
            // 
            // SupplierFilterComboBox
            // 
            this.SupplierFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierFilterComboBox.Enabled = false;
            this.SupplierFilterComboBox.FormattingEnabled = true;
            this.SupplierFilterComboBox.Location = new System.Drawing.Point(105, 55);
            this.SupplierFilterComboBox.Name = "SupplierFilterComboBox";
            this.SupplierFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.SupplierFilterComboBox.TabIndex = 3;
            // 
            // DescriptionFilterComboBox
            // 
            this.DescriptionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptionFilterComboBox.Enabled = false;
            this.DescriptionFilterComboBox.FormattingEnabled = true;
            this.DescriptionFilterComboBox.Location = new System.Drawing.Point(105, 24);
            this.DescriptionFilterComboBox.Name = "DescriptionFilterComboBox";
            this.DescriptionFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.DescriptionFilterComboBox.TabIndex = 2;
            // 
            // SupplierFilterCheckBox
            // 
            this.SupplierFilterCheckBox.AutoSize = true;
            this.SupplierFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SupplierFilterCheckBox.Location = new System.Drawing.Point(24, 57);
            this.SupplierFilterCheckBox.Name = "SupplierFilterCheckBox";
            this.SupplierFilterCheckBox.Size = new System.Drawing.Size(75, 21);
            this.SupplierFilterCheckBox.TabIndex = 1;
            this.SupplierFilterCheckBox.Text = "Supplier";
            this.SupplierFilterCheckBox.UseVisualStyleBackColor = true;
            this.SupplierFilterCheckBox.CheckedChanged += new System.EventHandler(this.SupplierFilterCheckBox_CheckedChanged);
            // 
            // DescriptionFilterCheckBox
            // 
            this.DescriptionFilterCheckBox.AutoSize = true;
            this.DescriptionFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DescriptionFilterCheckBox.Location = new System.Drawing.Point(6, 26);
            this.DescriptionFilterCheckBox.Name = "DescriptionFilterCheckBox";
            this.DescriptionFilterCheckBox.Size = new System.Drawing.Size(93, 21);
            this.DescriptionFilterCheckBox.TabIndex = 0;
            this.DescriptionFilterCheckBox.Text = "Description";
            this.DescriptionFilterCheckBox.UseVisualStyleBackColor = true;
            this.DescriptionFilterCheckBox.CheckedChanged += new System.EventHandler(this.DescriptionFilterCheckBox_CheckedChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(953, 141);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(156, 40);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.StockDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.StockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDataGridView.ColumnHeadersHeight = 50;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockColumn,
            this.Stock_ItemColumn,
            this.Stock_DeliveryDate,
            this.Stock_SiNumber,
            this.Stock_DrNumber,
            this.Stock_MrisNumber,
            this.Stock_AddedStockValue,
            this.Stock_UnitPrice,
            this.Stock_PaymentTermColumn,
            this.Stock_BranchColumn,
            this.Stock_CompanyColumn,
            this.Stock_SupplierColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.StockDataGridView.EnableHeadersVisualStyles = false;
            this.StockDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StockDataGridView.Location = new System.Drawing.Point(11, 186);
            this.StockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StockDataGridView.MultiSelect = false;
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.RowHeadersVisible = false;
            this.StockDataGridView.RowTemplate.Height = 30;
            this.StockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDataGridView.Size = new System.Drawing.Size(1098, 518);
            this.StockDataGridView.TabIndex = 102;
            // 
            // StockColumn
            // 
            this.StockColumn.HeaderText = "Stock";
            this.StockColumn.Name = "StockColumn";
            this.StockColumn.ReadOnly = true;
            this.StockColumn.Visible = false;
            this.StockColumn.Width = 64;
            // 
            // Stock_ItemColumn
            // 
            this.Stock_ItemColumn.HeaderText = "Item Description";
            this.Stock_ItemColumn.Name = "Stock_ItemColumn";
            this.Stock_ItemColumn.ReadOnly = true;
            this.Stock_ItemColumn.Width = 116;
            // 
            // Stock_DeliveryDate
            // 
            dataGridViewCellStyle3.Format = "MMMM dd, yyyy";
            this.Stock_DeliveryDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.Stock_DeliveryDate.HeaderText = "Delivery Date";
            this.Stock_DeliveryDate.Name = "Stock_DeliveryDate";
            this.Stock_DeliveryDate.ReadOnly = true;
            // 
            // Stock_SiNumber
            // 
            this.Stock_SiNumber.HeaderText = "SI No.";
            this.Stock_SiNumber.Name = "Stock_SiNumber";
            this.Stock_SiNumber.ReadOnly = true;
            this.Stock_SiNumber.Width = 62;
            // 
            // Stock_DrNumber
            // 
            this.Stock_DrNumber.HeaderText = "DR No.";
            this.Stock_DrNumber.Name = "Stock_DrNumber";
            this.Stock_DrNumber.ReadOnly = true;
            this.Stock_DrNumber.Width = 68;
            // 
            // Stock_MrisNumber
            // 
            this.Stock_MrisNumber.HeaderText = "MRIS No.";
            this.Stock_MrisNumber.Name = "Stock_MrisNumber";
            this.Stock_MrisNumber.ReadOnly = true;
            this.Stock_MrisNumber.Width = 80;
            // 
            // Stock_AddedStockValue
            // 
            dataGridViewCellStyle4.Format = "#,##0.00";
            this.Stock_AddedStockValue.DefaultCellStyle = dataGridViewCellStyle4;
            this.Stock_AddedStockValue.HeaderText = "Added Stock Value";
            this.Stock_AddedStockValue.Name = "Stock_AddedStockValue";
            this.Stock_AddedStockValue.ReadOnly = true;
            this.Stock_AddedStockValue.Width = 101;
            // 
            // Stock_UnitPrice
            // 
            dataGridViewCellStyle5.Format = "#,##0.00";
            this.Stock_UnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.Stock_UnitPrice.HeaderText = "Unit Price";
            this.Stock_UnitPrice.Name = "Stock_UnitPrice";
            this.Stock_UnitPrice.ReadOnly = true;
            this.Stock_UnitPrice.Width = 80;
            // 
            // Stock_PaymentTermColumn
            // 
            this.Stock_PaymentTermColumn.HeaderText = "Payment Term";
            this.Stock_PaymentTermColumn.Name = "Stock_PaymentTermColumn";
            this.Stock_PaymentTermColumn.ReadOnly = true;
            this.Stock_PaymentTermColumn.Width = 104;
            // 
            // Stock_BranchColumn
            // 
            this.Stock_BranchColumn.HeaderText = "Branch";
            this.Stock_BranchColumn.Name = "Stock_BranchColumn";
            this.Stock_BranchColumn.ReadOnly = true;
            this.Stock_BranchColumn.Width = 71;
            // 
            // Stock_CompanyColumn
            // 
            this.Stock_CompanyColumn.HeaderText = "Company";
            this.Stock_CompanyColumn.Name = "Stock_CompanyColumn";
            this.Stock_CompanyColumn.ReadOnly = true;
            this.Stock_CompanyColumn.Width = 87;
            // 
            // Stock_SupplierColumn
            // 
            this.Stock_SupplierColumn.HeaderText = "Supplier";
            this.Stock_SupplierColumn.Name = "Stock_SupplierColumn";
            this.Stock_SupplierColumn.ReadOnly = true;
            this.Stock_SupplierColumn.Width = 80;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.Color.Red;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(953, 709);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(156, 40);
            this.ExportButton.TabIndex = 103;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // InventoryStocksReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 761);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.FilterGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryStocksReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Stock Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryStocksReportForm_Load);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrNumberFilterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SiNumberFilterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.CheckBox SupplierFilterCheckBox;
        private System.Windows.Forms.CheckBox DescriptionFilterCheckBox;
        private System.Windows.Forms.ComboBox DescriptionFilterComboBox;
        private System.Windows.Forms.ComboBox SupplierFilterComboBox;
        private System.Windows.Forms.CheckBox BranchFilterCheckBox;
        private System.Windows.Forms.ComboBox BranchFilterComboBox;
        private System.Windows.Forms.CheckBox DeliveryDateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker DeliveryDateFilterBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker DeliveryDateFilterEndDateTimePicker;
        private System.Windows.Forms.Label DeliveryDateFilterToLabel;
        private System.Windows.Forms.CheckBox SiNumberFilterCheckBox;
        private System.Windows.Forms.NumericUpDown SiNumberFilterNumericUpDown;
        private System.Windows.Forms.NumericUpDown DrNumberFilterNumericUpDown;
        private System.Windows.Forms.CheckBox DrNumberFilterCheckBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_ItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_SiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_DrNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_MrisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_AddedStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_PaymentTermColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_BranchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_SupplierColumn;
        private System.Windows.Forms.Button ExportButton;
    }
}