namespace Citicon.Payables
{
    partial class ChequeVoucherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblChequeVoucher = new System.Windows.Forms.Label();
            this.tcChequeVoucher = new System.Windows.Forms.TabControl();
            this.tpVariableCost = new System.Windows.Forms.TabPage();
            this.btnRemoveSameMrisNumber = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.lblActiveSupplier = new System.Windows.Forms.Label();
            this.tbxActiveSupplier = new System.Windows.Forms.TextBox();
            this.btnSearchMrisNumber = new System.Windows.Forms.Button();
            this.tbxSearchMrisNumber = new System.Windows.Forms.TextBox();
            this.lblSearchMrisNumber = new System.Windows.Forms.Label();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.colStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocksMrisNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocksCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocksBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocksTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.tbxExpenseRemarks = new System.Windows.Forms.TextBox();
            this.lblExpenseRemarks = new System.Windows.Forms.Label();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExpenseCancel = new System.Windows.Forms.Button();
            this.btnExpenseAdd = new System.Windows.Forms.Button();
            this.nudExpenseAmount = new System.Windows.Forms.NumericUpDown();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.dtpExpenseSalaryPeriodEnd = new System.Windows.Forms.DateTimePicker();
            this.lblExpenseSalaryPeriodEnd = new System.Windows.Forms.Label();
            this.lblExpenseSalaryPeriodStart = new System.Windows.Forms.Label();
            this.dtpExpenseSalaryPeriodStart = new System.Windows.Forms.DateTimePicker();
            this.lblExpenseSalaryPeriod = new System.Windows.Forms.Label();
            this.lblExpenseBranch = new System.Windows.Forms.Label();
            this.tbxExpenseBranch = new System.Windows.Forms.TextBox();
            this.tbxExpenseCompany = new System.Windows.Forms.TextBox();
            this.lblExpenseCompany = new System.Windows.Forms.Label();
            this.tbxExpenseExpense = new System.Windows.Forms.TextBox();
            this.lblExpenseExpense = new System.Windows.Forms.Label();
            this.lblExpenseSupplier = new System.Windows.Forms.Label();
            this.btnChangeExpenseSupplier = new System.Windows.Forms.Button();
            this.tbxExpenseSupplier = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.tbxGrandTotal = new System.Windows.Forms.TextBox();
            this.btnExportCheque = new System.Windows.Forms.Button();
            this.tbxCheckVoucherNumber = new System.Windows.Forms.TextBox();
            this.lblCheckVoucherNumber = new System.Windows.Forms.Label();
            this.tcChequeVoucher.SuspendLayout();
            this.tpVariableCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            this.tpExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpenseAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChequeVoucher
            // 
            this.lblChequeVoucher.BackColor = System.Drawing.Color.White;
            this.lblChequeVoucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChequeVoucher.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeVoucher.Location = new System.Drawing.Point(0, 0);
            this.lblChequeVoucher.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChequeVoucher.Name = "lblChequeVoucher";
            this.lblChequeVoucher.Size = new System.Drawing.Size(1519, 100);
            this.lblChequeVoucher.TabIndex = 14;
            this.lblChequeVoucher.Text = "Cheque Voucher";
            this.lblChequeVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcChequeVoucher
            // 
            this.tcChequeVoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcChequeVoucher.Controls.Add(this.tpVariableCost);
            this.tcChequeVoucher.Controls.Add(this.tpExpenses);
            this.tcChequeVoucher.Location = new System.Drawing.Point(11, 103);
            this.tcChequeVoucher.Name = "tcChequeVoucher";
            this.tcChequeVoucher.Padding = new System.Drawing.Point(30, 15);
            this.tcChequeVoucher.SelectedIndex = 0;
            this.tcChequeVoucher.Size = new System.Drawing.Size(1496, 525);
            this.tcChequeVoucher.TabIndex = 15;
            this.tcChequeVoucher.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcChequeVoucher_Selected);
            // 
            // tpVariableCost
            // 
            this.tpVariableCost.Controls.Add(this.btnRemoveSameMrisNumber);
            this.tpVariableCost.Controls.Add(this.btnRemoveSelected);
            this.tpVariableCost.Controls.Add(this.btnRemoveAll);
            this.tpVariableCost.Controls.Add(this.lblActiveSupplier);
            this.tpVariableCost.Controls.Add(this.tbxActiveSupplier);
            this.tpVariableCost.Controls.Add(this.btnSearchMrisNumber);
            this.tpVariableCost.Controls.Add(this.tbxSearchMrisNumber);
            this.tpVariableCost.Controls.Add(this.lblSearchMrisNumber);
            this.tpVariableCost.Controls.Add(this.dgvStocks);
            this.tpVariableCost.Location = new System.Drawing.Point(4, 58);
            this.tpVariableCost.Name = "tpVariableCost";
            this.tpVariableCost.Padding = new System.Windows.Forms.Padding(3);
            this.tpVariableCost.Size = new System.Drawing.Size(1488, 463);
            this.tpVariableCost.TabIndex = 0;
            this.tpVariableCost.Text = "Variable Cost";
            this.tpVariableCost.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSameMrisNumber
            // 
            this.btnRemoveSameMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSameMrisNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveSameMrisNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSameMrisNumber.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSameMrisNumber.Location = new System.Drawing.Point(1026, 417);
            this.btnRemoveSameMrisNumber.Name = "btnRemoveSameMrisNumber";
            this.btnRemoveSameMrisNumber.Size = new System.Drawing.Size(225, 40);
            this.btnRemoveSameMrisNumber.TabIndex = 84;
            this.btnRemoveSameMrisNumber.Text = "Remove Same MRIS No.";
            this.btnRemoveSameMrisNumber.UseVisualStyleBackColor = false;
            this.btnRemoveSameMrisNumber.Click += new System.EventHandler(this.btnRemoveSameMrisNumber_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(795, 417);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(225, 40);
            this.btnRemoveSelected.TabIndex = 83;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(1257, 417);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(225, 40);
            this.btnRemoveAll.TabIndex = 82;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // lblActiveSupplier
            // 
            this.lblActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveSupplier.AutoSize = true;
            this.lblActiveSupplier.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveSupplier.Location = new System.Drawing.Point(633, 6);
            this.lblActiveSupplier.Name = "lblActiveSupplier";
            this.lblActiveSupplier.Size = new System.Drawing.Size(115, 37);
            this.lblActiveSupplier.TabIndex = 81;
            this.lblActiveSupplier.Text = "Supplier";
            // 
            // tbxActiveSupplier
            // 
            this.tbxActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxActiveSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxActiveSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxActiveSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxActiveSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxActiveSupplier.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxActiveSupplier.Location = new System.Drawing.Point(754, 6);
            this.tbxActiveSupplier.Name = "tbxActiveSupplier";
            this.tbxActiveSupplier.ReadOnly = true;
            this.tbxActiveSupplier.Size = new System.Drawing.Size(728, 54);
            this.tbxActiveSupplier.TabIndex = 80;
            this.tbxActiveSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearchMrisNumber
            // 
            this.btnSearchMrisNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchMrisNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMrisNumber.ForeColor = System.Drawing.Color.White;
            this.btnSearchMrisNumber.Location = new System.Drawing.Point(440, 6);
            this.btnSearchMrisNumber.Name = "btnSearchMrisNumber";
            this.btnSearchMrisNumber.Size = new System.Drawing.Size(100, 33);
            this.btnSearchMrisNumber.TabIndex = 79;
            this.btnSearchMrisNumber.Text = "&Search";
            this.btnSearchMrisNumber.UseVisualStyleBackColor = false;
            this.btnSearchMrisNumber.Click += new System.EventHandler(this.btnSearchMrisNumber_Click);
            // 
            // tbxSearchMrisNumber
            // 
            this.tbxSearchMrisNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxSearchMrisNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxSearchMrisNumber.BackColor = System.Drawing.Color.White;
            this.tbxSearchMrisNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearchMrisNumber.Location = new System.Drawing.Point(101, 6);
            this.tbxSearchMrisNumber.Name = "tbxSearchMrisNumber";
            this.tbxSearchMrisNumber.Size = new System.Drawing.Size(333, 33);
            this.tbxSearchMrisNumber.TabIndex = 78;
            this.tbxSearchMrisNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearchMrisNumber_KeyDown);
            // 
            // lblSearchMrisNumber
            // 
            this.lblSearchMrisNumber.AutoSize = true;
            this.lblSearchMrisNumber.Location = new System.Drawing.Point(6, 10);
            this.lblSearchMrisNumber.Name = "lblSearchMrisNumber";
            this.lblSearchMrisNumber.Size = new System.Drawing.Size(89, 25);
            this.lblSearchMrisNumber.TabIndex = 77;
            this.lblSearchMrisNumber.Text = "MRIS No.";
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.AllowUserToDeleteRows = false;
            this.dgvStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStocks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.dgvStocks.ColumnHeadersHeight = 60;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStocks,
            this.colStocksMrisNumber,
            this.colStocksCompany,
            this.colStocksBranch,
            this.colStocksTotalAmount});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStocks.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvStocks.EnableHeadersVisualStyles = false;
            this.dgvStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvStocks.Location = new System.Drawing.Point(11, 66);
            this.dgvStocks.MultiSelect = false;
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersVisible = false;
            this.dgvStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStocks.RowTemplate.Height = 40;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(1471, 345);
            this.dgvStocks.TabIndex = 76;
            // 
            // colStocks
            // 
            this.colStocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStocks.HeaderText = "Stocks";
            this.colStocks.Name = "colStocks";
            this.colStocks.ReadOnly = true;
            // 
            // colStocksMrisNumber
            // 
            this.colStocksMrisNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStocksMrisNumber.HeaderText = "MRIS No.";
            this.colStocksMrisNumber.Name = "colStocksMrisNumber";
            this.colStocksMrisNumber.ReadOnly = true;
            this.colStocksMrisNumber.Width = 104;
            // 
            // colStocksCompany
            // 
            this.colStocksCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStocksCompany.HeaderText = "Company";
            this.colStocksCompany.Name = "colStocksCompany";
            this.colStocksCompany.ReadOnly = true;
            this.colStocksCompany.Width = 116;
            // 
            // colStocksBranch
            // 
            this.colStocksBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStocksBranch.HeaderText = "Branch";
            this.colStocksBranch.Name = "colStocksBranch";
            this.colStocksBranch.ReadOnly = true;
            this.colStocksBranch.Width = 95;
            // 
            // colStocksTotalAmount
            // 
            this.colStocksTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStocksTotalAmount.DefaultCellStyle = dataGridViewCellStyle39;
            this.colStocksTotalAmount.HeaderText = "Total Amount";
            this.colStocksTotalAmount.Name = "colStocksTotalAmount";
            this.colStocksTotalAmount.ReadOnly = true;
            this.colStocksTotalAmount.Width = 137;
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.tbxExpenseRemarks);
            this.tpExpenses.Controls.Add(this.lblExpenseRemarks);
            this.tpExpenses.Controls.Add(this.dgvExpenses);
            this.tpExpenses.Controls.Add(this.btnExpenseCancel);
            this.tpExpenses.Controls.Add(this.btnExpenseAdd);
            this.tpExpenses.Controls.Add(this.nudExpenseAmount);
            this.tpExpenses.Controls.Add(this.lblExpenseAmount);
            this.tpExpenses.Controls.Add(this.dtpExpenseSalaryPeriodEnd);
            this.tpExpenses.Controls.Add(this.lblExpenseSalaryPeriodEnd);
            this.tpExpenses.Controls.Add(this.lblExpenseSalaryPeriodStart);
            this.tpExpenses.Controls.Add(this.dtpExpenseSalaryPeriodStart);
            this.tpExpenses.Controls.Add(this.lblExpenseSalaryPeriod);
            this.tpExpenses.Controls.Add(this.lblExpenseBranch);
            this.tpExpenses.Controls.Add(this.tbxExpenseBranch);
            this.tpExpenses.Controls.Add(this.tbxExpenseCompany);
            this.tpExpenses.Controls.Add(this.lblExpenseCompany);
            this.tpExpenses.Controls.Add(this.tbxExpenseExpense);
            this.tpExpenses.Controls.Add(this.lblExpenseExpense);
            this.tpExpenses.Controls.Add(this.lblExpenseSupplier);
            this.tpExpenses.Controls.Add(this.btnChangeExpenseSupplier);
            this.tpExpenses.Controls.Add(this.tbxExpenseSupplier);
            this.tpExpenses.Location = new System.Drawing.Point(4, 58);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(1488, 463);
            this.tpExpenses.TabIndex = 1;
            this.tpExpenses.Text = "Expenses";
            this.tpExpenses.UseVisualStyleBackColor = true;
            // 
            // tbxExpenseRemarks
            // 
            this.tbxExpenseRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxExpenseRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxExpenseRemarks.BackColor = System.Drawing.Color.White;
            this.tbxExpenseRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseRemarks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenseRemarks.Location = new System.Drawing.Point(13, 248);
            this.tbxExpenseRemarks.Name = "tbxExpenseRemarks";
            this.tbxExpenseRemarks.Size = new System.Drawing.Size(1004, 33);
            this.tbxExpenseRemarks.TabIndex = 103;
            // 
            // lblExpenseRemarks
            // 
            this.lblExpenseRemarks.AutoSize = true;
            this.lblExpenseRemarks.Location = new System.Drawing.Point(8, 220);
            this.lblExpenseRemarks.Name = "lblExpenseRemarks";
            this.lblExpenseRemarks.Size = new System.Drawing.Size(83, 25);
            this.lblExpenseRemarks.TabIndex = 102;
            this.lblExpenseRemarks.Text = "Remarks";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvExpenses.ColumnHeadersHeight = 60;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpense,
            this.colExpenseCompany,
            this.colExpenseBranch,
            this.colExpenseTotalAmount});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvExpenses.Location = new System.Drawing.Point(13, 287);
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvExpenses.RowTemplate.Height = 40;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Size = new System.Drawing.Size(1469, 170);
            this.dgvExpenses.TabIndex = 101;
            // 
            // colExpense
            // 
            this.colExpense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpense.HeaderText = "Expenses";
            this.colExpense.Name = "colExpense";
            this.colExpense.ReadOnly = true;
            // 
            // colExpenseCompany
            // 
            this.colExpenseCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colExpenseCompany.HeaderText = "Company";
            this.colExpenseCompany.Name = "colExpenseCompany";
            this.colExpenseCompany.ReadOnly = true;
            this.colExpenseCompany.Width = 116;
            // 
            // colExpenseBranch
            // 
            this.colExpenseBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colExpenseBranch.HeaderText = "Branch";
            this.colExpenseBranch.Name = "colExpenseBranch";
            this.colExpenseBranch.ReadOnly = true;
            this.colExpenseBranch.Width = 95;
            // 
            // colExpenseTotalAmount
            // 
            this.colExpenseTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colExpenseTotalAmount.DefaultCellStyle = dataGridViewCellStyle35;
            this.colExpenseTotalAmount.HeaderText = "Total Amount";
            this.colExpenseTotalAmount.Name = "colExpenseTotalAmount";
            this.colExpenseTotalAmount.ReadOnly = true;
            this.colExpenseTotalAmount.Width = 137;
            // 
            // btnExpenseCancel
            // 
            this.btnExpenseCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExpenseCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseCancel.ForeColor = System.Drawing.Color.White;
            this.btnExpenseCancel.Location = new System.Drawing.Point(1151, 248);
            this.btnExpenseCancel.Name = "btnExpenseCancel";
            this.btnExpenseCancel.Size = new System.Drawing.Size(125, 33);
            this.btnExpenseCancel.TabIndex = 100;
            this.btnExpenseCancel.Text = "Ca&ncel";
            this.btnExpenseCancel.UseVisualStyleBackColor = false;
            this.btnExpenseCancel.Click += new System.EventHandler(this.btnExpenseCancel_Click);
            // 
            // btnExpenseAdd
            // 
            this.btnExpenseAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExpenseAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseAdd.ForeColor = System.Drawing.Color.White;
            this.btnExpenseAdd.Location = new System.Drawing.Point(1023, 248);
            this.btnExpenseAdd.Name = "btnExpenseAdd";
            this.btnExpenseAdd.Size = new System.Drawing.Size(125, 33);
            this.btnExpenseAdd.TabIndex = 99;
            this.btnExpenseAdd.Text = "&Add";
            this.btnExpenseAdd.UseVisualStyleBackColor = false;
            this.btnExpenseAdd.Click += new System.EventHandler(this.btnExpenseAdd_Click);
            // 
            // nudExpenseAmount
            // 
            this.nudExpenseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudExpenseAmount.DecimalPlaces = 2;
            this.nudExpenseAmount.Location = new System.Drawing.Point(757, 184);
            this.nudExpenseAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudExpenseAmount.Name = "nudExpenseAmount";
            this.nudExpenseAmount.Size = new System.Drawing.Size(260, 33);
            this.nudExpenseAmount.TabIndex = 98;
            this.nudExpenseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudExpenseAmount.ThousandsSeparator = true;
            // 
            // lblExpenseAmount
            // 
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Location = new System.Drawing.Point(752, 156);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(79, 25);
            this.lblExpenseAmount.TabIndex = 97;
            this.lblExpenseAmount.Text = "Amount";
            // 
            // dtpExpenseSalaryPeriodEnd
            // 
            this.dtpExpenseSalaryPeriodEnd.CustomFormat = "MMM dd, yyyy";
            this.dtpExpenseSalaryPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpenseSalaryPeriodEnd.Location = new System.Drawing.Point(1056, 120);
            this.dtpExpenseSalaryPeriodEnd.Name = "dtpExpenseSalaryPeriodEnd";
            this.dtpExpenseSalaryPeriodEnd.Size = new System.Drawing.Size(223, 33);
            this.dtpExpenseSalaryPeriodEnd.TabIndex = 96;
            this.dtpExpenseSalaryPeriodEnd.ValueChanged += new System.EventHandler(this.dtpExpenseSalaryPeriodEnd_ValueChanged);
            // 
            // lblExpenseSalaryPeriodEnd
            // 
            this.lblExpenseSalaryPeriodEnd.AutoSize = true;
            this.lblExpenseSalaryPeriodEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseSalaryPeriodEnd.Location = new System.Drawing.Point(1023, 120);
            this.lblExpenseSalaryPeriodEnd.Name = "lblExpenseSalaryPeriodEnd";
            this.lblExpenseSalaryPeriodEnd.Size = new System.Drawing.Size(27, 15);
            this.lblExpenseSalaryPeriodEnd.TabIndex = 95;
            this.lblExpenseSalaryPeriodEnd.Text = "End";
            // 
            // lblExpenseSalaryPeriodStart
            // 
            this.lblExpenseSalaryPeriodStart.AutoSize = true;
            this.lblExpenseSalaryPeriodStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseSalaryPeriodStart.Location = new System.Drawing.Point(754, 120);
            this.lblExpenseSalaryPeriodStart.Name = "lblExpenseSalaryPeriodStart";
            this.lblExpenseSalaryPeriodStart.Size = new System.Drawing.Size(31, 15);
            this.lblExpenseSalaryPeriodStart.TabIndex = 94;
            this.lblExpenseSalaryPeriodStart.Text = "Start";
            // 
            // dtpExpenseSalaryPeriodStart
            // 
            this.dtpExpenseSalaryPeriodStart.CustomFormat = "MMM dd, yyyy";
            this.dtpExpenseSalaryPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpenseSalaryPeriodStart.Location = new System.Drawing.Point(791, 120);
            this.dtpExpenseSalaryPeriodStart.Name = "dtpExpenseSalaryPeriodStart";
            this.dtpExpenseSalaryPeriodStart.Size = new System.Drawing.Size(226, 33);
            this.dtpExpenseSalaryPeriodStart.TabIndex = 93;
            this.dtpExpenseSalaryPeriodStart.ValueChanged += new System.EventHandler(this.dtpExpenseSalaryPeriodStart_ValueChanged);
            // 
            // lblExpenseSalaryPeriod
            // 
            this.lblExpenseSalaryPeriod.AutoSize = true;
            this.lblExpenseSalaryPeriod.Location = new System.Drawing.Point(752, 92);
            this.lblExpenseSalaryPeriod.Name = "lblExpenseSalaryPeriod";
            this.lblExpenseSalaryPeriod.Size = new System.Drawing.Size(123, 25);
            this.lblExpenseSalaryPeriod.TabIndex = 92;
            this.lblExpenseSalaryPeriod.Text = "Salary Period";
            // 
            // lblExpenseBranch
            // 
            this.lblExpenseBranch.AutoSize = true;
            this.lblExpenseBranch.Location = new System.Drawing.Point(384, 156);
            this.lblExpenseBranch.Name = "lblExpenseBranch";
            this.lblExpenseBranch.Size = new System.Drawing.Size(71, 25);
            this.lblExpenseBranch.TabIndex = 91;
            this.lblExpenseBranch.Text = "Branch";
            // 
            // tbxExpenseBranch
            // 
            this.tbxExpenseBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxExpenseBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxExpenseBranch.BackColor = System.Drawing.Color.White;
            this.tbxExpenseBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseBranch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenseBranch.Location = new System.Drawing.Point(385, 184);
            this.tbxExpenseBranch.Name = "tbxExpenseBranch";
            this.tbxExpenseBranch.Size = new System.Drawing.Size(366, 33);
            this.tbxExpenseBranch.TabIndex = 90;
            // 
            // tbxExpenseCompany
            // 
            this.tbxExpenseCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxExpenseCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxExpenseCompany.BackColor = System.Drawing.Color.White;
            this.tbxExpenseCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenseCompany.Location = new System.Drawing.Point(13, 184);
            this.tbxExpenseCompany.Name = "tbxExpenseCompany";
            this.tbxExpenseCompany.Size = new System.Drawing.Size(366, 33);
            this.tbxExpenseCompany.TabIndex = 89;
            // 
            // lblExpenseCompany
            // 
            this.lblExpenseCompany.AutoSize = true;
            this.lblExpenseCompany.Location = new System.Drawing.Point(8, 156);
            this.lblExpenseCompany.Name = "lblExpenseCompany";
            this.lblExpenseCompany.Size = new System.Drawing.Size(92, 25);
            this.lblExpenseCompany.TabIndex = 88;
            this.lblExpenseCompany.Text = "Company";
            // 
            // tbxExpenseExpense
            // 
            this.tbxExpenseExpense.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxExpenseExpense.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxExpenseExpense.BackColor = System.Drawing.Color.White;
            this.tbxExpenseExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseExpense.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseExpense.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenseExpense.Location = new System.Drawing.Point(13, 120);
            this.tbxExpenseExpense.Name = "tbxExpenseExpense";
            this.tbxExpenseExpense.Size = new System.Drawing.Size(738, 33);
            this.tbxExpenseExpense.TabIndex = 87;
            this.tbxExpenseExpense.TextChanged += new System.EventHandler(this.tbxExpenseExpense_TextChanged);
            // 
            // lblExpenseExpense
            // 
            this.lblExpenseExpense.AutoSize = true;
            this.lblExpenseExpense.Location = new System.Drawing.Point(8, 92);
            this.lblExpenseExpense.Name = "lblExpenseExpense";
            this.lblExpenseExpense.Size = new System.Drawing.Size(123, 25);
            this.lblExpenseExpense.TabIndex = 86;
            this.lblExpenseExpense.Text = "Classification";
            // 
            // lblExpenseSupplier
            // 
            this.lblExpenseSupplier.AutoSize = true;
            this.lblExpenseSupplier.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenseSupplier.Location = new System.Drawing.Point(6, 3);
            this.lblExpenseSupplier.Name = "lblExpenseSupplier";
            this.lblExpenseSupplier.Size = new System.Drawing.Size(115, 37);
            this.lblExpenseSupplier.TabIndex = 85;
            this.lblExpenseSupplier.Text = "Supplier";
            // 
            // btnChangeExpenseSupplier
            // 
            this.btnChangeExpenseSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChangeExpenseSupplier.FlatAppearance.BorderSize = 0;
            this.btnChangeExpenseSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeExpenseSupplier.ForeColor = System.Drawing.Color.White;
            this.btnChangeExpenseSupplier.Location = new System.Drawing.Point(751, 43);
            this.btnChangeExpenseSupplier.Name = "btnChangeExpenseSupplier";
            this.btnChangeExpenseSupplier.Size = new System.Drawing.Size(125, 46);
            this.btnChangeExpenseSupplier.TabIndex = 84;
            this.btnChangeExpenseSupplier.Text = "&Change";
            this.btnChangeExpenseSupplier.UseVisualStyleBackColor = false;
            this.btnChangeExpenseSupplier.Click += new System.EventHandler(this.btnChangeExpenseSupplier_Click);
            // 
            // tbxExpenseSupplier
            // 
            this.tbxExpenseSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxExpenseSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxExpenseSupplier.BackColor = System.Drawing.Color.White;
            this.tbxExpenseSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseSupplier.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpenseSupplier.Location = new System.Drawing.Point(13, 43);
            this.tbxExpenseSupplier.Name = "tbxExpenseSupplier";
            this.tbxExpenseSupplier.Size = new System.Drawing.Size(738, 46);
            this.tbxExpenseSupplier.TabIndex = 83;
            this.tbxExpenseSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxExpenseSupplier_KeyDown);
            this.tbxExpenseSupplier.Leave += new System.EventHandler(this.tbxExpenseSupplier_Leave);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(711, 631);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(167, 40);
            this.lblGrandTotal.TabIndex = 78;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // tbxGrandTotal
            // 
            this.tbxGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGrandTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxGrandTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbxGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxGrandTotal.Location = new System.Drawing.Point(718, 674);
            this.tbxGrandTotal.Name = "tbxGrandTotal";
            this.tbxGrandTotal.Size = new System.Drawing.Size(533, 75);
            this.tbxGrandTotal.TabIndex = 79;
            this.tbxGrandTotal.Text = "0.00";
            this.tbxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExportCheque
            // 
            this.btnExportCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCheque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExportCheque.FlatAppearance.BorderSize = 0;
            this.btnExportCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCheque.ForeColor = System.Drawing.Color.White;
            this.btnExportCheque.Location = new System.Drawing.Point(1257, 674);
            this.btnExportCheque.Name = "btnExportCheque";
            this.btnExportCheque.Size = new System.Drawing.Size(250, 75);
            this.btnExportCheque.TabIndex = 92;
            this.btnExportCheque.Text = "Export Cheque Voucher";
            this.btnExportCheque.UseVisualStyleBackColor = false;
            this.btnExportCheque.Click += new System.EventHandler(this.btnExportCheque_Click);
            // 
            // tbxCheckVoucherNumber
            // 
            this.tbxCheckVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCheckVoucherNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxCheckVoucherNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCheckVoucherNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbxCheckVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheckVoucherNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxCheckVoucherNumber.Location = new System.Drawing.Point(11, 674);
            this.tbxCheckVoucherNumber.Name = "tbxCheckVoucherNumber";
            this.tbxCheckVoucherNumber.Size = new System.Drawing.Size(370, 75);
            this.tbxCheckVoucherNumber.TabIndex = 93;
            this.tbxCheckVoucherNumber.Text = "0000000";
            this.tbxCheckVoucherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCheckVoucherNumber
            // 
            this.lblCheckVoucherNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCheckVoucherNumber.AutoSize = true;
            this.lblCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckVoucherNumber.Location = new System.Drawing.Point(4, 631);
            this.lblCheckVoucherNumber.Name = "lblCheckVoucherNumber";
            this.lblCheckVoucherNumber.Size = new System.Drawing.Size(259, 40);
            this.lblCheckVoucherNumber.TabIndex = 94;
            this.lblCheckVoucherNumber.Text = "Check Voucher No.";
            // 
            // ChequeVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1519, 761);
            this.Controls.Add(this.lblCheckVoucherNumber);
            this.Controls.Add(this.tbxCheckVoucherNumber);
            this.Controls.Add(this.btnExportCheque);
            this.Controls.Add(this.tbxGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.tcChequeVoucher);
            this.Controls.Add(this.lblChequeVoucher);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChequeVoucherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payables | Cheque Voucher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChequeVoucherForm_Load);
            this.tcChequeVoucher.ResumeLayout(false);
            this.tpVariableCost.ResumeLayout(false);
            this.tpVariableCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            this.tpExpenses.ResumeLayout(false);
            this.tpExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpenseAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChequeVoucher;
        private System.Windows.Forms.TabControl tcChequeVoucher;
        private System.Windows.Forms.TabPage tpVariableCost;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label lblSearchMrisNumber;
        private System.Windows.Forms.TextBox tbxSearchMrisNumber;
        private System.Windows.Forms.Button btnSearchMrisNumber;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox tbxGrandTotal;
        private System.Windows.Forms.Button btnExportCheque;
        private System.Windows.Forms.TextBox tbxActiveSupplier;
        private System.Windows.Forms.Label lblActiveSupplier;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocksTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocksBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocksCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocksMrisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocks;
        private System.Windows.Forms.Button btnRemoveSameMrisNumber;
        private System.Windows.Forms.TextBox tbxCheckVoucherNumber;
        private System.Windows.Forms.Label lblCheckVoucherNumber;
        private System.Windows.Forms.TextBox tbxExpenseSupplier;
        private System.Windows.Forms.Button btnChangeExpenseSupplier;
        private System.Windows.Forms.Label lblExpenseSupplier;
        private System.Windows.Forms.Label lblExpenseExpense;
        private System.Windows.Forms.TextBox tbxExpenseExpense;
        private System.Windows.Forms.Label lblExpenseCompany;
        private System.Windows.Forms.TextBox tbxExpenseCompany;
        private System.Windows.Forms.TextBox tbxExpenseBranch;
        private System.Windows.Forms.Label lblExpenseBranch;
        private System.Windows.Forms.Label lblExpenseSalaryPeriod;
        private System.Windows.Forms.DateTimePicker dtpExpenseSalaryPeriodStart;
        private System.Windows.Forms.Label lblExpenseSalaryPeriodStart;
        private System.Windows.Forms.Label lblExpenseSalaryPeriodEnd;
        private System.Windows.Forms.DateTimePicker dtpExpenseSalaryPeriodEnd;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.NumericUpDown nudExpenseAmount;
        private System.Windows.Forms.Button btnExpenseAdd;
        private System.Windows.Forms.Button btnExpenseCancel;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpense;
        private System.Windows.Forms.Label lblExpenseRemarks;
        private System.Windows.Forms.TextBox tbxExpenseRemarks;
    }
}