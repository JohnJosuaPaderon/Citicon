﻿namespace Citicon.Payables
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
            this.btnRange = new System.Windows.Forms.Button();
            this.tbxBank = new System.Windows.Forms.TextBox();
            this.tbxBankAccount = new System.Windows.Forms.TextBox();
            this.ChequeCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.ChequeCompanyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayables)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChequeIssuance
            // 
            this.lblChequeIssuance.BackColor = System.Drawing.Color.White;
            this.lblChequeIssuance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChequeIssuance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeIssuance.Location = new System.Drawing.Point(0, 0);
            this.lblChequeIssuance.Name = "lblChequeIssuance";
            this.lblChequeIssuance.Size = new System.Drawing.Size(1265, 68);
            this.lblChequeIssuance.TabIndex = 15;
            this.lblChequeIssuance.Text = "Cheque Issuance";
            this.lblChequeIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCheckVoucherNumber
            // 
            this.lblCheckVoucherNumber.AutoSize = true;
            this.lblCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckVoucherNumber.Location = new System.Drawing.Point(6, 68);
            this.lblCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckVoucherNumber.Name = "lblCheckVoucherNumber";
            this.lblCheckVoucherNumber.Size = new System.Drawing.Size(205, 30);
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
            this.tbxCheckVoucherNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheckVoucherNumber.Location = new System.Drawing.Point(11, 100);
            this.tbxCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCheckVoucherNumber.Name = "tbxCheckVoucherNumber";
            this.tbxCheckVoucherNumber.Size = new System.Drawing.Size(356, 35);
            this.tbxCheckVoucherNumber.TabIndex = 86;
            this.tbxCheckVoucherNumber.TextChanged += new System.EventHandler(this.tbxCheckVoucherNumber_TextChanged);
            this.tbxCheckVoucherNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxCheckVoucherNumber_KeyDown);
            this.tbxCheckVoucherNumber.Leave += new System.EventHandler(this.tbxCheckVoucherNumber_Leave);
            // 
            // lblChangeCheckVoucherNumber
            // 
            this.lblChangeCheckVoucherNumber.AutoSize = true;
            this.lblChangeCheckVoucherNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblChangeCheckVoucherNumber.Location = new System.Drawing.Point(315, 78);
            this.lblChangeCheckVoucherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeCheckVoucherNumber.Name = "lblChangeCheckVoucherNumber";
            this.lblChangeCheckVoucherNumber.Size = new System.Drawing.Size(52, 17);
            this.lblChangeCheckVoucherNumber.TabIndex = 88;
            this.lblChangeCheckVoucherNumber.TabStop = true;
            this.lblChangeCheckVoucherNumber.Text = "Change";
            this.lblChangeCheckVoucherNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangeCheckVoucherNumber_LinkClicked);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(607, 139);
            this.lblBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(35, 17);
            this.lblBank.TabIndex = 89;
            this.lblBank.Text = "Bank";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(828, 139);
            this.lblBankAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(85, 17);
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
            this.dgvPayables.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPayables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayables.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayables.EnableHeadersVisualStyles = false;
            this.dgvPayables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPayables.Location = new System.Drawing.Point(7, 188);
            this.dgvPayables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPayables.MultiSelect = false;
            this.dgvPayables.Name = "dgvPayables";
            this.dgvPayables.ReadOnly = true;
            this.dgvPayables.RowHeadersVisible = false;
            this.dgvPayables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayables.RowTemplate.Height = 40;
            this.dgvPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayables.Size = new System.Drawing.Size(1247, 295);
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
            this.colPayableCompany.Width = 87;
            // 
            // colPayableBranch
            // 
            this.colPayableBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPayableBranch.HeaderText = "Branch";
            this.colPayableBranch.Name = "colPayableBranch";
            this.colPayableBranch.ReadOnly = true;
            this.colPayableBranch.Width = 71;
            // 
            // colPayableTotalAmount
            // 
            this.colPayableTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPayableTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPayableTotalAmount.HeaderText = "Total Amount";
            this.colPayableTotalAmount.Name = "colPayableTotalAmount";
            this.colPayableTotalAmount.ReadOnly = true;
            // 
            // tbxCheckNumber
            // 
            this.tbxCheckNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxCheckNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCheckNumber.BackColor = System.Drawing.Color.Black;
            this.tbxCheckNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCheckNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxCheckNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCheckNumber.ForeColor = System.Drawing.Color.Lime;
            this.tbxCheckNumber.Location = new System.Drawing.Point(111, 146);
            this.tbxCheckNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCheckNumber.Name = "tbxCheckNumber";
            this.tbxCheckNumber.ReadOnly = true;
            this.tbxCheckNumber.Size = new System.Drawing.Size(177, 35);
            this.tbxCheckNumber.TabIndex = 103;
            this.tbxCheckNumber.Text = "0000000";
            this.tbxCheckNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPayee
            // 
            this.tbxPayee.BackColor = System.Drawing.Color.White;
            this.tbxPayee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPayee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPayee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPayee.Location = new System.Drawing.Point(393, 102);
            this.tbxPayee.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPayee.Name = "tbxPayee";
            this.tbxPayee.ReadOnly = true;
            this.tbxPayee.Size = new System.Drawing.Size(655, 35);
            this.tbxPayee.TabIndex = 105;
            this.tbxPayee.TextChanged += new System.EventHandler(this.tbxPayee_TextChanged);
            // 
            // lblPayee
            // 
            this.lblPayee.AutoSize = true;
            this.lblPayee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayee.Location = new System.Drawing.Point(388, 68);
            this.lblPayee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayee.Name = "lblPayee";
            this.lblPayee.Size = new System.Drawing.Size(67, 30);
            this.lblPayee.TabIndex = 104;
            this.lblPayee.Text = "Payee";
            // 
            // lblCheckNumber
            // 
            this.lblCheckNumber.AutoSize = true;
            this.lblCheckNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckNumber.Location = new System.Drawing.Point(6, 146);
            this.lblCheckNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckNumber.Name = "lblCheckNumber";
            this.lblCheckNumber.Size = new System.Drawing.Size(99, 21);
            this.lblCheckNumber.TabIndex = 106;
            this.lblCheckNumber.Text = "Cheque No.";
            // 
            // cmbxBanks
            // 
            this.cmbxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBanks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBanks.FormattingEnabled = true;
            this.cmbxBanks.Location = new System.Drawing.Point(419, 42);
            this.cmbxBanks.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxBanks.Name = "cmbxBanks";
            this.cmbxBanks.Size = new System.Drawing.Size(177, 25);
            this.cmbxBanks.TabIndex = 107;
            this.cmbxBanks.Visible = false;
            this.cmbxBanks.SelectedIndexChanged += new System.EventHandler(this.cmbxBanks_SelectedIndexChanged);
            // 
            // cmbxBankAccounts
            // 
            this.cmbxBankAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBankAccounts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBankAccounts.FormattingEnabled = true;
            this.cmbxBankAccounts.Location = new System.Drawing.Point(599, 42);
            this.cmbxBankAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxBankAccounts.Name = "cmbxBankAccounts";
            this.cmbxBankAccounts.Size = new System.Drawing.Size(181, 25);
            this.cmbxBankAccounts.TabIndex = 108;
            this.cmbxBankAccounts.Visible = false;
            this.cmbxBankAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbxBankAccounts_SelectedIndexChanged);
            // 
            // btnExportCheque
            // 
            this.btnExportCheque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCheque.BackColor = System.Drawing.Color.Red;
            this.btnExportCheque.FlatAppearance.BorderSize = 0;
            this.btnExportCheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCheque.ForeColor = System.Drawing.Color.White;
            this.btnExportCheque.Location = new System.Drawing.Point(1045, 487);
            this.btnExportCheque.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportCheque.Name = "btnExportCheque";
            this.btnExportCheque.Size = new System.Drawing.Size(128, 40);
            this.btnExportCheque.TabIndex = 109;
            this.btnExportCheque.Text = "Export Cheque";
            this.btnExportCheque.UseVisualStyleBackColor = false;
            this.btnExportCheque.Click += new System.EventHandler(this.btnExportCheque_Click);
            // 
            // lblgrandTotal
            // 
            this.lblgrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgrandTotal.AutoSize = true;
            this.lblgrandTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrandTotal.Location = new System.Drawing.Point(536, 495);
            this.lblgrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgrandTotal.Name = "lblgrandTotal";
            this.lblgrandTotal.Size = new System.Drawing.Size(119, 30);
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
            this.tbxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrandTotal.ForeColor = System.Drawing.Color.Lime;
            this.tbxGrandTotal.Location = new System.Drawing.Point(659, 493);
            this.tbxGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGrandTotal.Name = "tbxGrandTotal";
            this.tbxGrandTotal.ReadOnly = true;
            this.tbxGrandTotal.Size = new System.Drawing.Size(382, 35);
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
            this.btnClose.Location = new System.Drawing.Point(1176, 487);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 40);
            this.btnClose.TabIndex = 112;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.Location = new System.Drawing.Point(419, 139);
            this.lblChequeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(83, 17);
            this.lblChequeDate.TabIndex = 113;
            this.lblChequeDate.Text = "Cheque Date";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChequeDate.Location = new System.Drawing.Point(422, 158);
            this.dtpChequeDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(184, 25);
            this.dtpChequeDate.TabIndex = 114;
            // 
            // btnRange
            // 
            this.btnRange.BackColor = System.Drawing.Color.Red;
            this.btnRange.FlatAppearance.BorderSize = 0;
            this.btnRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRange.ForeColor = System.Drawing.Color.White;
            this.btnRange.Location = new System.Drawing.Point(292, 146);
            this.btnRange.Margin = new System.Windows.Forms.Padding(2);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(75, 35);
            this.btnRange.TabIndex = 115;
            this.btnRange.Text = "Range";
            this.btnRange.UseVisualStyleBackColor = false;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // tbxBank
            // 
            this.tbxBank.Location = new System.Drawing.Point(610, 159);
            this.tbxBank.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBank.Name = "tbxBank";
            this.tbxBank.ReadOnly = true;
            this.tbxBank.Size = new System.Drawing.Size(217, 25);
            this.tbxBank.TabIndex = 116;
            // 
            // tbxBankAccount
            // 
            this.tbxBankAccount.Location = new System.Drawing.Point(831, 159);
            this.tbxBankAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tbxBankAccount.Name = "tbxBankAccount";
            this.tbxBankAccount.ReadOnly = true;
            this.tbxBankAccount.Size = new System.Drawing.Size(217, 25);
            this.tbxBankAccount.TabIndex = 117;
            // 
            // ChequeCompanyComboBox
            // 
            this.ChequeCompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChequeCompanyComboBox.FormattingEnabled = true;
            this.ChequeCompanyComboBox.Location = new System.Drawing.Point(1053, 159);
            this.ChequeCompanyComboBox.Name = "ChequeCompanyComboBox";
            this.ChequeCompanyComboBox.Size = new System.Drawing.Size(179, 25);
            this.ChequeCompanyComboBox.TabIndex = 118;
            // 
            // ChequeCompanyLabel
            // 
            this.ChequeCompanyLabel.AutoSize = true;
            this.ChequeCompanyLabel.Location = new System.Drawing.Point(1052, 139);
            this.ChequeCompanyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChequeCompanyLabel.Name = "ChequeCompanyLabel";
            this.ChequeCompanyLabel.Size = new System.Drawing.Size(63, 17);
            this.ChequeCompanyLabel.TabIndex = 119;
            this.ChequeCompanyLabel.Text = "Company";
            // 
            // ChequeIssuanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 538);
            this.Controls.Add(this.ChequeCompanyLabel);
            this.Controls.Add(this.ChequeCompanyComboBox);
            this.Controls.Add(this.tbxBankAccount);
            this.Controls.Add(this.tbxBank);
            this.Controls.Add(this.btnRange);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox tbxBank;
        private System.Windows.Forms.TextBox tbxBankAccount;
        private System.Windows.Forms.ComboBox ChequeCompanyComboBox;
        private System.Windows.Forms.Label ChequeCompanyLabel;
    }
}