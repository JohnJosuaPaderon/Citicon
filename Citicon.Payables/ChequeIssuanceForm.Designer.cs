namespace Citicon.Payables
{
    partial class ChequeIssuanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeIssuanceForm));
            this.lblChequeIssuance = new System.Windows.Forms.Label();
            this.lblCheckVoucherNumber = new System.Windows.Forms.Label();
            this.tbxCheckVoucherNumber = new System.Windows.Forms.TextBox();
            this.lblChangeCheckVoucherNumber = new System.Windows.Forms.LinkLabel();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.dgvPayables = new System.Windows.Forms.DataGridView();
            this.colPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayableCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayableBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayableTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxCheckNumber = new System.Windows.Forms.TextBox();
            this.tbxPayee = new System.Windows.Forms.TextBox();
            this.lblPayee = new System.Windows.Forms.Label();
            this.lblCheckNumber = new System.Windows.Forms.Label();
            this.cmbxBanks = new System.Windows.Forms.ComboBox();
            this.cmbxBankAccounts = new System.Windows.Forms.ComboBox();
            this.btnExportCheque = new System.Windows.Forms.Button();
            this.lblgrandTotal = new System.Windows.Forms.Label();
            this.tbxGrandTotal = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblChequeDate = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayables)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChequeIssuance
            // 
            this.lblChequeIssuance.BackColor = System.Drawing.Color.White;
            this.lblChequeIssuance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChequeIssuance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeIssuance.Location = new System.Drawing.Point(0, 0);
            this.lblChequeIssuance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChequeIssuance.Name = "lblChequeIssuance";
            this.lblChequeIssuance.Size = new System.Drawing.Size(1378, 84);
            this.lblChequeIssuance.TabIndex = 15;
            this.lblChequeIssuance.Text = "Cheque Issuance";
            this.lblChequeIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckVoucherNumber
            // 
            this.lblCheckVoucherNumber.AutoSize = true;
            this.lblCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckVoucherNumber.Location = new System.Drawing.Point(2, 84);
            this.lblCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckVoucherNumber.Name = "lblCheckVoucherNumber";
            this.lblCheckVoucherNumber.Size = new System.Drawing.Size(260, 37);
            this.lblCheckVoucherNumber.TabIndex = 87;
            this.lblCheckVoucherNumber.Text = "Cheque Voucher No.";
            // 
            // tbxCheckVoucherNumber
            // 
            this.tbxCheckVoucherNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxCheckVoucherNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCheckVoucherNumber.BackColor = System.Drawing.Color.White;
            this.tbxCheckVoucherNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCheckVoucherNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheckVoucherNumber.Location = new System.Drawing.Point(11, 124);
            this.tbxCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxCheckVoucherNumber.Name = "tbxCheckVoucherNumber";
            this.tbxCheckVoucherNumber.Size = new System.Drawing.Size(462, 46);
            this.tbxCheckVoucherNumber.TabIndex = 86;
            this.tbxCheckVoucherNumber.TextChanged += new System.EventHandler(this.tbxCheckVoucherNumber_TextChanged);
            this.tbxCheckVoucherNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCheckVoucherNumber_KeyDown);
            this.tbxCheckVoucherNumber.Leave += new System.EventHandler(this.tbxCheckVoucherNumber_Leave);
            // 
            // lblChangeCheckVoucherNumber
            // 
            this.lblChangeCheckVoucherNumber.AutoSize = true;
            this.lblChangeCheckVoucherNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChangeCheckVoucherNumber.Location = new System.Drawing.Point(410, 100);
            this.lblChangeCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeCheckVoucherNumber.Name = "lblChangeCheckVoucherNumber";
            this.lblChangeCheckVoucherNumber.Size = new System.Drawing.Size(63, 21);
            this.lblChangeCheckVoucherNumber.TabIndex = 88;
            this.lblChangeCheckVoucherNumber.TabStop = true;
            this.lblChangeCheckVoucherNumber.Text = "Change";
            this.lblChangeCheckVoucherNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangeCheckVoucherNumber_LinkClicked);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(7, 173);
            this.lblBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(44, 21);
            this.lblBank.TabIndex = 89;
            this.lblBank.Text = "Bank";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(236, 173);
            this.lblBankAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(104, 21);
            this.lblBankAccount.TabIndex = 94;
            this.lblBankAccount.Text = "Bank Account";
            // 
            // dgvPayables
            // 
            this.dgvPayables.AllowUserToAddRows = false;
            this.dgvPayables.AllowUserToDeleteRows = false;
            this.dgvPayables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPayables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPayables.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPayables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayables.ColumnHeadersHeight = 60;
            this.dgvPayables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPayable,
            this.colPayableCompany,
            this.colPayableBranch,
            this.colPayableTotalAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayables.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayables.EnableHeadersVisualStyles = false;
            this.dgvPayables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPayables.Location = new System.Drawing.Point(9, 232);
            this.dgvPayables.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPayables.MultiSelect = false;
            this.dgvPayables.Name = "dgvPayables";
            this.dgvPayables.ReadOnly = true;
            this.dgvPayables.RowHeadersVisible = false;
            this.dgvPayables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayables.RowTemplate.Height = 40;
            this.dgvPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayables.Size = new System.Drawing.Size(1360, 364);
            this.dgvPayables.TabIndex = 102;
            // 
            // colPayable
            // 
            this.colPayable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPayable.HeaderText = "Payables";
            this.colPayable.Name = "colPayable";
            this.colPayable.ReadOnly = true;
            // 
            // colPayableCompany
            // 
            this.colPayableCompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPayableCompany.HeaderText = "Company";
            this.colPayableCompany.Name = "colPayableCompany";
            this.colPayableCompany.ReadOnly = true;
            this.colPayableCompany.Width = 101;
            // 
            // colPayableBranch
            // 
            this.colPayableBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPayableBranch.HeaderText = "Branch";
            this.colPayableBranch.Name = "colPayableBranch";
            this.colPayableBranch.ReadOnly = true;
            this.colPayableBranch.Width = 82;
            // 
            // colPayableTotalAmount
            // 
            this.colPayableTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPayableTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPayableTotalAmount.HeaderText = "Total Amount";
            this.colPayableTotalAmount.Name = "colPayableTotalAmount";
            this.colPayableTotalAmount.ReadOnly = true;
            this.colPayableTotalAmount.Width = 115;
            // 
            // tbxCheckNumber
            // 
            this.tbxCheckNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCheckNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxCheckNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCheckNumber.BackColor = System.Drawing.Color.Black;
            this.tbxCheckNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCheckNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCheckNumber.Font = new System.Drawing.Font("Segoe UI", 42.5F, System.Drawing.FontStyle.Bold);
            this.tbxCheckNumber.ForeColor = System.Drawing.Color.Lime;
            this.tbxCheckNumber.Location = new System.Drawing.Point(1020, 78);
            this.tbxCheckNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxCheckNumber.Name = "tbxCheckNumber";
            this.tbxCheckNumber.ReadOnly = true;
            this.tbxCheckNumber.Size = new System.Drawing.Size(349, 83);
            this.tbxCheckNumber.TabIndex = 103;
            this.tbxCheckNumber.Text = "0000000";
            this.tbxCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPayee
            // 
            this.tbxPayee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPayee.BackColor = System.Drawing.Color.White;
            this.tbxPayee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPayee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPayee.Font = new System.Drawing.Font("Segoe UI", 28.5F);
            this.tbxPayee.Location = new System.Drawing.Point(739, 168);
            this.tbxPayee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxPayee.Name = "tbxPayee";
            this.tbxPayee.ReadOnly = true;
            this.tbxPayee.Size = new System.Drawing.Size(630, 58);
            this.tbxPayee.TabIndex = 105;
            this.tbxPayee.TextChanged += new System.EventHandler(this.tbxPayee_TextChanged);
            // 
            // lblPayee
            // 
            this.lblPayee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayee.AutoSize = true;
            this.lblPayee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayee.Location = new System.Drawing.Point(733, 133);
            this.lblPayee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayee.Name = "lblPayee";
            this.lblPayee.Size = new System.Drawing.Size(77, 32);
            this.lblPayee.TabIndex = 104;
            this.lblPayee.Text = "Payee";
            // 
            // lblCheckNumber
            // 
            this.lblCheckNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCheckNumber.AutoSize = true;
            this.lblCheckNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckNumber.Location = new System.Drawing.Point(859, 78);
            this.lblCheckNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckNumber.Name = "lblCheckNumber";
            this.lblCheckNumber.Size = new System.Drawing.Size(157, 37);
            this.lblCheckNumber.TabIndex = 106;
            this.lblCheckNumber.Text = "Cheque No.";
            // 
            // cmbxBanks
            // 
            this.cmbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBanks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBanks.FormattingEnabled = true;
            this.cmbxBanks.Location = new System.Drawing.Point(9, 197);
            this.cmbxBanks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxBanks.Name = "cmbxBanks";
            this.cmbxBanks.Size = new System.Drawing.Size(227, 29);
            this.cmbxBanks.TabIndex = 107;
            this.cmbxBanks.SelectedIndexChanged += new System.EventHandler(this.cmbxBanks_SelectedIndexChanged);
            // 
            // cmbxBankAccounts
            // 
            this.cmbxBankAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBankAccounts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBankAccounts.FormattingEnabled = true;
            this.cmbxBankAccounts.Location = new System.Drawing.Point(240, 197);
            this.cmbxBankAccounts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxBankAccounts.Name = "cmbxBankAccounts";
            this.cmbxBankAccounts.Size = new System.Drawing.Size(231, 29);
            this.cmbxBankAccounts.TabIndex = 108;
            this.cmbxBankAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbxBankAccounts_SelectedIndexChanged);
            // 
            // btnExportCheque
            // 
            this.btnExportCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCheque.BackColor = System.Drawing.Color.Red;
            this.btnExportCheque.FlatAppearance.BorderSize = 0;
            this.btnExportCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCheque.ForeColor = System.Drawing.Color.White;
            this.btnExportCheque.Location = new System.Drawing.Point(1101, 602);
            this.btnExportCheque.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExportCheque.Name = "btnExportCheque";
            this.btnExportCheque.Size = new System.Drawing.Size(164, 50);
            this.btnExportCheque.TabIndex = 109;
            this.btnExportCheque.Text = "Export Cheque";
            this.btnExportCheque.UseVisualStyleBackColor = false;
            this.btnExportCheque.Click += new System.EventHandler(this.btnExportCheque_Click);
            // 
            // lblgrandTotal
            // 
            this.lblgrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgrandTotal.AutoSize = true;
            this.lblgrandTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrandTotal.Location = new System.Drawing.Point(448, 604);
            this.lblgrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrandTotal.Name = "lblgrandTotal";
            this.lblgrandTotal.Size = new System.Drawing.Size(154, 37);
            this.lblgrandTotal.TabIndex = 110;
            this.lblgrandTotal.Text = "Grand Total";
            // 
            // tbxGrandTotal
            // 
            this.tbxGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxGrandTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxGrandTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxGrandTotal.BackColor = System.Drawing.Color.Black;
            this.tbxGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrandTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrandTotal.ForeColor = System.Drawing.Color.Lime;
            this.tbxGrandTotal.Location = new System.Drawing.Point(606, 602);
            this.tbxGrandTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxGrandTotal.Name = "tbxGrandTotal";
            this.tbxGrandTotal.ReadOnly = true;
            this.tbxGrandTotal.Size = new System.Drawing.Size(491, 50);
            this.tbxGrandTotal.TabIndex = 111;
            this.tbxGrandTotal.Text = "0.00";
            this.tbxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1269, 602);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.Location = new System.Drawing.Point(474, 173);
            this.lblChequeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(99, 21);
            this.lblChequeDate.TabIndex = 113;
            this.lblChequeDate.Text = "Cheque Date";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(476, 197);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(235, 29);
            this.dtpChequeDate.TabIndex = 114;
            // 
            // ChequeIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 664);
            this.Controls.Add(this.dtpChequeDate);
            this.Controls.Add(this.lblChequeDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxGrandTotal);
            this.Controls.Add(this.lblgrandTotal);
            this.Controls.Add(this.btnExportCheque);
            this.Controls.Add(this.cmbxBankAccounts);
            this.Controls.Add(this.cmbxBanks);
            this.Controls.Add(this.lblCheckNumber);
            this.Controls.Add(this.tbxPayee);
            this.Controls.Add(this.lblPayee);
            this.Controls.Add(this.tbxCheckNumber);
            this.Controls.Add(this.dgvPayables);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblChangeCheckVoucherNumber);
            this.Controls.Add(this.lblCheckVoucherNumber);
            this.Controls.Add(this.tbxCheckVoucherNumber);
            this.Controls.Add(this.lblChequeIssuance);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ChequeIssuanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payables | Cheque Issuance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChequeIssuanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChequeIssuance;
        private System.Windows.Forms.Label lblCheckVoucherNumber;
        private System.Windows.Forms.TextBox tbxCheckVoucherNumber;
        private System.Windows.Forms.LinkLabel lblChangeCheckVoucherNumber;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.DataGridView dgvPayables;
        private System.Windows.Forms.TextBox tbxCheckNumber;
        private System.Windows.Forms.Label lblPayee;
        private System.Windows.Forms.TextBox tbxPayee;
        private System.Windows.Forms.Label lblCheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayableTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayableBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayableCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayable;
        private System.Windows.Forms.ComboBox cmbxBanks;
        private System.Windows.Forms.ComboBox cmbxBankAccounts;
        private System.Windows.Forms.Button btnExportCheque;
        private System.Windows.Forms.Label lblgrandTotal;
        private System.Windows.Forms.TextBox tbxGrandTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblChequeDate;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
    }
}