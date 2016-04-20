namespace Citicon.Inventory
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
            this.lblIncomingStocks = new System.Windows.Forms.Label();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.tbxSearchItems = new System.Windows.Forms.TextBox();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colStockDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPastStockRecords = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tbxSidrNumber = new System.Windows.Forms.TextBox();
            this.tbxItemStockValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxPaymentTerms = new System.Windows.Forms.ComboBox();
            this.cmbxVehicles = new System.Windows.Forms.ComboBox();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblSidrNumber = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddedStockValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncomingStocks
            // 
            this.lblIncomingStocks.BackColor = System.Drawing.Color.White;
            this.lblIncomingStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIncomingStocks.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomingStocks.Location = new System.Drawing.Point(0, 0);
            this.lblIncomingStocks.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIncomingStocks.Name = "lblIncomingStocks";
            this.lblIncomingStocks.Size = new System.Drawing.Size(1454, 100);
            this.lblIncomingStocks.TabIndex = 10;
            this.lblIncomingStocks.Text = "Incoming Stocks";
            this.lblIncomingStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(12, 100);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(111, 25);
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
            this.tbxSearchItems.Location = new System.Drawing.Point(17, 128);
            this.tbxSearchItems.Name = "tbxSearchItems";
            this.tbxSearchItems.Size = new System.Drawing.Size(923, 33);
            this.tbxSearchItems.TabIndex = 12;
            this.tbxSearchItems.TextChanged += new System.EventHandler(this.tbxSearchItems_TextChanged);
            this.tbxSearchItems.Enter += new System.EventHandler(this.tbxSearchItems_Enter);
            this.tbxSearchItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchItems_KeyDown);
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchItems.FlatAppearance.BorderSize = 0;
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.ForeColor = System.Drawing.Color.White;
            this.btnSearchItems.Location = new System.Drawing.Point(1317, 128);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(125, 33);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.colSubClassification,
            this.colStockValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvItems.Location = new System.Drawing.Point(17, 167);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1302, 0);
            this.dgvItems.TabIndex = 37;
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
            this.colCode.Width = 80;
            // 
            // colClassification
            // 
            this.colClassification.HeaderText = "Classification";
            this.colClassification.Name = "colClassification";
            this.colClassification.ReadOnly = true;
            this.colClassification.Width = 147;
            // 
            // colSubClassification
            // 
            this.colSubClassification.HeaderText = "Sub-Classification";
            this.colSubClassification.Name = "colSubClassification";
            this.colSubClassification.ReadOnly = true;
            this.colSubClassification.Width = 187;
            // 
            // colStockValue
            // 
            this.colStockValue.HeaderText = "Stock Value";
            this.colStockValue.Name = "colStockValue";
            this.colStockValue.ReadOnly = true;
            this.colStockValue.Width = 134;
            // 
            // tmrGenerateItems
            // 
            this.tmrGenerateItems.Interval = 10000;
            this.tmrGenerateItems.Tick += new System.EventHandler(this.tmrGenerateItems_Tick);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(941, 99);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(94, 25);
            this.lblSearchBy.TabIndex = 38;
            this.lblSearchBy.Text = "Search By";
            // 
            // cmbxSearchBy
            // 
            this.cmbxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSearchBy.FormattingEnabled = true;
            this.cmbxSearchBy.Location = new System.Drawing.Point(946, 127);
            this.cmbxSearchBy.Name = "cmbxSearchBy";
            this.cmbxSearchBy.Size = new System.Drawing.Size(365, 33);
            this.cmbxSearchBy.TabIndex = 39;
            this.cmbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchBy_SelectedIndexChanged);
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(12, 170);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(150, 25);
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
            this.tbxItemDescription.Location = new System.Drawing.Point(17, 198);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.ReadOnly = true;
            this.tbxItemDescription.Size = new System.Drawing.Size(358, 33);
            this.tbxItemDescription.TabIndex = 41;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(376, 170);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(98, 25);
            this.lblItemCode.TabIndex = 46;
            this.lblItemCode.Text = "Item Code";
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemCode.BackColor = System.Drawing.Color.White;
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemCode.Location = new System.Drawing.Point(381, 198);
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.ReadOnly = true;
            this.tbxItemCode.Size = new System.Drawing.Size(365, 33);
            this.tbxItemCode.TabIndex = 47;
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
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
            this.colStockDeliveryDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStocks.EnableHeadersVisualStyles = false;
            this.dgvStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvStocks.Location = new System.Drawing.Point(17, 262);
            this.dgvStocks.MultiSelect = false;
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.RowTemplate.Height = 30;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(923, 643);
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
            this.colStockLastStockValue.Width = 172;
            // 
            // colAddedStockValue
            // 
            this.colAddedStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colAddedStockValue.HeaderText = "Added Stock Value";
            this.colAddedStockValue.Name = "colAddedStockValue";
            this.colAddedStockValue.ReadOnly = true;
            this.colAddedStockValue.Width = 194;
            // 
            // colStockDeliveryDate
            // 
            this.colStockDeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStockDeliveryDate.HeaderText = "Delivery Date";
            this.colStockDeliveryDate.Name = "colStockDeliveryDate";
            this.colStockDeliveryDate.ReadOnly = true;
            this.colStockDeliveryDate.Width = 148;
            // 
            // lblPastStockRecords
            // 
            this.lblPastStockRecords.AutoSize = true;
            this.lblPastStockRecords.Location = new System.Drawing.Point(12, 234);
            this.lblPastStockRecords.Name = "lblPastStockRecords";
            this.lblPastStockRecords.Size = new System.Drawing.Size(169, 25);
            this.lblPastStockRecords.TabIndex = 51;
            this.lblPastStockRecords.Text = "Past Stock Records";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDeliveryDate.CustomFormat = "MMM dd, yyyy";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(951, 290);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(245, 33);
            this.dtpDeliveryDate.TabIndex = 53;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // tbxSidrNumber
            // 
            this.tbxSidrNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSidrNumber.BackColor = System.Drawing.Color.White;
            this.tbxSidrNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSidrNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSidrNumber.Location = new System.Drawing.Point(1202, 354);
            this.tbxSidrNumber.Name = "tbxSidrNumber";
            this.tbxSidrNumber.Size = new System.Drawing.Size(244, 33);
            this.tbxSidrNumber.TabIndex = 56;
            // 
            // tbxItemStockValue
            // 
            this.tbxItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemStockValue.BackColor = System.Drawing.Color.White;
            this.tbxItemStockValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemStockValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemStockValue.Location = new System.Drawing.Point(752, 198);
            this.tbxItemStockValue.Name = "tbxItemStockValue";
            this.tbxItemStockValue.ReadOnly = true;
            this.tbxItemStockValue.Size = new System.Drawing.Size(188, 33);
            this.tbxItemStockValue.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Stock Value";
            // 
            // cmbxPaymentTerms
            // 
            this.cmbxPaymentTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxPaymentTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaymentTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxPaymentTerms.FormattingEnabled = true;
            this.cmbxPaymentTerms.Location = new System.Drawing.Point(1202, 290);
            this.cmbxPaymentTerms.Name = "cmbxPaymentTerms";
            this.cmbxPaymentTerms.Size = new System.Drawing.Size(245, 33);
            this.cmbxPaymentTerms.TabIndex = 63;
            this.cmbxPaymentTerms.SelectedIndexChanged += new System.EventHandler(this.cmbxPaymentTerms_SelectedIndexChanged);
            // 
            // cmbxVehicles
            // 
            this.cmbxVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVehicles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxVehicles.FormattingEnabled = true;
            this.cmbxVehicles.Location = new System.Drawing.Point(951, 354);
            this.cmbxVehicles.Name = "cmbxVehicles";
            this.cmbxVehicles.Size = new System.Drawing.Size(245, 33);
            this.cmbxVehicles.TabIndex = 65;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(946, 262);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(124, 25);
            this.lblDeliveryDate.TabIndex = 54;
            this.lblDeliveryDate.Text = "Delivery Date";
            // 
            // lblSidrNumber
            // 
            this.lblSidrNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSidrNumber.AutoSize = true;
            this.lblSidrNumber.Location = new System.Drawing.Point(1197, 326);
            this.lblSidrNumber.Name = "lblSidrNumber";
            this.lblSidrNumber.Size = new System.Drawing.Size(85, 25);
            this.lblSidrNumber.TabIndex = 55;
            this.lblSidrNumber.Text = "SIDR No.";
            // 
            // lblAddedStockValue
            // 
            this.lblAddedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddedStockValue.AutoSize = true;
            this.lblAddedStockValue.Location = new System.Drawing.Point(946, 454);
            this.lblAddedStockValue.Name = "lblAddedStockValue";
            this.lblAddedStockValue.Size = new System.Drawing.Size(170, 25);
            this.lblAddedStockValue.TabIndex = 61;
            this.lblAddedStockValue.Text = "Added Stock Value";
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.Location = new System.Drawing.Point(1197, 262);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(133, 25);
            this.lblPaymentTerm.TabIndex = 64;
            this.lblPaymentTerm.Text = "Payment Term";
            // 
            // lblVehicle
            // 
            this.lblVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Location = new System.Drawing.Point(946, 326);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(74, 25);
            this.lblVehicle.TabIndex = 66;
            this.lblVehicle.Text = "Vehicle";
            // 
            // nudAddedStockValue
            // 
            this.nudAddedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAddedStockValue.Location = new System.Drawing.Point(951, 482);
            this.nudAddedStockValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAddedStockValue.Name = "nudAddedStockValue";
            this.nudAddedStockValue.Size = new System.Drawing.Size(245, 33);
            this.nudAddedStockValue.TabIndex = 67;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(1197, 454);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(94, 25);
            this.lblUnitPrice.TabIndex = 68;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // nudUnitPrice
            // 
            this.nudUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudUnitPrice.DecimalPlaces = 2;
            this.nudUnitPrice.Location = new System.Drawing.Point(1202, 482);
            this.nudUnitPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(245, 33);
            this.nudUnitPrice.TabIndex = 69;
            this.nudUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(1197, 390);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(92, 25);
            this.lblCompany.TabIndex = 73;
            this.lblCompany.Text = "Company";
            // 
            // cmbxCompanies
            // 
            this.cmbxCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCompanies.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCompanies.FormattingEnabled = true;
            this.cmbxCompanies.Location = new System.Drawing.Point(1202, 418);
            this.cmbxCompanies.Name = "cmbxCompanies";
            this.cmbxCompanies.Size = new System.Drawing.Size(245, 33);
            this.cmbxCompanies.TabIndex = 72;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(946, 390);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(71, 25);
            this.lblBranch.TabIndex = 71;
            this.lblBranch.Text = "Branch";
            // 
            // cmbxBranches
            // 
            this.cmbxBranches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxBranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBranches.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBranches.FormattingEnabled = true;
            this.cmbxBranches.Location = new System.Drawing.Point(951, 418);
            this.cmbxBranches.Name = "cmbxBranches";
            this.cmbxBranches.Size = new System.Drawing.Size(245, 33);
            this.cmbxBranches.TabIndex = 70;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(946, 518);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(82, 25);
            this.lblSupplier.TabIndex = 75;
            this.lblSupplier.Text = "Supplier";
            // 
            // cmbxSuppliers
            // 
            this.cmbxSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSuppliers.FormattingEnabled = true;
            this.cmbxSuppliers.Location = new System.Drawing.Point(951, 546);
            this.cmbxSuppliers.Name = "cmbxSuppliers";
            this.cmbxSuppliers.Size = new System.Drawing.Size(496, 33);
            this.cmbxSuppliers.TabIndex = 74;
            // 
            // tbxAcceptedBy
            // 
            this.tbxAcceptedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAcceptedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxAcceptedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxAcceptedBy.BackColor = System.Drawing.Color.White;
            this.tbxAcceptedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAcceptedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxAcceptedBy.Location = new System.Drawing.Point(951, 610);
            this.tbxAcceptedBy.Name = "tbxAcceptedBy";
            this.tbxAcceptedBy.Size = new System.Drawing.Size(496, 33);
            this.tbxAcceptedBy.TabIndex = 77;
            this.tbxAcceptedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAcceptedBy_KeyDown);
            this.tbxAcceptedBy.Leave += new System.EventHandler(this.tbxAcceptedBy_Leave);
            // 
            // lblAcceptedBy
            // 
            this.lblAcceptedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcceptedBy.AutoSize = true;
            this.lblAcceptedBy.Location = new System.Drawing.Point(946, 582);
            this.lblAcceptedBy.Name = "lblAcceptedBy";
            this.lblAcceptedBy.Size = new System.Drawing.Size(115, 25);
            this.lblAcceptedBy.TabIndex = 76;
            this.lblAcceptedBy.Text = "Accepted By";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1191, 713);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1322, 713);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(946, 646);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(83, 25);
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
            this.tbxRemarks.Location = new System.Drawing.Point(951, 674);
            this.tbxRemarks.Name = "tbxRemarks";
            this.tbxRemarks.Size = new System.Drawing.Size(496, 33);
            this.tbxRemarks.TabIndex = 81;
            // 
            // IncomingStocksform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 917);
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
            this.Controls.Add(this.tbxSidrNumber);
            this.Controls.Add(this.lblSidrNumber);
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
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "IncomingStocksform";
            this.Text = "Citicon Inventory | Incoming Stocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncomingStocksform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddedStockValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnitPrice)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbxSearchBy;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label lblPastStockRecords;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox tbxSidrNumber;
        private System.Windows.Forms.TextBox tbxItemStockValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxPaymentTerms;
        private System.Windows.Forms.ComboBox cmbxVehicles;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.Label lblAddedStockValue;
        private System.Windows.Forms.Label lblSidrNumber;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddedStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockLastStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox tbxRemarks;
    }
}