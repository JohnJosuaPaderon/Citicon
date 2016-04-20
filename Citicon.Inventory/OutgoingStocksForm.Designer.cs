namespace Citicon.Inventory
{
    partial class OutgoingStocksForm
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxItemStockValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPastTransactionRecords = new System.Windows.Forms.Label();
            this.tbxItemCode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tbxItemDescription = new System.Windows.Forms.TextBox();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.cmbxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnSearchItems = new System.Windows.Forms.Button();
            this.tbxSearchItems = new System.Windows.Forms.TextBox();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.colTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionLastStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionRemovedStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrGenerateItems = new System.Windows.Forms.Timer(this.components);
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lblRemovedStockValue = new System.Windows.Forms.Label();
            this.nudRemovedStockValue = new System.Windows.Forms.NumericUpDown();
            this.cmbxBranch = new System.Windows.Forms.ComboBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbxCompany = new System.Windows.Forms.ComboBox();
            this.lblRequestedBy = new System.Windows.Forms.Label();
            this.lblReleasedBy = new System.Windows.Forms.Label();
            this.tbxRequestedBy = new System.Windows.Forms.TextBox();
            this.tbxReleasedBy = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.tbxPurpose = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemovedStockValue)).BeginInit();
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
            this.lblIncomingStocks.TabIndex = 11;
            this.lblIncomingStocks.Text = "Outgoing Stocks";
            this.lblIncomingStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvItems.TabIndex = 64;
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
            this.tbxItemStockValue.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Stock Value";
            // 
            // lblPastTransactionRecords
            // 
            this.lblPastTransactionRecords.AutoSize = true;
            this.lblPastTransactionRecords.Location = new System.Drawing.Point(12, 234);
            this.lblPastTransactionRecords.Name = "lblPastTransactionRecords";
            this.lblPastTransactionRecords.Size = new System.Drawing.Size(230, 25);
            this.lblPastTransactionRecords.TabIndex = 72;
            this.lblPastTransactionRecords.Text = "Past Transactions Records";
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
            this.tbxItemCode.TabIndex = 70;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(376, 170);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(98, 25);
            this.lblItemCode.TabIndex = 69;
            this.lblItemCode.Text = "Item Code";
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
            this.tbxItemDescription.TabIndex = 68;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(12, 170);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(150, 25);
            this.lblItemDescription.TabIndex = 67;
            this.lblItemDescription.Text = "Item Description";
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
            this.cmbxSearchBy.TabIndex = 66;
            this.cmbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbxSearchBy_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(941, 99);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(94, 25);
            this.lblSearchBy.TabIndex = 65;
            this.lblSearchBy.Text = "Search By";
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
            this.btnSearchItems.TabIndex = 63;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            this.btnSearchItems.Click += new System.EventHandler(this.btnSearchItems_Click);
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
            this.tbxSearchItems.TabIndex = 62;
            this.tbxSearchItems.TextChanged += new System.EventHandler(this.tbxSearchItems_TextChanged);
            this.tbxSearchItems.Enter += new System.EventHandler(this.tbxSearchItems_Enter);
            this.tbxSearchItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchItems_KeyDown);
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(12, 100);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(111, 25);
            this.lblSearchItem.TabIndex = 61;
            this.lblSearchItem.Text = "Search Item";
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
            this.colTransaction,
            this.colTransactionLastStockValue,
            this.colTransactionRemovedStockValue,
            this.colTransactionTransactionDate});
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
            this.dgvStocks.TabIndex = 71;
            // 
            // colTransaction
            // 
            this.colTransaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransaction.HeaderText = "Transaction";
            this.colTransaction.Name = "colTransaction";
            this.colTransaction.ReadOnly = true;
            this.colTransaction.Visible = false;
            // 
            // colTransactionLastStockValue
            // 
            this.colTransactionLastStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTransactionLastStockValue.HeaderText = "Last Stock Value";
            this.colTransactionLastStockValue.Name = "colTransactionLastStockValue";
            this.colTransactionLastStockValue.ReadOnly = true;
            this.colTransactionLastStockValue.Width = 172;
            // 
            // colTransactionRemovedStockValue
            // 
            this.colTransactionRemovedStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTransactionRemovedStockValue.HeaderText = "Removed Stock Value";
            this.colTransactionRemovedStockValue.Name = "colTransactionRemovedStockValue";
            this.colTransactionRemovedStockValue.ReadOnly = true;
            this.colTransactionRemovedStockValue.Width = 217;
            // 
            // colTransactionTransactionDate
            // 
            this.colTransactionTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTransactionTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionTransactionDate.Name = "colTransactionTransactionDate";
            this.colTransactionTransactionDate.ReadOnly = true;
            this.colTransactionTransactionDate.Width = 178;
            // 
            // tmrGenerateItems
            // 
            this.tmrGenerateItems.Interval = 10000;
            this.tmrGenerateItems.Tick += new System.EventHandler(this.tmrGenerateItems_Tick);
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(946, 262);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(154, 25);
            this.lblTransactionDate.TabIndex = 76;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTransactionDate.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(951, 290);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(245, 33);
            this.dtpTransactionDate.TabIndex = 75;
            // 
            // lblRemovedStockValue
            // 
            this.lblRemovedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemovedStockValue.AutoSize = true;
            this.lblRemovedStockValue.Location = new System.Drawing.Point(1197, 262);
            this.lblRemovedStockValue.Name = "lblRemovedStockValue";
            this.lblRemovedStockValue.Size = new System.Drawing.Size(193, 25);
            this.lblRemovedStockValue.TabIndex = 77;
            this.lblRemovedStockValue.Text = "Removed Stock Value";
            // 
            // nudRemovedStockValue
            // 
            this.nudRemovedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRemovedStockValue.Location = new System.Drawing.Point(1202, 290);
            this.nudRemovedStockValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRemovedStockValue.Name = "nudRemovedStockValue";
            this.nudRemovedStockValue.Size = new System.Drawing.Size(245, 33);
            this.nudRemovedStockValue.TabIndex = 78;
            // 
            // cmbxBranch
            // 
            this.cmbxBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBranch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBranch.FormattingEnabled = true;
            this.cmbxBranch.Location = new System.Drawing.Point(951, 354);
            this.cmbxBranch.Name = "cmbxBranch";
            this.cmbxBranch.Size = new System.Drawing.Size(245, 33);
            this.cmbxBranch.TabIndex = 79;
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(946, 326);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(71, 25);
            this.lblBranch.TabIndex = 80;
            this.lblBranch.Text = "Branch";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(1197, 326);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(92, 25);
            this.lblCompany.TabIndex = 82;
            this.lblCompany.Text = "Company";
            // 
            // cmbxCompany
            // 
            this.cmbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCompany.FormattingEnabled = true;
            this.cmbxCompany.Location = new System.Drawing.Point(1202, 354);
            this.cmbxCompany.Name = "cmbxCompany";
            this.cmbxCompany.Size = new System.Drawing.Size(245, 33);
            this.cmbxCompany.TabIndex = 81;
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(946, 390);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(125, 25);
            this.lblRequestedBy.TabIndex = 83;
            this.lblRequestedBy.Text = "Requested By";
            // 
            // lblReleasedBy
            // 
            this.lblReleasedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleasedBy.AutoSize = true;
            this.lblReleasedBy.Location = new System.Drawing.Point(946, 454);
            this.lblReleasedBy.Name = "lblReleasedBy";
            this.lblReleasedBy.Size = new System.Drawing.Size(112, 25);
            this.lblReleasedBy.TabIndex = 84;
            this.lblReleasedBy.Text = "Released By";
            // 
            // tbxRequestedBy
            // 
            this.tbxRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxRequestedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbxRequestedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxRequestedBy.BackColor = System.Drawing.Color.White;
            this.tbxRequestedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRequestedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxRequestedBy.Location = new System.Drawing.Point(951, 418);
            this.tbxRequestedBy.Name = "tbxRequestedBy";
            this.tbxRequestedBy.Size = new System.Drawing.Size(496, 33);
            this.tbxRequestedBy.TabIndex = 85;
            this.tbxRequestedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRequestedBy_KeyDown);
            this.tbxRequestedBy.Leave += new System.EventHandler(this.tbxRequestedBy_Leave);
            // 
            // tbxReleasedBy
            // 
            this.tbxReleasedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReleasedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxReleasedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxReleasedBy.BackColor = System.Drawing.Color.White;
            this.tbxReleasedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxReleasedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxReleasedBy.Location = new System.Drawing.Point(951, 482);
            this.tbxReleasedBy.Name = "tbxReleasedBy";
            this.tbxReleasedBy.Size = new System.Drawing.Size(496, 33);
            this.tbxReleasedBy.TabIndex = 86;
            this.tbxReleasedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxReleasedBy_KeyDown);
            this.tbxReleasedBy.Leave += new System.EventHandler(this.tbxReleasedBy_Leave);
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(946, 518);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(81, 25);
            this.lblPurpose.TabIndex = 87;
            this.lblPurpose.Text = "Purpose";
            // 
            // tbxPurpose
            // 
            this.tbxPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPurpose.BackColor = System.Drawing.Color.White;
            this.tbxPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPurpose.Location = new System.Drawing.Point(951, 546);
            this.tbxPurpose.Multiline = true;
            this.tbxPurpose.Name = "tbxPurpose";
            this.tbxPurpose.Size = new System.Drawing.Size(496, 75);
            this.tbxPurpose.TabIndex = 88;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1322, 627);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 50);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1191, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OutgoingStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1454, 917);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxPurpose);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.tbxReleasedBy);
            this.Controls.Add(this.tbxRequestedBy);
            this.Controls.Add(this.lblReleasedBy);
            this.Controls.Add(this.lblRequestedBy);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cmbxCompany);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.cmbxBranch);
            this.Controls.Add(this.nudRemovedStockValue);
            this.Controls.Add(this.lblRemovedStockValue);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.tbxItemStockValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPastTransactionRecords);
            this.Controls.Add(this.tbxItemCode);
            this.Controls.Add(this.lblItemCode);
            this.Controls.Add(this.tbxItemDescription);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.cmbxSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.btnSearchItems);
            this.Controls.Add(this.tbxSearchItems);
            this.Controls.Add(this.lblSearchItem);
            this.Controls.Add(this.dgvStocks);
            this.Controls.Add(this.lblIncomingStocks);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OutgoingStocksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory | Outgoing Stocks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OutgoingStocksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemovedStockValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncomingStocks;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockValue;
        private System.Windows.Forms.TextBox tbxItemStockValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPastTransactionRecords;
        private System.Windows.Forms.TextBox tbxItemCode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TextBox tbxItemDescription;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.TextBox tbxSearchItems;
        private System.Windows.Forms.Button btnSearchItems;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbxSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionLastStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionRemovedStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransaction;
        private System.Windows.Forms.Timer tmrGenerateItems;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label lblRemovedStockValue;
        private System.Windows.Forms.NumericUpDown nudRemovedStockValue;
        private System.Windows.Forms.ComboBox cmbxBranch;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbxCompany;
        private System.Windows.Forms.Label lblRequestedBy;
        private System.Windows.Forms.Label lblReleasedBy;
        private System.Windows.Forms.TextBox tbxRequestedBy;
        private System.Windows.Forms.TextBox tbxReleasedBy;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.TextBox tbxPurpose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}