namespace Citicon.Payables
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.lblChequeVoucher = new System.Windows.Forms.Label();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tpTransactions = new System.Windows.Forms.TabPage();
            this.cmbxTransactionsSupplier = new System.Windows.Forms.ComboBox();
            this.ckbxTransactionsSupplier = new System.Windows.Forms.CheckBox();
            this.cmbxTransactionsExpense = new System.Windows.Forms.ComboBox();
            this.cmbxTransactionsItemClassification = new System.Windows.Forms.ComboBox();
            this.ckbxTransactionsExpense = new System.Windows.Forms.CheckBox();
            this.ckbxTransactionsItemClassification = new System.Windows.Forms.CheckBox();
            this.ckbxTransactionsBranch = new System.Windows.Forms.CheckBox();
            this.ckbxTransactionsCompany = new System.Windows.Forms.CheckBox();
            this.ckbxTransactionsTransactionDate = new System.Windows.Forms.CheckBox();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.colTransactionsPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionsChequeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionsPayee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransactionsGenerate = new System.Windows.Forms.Button();
            this.cmbxTransactionsBranch = new System.Windows.Forms.ComboBox();
            this.cmbxTransactionsCompany = new System.Windows.Forms.ComboBox();
            this.lblTransactionsTransactionDateEnd = new System.Windows.Forms.Label();
            this.dtpTransactionsTransactionDateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTransactionsTransactionDateStart = new System.Windows.Forms.Label();
            this.dtpTransactionsTransactionDateStart = new System.Windows.Forms.DateTimePicker();
            this.tpReports_Cheques = new System.Windows.Forms.TabPage();
            this.ChequeReports = new Citicon.Payables.Reports.ChequeReports();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExportCheque = new System.Windows.Forms.Button();
            this.tcReports.SuspendLayout();
            this.tpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.tpReports_Cheques.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChequeVoucher
            // 
            this.lblChequeVoucher.BackColor = System.Drawing.Color.White;
            this.lblChequeVoucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChequeVoucher.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeVoucher.Location = new System.Drawing.Point(0, 0);
            this.lblChequeVoucher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChequeVoucher.Name = "lblChequeVoucher";
            this.lblChequeVoucher.Size = new System.Drawing.Size(1312, 84);
            this.lblChequeVoucher.TabIndex = 15;
            this.lblChequeVoucher.Text = "Reports";
            this.lblChequeVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcReports
            // 
            this.tcReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcReports.Controls.Add(this.tpTransactions);
            this.tcReports.Controls.Add(this.tpReports_Cheques);
            this.tcReports.Location = new System.Drawing.Point(10, 87);
            this.tcReports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tcReports.Name = "tcReports";
            this.tcReports.Padding = new System.Drawing.Point(20, 10);
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(1292, 482);
            this.tcReports.TabIndex = 16;
            // 
            // tpTransactions
            // 
            this.tpTransactions.Controls.Add(this.cmbxTransactionsSupplier);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsSupplier);
            this.tpTransactions.Controls.Add(this.cmbxTransactionsExpense);
            this.tpTransactions.Controls.Add(this.cmbxTransactionsItemClassification);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsExpense);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsItemClassification);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsBranch);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsCompany);
            this.tpTransactions.Controls.Add(this.ckbxTransactionsTransactionDate);
            this.tpTransactions.Controls.Add(this.dgvTransactions);
            this.tpTransactions.Controls.Add(this.btnTransactionsGenerate);
            this.tpTransactions.Controls.Add(this.cmbxTransactionsBranch);
            this.tpTransactions.Controls.Add(this.cmbxTransactionsCompany);
            this.tpTransactions.Controls.Add(this.lblTransactionsTransactionDateEnd);
            this.tpTransactions.Controls.Add(this.dtpTransactionsTransactionDateEnd);
            this.tpTransactions.Controls.Add(this.lblTransactionsTransactionDateStart);
            this.tpTransactions.Controls.Add(this.dtpTransactionsTransactionDateStart);
            this.tpTransactions.Location = new System.Drawing.Point(4, 44);
            this.tpTransactions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpTransactions.Name = "tpTransactions";
            this.tpTransactions.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tpTransactions.Size = new System.Drawing.Size(1284, 434);
            this.tpTransactions.TabIndex = 0;
            this.tpTransactions.Text = "Transactions";
            this.tpTransactions.UseVisualStyleBackColor = true;
            // 
            // cmbxTransactionsSupplier
            // 
            this.cmbxTransactionsSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransactionsSupplier.Enabled = false;
            this.cmbxTransactionsSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTransactionsSupplier.FormattingEnabled = true;
            this.cmbxTransactionsSupplier.Location = new System.Drawing.Point(604, 88);
            this.cmbxTransactionsSupplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxTransactionsSupplier.Name = "cmbxTransactionsSupplier";
            this.cmbxTransactionsSupplier.Size = new System.Drawing.Size(294, 29);
            this.cmbxTransactionsSupplier.TabIndex = 94;
            this.cmbxTransactionsSupplier.Tag = "Transactions_Supplier";
            // 
            // ckbxTransactionsSupplier
            // 
            this.ckbxTransactionsSupplier.AutoSize = true;
            this.ckbxTransactionsSupplier.Location = new System.Drawing.Point(448, 88);
            this.ckbxTransactionsSupplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsSupplier.Name = "ckbxTransactionsSupplier";
            this.ckbxTransactionsSupplier.Size = new System.Drawing.Size(69, 25);
            this.ckbxTransactionsSupplier.TabIndex = 93;
            this.ckbxTransactionsSupplier.Tag = "Transactions_Supplier";
            this.ckbxTransactionsSupplier.Text = "Payee";
            this.ckbxTransactionsSupplier.UseVisualStyleBackColor = true;
            this.ckbxTransactionsSupplier.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // cmbxTransactionsExpense
            // 
            this.cmbxTransactionsExpense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransactionsExpense.Enabled = false;
            this.cmbxTransactionsExpense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTransactionsExpense.FormattingEnabled = true;
            this.cmbxTransactionsExpense.Location = new System.Drawing.Point(604, 55);
            this.cmbxTransactionsExpense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxTransactionsExpense.Name = "cmbxTransactionsExpense";
            this.cmbxTransactionsExpense.Size = new System.Drawing.Size(294, 29);
            this.cmbxTransactionsExpense.TabIndex = 92;
            this.cmbxTransactionsExpense.Tag = "Transactions_Expense";
            // 
            // cmbxTransactionsItemClassification
            // 
            this.cmbxTransactionsItemClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransactionsItemClassification.Enabled = false;
            this.cmbxTransactionsItemClassification.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTransactionsItemClassification.FormattingEnabled = true;
            this.cmbxTransactionsItemClassification.Location = new System.Drawing.Point(604, 23);
            this.cmbxTransactionsItemClassification.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxTransactionsItemClassification.Name = "cmbxTransactionsItemClassification";
            this.cmbxTransactionsItemClassification.Size = new System.Drawing.Size(294, 29);
            this.cmbxTransactionsItemClassification.TabIndex = 91;
            this.cmbxTransactionsItemClassification.Tag = "Transactions_ItemClassification";
            // 
            // ckbxTransactionsExpense
            // 
            this.ckbxTransactionsExpense.AutoSize = true;
            this.ckbxTransactionsExpense.Location = new System.Drawing.Point(448, 55);
            this.ckbxTransactionsExpense.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsExpense.Name = "ckbxTransactionsExpense";
            this.ckbxTransactionsExpense.Size = new System.Drawing.Size(92, 25);
            this.ckbxTransactionsExpense.TabIndex = 90;
            this.ckbxTransactionsExpense.Tag = "Transactions_Expense";
            this.ckbxTransactionsExpense.Text = "Expenses";
            this.ckbxTransactionsExpense.UseVisualStyleBackColor = true;
            this.ckbxTransactionsExpense.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // ckbxTransactionsItemClassification
            // 
            this.ckbxTransactionsItemClassification.AutoSize = true;
            this.ckbxTransactionsItemClassification.Location = new System.Drawing.Point(448, 23);
            this.ckbxTransactionsItemClassification.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsItemClassification.Name = "ckbxTransactionsItemClassification";
            this.ckbxTransactionsItemClassification.Size = new System.Drawing.Size(155, 25);
            this.ckbxTransactionsItemClassification.TabIndex = 89;
            this.ckbxTransactionsItemClassification.Tag = "Transactions_ItemClassification";
            this.ckbxTransactionsItemClassification.Text = "Item Classification";
            this.ckbxTransactionsItemClassification.UseVisualStyleBackColor = true;
            this.ckbxTransactionsItemClassification.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // ckbxTransactionsBranch
            // 
            this.ckbxTransactionsBranch.AutoSize = true;
            this.ckbxTransactionsBranch.Checked = true;
            this.ckbxTransactionsBranch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxTransactionsBranch.Location = new System.Drawing.Point(4, 90);
            this.ckbxTransactionsBranch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsBranch.Name = "ckbxTransactionsBranch";
            this.ckbxTransactionsBranch.Size = new System.Drawing.Size(77, 25);
            this.ckbxTransactionsBranch.TabIndex = 88;
            this.ckbxTransactionsBranch.Tag = "Transactions_Branch";
            this.ckbxTransactionsBranch.Text = "Branch";
            this.ckbxTransactionsBranch.UseVisualStyleBackColor = true;
            this.ckbxTransactionsBranch.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // ckbxTransactionsCompany
            // 
            this.ckbxTransactionsCompany.AutoSize = true;
            this.ckbxTransactionsCompany.Checked = true;
            this.ckbxTransactionsCompany.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxTransactionsCompany.Location = new System.Drawing.Point(4, 55);
            this.ckbxTransactionsCompany.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsCompany.Name = "ckbxTransactionsCompany";
            this.ckbxTransactionsCompany.Size = new System.Drawing.Size(96, 25);
            this.ckbxTransactionsCompany.TabIndex = 87;
            this.ckbxTransactionsCompany.Tag = "Transactions_Company";
            this.ckbxTransactionsCompany.Text = "Company";
            this.ckbxTransactionsCompany.UseVisualStyleBackColor = true;
            this.ckbxTransactionsCompany.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // ckbxTransactionsTransactionDate
            // 
            this.ckbxTransactionsTransactionDate.AutoSize = true;
            this.ckbxTransactionsTransactionDate.Checked = true;
            this.ckbxTransactionsTransactionDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxTransactionsTransactionDate.Location = new System.Drawing.Point(4, 23);
            this.ckbxTransactionsTransactionDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ckbxTransactionsTransactionDate.Name = "ckbxTransactionsTransactionDate";
            this.ckbxTransactionsTransactionDate.Size = new System.Drawing.Size(144, 25);
            this.ckbxTransactionsTransactionDate.TabIndex = 86;
            this.ckbxTransactionsTransactionDate.Tag = "Transactions_TransactionDate";
            this.ckbxTransactionsTransactionDate.Text = "Transaction Date";
            this.ckbxTransactionsTransactionDate.UseVisualStyleBackColor = true;
            this.ckbxTransactionsTransactionDate.CheckedChanged += new System.EventHandler(this.Transactions_CheckBoxes_CheckedChanged);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.ColumnHeadersHeight = 60;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionsPayable,
            this.colTransactionsDescription,
            this.colTransactionsAmount,
            this.colTransactionsChequeNumber,
            this.colTransactionsPayee,
            this.colTransactionsDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvTransactions.Location = new System.Drawing.Point(10, 168);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 30;
            this.dgvTransactions.Size = new System.Drawing.Size(1262, 262);
            this.dgvTransactions.TabIndex = 81;
            // 
            // colTransactionsPayable
            // 
            this.colTransactionsPayable.HeaderText = "Payable";
            this.colTransactionsPayable.Name = "colTransactionsPayable";
            this.colTransactionsPayable.ReadOnly = true;
            this.colTransactionsPayable.Visible = false;
            // 
            // colTransactionsDescription
            // 
            this.colTransactionsDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionsDescription.HeaderText = "Description";
            this.colTransactionsDescription.Name = "colTransactionsDescription";
            this.colTransactionsDescription.ReadOnly = true;
            this.colTransactionsDescription.Width = 114;
            // 
            // colTransactionsAmount
            // 
            this.colTransactionsAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionsAmount.HeaderText = "Amount";
            this.colTransactionsAmount.Name = "colTransactionsAmount";
            this.colTransactionsAmount.ReadOnly = true;
            this.colTransactionsAmount.Width = 91;
            // 
            // colTransactionsChequeNumber
            // 
            this.colTransactionsChequeNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionsChequeNumber.HeaderText = "Cheque No.";
            this.colTransactionsChequeNumber.Name = "colTransactionsChequeNumber";
            this.colTransactionsChequeNumber.ReadOnly = true;
            this.colTransactionsChequeNumber.Width = 106;
            // 
            // colTransactionsPayee
            // 
            this.colTransactionsPayee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionsPayee.HeaderText = "Payee";
            this.colTransactionsPayee.Name = "colTransactionsPayee";
            this.colTransactionsPayee.ReadOnly = true;
            this.colTransactionsPayee.Width = 75;
            // 
            // colTransactionsDate
            // 
            this.colTransactionsDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTransactionsDate.HeaderText = "Date";
            this.colTransactionsDate.Name = "colTransactionsDate";
            this.colTransactionsDate.ReadOnly = true;
            this.colTransactionsDate.Width = 67;
            // 
            // btnTransactionsGenerate
            // 
            this.btnTransactionsGenerate.BackColor = System.Drawing.Color.Red;
            this.btnTransactionsGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsGenerate.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsGenerate.Location = new System.Drawing.Point(774, 121);
            this.btnTransactionsGenerate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTransactionsGenerate.Name = "btnTransactionsGenerate";
            this.btnTransactionsGenerate.Size = new System.Drawing.Size(123, 42);
            this.btnTransactionsGenerate.TabIndex = 80;
            this.btnTransactionsGenerate.Text = "&Generate";
            this.btnTransactionsGenerate.UseVisualStyleBackColor = false;
            this.btnTransactionsGenerate.Click += new System.EventHandler(this.btnTransactionsGenerate_Click);
            // 
            // cmbxTransactionsBranch
            // 
            this.cmbxTransactionsBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransactionsBranch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTransactionsBranch.FormattingEnabled = true;
            this.cmbxTransactionsBranch.Location = new System.Drawing.Point(150, 89);
            this.cmbxTransactionsBranch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxTransactionsBranch.Name = "cmbxTransactionsBranch";
            this.cmbxTransactionsBranch.Size = new System.Drawing.Size(294, 29);
            this.cmbxTransactionsBranch.TabIndex = 8;
            this.cmbxTransactionsBranch.Tag = "Transactions_Branch";
            // 
            // cmbxTransactionsCompany
            // 
            this.cmbxTransactionsCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransactionsCompany.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxTransactionsCompany.FormattingEnabled = true;
            this.cmbxTransactionsCompany.Location = new System.Drawing.Point(150, 56);
            this.cmbxTransactionsCompany.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxTransactionsCompany.Name = "cmbxTransactionsCompany";
            this.cmbxTransactionsCompany.Size = new System.Drawing.Size(294, 29);
            this.cmbxTransactionsCompany.TabIndex = 6;
            this.cmbxTransactionsCompany.Tag = "Transactions_Company";
            // 
            // lblTransactionsTransactionDateEnd
            // 
            this.lblTransactionsTransactionDateEnd.AutoSize = true;
            this.lblTransactionsTransactionDateEnd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransactionsTransactionDateEnd.Location = new System.Drawing.Point(296, 3);
            this.lblTransactionsTransactionDateEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionsTransactionDateEnd.Name = "lblTransactionsTransactionDateEnd";
            this.lblTransactionsTransactionDateEnd.Size = new System.Drawing.Size(32, 19);
            this.lblTransactionsTransactionDateEnd.TabIndex = 4;
            this.lblTransactionsTransactionDateEnd.Tag = "Transactions_TransactionDate";
            this.lblTransactionsTransactionDateEnd.Text = "End";
            // 
            // dtpTransactionsTransactionDateEnd
            // 
            this.dtpTransactionsTransactionDateEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionsTransactionDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionsTransactionDateEnd.Location = new System.Drawing.Point(299, 23);
            this.dtpTransactionsTransactionDateEnd.Name = "dtpTransactionsTransactionDateEnd";
            this.dtpTransactionsTransactionDateEnd.Size = new System.Drawing.Size(144, 29);
            this.dtpTransactionsTransactionDateEnd.TabIndex = 3;
            this.dtpTransactionsTransactionDateEnd.Tag = "Transactions_TransactionDate";
            // 
            // lblTransactionsTransactionDateStart
            // 
            this.lblTransactionsTransactionDateStart.AutoSize = true;
            this.lblTransactionsTransactionDateStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransactionsTransactionDateStart.Location = new System.Drawing.Point(146, 3);
            this.lblTransactionsTransactionDateStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionsTransactionDateStart.Name = "lblTransactionsTransactionDateStart";
            this.lblTransactionsTransactionDateStart.Size = new System.Drawing.Size(38, 19);
            this.lblTransactionsTransactionDateStart.TabIndex = 2;
            this.lblTransactionsTransactionDateStart.Tag = "Transactions_TransactionDate";
            this.lblTransactionsTransactionDateStart.Text = "Start";
            // 
            // dtpTransactionsTransactionDateStart
            // 
            this.dtpTransactionsTransactionDateStart.CustomFormat = "MMM dd, yyyy";
            this.dtpTransactionsTransactionDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionsTransactionDateStart.Location = new System.Drawing.Point(150, 23);
            this.dtpTransactionsTransactionDateStart.Name = "dtpTransactionsTransactionDateStart";
            this.dtpTransactionsTransactionDateStart.Size = new System.Drawing.Size(144, 29);
            this.dtpTransactionsTransactionDateStart.TabIndex = 1;
            this.dtpTransactionsTransactionDateStart.Tag = "Transactions_TransactionDate";
            // 
            // tpReports_Cheques
            // 
            this.tpReports_Cheques.Controls.Add(this.ChequeReports);
            this.tpReports_Cheques.Location = new System.Drawing.Point(4, 44);
            this.tpReports_Cheques.Name = "tpReports_Cheques";
            this.tpReports_Cheques.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports_Cheques.Size = new System.Drawing.Size(1284, 434);
            this.tpReports_Cheques.TabIndex = 1;
            this.tpReports_Cheques.Text = "Cheques";
            this.tpReports_Cheques.UseVisualStyleBackColor = true;
            // 
            // ChequeReports
            // 
            this.ChequeReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChequeReports.BackColor = System.Drawing.Color.White;
            this.ChequeReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChequeReports.ForeColor = System.Drawing.Color.Red;
            this.ChequeReports.Location = new System.Drawing.Point(7, 8);
            this.ChequeReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChequeReports.Name = "ChequeReports";
            this.ChequeReports.Size = new System.Drawing.Size(1270, 418);
            this.ChequeReports.TabIndex = 0;
            this.ChequeReports.Load += new System.EventHandler(this.ChequeReports_Load);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1202, 575);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 97;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportCheque
            // 
            this.btnExportCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCheque.BackColor = System.Drawing.Color.Red;
            this.btnExportCheque.FlatAppearance.BorderSize = 0;
            this.btnExportCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCheque.ForeColor = System.Drawing.Color.White;
            this.btnExportCheque.Location = new System.Drawing.Point(1048, 575);
            this.btnExportCheque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportCheque.Name = "btnExportCheque";
            this.btnExportCheque.Size = new System.Drawing.Size(150, 50);
            this.btnExportCheque.TabIndex = 96;
            this.btnExportCheque.Text = "&Print Report";
            this.btnExportCheque.UseVisualStyleBackColor = false;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 637);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportCheque);
            this.Controls.Add(this.tcReports);
            this.Controls.Add(this.lblChequeVoucher);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payables | Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.tcReports.ResumeLayout(false);
            this.tpTransactions.ResumeLayout(false);
            this.tpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.tpReports_Cheques.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChequeVoucher;
        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tpTransactions;
        private System.Windows.Forms.Label lblTransactionsTransactionDateStart;
        private System.Windows.Forms.DateTimePicker dtpTransactionsTransactionDateStart;
        private System.Windows.Forms.DateTimePicker dtpTransactionsTransactionDateEnd;
        private System.Windows.Forms.Label lblTransactionsTransactionDateEnd;
        private System.Windows.Forms.ComboBox cmbxTransactionsCompany;
        private System.Windows.Forms.ComboBox cmbxTransactionsBranch;
        private System.Windows.Forms.Button btnTransactionsGenerate;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportCheque;
        private System.Windows.Forms.CheckBox ckbxTransactionsTransactionDate;
        private System.Windows.Forms.CheckBox ckbxTransactionsCompany;
        private System.Windows.Forms.CheckBox ckbxTransactionsBranch;
        private System.Windows.Forms.CheckBox ckbxTransactionsExpense;
        private System.Windows.Forms.CheckBox ckbxTransactionsItemClassification;
        private System.Windows.Forms.CheckBox ckbxTransactionsSupplier;
        private System.Windows.Forms.ComboBox cmbxTransactionsExpense;
        private System.Windows.Forms.ComboBox cmbxTransactionsItemClassification;
        private System.Windows.Forms.ComboBox cmbxTransactionsSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsPayable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsChequeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsPayee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionsDate;
        private System.Windows.Forms.TabPage tpReports_Cheques;
        private Reports.ChequeReports ChequeReports;
    }
}