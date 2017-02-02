namespace Citicon.Inventory
{
    partial class ItemManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagerForm));
            this.lblInventoryItems = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lblItemClassification = new System.Windows.Forms.Label();
            this.cmbxItemClassification = new System.Windows.Forms.ComboBox();
            this.lblItemStockValue = new System.Windows.Forms.Label();
            this.nudItemStockValue = new System.Windows.Forms.NumericUpDown();
            this.tbxItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.cmbxMeasurementUnit = new System.Windows.Forms.ComboBox();
            this.lblMeasurementUnit = new System.Windows.Forms.Label();
            this.ckbxCementSupplied = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnViewPriceHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStockValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryItems
            // 
            this.lblInventoryItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventoryItems.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryItems.Location = new System.Drawing.Point(0, 0);
            this.lblInventoryItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInventoryItems.Name = "lblInventoryItems";
            this.lblInventoryItems.Size = new System.Drawing.Size(1430, 84);
            this.lblInventoryItems.TabIndex = 9;
            this.lblInventoryItems.Text = "Inventory Items";
            this.lblInventoryItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 50;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colItemCode,
            this.colItemsClassification,
            this.colItemsStockValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(10, 119);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(982, 475);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "Description";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colItemCode
            // 
            this.colItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemCode.HeaderText = "Code";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.ReadOnly = true;
            this.colItemCode.Width = 70;
            // 
            // colItemsClassification
            // 
            this.colItemsClassification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsClassification.HeaderText = "Account Descriptions";
            this.colItemsClassification.Name = "colItemsClassification";
            this.colItemsClassification.ReadOnly = true;
            this.colItemsClassification.Width = 164;
            // 
            // colItemsStockValue
            // 
            this.colItemsStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colItemsStockValue.HeaderText = "Stock Value";
            this.colItemsStockValue.Name = "colItemsStockValue";
            this.colItemsStockValue.ReadOnly = true;
            this.colItemsStockValue.Width = 104;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(992, 239);
            this.lblItemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(89, 21);
            this.lblItemDescription.TabIndex = 13;
            this.lblItemDescription.Text = "Description";
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(997, 87);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(102, 42);
            this.btnNewItem.TabIndex = 0;
            this.btnNewItem.Text = "&New";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.Location = new System.Drawing.Point(1104, 87);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(102, 42);
            this.btnEditItem.TabIndex = 1;
            this.btnEditItem.Text = "&Edit";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lblItemClassification
            // 
            this.lblItemClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemClassification.AutoSize = true;
            this.lblItemClassification.Location = new System.Drawing.Point(992, 131);
            this.lblItemClassification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemClassification.Name = "lblItemClassification";
            this.lblItemClassification.Size = new System.Drawing.Size(149, 21);
            this.lblItemClassification.TabIndex = 38;
            this.lblItemClassification.Text = "Account Description";
            // 
            // cmbxItemClassification
            // 
            this.cmbxItemClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxItemClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxItemClassification.Enabled = false;
            this.cmbxItemClassification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxItemClassification.FormattingEnabled = true;
            this.cmbxItemClassification.Location = new System.Drawing.Point(997, 155);
            this.cmbxItemClassification.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxItemClassification.Name = "cmbxItemClassification";
            this.cmbxItemClassification.Size = new System.Drawing.Size(425, 29);
            this.cmbxItemClassification.TabIndex = 2;
            this.cmbxItemClassification.SelectedIndexChanged += new System.EventHandler(this.cmbxItemClassification_SelectedIndexChanged);
            this.cmbxItemClassification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxItemClassification.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // lblItemStockValue
            // 
            this.lblItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemStockValue.AutoSize = true;
            this.lblItemStockValue.Location = new System.Drawing.Point(992, 346);
            this.lblItemStockValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemStockValue.Name = "lblItemStockValue";
            this.lblItemStockValue.Size = new System.Drawing.Size(131, 21);
            this.lblItemStockValue.TabIndex = 44;
            this.lblItemStockValue.Text = "Initial Stock Value";
            // 
            // nudItemStockValue
            // 
            this.nudItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudItemStockValue.Enabled = false;
            this.nudItemStockValue.Location = new System.Drawing.Point(997, 370);
            this.nudItemStockValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudItemStockValue.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudItemStockValue.Name = "nudItemStockValue";
            this.nudItemStockValue.Size = new System.Drawing.Size(424, 29);
            this.nudItemStockValue.TabIndex = 7;
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemCode.Enabled = false;
            this.tbxItemCode.Location = new System.Drawing.Point(997, 316);
            this.tbxItemCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxItemCode.MaxLength = 39;
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.Size = new System.Drawing.Size(423, 29);
            this.tbxItemCode.TabIndex = 6;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(992, 292);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(46, 21);
            this.lblItemCode.TabIndex = 46;
            this.lblItemCode.Text = "Code";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Location = new System.Drawing.Point(1211, 432);
            this.btnCancelItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(102, 42);
            this.btnCancelItem.TabIndex = 10;
            this.btnCancelItem.Text = "&Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveItem.Location = new System.Drawing.Point(1104, 432);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(102, 42);
            this.btnSaveItem.TabIndex = 9;
            this.btnSaveItem.Text = "&Save";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(997, 432);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(102, 42);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "&Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxItemDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemDescription.Enabled = false;
            this.tbxItemDescription.Location = new System.Drawing.Point(997, 262);
            this.tbxItemDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.Size = new System.Drawing.Size(424, 29);
            this.tbxItemDescription.TabIndex = 5;
            // 
            // cmbxMeasurementUnit
            // 
            this.cmbxMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxMeasurementUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMeasurementUnit.Enabled = false;
            this.cmbxMeasurementUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxMeasurementUnit.FormattingEnabled = true;
            this.cmbxMeasurementUnit.Location = new System.Drawing.Point(997, 208);
            this.cmbxMeasurementUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxMeasurementUnit.Name = "cmbxMeasurementUnit";
            this.cmbxMeasurementUnit.Size = new System.Drawing.Size(425, 29);
            this.cmbxMeasurementUnit.TabIndex = 4;
            this.cmbxMeasurementUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxMeasurementUnit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // lblMeasurementUnit
            // 
            this.lblMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeasurementUnit.AutoSize = true;
            this.lblMeasurementUnit.Location = new System.Drawing.Point(992, 185);
            this.lblMeasurementUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeasurementUnit.Name = "lblMeasurementUnit";
            this.lblMeasurementUnit.Size = new System.Drawing.Size(139, 21);
            this.lblMeasurementUnit.TabIndex = 53;
            this.lblMeasurementUnit.Text = "Measurement Unit";
            // 
            // ckbxCementSupplied
            // 
            this.ckbxCementSupplied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxCementSupplied.AutoSize = true;
            this.ckbxCementSupplied.Location = new System.Drawing.Point(992, 402);
            this.ckbxCementSupplied.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxCementSupplied.Name = "ckbxCementSupplied";
            this.ckbxCementSupplied.Size = new System.Drawing.Size(148, 25);
            this.ckbxCementSupplied.TabIndex = 54;
            this.ckbxCementSupplied.Text = "Cement Supplied";
            this.ckbxCementSupplied.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1318, 432);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 89;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(5, 596);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(118, 21);
            this.lblMessage.TabIndex = 90;
            this.lblMessage.Text = "Inventory Items";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 88);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 21);
            this.lblSearch.TabIndex = 91;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSearch.Location = new System.Drawing.Point(67, 87);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(925, 29);
            this.tbxSearch.TabIndex = 92;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnViewPriceHistory
            // 
            this.btnViewPriceHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPriceHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewPriceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPriceHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewPriceHistory.Location = new System.Drawing.Point(1277, 87);
            this.btnViewPriceHistory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnViewPriceHistory.Name = "btnViewPriceHistory";
            this.btnViewPriceHistory.Size = new System.Drawing.Size(143, 42);
            this.btnViewPriceHistory.TabIndex = 93;
            this.btnViewPriceHistory.Text = "&View Price History";
            this.btnViewPriceHistory.UseVisualStyleBackColor = false;
            this.btnViewPriceHistory.Click += new System.EventHandler(this.btnViewPriceHistory_Click);
            // 
            // ItemManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 625);
            this.Controls.Add(this.btnViewPriceHistory);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ckbxCementSupplied);
            this.Controls.Add(this.lblMeasurementUnit);
            this.Controls.Add(this.cmbxMeasurementUnit);
            this.Controls.Add(this.btnCancelItem);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.tbxItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.nudItemStockValue);
            this.Controls.Add(this.lblItemStockValue);
            this.Controls.Add(this.cmbxItemClassification);
            this.Controls.Add(this.lblItemClassification);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblInventoryItems);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory | Items Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemStockValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventoryItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label lblItemClassification;
        private System.Windows.Forms.ComboBox cmbxItemClassification;
        private System.Windows.Forms.Label lblItemStockValue;
        private System.Windows.Forms.NumericUpDown nudItemStockValue;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Button btnCancelItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.ComboBox cmbxMeasurementUnit;
        private System.Windows.Forms.Label lblMeasurementUnit;
        private System.Windows.Forms.CheckBox ckbxCementSupplied;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsStockValue;
        private System.Windows.Forms.Button btnViewPriceHistory;
    }
}