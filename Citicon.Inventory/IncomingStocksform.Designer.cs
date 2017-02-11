﻿namespace Citicon.Inventory
{
    partial class IncomingStocksform
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomingStocksform));
            this.lblIncomingStocks = new System.Windows.Forms.Label();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.tbxSearchItems = new System.Windows.Forms.TextBox();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrGenerateItems = new System.Windows.Forms.Timer(this.components);
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cmbxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tbxItemCode = new System.Windows.Forms.TextBox();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockLastStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddedStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalesInvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPastStockRecords = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tbxItemStockValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxPaymentTerms = new System.Windows.Forms.ComboBox();
            this.cmbxVehicles = new System.Windows.Forms.ComboBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblSiNumber = new System.Windows.Forms.Label();
            this.lblAddedStockValue = new System.Windows.Forms.Label();
            this.lblPaymentTerm = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.nudAddedStockValue = new System.Windows.Forms.NumericUpDown();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbxCompanies = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.cmbxBranches = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbxSuppliers = new System.Windows.Forms.ComboBox();
            this.tbxAcceptedBy = new System.Windows.Forms.TextBox();
            this.lblAcceptedBy = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.tbxRemarks = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDrNumber = new System.Windows.Forms.Label();
            this.nudSiNumber = new System.Windows.Forms.NumericUpDown();
            this.nudDrNumber = new System.Windows.Forms.NumericUpDown();
            this.btnEditSelectedUnitPrice = new System.Windows.Forms.Button();
            this.ckbxIncludeWithHoldingTax = new System.Windows.Forms.CheckBox();
            this.nudWithHoldingTax = new System.Windows.Forms.NumericUpDown();
            this.nudAmountDue = new System.Windows.Forms.NumericUpDown();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.nudVat = new System.Windows.Forms.NumericUpDown();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.nudTotalAmountDue = new System.Windows.Forms.NumericUpDown();
            this.ckbxRetainData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddedStockValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithHoldingTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountDue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncomingStocks
            // 
            this.lblIncomingStocks.BackColor = System.Drawing.Color.White;
            this.lblIncomingStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncomingStocks.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingStocks.Location = new System.Drawing.Point(0, 0);
            this.lblIncomingStocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingStocks.Name = "lblIncomingStocks";
            this.lblIncomingStocks.Size = new System.Drawing.Size(1458, 84);
            this.lblIncomingStocks.TabIndex = 10;
            this.lblIncomingStocks.Text = "Incoming Stocks";
            this.lblIncomingStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(10, 84);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(92, 21);
            this.lblSearchItem.TabIndex = 11;
            this.lblSearchItem.Text = "Search Item";
            // 
            // tbxSearchItems
            // 
            this.tbxSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchItems.BackColor = System.Drawing.Color.White;
            this.tbxSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearchItems.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSearchItems.Location = new System.Drawing.Point(14, 108);
            this.tbxSearchItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxSearchItems.Name = "tbxSearchItems";
            this.tbxSearchItems.Size = new System.Drawing.Size(954, 29);
            this.tbxSearchItems.TabIndex = 12;
            this.tbxSearchItems.TextChanged += new System.EventHandler(this.tbxSearchItems_TextChanged);
            this.tbxSearchItems.Enter += new System.EventHandler(this.tbxSearchItems_Enter);
            this.tbxSearchItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchItems_KeyDown);
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.BackColor = System.Drawing.Color.Red;
            this.btnSearchItems.FlatAppearance.BorderSize = 0;
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.ForeColor = System.Drawing.Color.White;
            this.btnSearchItems.Location = new System.Drawing.Point(1346, 108);
            this.btnSearchItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(102, 28);
            this.btnSearchItems.TabIndex = 36;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            this.btnSearchItems.Click += new System.EventHandler(this.btnSearchItems_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 50;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colCode,
            this.colClassification,
            this.colStockValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(14, 139);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(953, 0);
            this.dgvItems.TabIndex = 37;
            this.dgvItems.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.dgvItems_QueryContinueDrag);
            this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            this.colCode.Width = 70;
            // 
            // colClassification
            // 
            this.colClassification.HeaderText = "Classification";
            this.colClassification.Name = "colClassification";
            this.colClassification.ReadOnly = true;
            this.colClassification.Width = 125;
            // 
            // colStockValue
            // 
            this.colStockValue.HeaderText = "Stock Value";
            this.colStockValue.Name = "colStockValue";
            this.colStockValue.ReadOnly = true;
            this.colStockValue.Width = 104;
            // 
            // tmrGenerateItems
            // 
            this.tmrGenerateItems.Interval = 60000;
            this.tmrGenerateItems.Tick += new System.EventHandler(this.tmrGenerateItems_Tick);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(968, 83);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(78, 21);
            this.lblSearchBy.TabIndex = 38;
            this.lblSearchBy.Text = "Search By";
            // 
            // cmbxSearchBy
            // 
            this.cmbxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSearchBy.FormattingEnabled = true;
            this.cmbxSearchBy.Location = new System.Drawing.Point(972, 107);
            this.cmbxSearchBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxSearchBy.Name = "cmbxSearchBy";
            this.cmbxSearchBy.Size = new System.Drawing.Size(369, 29);
            this.cmbxSearchBy.TabIndex = 39;
            this.cmbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchBy_SelectedIndexChanged);
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(10, 143);
            this.lblItemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(124, 21);
            this.lblItemDescription.TabIndex = 40;
            this.lblItemDescription.Text = "Item Description";
            // 
            // tbxItemDescription
            // 
            this.tbxItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemDescription.BackColor = System.Drawing.Color.White;
            this.tbxItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemDescription.Location = new System.Drawing.Point(14, 166);
            this.tbxItemDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.ReadOnly = true;
            this.tbxItemDescription.Size = new System.Drawing.Size(493, 29);
            this.tbxItemDescription.TabIndex = 41;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(507, 143);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(81, 21);
            this.lblItemCode.TabIndex = 46;
            this.lblItemCode.Text = "Item Code";
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemCode.BackColor = System.Drawing.Color.White;
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemCode.Location = new System.Drawing.Point(511, 166);
            this.tbxItemCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.ReadOnly = true;
            this.tbxItemCode.Size = new System.Drawing.Size(299, 29);
            this.tbxItemCode.TabIndex = 47;
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStocks.ColumnHeadersHeight = 50;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStock,
            this.colStockLastStockValue,
            this.colAddedStockValue,
            this.colSupplier,
            this.colSalesInvoiceNumber,
            this.colDeliveryReceiptNumber,
            this.colStockDeliveryDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStocks.EnableHeadersVisualStyles = false;
            this.dgvStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvStocks.Location = new System.Drawing.Point(14, 220);
            this.dgvStocks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvStocks.MultiSelect = false;
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.RowTemplate.Height = 30;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(954, 557);
            this.dgvStocks.TabIndex = 50;
            // 
            // colStock
            // 
            this.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Visible = false;
            // 
            // colStockLastStockValue
            // 
            this.colStockLastStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStockLastStockValue.HeaderText = "Last Stock Value";
            this.colStockLastStockValue.Name = "colStockLastStockValue";
            this.colStockLastStockValue.ReadOnly = true;
            this.colStockLastStockValue.Width = 132;
            // 
            // colAddedStockValue
            // 
            this.colAddedStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddedStockValue.HeaderText = "Added Stock Value";
            this.colAddedStockValue.Name = "colAddedStockValue";
            this.colAddedStockValue.ReadOnly = true;
            this.colAddedStockValue.Width = 113;
            // 
            // colSupplier
            // 
            this.colSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 92;
            // 
            // colSalesInvoiceNumber
            // 
            this.colSalesInvoiceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSalesInvoiceNumber.HeaderText = "SI No.";
            this.colSalesInvoiceNumber.Name = "colSalesInvoiceNumber";
            this.colSalesInvoiceNumber.ReadOnly = true;
            this.colSalesInvoiceNumber.Width = 69;
            // 
            // colDeliveryReceiptNumber
            // 
            this.colDeliveryReceiptNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDeliveryReceiptNumber.HeaderText = "DR No.";
            this.colDeliveryReceiptNumber.Name = "colDeliveryReceiptNumber";
            this.colDeliveryReceiptNumber.ReadOnly = true;
            this.colDeliveryReceiptNumber.Width = 77;
            // 
            // colStockDeliveryDate
            // 
            this.colStockDeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStockDeliveryDate.HeaderText = "Delivery Date";
            this.colStockDeliveryDate.Name = "colStockDeliveryDate";
            this.colStockDeliveryDate.ReadOnly = true;
            this.colStockDeliveryDate.Width = 116;
            // 
            // lblPastStockRecords
            // 
            this.lblPastStockRecords.AutoSize = true;
            this.lblPastStockRecords.Location = new System.Drawing.Point(10, 197);
            this.lblPastStockRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPastStockRecords.Name = "lblPastStockRecords";
            this.lblPastStockRecords.Size = new System.Drawing.Size(139, 21);
            this.lblPastStockRecords.TabIndex = 51;
            this.lblPastStockRecords.Text = "Past Stock Records";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeliveryDate.CustomFormat = "MMM dd, yyyy";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(972, 244);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(237, 29);
            this.dtpDeliveryDate.TabIndex = 53;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // tbxItemStockValue
            // 
            this.tbxItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemStockValue.BackColor = System.Drawing.Color.White;
            this.tbxItemStockValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemStockValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemStockValue.Location = new System.Drawing.Point(814, 166);
            this.tbxItemStockValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxItemStockValue.Name = "tbxItemStockValue";
            this.tbxItemStockValue.ReadOnly = true;
            this.tbxItemStockValue.Size = new System.Drawing.Size(154, 29);
            this.tbxItemStockValue.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(810, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Stock Value";
            // 
            // cmbxPaymentTerms
            // 
            this.cmbxPaymentTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPaymentTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaymentTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxPaymentTerms.FormattingEnabled = true;
            this.cmbxPaymentTerms.Location = new System.Drawing.Point(1213, 244);
            this.cmbxPaymentTerms.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxPaymentTerms.Name = "cmbxPaymentTerms";
            this.cmbxPaymentTerms.Size = new System.Drawing.Size(235, 29);
            this.cmbxPaymentTerms.TabIndex = 63;
            this.cmbxPaymentTerms.SelectedIndexChanged += new System.EventHandler(this.cmbxPaymentTerms_SelectedIndexChanged);
            this.cmbxPaymentTerms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxPaymentTerms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmbxPaymentTerms_MouseDoubleClick);
            this.cmbxPaymentTerms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // cmbxVehicles
            // 
            this.cmbxVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehicles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxVehicles.FormattingEnabled = true;
            this.cmbxVehicles.Location = new System.Drawing.Point(1112, 166);
            this.cmbxVehicles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxVehicles.Name = "cmbxVehicles";
            this.cmbxVehicles.Size = new System.Drawing.Size(201, 29);
            this.cmbxVehicles.TabIndex = 65;
            this.cmbxVehicles.Visible = false;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(968, 220);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(103, 21);
            this.lblDeliveryDate.TabIndex = 54;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblSiNumber
            // 
            this.lblSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiNumber.AutoSize = true;
            this.lblSiNumber.Location = new System.Drawing.Point(969, 274);
            this.lblSiNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSiNumber.Name = "lblSiNumber";
            this.lblSiNumber.Size = new System.Drawing.Size(51, 21);
            this.lblSiNumber.TabIndex = 55;
            this.lblSiNumber.Text = "SI No.";
            // 
            // lblAddedStockValue
            // 
            this.lblAddedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddedStockValue.AutoSize = true;
            this.lblAddedStockValue.Location = new System.Drawing.Point(969, 381);
            this.lblAddedStockValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddedStockValue.Name = "lblAddedStockValue";
            this.lblAddedStockValue.Size = new System.Drawing.Size(138, 21);
            this.lblAddedStockValue.TabIndex = 61;
            this.lblAddedStockValue.Text = "Added Stock Value";
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.Location = new System.Drawing.Point(1209, 220);
            this.lblPaymentTerm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(108, 21);
            this.lblPaymentTerm.TabIndex = 64;
            this.lblPaymentTerm.Text = "Payment Term";
            // 
            // lblVehicle
            // 
            this.lblVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(1108, 143);
            this.lblVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(59, 21);
            this.lblVehicle.TabIndex = 66;
            this.lblVehicle.Text = "Vehicle";
            this.lblVehicle.Visible = false;
            // 
            // nudAddedStockValue
            // 
            this.nudAddedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAddedStockValue.DecimalPlaces = 2;
            this.nudAddedStockValue.Location = new System.Drawing.Point(973, 405);
            this.nudAddedStockValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudAddedStockValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAddedStockValue.Name = "nudAddedStockValue";
            this.nudAddedStockValue.Size = new System.Drawing.Size(236, 29);
            this.nudAddedStockValue.TabIndex = 67;
            this.nudAddedStockValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAddedStockValue.ThousandsSeparator = true;
            this.nudAddedStockValue.ValueChanged += new System.EventHandler(this.nudUnitPrice_ValueChanged);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(1209, 381);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(77, 21);
            this.lblUnitPrice.TabIndex = 68;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudUnitPrice.DecimalPlaces = 4;
            this.nudUnitPrice.Location = new System.Drawing.Point(1213, 405);
            this.nudUnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(234, 29);
            this.nudUnitPrice.TabIndex = 69;
            this.nudUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudUnitPrice.ThousandsSeparator = true;
            this.nudUnitPrice.ValueChanged += new System.EventHandler(this.nudUnitPrice_ValueChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(969, 328);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(77, 21);
            this.lblCompany.TabIndex = 73;
            this.lblCompany.Text = "Company";
            // 
            // cmbxCompanies
            // 
            this.cmbxCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCompanies.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCompanies.FormattingEnabled = true;
            this.cmbxCompanies.Location = new System.Drawing.Point(973, 351);
            this.cmbxCompanies.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxCompanies.Name = "cmbxCompanies";
            this.cmbxCompanies.Size = new System.Drawing.Size(236, 29);
            this.cmbxCompanies.TabIndex = 72;
            this.cmbxCompanies.SelectedIndexChanged += new System.EventHandler(this.cmbxCompanies_SelectedIndexChanged);
            this.cmbxCompanies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxCompanies.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(1209, 328);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(58, 21);
            this.lblBranch.TabIndex = 71;
            this.lblBranch.Text = "Branch";
            // 
            // cmbxBranches
            // 
            this.cmbxBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBranches.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBranches.FormattingEnabled = true;
            this.cmbxBranches.Location = new System.Drawing.Point(1213, 351);
            this.cmbxBranches.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxBranches.Name = "cmbxBranches";
            this.cmbxBranches.Size = new System.Drawing.Size(235, 29);
            this.cmbxBranches.TabIndex = 70;
            this.cmbxBranches.SelectedIndexChanged += new System.EventHandler(this.cmbxCompanies_SelectedIndexChanged);
            this.cmbxBranches.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxBranches.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(969, 560);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(68, 21);
            this.lblSupplier.TabIndex = 75;
            this.lblSupplier.Text = "Supplier";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // cmbxSuppliers
            // 
            this.cmbxSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSuppliers.FormattingEnabled = true;
            this.cmbxSuppliers.Location = new System.Drawing.Point(977, 582);
            this.cmbxSuppliers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxSuppliers.Name = "cmbxSuppliers";
            this.cmbxSuppliers.Size = new System.Drawing.Size(476, 29);
            this.cmbxSuppliers.TabIndex = 74;
            this.cmbxSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbxCompanies_SelectedIndexChanged);
            this.cmbxSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbx_KeyDown);
            this.cmbxSuppliers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.searchableComboBox);
            // 
            // tbxAcceptedBy
            // 
            this.tbxAcceptedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAcceptedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxAcceptedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxAcceptedBy.BackColor = System.Drawing.Color.White;
            this.tbxAcceptedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAcceptedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxAcceptedBy.Location = new System.Drawing.Point(977, 690);
            this.tbxAcceptedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxAcceptedBy.Name = "tbxAcceptedBy";
            this.tbxAcceptedBy.Size = new System.Drawing.Size(475, 29);
            this.tbxAcceptedBy.TabIndex = 77;
            this.tbxAcceptedBy.TextChanged += new System.EventHandler(this.tbxAcceptedBy_TextChanged);
            this.tbxAcceptedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAcceptedBy_KeyDown);
            this.tbxAcceptedBy.Leave += new System.EventHandler(this.tbxAcceptedBy_Leave);
            // 
            // lblAcceptedBy
            // 
            this.lblAcceptedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcceptedBy.AutoSize = true;
            this.lblAcceptedBy.Location = new System.Drawing.Point(969, 668);
            this.lblAcceptedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceptedBy.Name = "lblAcceptedBy";
            this.lblAcceptedBy.Size = new System.Drawing.Size(94, 21);
            this.lblAcceptedBy.TabIndex = 76;
            this.lblAcceptedBy.Text = "Accepted By";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1135, 781);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 42);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1242, 781);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 42);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(975, 722);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(71, 21);
            this.lblRemarks.TabIndex = 80;
            this.lblRemarks.Text = "Remarks";
            // 
            // tbxRemarks
            // 
            this.tbxRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxRemarks.BackColor = System.Drawing.Color.White;
            this.tbxRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRemarks.Location = new System.Drawing.Point(977, 743);
            this.tbxRemarks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxRemarks.Name = "tbxRemarks";
            this.tbxRemarks.Size = new System.Drawing.Size(475, 29);
            this.tbxRemarks.TabIndex = 81;
            this.tbxRemarks.TextChanged += new System.EventHandler(this.tbxRemarks_TextChanged);
            // 
            // lblLength
            // 
            this.lblLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLength.AutoSize = true;
            this.lblLength.Enabled = false;
            this.lblLength.Location = new System.Drawing.Point(969, 612);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(58, 21);
            this.lblLength.TabIndex = 82;
            this.lblLength.Tag = "MeasurementDescription";
            this.lblLength.Text = "Length";
            // 
            // nudLength
            // 
            this.nudLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLength.DecimalPlaces = 2;
            this.nudLength.Enabled = false;
            this.nudLength.Location = new System.Drawing.Point(973, 636);
            this.nudLength.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(163, 29);
            this.nudLength.TabIndex = 83;
            this.nudLength.Tag = "MeasurementDescription";
            this.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLength.ThousandsSeparator = true;
            this.nudLength.ValueChanged += new System.EventHandler(this.nudLength_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWidth.DecimalPlaces = 2;
            this.nudWidth.Enabled = false;
            this.nudWidth.Location = new System.Drawing.Point(1140, 636);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(151, 29);
            this.nudWidth.TabIndex = 84;
            this.nudWidth.Tag = "MeasurementDescription";
            this.nudWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWidth.ThousandsSeparator = true;
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHeight.DecimalPlaces = 2;
            this.nudHeight.Enabled = false;
            this.nudHeight.Location = new System.Drawing.Point(1295, 636);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(157, 29);
            this.nudHeight.TabIndex = 85;
            this.nudHeight.Tag = "MeasurementDescription";
            this.nudHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHeight.ThousandsSeparator = true;
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Enabled = false;
            this.lblWidth.Location = new System.Drawing.Point(1136, 612);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(52, 21);
            this.lblWidth.TabIndex = 86;
            this.lblWidth.Tag = "MeasurementDescription";
            this.lblWidth.Text = "Width";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Enabled = false;
            this.lblHeight.Location = new System.Drawing.Point(1291, 614);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 21);
            this.lblHeight.TabIndex = 87;
            this.lblHeight.Tag = "MeasurementDescription";
            this.lblHeight.Text = "Height";
            this.lblHeight.Click += new System.EventHandler(this.lblHeight_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1350, 781);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDrNumber
            // 
            this.lblDrNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrNumber.AutoSize = true;
            this.lblDrNumber.Location = new System.Drawing.Point(1209, 274);
            this.lblDrNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDrNumber.Name = "lblDrNumber";
            this.lblDrNumber.Size = new System.Drawing.Size(59, 21);
            this.lblDrNumber.TabIndex = 89;
            this.lblDrNumber.Text = "DR No.";
            // 
            // nudSiNumber
            // 
            this.nudSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSiNumber.Location = new System.Drawing.Point(973, 297);
            this.nudSiNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudSiNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSiNumber.Name = "nudSiNumber";
            this.nudSiNumber.Size = new System.Drawing.Size(236, 29);
            this.nudSiNumber.TabIndex = 90;
            this.nudSiNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDrNumber
            // 
            this.nudDrNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDrNumber.Location = new System.Drawing.Point(1213, 297);
            this.nudDrNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudDrNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDrNumber.Name = "nudDrNumber";
            this.nudDrNumber.Size = new System.Drawing.Size(234, 29);
            this.nudDrNumber.TabIndex = 91;
            this.nudDrNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEditSelectedUnitPrice
            // 
            this.btnEditSelectedUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSelectedUnitPrice.BackColor = System.Drawing.Color.Red;
            this.btnEditSelectedUnitPrice.FlatAppearance.BorderSize = 0;
            this.btnEditSelectedUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelectedUnitPrice.ForeColor = System.Drawing.Color.White;
            this.btnEditSelectedUnitPrice.Location = new System.Drawing.Point(804, 783);
            this.btnEditSelectedUnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditSelectedUnitPrice.Name = "btnEditSelectedUnitPrice";
            this.btnEditSelectedUnitPrice.Size = new System.Drawing.Size(164, 42);
            this.btnEditSelectedUnitPrice.TabIndex = 92;
            this.btnEditSelectedUnitPrice.Text = "Edit  Selected";
            this.btnEditSelectedUnitPrice.UseVisualStyleBackColor = false;
            this.btnEditSelectedUnitPrice.Click += new System.EventHandler(this.btnEditSelectedUnitPrice_Click);
            // 
            // ckbxIncludeWithHoldingTax
            // 
            this.ckbxIncludeWithHoldingTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxIncludeWithHoldingTax.AutoSize = true;
            this.ckbxIncludeWithHoldingTax.Location = new System.Drawing.Point(971, 438);
            this.ckbxIncludeWithHoldingTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxIncludeWithHoldingTax.Name = "ckbxIncludeWithHoldingTax";
            this.ckbxIncludeWithHoldingTax.Size = new System.Drawing.Size(202, 25);
            this.ckbxIncludeWithHoldingTax.TabIndex = 93;
            this.ckbxIncludeWithHoldingTax.Text = "Include With-Holding Tax";
            this.ckbxIncludeWithHoldingTax.UseVisualStyleBackColor = true;
            this.ckbxIncludeWithHoldingTax.CheckedChanged += new System.EventHandler(this.ckbxIncludeWithHoldingTax_CheckedChanged);
            // 
            // nudWithHoldingTax
            // 
            this.nudWithHoldingTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWithHoldingTax.DecimalPlaces = 2;
            this.nudWithHoldingTax.Enabled = false;
            this.nudWithHoldingTax.Location = new System.Drawing.Point(973, 467);
            this.nudWithHoldingTax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudWithHoldingTax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudWithHoldingTax.Name = "nudWithHoldingTax";
            this.nudWithHoldingTax.Size = new System.Drawing.Size(236, 29);
            this.nudWithHoldingTax.TabIndex = 94;
            this.nudWithHoldingTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWithHoldingTax.ThousandsSeparator = true;
            this.nudWithHoldingTax.ValueChanged += new System.EventHandler(this.nudUnitPrice_ValueChanged);
            this.nudWithHoldingTax.EnabledChanged += new System.EventHandler(this.nudWithHoldingTax_EnabledChanged);
            // 
            // nudAmountDue
            // 
            this.nudAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmountDue.DecimalPlaces = 2;
            this.nudAmountDue.Location = new System.Drawing.Point(1213, 467);
            this.nudAmountDue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudAmountDue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudAmountDue.Name = "nudAmountDue";
            this.nudAmountDue.Size = new System.Drawing.Size(234, 29);
            this.nudAmountDue.TabIndex = 95;
            this.nudAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmountDue.ThousandsSeparator = true;
            this.nudAmountDue.ValueChanged += new System.EventHandler(this.nudAmountDue_ValueChanged);
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(1213, 438);
            this.lblAmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(98, 21);
            this.lblAmountDue.TabIndex = 96;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // lblVat
            // 
            this.lblVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(973, 500);
            this.lblVat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(36, 21);
            this.lblVat.TabIndex = 98;
            this.lblVat.Text = "VAT";
            // 
            // nudVat
            // 
            this.nudVat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVat.DecimalPlaces = 2;
            this.nudVat.Location = new System.Drawing.Point(973, 528);
            this.nudVat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudVat.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudVat.Name = "nudVat";
            this.nudVat.Size = new System.Drawing.Size(236, 29);
            this.nudVat.TabIndex = 97;
            this.nudVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVat.ThousandsSeparator = true;
            this.nudVat.ValueChanged += new System.EventHandler(this.nudVat_ValueChanged);
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.Location = new System.Drawing.Point(1213, 500);
            this.lblTotalAmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(134, 21);
            this.lblTotalAmountDue.TabIndex = 100;
            this.lblTotalAmountDue.Text = "Total Amount Due";
            // 
            // nudTotalAmountDue
            // 
            this.nudTotalAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTotalAmountDue.DecimalPlaces = 2;
            this.nudTotalAmountDue.Location = new System.Drawing.Point(1213, 528);
            this.nudTotalAmountDue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nudTotalAmountDue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudTotalAmountDue.Name = "nudTotalAmountDue";
            this.nudTotalAmountDue.Size = new System.Drawing.Size(238, 29);
            this.nudTotalAmountDue.TabIndex = 99;
            this.nudTotalAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmountDue.ThousandsSeparator = true;
            // 
            // ckbxRetainData
            // 
            this.ckbxRetainData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxRetainData.AutoSize = true;
            this.ckbxRetainData.Location = new System.Drawing.Point(977, 783);
            this.ckbxRetainData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxRetainData.Name = "ckbxRetainData";
            this.ckbxRetainData.Size = new System.Drawing.Size(109, 25);
            this.ckbxRetainData.TabIndex = 101;
            this.ckbxRetainData.Text = "Retain Data";
            this.ckbxRetainData.UseVisualStyleBackColor = true;
            this.ckbxRetainData.CheckedChanged += new System.EventHandler(this.ckbxRetainData_CheckedChanged);
            // 
            // IncomingStocksform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1458, 834);
            this.Controls.Add(this.ckbxRetainData);
            this.Controls.Add(this.lblTotalAmountDue);
            this.Controls.Add(this.nudTotalAmountDue);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.nudVat);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.nudAmountDue);
            this.Controls.Add(this.nudWithHoldingTax);
            this.Controls.Add(this.ckbxIncludeWithHoldingTax);
            this.Controls.Add(this.btnEditSelectedUnitPrice);
            this.Controls.Add(this.nudDrNumber);
            this.Controls.Add(this.nudSiNumber);
            this.Controls.Add(this.lblDrNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.nudLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.tbxRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxAcceptedBy);
            this.Controls.Add(this.lblAcceptedBy);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.cmbxSuppliers);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbxCompanies);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.cmbxBranches);
            this.Controls.Add(this.nudUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.nudAddedStockValue);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.cmbxVehicles);
            this.Controls.Add(this.lblPaymentTerm);
            this.Controls.Add(this.cmbxPaymentTerms);
            this.Controls.Add(this.lblAddedStockValue);
            this.Controls.Add(this.tbxItemStockValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSiNumber);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.lblPastStockRecords);
            this.Controls.Add(this.tbxItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.cmbxSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.btnSearchItems);
            this.Controls.Add(this.tbxSearchItems);
            this.Controls.Add(this.lblSearchItem);
            this.Controls.Add(this.lblIncomingStocks);
            this.Controls.Add(this.dgvStocks);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IncomingStocksform";
            this.Text = "Citicon Inventory | Incoming Stocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncomingStocksform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddedStockValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSiNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithHoldingTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountDue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomingStocks;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.TextBox tbxSearchItems;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Timer tmrGenerateItems;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbxSearchBy;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label lblPastStockRecords;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox tbxItemStockValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxPaymentTerms;
        private System.Windows.Forms.ComboBox cmbxVehicles;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.Label lblAddedStockValue;
        private System.Windows.Forms.Label lblSiNumber;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.NumericUpDown nudAddedStockValue;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbxCompanies;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.ComboBox cmbxBranches;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbxSuppliers;
        private System.Windows.Forms.TextBox tbxAcceptedBy;
        private System.Windows.Forms.Label lblAcceptedBy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox tbxRemarks;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDrNumber;
        private System.Windows.Forms.NumericUpDown nudSiNumber;
        private System.Windows.Forms.NumericUpDown nudDrNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockValue;
        private System.Windows.Forms.Button btnEditSelectedUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockLastStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalesInvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryReceiptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDeliveryDate;
        private System.Windows.Forms.CheckBox ckbxIncludeWithHoldingTax;
        private System.Windows.Forms.NumericUpDown nudWithHoldingTax;
        private System.Windows.Forms.NumericUpDown nudAmountDue;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.NumericUpDown nudVat;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.NumericUpDown nudTotalAmountDue;
        private System.Windows.Forms.CheckBox ckbxRetainData;
    }
}