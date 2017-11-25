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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingStocksForm));
            this.lblIncomingStocks = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lblTruck = new System.Windows.Forms.Label();
            this.cmbxTruck = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.IssuanceSlipNumberLabel = new System.Windows.Forms.Label();
            this.IssuanceSlipNumberTextBox = new System.Windows.Forms.TextBox();
            this.LastPriceDateTextBox = new System.Windows.Forms.TextBox();
            this.LastPriceDateLabel = new System.Windows.Forms.Label();
            this.LastPriceLabel = new System.Windows.Forms.Label();
            this.LastPriceTextBox = new System.Windows.Forms.TextBox();
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
            this.lblIncomingStocks.Name = "lblIncomingStocks";
            this.lblIncomingStocks.Size = new System.Drawing.Size(1193, 86);
            this.lblIncomingStocks.TabIndex = 11;
            this.lblIncomingStocks.Text = "Outgoing Stocks";
            this.lblIncomingStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(11, 142);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(791, 0);
            this.dgvItems.TabIndex = 64;
            this.dgvItems.DoubleClick += new System.EventHandler(this.DgvItems_DoubleClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvItems_KeyDown);
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
            this.colCode.Width = 78;
            // 
            // colClassification
            // 
            this.colClassification.HeaderText = "Classification";
            this.colClassification.Name = "colClassification";
            this.colClassification.ReadOnly = true;
            this.colClassification.Width = 136;
            // 
            // colStockValue
            // 
            this.colStockValue.HeaderText = "Stock Value";
            this.colStockValue.Name = "colStockValue";
            this.colStockValue.ReadOnly = true;
            this.colStockValue.Width = 115;
            // 
            // tbxItemStockValue
            // 
            this.tbxItemStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemStockValue.BackColor = System.Drawing.Color.White;
            this.tbxItemStockValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemStockValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemStockValue.Location = new System.Drawing.Point(688, 167);
            this.tbxItemStockValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbxItemStockValue.Name = "tbxItemStockValue";
            this.tbxItemStockValue.ReadOnly = true;
            this.tbxItemStockValue.Size = new System.Drawing.Size(114, 29);
            this.tbxItemStockValue.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 73;
            this.label4.Text = "Stock Value";
            // 
            // lblPastTransactionRecords
            // 
            this.lblPastTransactionRecords.AutoSize = true;
            this.lblPastTransactionRecords.Location = new System.Drawing.Point(7, 198);
            this.lblPastTransactionRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPastTransactionRecords.Name = "lblPastTransactionRecords";
            this.lblPastTransactionRecords.Size = new System.Drawing.Size(205, 23);
            this.lblPastTransactionRecords.TabIndex = 72;
            this.lblPastTransactionRecords.Text = "Past Transactions Records";
            // 
            // tbxItemCode
            // 
            this.tbxItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxItemCode.BackColor = System.Drawing.Color.White;
            this.tbxItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxItemCode.Location = new System.Drawing.Point(510, 167);
            this.tbxItemCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbxItemCode.Name = "tbxItemCode";
            this.tbxItemCode.ReadOnly = true;
            this.tbxItemCode.Size = new System.Drawing.Size(174, 29);
            this.tbxItemCode.TabIndex = 70;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(506, 142);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 23);
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
            this.tbxItemDescription.Location = new System.Drawing.Point(11, 167);
            this.tbxItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbxItemDescription.Name = "tbxItemDescription";
            this.tbxItemDescription.ReadOnly = true;
            this.tbxItemDescription.Size = new System.Drawing.Size(495, 29);
            this.tbxItemDescription.TabIndex = 68;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(7, 142);
            this.lblItemDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(136, 23);
            this.lblItemDescription.TabIndex = 67;
            this.lblItemDescription.Text = "Item Description";
            // 
            // cmbxSearchBy
            // 
            this.cmbxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxSearchBy.FormattingEnabled = true;
            this.cmbxSearchBy.Location = new System.Drawing.Point(806, 111);
            this.cmbxSearchBy.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxSearchBy.Name = "cmbxSearchBy";
            this.cmbxSearchBy.Size = new System.Drawing.Size(292, 29);
            this.cmbxSearchBy.TabIndex = 66;
            this.cmbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.CmbxSearchBy_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(802, 86);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(84, 23);
            this.lblSearchBy.TabIndex = 65;
            this.lblSearchBy.Text = "Search By";
            // 
            // btnSearchItems
            // 
            this.btnSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchItems.BackColor = System.Drawing.Color.Red;
            this.btnSearchItems.FlatAppearance.BorderSize = 0;
            this.btnSearchItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchItems.ForeColor = System.Drawing.Color.White;
            this.btnSearchItems.Location = new System.Drawing.Point(1102, 111);
            this.btnSearchItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchItems.Name = "btnSearchItems";
            this.btnSearchItems.Size = new System.Drawing.Size(80, 29);
            this.btnSearchItems.TabIndex = 63;
            this.btnSearchItems.Text = "Search";
            this.btnSearchItems.UseVisualStyleBackColor = false;
            this.btnSearchItems.Click += new System.EventHandler(this.BtnSearchItems_Click);
            // 
            // tbxSearchItems
            // 
            this.tbxSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchItems.BackColor = System.Drawing.Color.White;
            this.tbxSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearchItems.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxSearchItems.Location = new System.Drawing.Point(11, 111);
            this.tbxSearchItems.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSearchItems.Name = "tbxSearchItems";
            this.tbxSearchItems.Size = new System.Drawing.Size(791, 29);
            this.tbxSearchItems.TabIndex = 62;
            this.tbxSearchItems.TextChanged += new System.EventHandler(this.TbxSearchItems_TextChanged);
            this.tbxSearchItems.Enter += new System.EventHandler(this.TbxSearchItems_Enter);
            this.tbxSearchItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxSearchItems_KeyDown);
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(7, 86);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(101, 23);
            this.lblSearchItem.TabIndex = 61;
            this.lblSearchItem.Text = "Search Item";
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStocks.ColumnHeadersHeight = 50;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransaction,
            this.colTransactionLastStockValue,
            this.colTransactionRemovedStockValue,
            this.colTransactionTransactionDate});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStocks.EnableHeadersVisualStyles = false;
            this.dgvStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvStocks.Location = new System.Drawing.Point(11, 223);
            this.dgvStocks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStocks.MultiSelect = false;
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.RowTemplate.Height = 30;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(791, 472);
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
            this.colTransactionLastStockValue.Width = 146;
            // 
            // colTransactionRemovedStockValue
            // 
            this.colTransactionRemovedStockValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTransactionRemovedStockValue.HeaderText = "Removed Stock Value";
            this.colTransactionRemovedStockValue.Name = "colTransactionRemovedStockValue";
            this.colTransactionRemovedStockValue.ReadOnly = true;
            this.colTransactionRemovedStockValue.Width = 145;
            // 
            // colTransactionTransactionDate
            // 
            this.colTransactionTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTransactionTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionTransactionDate.Name = "colTransactionTransactionDate";
            this.colTransactionTransactionDate.ReadOnly = true;
            this.colTransactionTransactionDate.Width = 152;
            // 
            // tmrGenerateItems
            // 
            this.tmrGenerateItems.Interval = 10000;
            this.tmrGenerateItems.Tick += new System.EventHandler(this.TmrGenerateItems_Tick);
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(806, 299);
            this.lblTransactionDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(138, 23);
            this.lblTransactionDate.TabIndex = 76;
            this.lblTransactionDate.Text = "Transaction Date";
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTransactionDate.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(806, 324);
            this.dtpTransactionDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(186, 29);
            this.dtpTransactionDate.TabIndex = 75;
            // 
            // lblRemovedStockValue
            // 
            this.lblRemovedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemovedStockValue.AutoSize = true;
            this.lblRemovedStockValue.Location = new System.Drawing.Point(992, 299);
            this.lblRemovedStockValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemovedStockValue.Name = "lblRemovedStockValue";
            this.lblRemovedStockValue.Size = new System.Drawing.Size(173, 23);
            this.lblRemovedStockValue.TabIndex = 77;
            this.lblRemovedStockValue.Text = "Removed Stock Value";
            // 
            // nudRemovedStockValue
            // 
            this.nudRemovedStockValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRemovedStockValue.DecimalPlaces = 2;
            this.nudRemovedStockValue.Location = new System.Drawing.Point(996, 324);
            this.nudRemovedStockValue.Margin = new System.Windows.Forms.Padding(2);
            this.nudRemovedStockValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRemovedStockValue.Name = "nudRemovedStockValue";
            this.nudRemovedStockValue.Size = new System.Drawing.Size(186, 29);
            this.nudRemovedStockValue.TabIndex = 78;
            this.nudRemovedStockValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRemovedStockValue.ThousandsSeparator = true;
            // 
            // cmbxBranch
            // 
            this.cmbxBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBranch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBranch.FormattingEnabled = true;
            this.cmbxBranch.Location = new System.Drawing.Point(806, 380);
            this.cmbxBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxBranch.Name = "cmbxBranch";
            this.cmbxBranch.Size = new System.Drawing.Size(186, 29);
            this.cmbxBranch.TabIndex = 79;
            this.cmbxBranch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbx_KeyDown);
            this.cmbxBranch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchableComboBox);
            // 
            // lblBranch
            // 
            this.lblBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(806, 355);
            this.lblBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(63, 23);
            this.lblBranch.TabIndex = 80;
            this.lblBranch.Text = "Branch";
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(992, 355);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(83, 23);
            this.lblCompany.TabIndex = 82;
            this.lblCompany.Text = "Company";
            // 
            // cmbxCompany
            // 
            this.cmbxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxCompany.FormattingEnabled = true;
            this.cmbxCompany.Location = new System.Drawing.Point(996, 380);
            this.cmbxCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxCompany.Name = "cmbxCompany";
            this.cmbxCompany.Size = new System.Drawing.Size(185, 29);
            this.cmbxCompany.TabIndex = 81;
            this.cmbxCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbx_KeyDown);
            this.cmbxCompany.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchableComboBox);
            // 
            // lblRequestedBy
            // 
            this.lblRequestedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequestedBy.AutoSize = true;
            this.lblRequestedBy.Location = new System.Drawing.Point(806, 467);
            this.lblRequestedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRequestedBy.Name = "lblRequestedBy";
            this.lblRequestedBy.Size = new System.Drawing.Size(113, 23);
            this.lblRequestedBy.TabIndex = 83;
            this.lblRequestedBy.Text = "Requested By";
            // 
            // lblReleasedBy
            // 
            this.lblReleasedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleasedBy.AutoSize = true;
            this.lblReleasedBy.Location = new System.Drawing.Point(806, 523);
            this.lblReleasedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReleasedBy.Name = "lblReleasedBy";
            this.lblReleasedBy.Size = new System.Drawing.Size(100, 23);
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
            this.tbxRequestedBy.Location = new System.Drawing.Point(806, 492);
            this.tbxRequestedBy.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRequestedBy.Name = "tbxRequestedBy";
            this.tbxRequestedBy.Size = new System.Drawing.Size(374, 29);
            this.tbxRequestedBy.TabIndex = 85;
            this.tbxRequestedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxRequestedBy_KeyDown);
            this.tbxRequestedBy.Leave += new System.EventHandler(this.TbxRequestedBy_Leave);
            // 
            // tbxReleasedBy
            // 
            this.tbxReleasedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxReleasedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxReleasedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxReleasedBy.BackColor = System.Drawing.Color.White;
            this.tbxReleasedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxReleasedBy.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxReleasedBy.Location = new System.Drawing.Point(806, 548);
            this.tbxReleasedBy.Margin = new System.Windows.Forms.Padding(2);
            this.tbxReleasedBy.Name = "tbxReleasedBy";
            this.tbxReleasedBy.Size = new System.Drawing.Size(374, 29);
            this.tbxReleasedBy.TabIndex = 86;
            this.tbxReleasedBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxReleasedBy_KeyDown);
            this.tbxReleasedBy.Leave += new System.EventHandler(this.TbxReleasedBy_Leave);
            // 
            // lblPurpose
            // 
            this.lblPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(806, 579);
            this.lblPurpose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(72, 23);
            this.lblPurpose.TabIndex = 87;
            this.lblPurpose.Text = "Purpose";
            // 
            // tbxPurpose
            // 
            this.tbxPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPurpose.BackColor = System.Drawing.Color.White;
            this.tbxPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPurpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPurpose.Location = new System.Drawing.Point(806, 603);
            this.tbxPurpose.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPurpose.Multiline = true;
            this.tbxPurpose.Name = "tbxPurpose";
            this.tbxPurpose.Size = new System.Drawing.Size(374, 51);
            this.tbxPurpose.TabIndex = 88;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1101, 658);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 34);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1017, 658);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 34);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblTruck
            // 
            this.lblTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(806, 411);
            this.lblTruck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(64, 23);
            this.lblTruck.TabIndex = 91;
            this.lblTruck.Text = "Vehicle";
            // 
            // cmbxTruck
            // 
            this.cmbxTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxTruck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTruck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTruck.FormattingEnabled = true;
            this.cmbxTruck.Location = new System.Drawing.Point(806, 436);
            this.cmbxTruck.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxTruck.Name = "cmbxTruck";
            this.cmbxTruck.Size = new System.Drawing.Size(374, 29);
            this.cmbxTruck.Sorted = true;
            this.cmbxTruck.TabIndex = 92;
            this.cmbxTruck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmbx_KeyDown);
            this.cmbxTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchableComboBox);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(1109, 715);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 34);
            this.btnClose.TabIndex = 93;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // IssuanceSlipNumberLabel
            // 
            this.IssuanceSlipNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuanceSlipNumberLabel.AutoSize = true;
            this.IssuanceSlipNumberLabel.Location = new System.Drawing.Point(854, 198);
            this.IssuanceSlipNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IssuanceSlipNumberLabel.Name = "IssuanceSlipNumberLabel";
            this.IssuanceSlipNumberLabel.Size = new System.Drawing.Size(139, 23);
            this.IssuanceSlipNumberLabel.TabIndex = 94;
            this.IssuanceSlipNumberLabel.Text = "Issuance Slip No.";
            // 
            // IssuanceSlipNumberTextBox
            // 
            this.IssuanceSlipNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuanceSlipNumberTextBox.Location = new System.Drawing.Point(998, 195);
            this.IssuanceSlipNumberTextBox.Name = "IssuanceSlipNumberTextBox";
            this.IssuanceSlipNumberTextBox.ReadOnly = true;
            this.IssuanceSlipNumberTextBox.Size = new System.Drawing.Size(183, 29);
            this.IssuanceSlipNumberTextBox.TabIndex = 95;
            // 
            // LastPriceDateTextBox
            // 
            this.LastPriceDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPriceDateTextBox.Location = new System.Drawing.Point(996, 267);
            this.LastPriceDateTextBox.Name = "LastPriceDateTextBox";
            this.LastPriceDateTextBox.ReadOnly = true;
            this.LastPriceDateTextBox.Size = new System.Drawing.Size(185, 29);
            this.LastPriceDateTextBox.TabIndex = 96;
            // 
            // LastPriceDateLabel
            // 
            this.LastPriceDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPriceDateLabel.AutoSize = true;
            this.LastPriceDateLabel.Location = new System.Drawing.Point(994, 241);
            this.LastPriceDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastPriceDateLabel.Name = "LastPriceDateLabel";
            this.LastPriceDateLabel.Size = new System.Drawing.Size(123, 23);
            this.LastPriceDateLabel.TabIndex = 97;
            this.LastPriceDateLabel.Text = "Last Price Date";
            // 
            // LastPriceLabel
            // 
            this.LastPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPriceLabel.AutoSize = true;
            this.LastPriceLabel.Location = new System.Drawing.Point(804, 241);
            this.LastPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastPriceLabel.Name = "LastPriceLabel";
            this.LastPriceLabel.Size = new System.Drawing.Size(82, 23);
            this.LastPriceLabel.TabIndex = 99;
            this.LastPriceLabel.Text = "Last Price";
            // 
            // LastPriceTextBox
            // 
            this.LastPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LastPriceTextBox.Location = new System.Drawing.Point(806, 267);
            this.LastPriceTextBox.Name = "LastPriceTextBox";
            this.LastPriceTextBox.ReadOnly = true;
            this.LastPriceTextBox.Size = new System.Drawing.Size(185, 29);
            this.LastPriceTextBox.TabIndex = 98;
            // 
            // OutgoingStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1193, 703);
            this.Controls.Add(this.LastPriceLabel);
            this.Controls.Add(this.LastPriceTextBox);
            this.Controls.Add(this.LastPriceDateLabel);
            this.Controls.Add(this.LastPriceDateTextBox);
            this.Controls.Add(this.IssuanceSlipNumberTextBox);
            this.Controls.Add(this.IssuanceSlipNumberLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbxTruck);
            this.Controls.Add(this.lblTruck);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.ComboBox cmbxTruck;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockValue;
        private System.Windows.Forms.Label IssuanceSlipNumberLabel;
        private System.Windows.Forms.TextBox IssuanceSlipNumberTextBox;
        private System.Windows.Forms.TextBox LastPriceDateTextBox;
        private System.Windows.Forms.Label LastPriceDateLabel;
        private System.Windows.Forms.Label LastPriceLabel;
        private System.Windows.Forms.TextBox LastPriceTextBox;
    }
}