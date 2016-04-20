namespace Citicon.Payables
{
    partial class MaintenanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMaintenance = new System.Windows.Forms.Label();
            this.tcMaintenance = new System.Windows.Forms.TabControl();
            this.tpGeneralSettings = new System.Windows.Forms.TabPage();
            this.btnRevokeMrisNumber = new System.Windows.Forms.Button();
            this.tbxRevokeMrisNumber = new System.Windows.Forms.TextBox();
            this.lblRevokeMrisNumber = new System.Windows.Forms.Label();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.btnCancelExpense = new System.Windows.Forms.Button();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.btnRemoveExpense = new System.Windows.Forms.Button();
            this.tbxExpenseCode = new System.Windows.Forms.TextBox();
            this.lblExpenseCode = new System.Windows.Forms.Label();
            this.tbxExpenseDescription = new System.Windows.Forms.TextBox();
            this.lblExpenseDescription = new System.Windows.Forms.Label();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colExpenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpenseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpBanks = new System.Windows.Forms.TabPage();
            this.btnCancelBank = new System.Windows.Forms.Button();
            this.btnSaveBank = new System.Windows.Forms.Button();
            this.btnRemoveBank = new System.Windows.Forms.Button();
            this.tbxBankCode = new System.Windows.Forms.TextBox();
            this.lblBankCode = new System.Windows.Forms.Label();
            this.tbxBankDescription = new System.Windows.Forms.TextBox();
            this.lblBankDescription = new System.Windows.Forms.Label();
            this.btnEditBank = new System.Windows.Forms.Button();
            this.btnNewbank = new System.Windows.Forms.Button();
            this.dgvBanks = new System.Windows.Forms.DataGridView();
            this.colBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpBankAccounts = new System.Windows.Forms.TabPage();
            this.lblBankAccountBank = new System.Windows.Forms.Label();
            this.cmbxBankAccountbank = new System.Windows.Forms.ComboBox();
            this.btnCancelBankAccount = new System.Windows.Forms.Button();
            this.btnSaveBankAccount = new System.Windows.Forms.Button();
            this.btnRemoveBankAccount = new System.Windows.Forms.Button();
            this.tbxBankAccountCode = new System.Windows.Forms.TextBox();
            this.lblbankAccountCode = new System.Windows.Forms.Label();
            this.tbxBankAccountDescription = new System.Windows.Forms.TextBox();
            this.lblBankAccountDescription = new System.Windows.Forms.Label();
            this.btnEditBankAccount = new System.Windows.Forms.Button();
            this.btnNewBankAccount = new System.Windows.Forms.Button();
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.colBankAccounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccountBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccountChequeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcMaintenance.SuspendLayout();
            this.tpGeneralSettings.SuspendLayout();
            this.tpExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.tpBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).BeginInit();
            this.tpBankAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaintenance
            // 
            this.lblMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMaintenance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenance.Location = new System.Drawing.Point(0, 0);
            this.lblMaintenance.Name = "lblMaintenance";
            this.lblMaintenance.Size = new System.Drawing.Size(1345, 100);
            this.lblMaintenance.TabIndex = 1;
            this.lblMaintenance.Text = "Maintenance";
            this.lblMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcMaintenance
            // 
            this.tcMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMaintenance.Controls.Add(this.tpGeneralSettings);
            this.tcMaintenance.Controls.Add(this.tpExpenses);
            this.tcMaintenance.Controls.Add(this.tpBanks);
            this.tcMaintenance.Controls.Add(this.tpBankAccounts);
            this.tcMaintenance.Location = new System.Drawing.Point(11, 103);
            this.tcMaintenance.Name = "tcMaintenance";
            this.tcMaintenance.Padding = new System.Drawing.Point(15, 15);
            this.tcMaintenance.SelectedIndex = 0;
            this.tcMaintenance.Size = new System.Drawing.Size(1322, 592);
            this.tcMaintenance.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcMaintenance.TabIndex = 2;
            // 
            // tpGeneralSettings
            // 
            this.tpGeneralSettings.Controls.Add(this.btnRevokeMrisNumber);
            this.tpGeneralSettings.Controls.Add(this.tbxRevokeMrisNumber);
            this.tpGeneralSettings.Controls.Add(this.lblRevokeMrisNumber);
            this.tpGeneralSettings.Location = new System.Drawing.Point(4, 58);
            this.tpGeneralSettings.Name = "tpGeneralSettings";
            this.tpGeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneralSettings.Size = new System.Drawing.Size(1314, 530);
            this.tpGeneralSettings.TabIndex = 10;
            this.tpGeneralSettings.Text = "General Settings";
            // 
            // btnRevokeMrisNumber
            // 
            this.btnRevokeMrisNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRevokeMrisNumber.FlatAppearance.BorderSize = 0;
            this.btnRevokeMrisNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevokeMrisNumber.ForeColor = System.Drawing.Color.White;
            this.btnRevokeMrisNumber.Location = new System.Drawing.Point(424, 31);
            this.btnRevokeMrisNumber.Name = "btnRevokeMrisNumber";
            this.btnRevokeMrisNumber.Size = new System.Drawing.Size(125, 33);
            this.btnRevokeMrisNumber.TabIndex = 47;
            this.btnRevokeMrisNumber.Text = "Revoke";
            this.btnRevokeMrisNumber.UseVisualStyleBackColor = false;
            this.btnRevokeMrisNumber.Click += new System.EventHandler(this.btnRevokeMrisNumber_Click);
            // 
            // tbxRevokeMrisNumber
            // 
            this.tbxRevokeMrisNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxRevokeMrisNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxRevokeMrisNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRevokeMrisNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxRevokeMrisNumber.Location = new System.Drawing.Point(11, 31);
            this.tbxRevokeMrisNumber.MaxLength = 75;
            this.tbxRevokeMrisNumber.Name = "tbxRevokeMrisNumber";
            this.tbxRevokeMrisNumber.Size = new System.Drawing.Size(407, 33);
            this.tbxRevokeMrisNumber.TabIndex = 46;
            // 
            // lblRevokeMrisNumber
            // 
            this.lblRevokeMrisNumber.AutoSize = true;
            this.lblRevokeMrisNumber.Location = new System.Drawing.Point(6, 3);
            this.lblRevokeMrisNumber.Name = "lblRevokeMrisNumber";
            this.lblRevokeMrisNumber.Size = new System.Drawing.Size(224, 25);
            this.lblRevokeMrisNumber.TabIndex = 45;
            this.lblRevokeMrisNumber.Text = "Revoke issued MRIS No.\'s";
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.btnCancelExpense);
            this.tpExpenses.Controls.Add(this.btnSaveExpense);
            this.tpExpenses.Controls.Add(this.btnRemoveExpense);
            this.tpExpenses.Controls.Add(this.tbxExpenseCode);
            this.tpExpenses.Controls.Add(this.lblExpenseCode);
            this.tpExpenses.Controls.Add(this.tbxExpenseDescription);
            this.tpExpenses.Controls.Add(this.lblExpenseDescription);
            this.tpExpenses.Controls.Add(this.btnEditExpense);
            this.tpExpenses.Controls.Add(this.btnNewExpense);
            this.tpExpenses.Controls.Add(this.dgvExpenses);
            this.tpExpenses.Location = new System.Drawing.Point(4, 58);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(1314, 530);
            this.tpExpenses.TabIndex = 7;
            this.tpExpenses.Text = "Expenses";
            // 
            // btnCancelExpense
            // 
            this.btnCancelExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelExpense.ForeColor = System.Drawing.Color.White;
            this.btnCancelExpense.Location = new System.Drawing.Point(1091, 187);
            this.btnCancelExpense.Name = "btnCancelExpense";
            this.btnCancelExpense.Size = new System.Drawing.Size(125, 50);
            this.btnCancelExpense.TabIndex = 52;
            this.btnCancelExpense.Text = "&Cancel";
            this.btnCancelExpense.UseVisualStyleBackColor = false;
            this.btnCancelExpense.Click += new System.EventHandler(this.btnCancelExpense_Click);
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExpense.ForeColor = System.Drawing.Color.White;
            this.btnSaveExpense.Location = new System.Drawing.Point(960, 187);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(125, 50);
            this.btnSaveExpense.TabIndex = 51;
            this.btnSaveExpense.Text = "&Save";
            this.btnSaveExpense.UseVisualStyleBackColor = false;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click);
            // 
            // btnRemoveExpense
            // 
            this.btnRemoveExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExpense.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExpense.Location = new System.Drawing.Point(829, 187);
            this.btnRemoveExpense.Name = "btnRemoveExpense";
            this.btnRemoveExpense.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveExpense.TabIndex = 50;
            this.btnRemoveExpense.Text = "&Remove";
            this.btnRemoveExpense.UseVisualStyleBackColor = false;
            this.btnRemoveExpense.Click += new System.EventHandler(this.btnRemoveExpense_Click);
            // 
            // tbxExpenseCode
            // 
            this.tbxExpenseCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseCode.Enabled = false;
            this.tbxExpenseCode.Location = new System.Drawing.Point(809, 148);
            this.tbxExpenseCode.MaxLength = 75;
            this.tbxExpenseCode.Name = "tbxExpenseCode";
            this.tbxExpenseCode.Size = new System.Drawing.Size(407, 33);
            this.tbxExpenseCode.TabIndex = 47;
            // 
            // lblExpenseCode
            // 
            this.lblExpenseCode.AutoSize = true;
            this.lblExpenseCode.Location = new System.Drawing.Point(804, 120);
            this.lblExpenseCode.Name = "lblExpenseCode";
            this.lblExpenseCode.Size = new System.Drawing.Size(56, 25);
            this.lblExpenseCode.TabIndex = 46;
            this.lblExpenseCode.Text = "Code";
            // 
            // tbxExpenseDescription
            // 
            this.tbxExpenseDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxExpenseDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxExpenseDescription.Enabled = false;
            this.tbxExpenseDescription.Location = new System.Drawing.Point(809, 84);
            this.tbxExpenseDescription.MaxLength = 75;
            this.tbxExpenseDescription.Name = "tbxExpenseDescription";
            this.tbxExpenseDescription.Size = new System.Drawing.Size(407, 33);
            this.tbxExpenseDescription.TabIndex = 45;
            // 
            // lblExpenseDescription
            // 
            this.lblExpenseDescription.AutoSize = true;
            this.lblExpenseDescription.Location = new System.Drawing.Point(804, 56);
            this.lblExpenseDescription.Name = "lblExpenseDescription";
            this.lblExpenseDescription.Size = new System.Drawing.Size(108, 25);
            this.lblExpenseDescription.TabIndex = 44;
            this.lblExpenseDescription.Text = "Description";
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditExpense.ForeColor = System.Drawing.Color.White;
            this.btnEditExpense.Location = new System.Drawing.Point(940, 3);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(125, 50);
            this.btnEditExpense.TabIndex = 43;
            this.btnEditExpense.Text = "&Edit";
            this.btnEditExpense.UseVisualStyleBackColor = false;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExpense.ForeColor = System.Drawing.Color.White;
            this.btnNewExpense.Location = new System.Drawing.Point(809, 3);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(125, 50);
            this.btnNewExpense.TabIndex = 42;
            this.btnNewExpense.Text = "&New";
            this.btnNewExpense.UseVisualStyleBackColor = false;
            this.btnNewExpense.Click += new System.EventHandler(this.btnNewExpense_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvExpenses.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvExpenses.ColumnHeadersHeight = 50;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpenses,
            this.colExpenseCode});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvExpenses.EnableHeadersVisualStyles = false;
            this.dgvExpenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvExpenses.Location = new System.Drawing.Point(3, 3);
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.RowTemplate.Height = 30;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Size = new System.Drawing.Size(800, 524);
            this.dgvExpenses.TabIndex = 14;
            this.dgvExpenses.SelectionChanged += new System.EventHandler(this.dgvExpenses_SelectionChanged);
            // 
            // colExpenses
            // 
            this.colExpenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colExpenses.HeaderText = "Expenses";
            this.colExpenses.Name = "colExpenses";
            this.colExpenses.ReadOnly = true;
            // 
            // colExpenseCode
            // 
            this.colExpenseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colExpenseCode.HeaderText = "Code";
            this.colExpenseCode.Name = "colExpenseCode";
            this.colExpenseCode.ReadOnly = true;
            this.colExpenseCode.Width = 80;
            // 
            // tpBanks
            // 
            this.tpBanks.Controls.Add(this.btnCancelBank);
            this.tpBanks.Controls.Add(this.btnSaveBank);
            this.tpBanks.Controls.Add(this.btnRemoveBank);
            this.tpBanks.Controls.Add(this.tbxBankCode);
            this.tpBanks.Controls.Add(this.lblBankCode);
            this.tpBanks.Controls.Add(this.tbxBankDescription);
            this.tpBanks.Controls.Add(this.lblBankDescription);
            this.tpBanks.Controls.Add(this.btnEditBank);
            this.tpBanks.Controls.Add(this.btnNewbank);
            this.tpBanks.Controls.Add(this.dgvBanks);
            this.tpBanks.Location = new System.Drawing.Point(4, 58);
            this.tpBanks.Name = "tpBanks";
            this.tpBanks.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanks.Size = new System.Drawing.Size(1314, 530);
            this.tpBanks.TabIndex = 8;
            this.tpBanks.Text = "Banks";
            // 
            // btnCancelBank
            // 
            this.btnCancelBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBank.ForeColor = System.Drawing.Color.White;
            this.btnCancelBank.Location = new System.Drawing.Point(1091, 187);
            this.btnCancelBank.Name = "btnCancelBank";
            this.btnCancelBank.Size = new System.Drawing.Size(125, 50);
            this.btnCancelBank.TabIndex = 62;
            this.btnCancelBank.Text = "&Cancel";
            this.btnCancelBank.UseVisualStyleBackColor = false;
            this.btnCancelBank.Click += new System.EventHandler(this.btnCancelBank_Click);
            // 
            // btnSaveBank
            // 
            this.btnSaveBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBank.ForeColor = System.Drawing.Color.White;
            this.btnSaveBank.Location = new System.Drawing.Point(960, 187);
            this.btnSaveBank.Name = "btnSaveBank";
            this.btnSaveBank.Size = new System.Drawing.Size(125, 50);
            this.btnSaveBank.TabIndex = 61;
            this.btnSaveBank.Text = "&Save";
            this.btnSaveBank.UseVisualStyleBackColor = false;
            this.btnSaveBank.Click += new System.EventHandler(this.btnSaveBank_Click);
            // 
            // btnRemoveBank
            // 
            this.btnRemoveBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBank.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBank.Location = new System.Drawing.Point(829, 187);
            this.btnRemoveBank.Name = "btnRemoveBank";
            this.btnRemoveBank.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveBank.TabIndex = 60;
            this.btnRemoveBank.Text = "&Remove";
            this.btnRemoveBank.UseVisualStyleBackColor = false;
            this.btnRemoveBank.Click += new System.EventHandler(this.btnRemoveBank_Click);
            // 
            // tbxBankCode
            // 
            this.tbxBankCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBankCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxBankCode.Enabled = false;
            this.tbxBankCode.Location = new System.Drawing.Point(809, 148);
            this.tbxBankCode.MaxLength = 75;
            this.tbxBankCode.Name = "tbxBankCode";
            this.tbxBankCode.Size = new System.Drawing.Size(407, 33);
            this.tbxBankCode.TabIndex = 59;
            // 
            // lblBankCode
            // 
            this.lblBankCode.AutoSize = true;
            this.lblBankCode.Location = new System.Drawing.Point(804, 120);
            this.lblBankCode.Name = "lblBankCode";
            this.lblBankCode.Size = new System.Drawing.Size(56, 25);
            this.lblBankCode.TabIndex = 58;
            this.lblBankCode.Text = "Code";
            // 
            // tbxBankDescription
            // 
            this.tbxBankDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBankDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxBankDescription.Enabled = false;
            this.tbxBankDescription.Location = new System.Drawing.Point(809, 84);
            this.tbxBankDescription.MaxLength = 75;
            this.tbxBankDescription.Name = "tbxBankDescription";
            this.tbxBankDescription.Size = new System.Drawing.Size(407, 33);
            this.tbxBankDescription.TabIndex = 57;
            // 
            // lblBankDescription
            // 
            this.lblBankDescription.AutoSize = true;
            this.lblBankDescription.Location = new System.Drawing.Point(804, 56);
            this.lblBankDescription.Name = "lblBankDescription";
            this.lblBankDescription.Size = new System.Drawing.Size(108, 25);
            this.lblBankDescription.TabIndex = 56;
            this.lblBankDescription.Text = "Description";
            // 
            // btnEditBank
            // 
            this.btnEditBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBank.ForeColor = System.Drawing.Color.White;
            this.btnEditBank.Location = new System.Drawing.Point(940, 3);
            this.btnEditBank.Name = "btnEditBank";
            this.btnEditBank.Size = new System.Drawing.Size(125, 50);
            this.btnEditBank.TabIndex = 55;
            this.btnEditBank.Text = "&Edit";
            this.btnEditBank.UseVisualStyleBackColor = false;
            this.btnEditBank.Click += new System.EventHandler(this.btnEditBank_Click);
            // 
            // btnNewbank
            // 
            this.btnNewbank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewbank.ForeColor = System.Drawing.Color.White;
            this.btnNewbank.Location = new System.Drawing.Point(809, 3);
            this.btnNewbank.Name = "btnNewbank";
            this.btnNewbank.Size = new System.Drawing.Size(125, 50);
            this.btnNewbank.TabIndex = 54;
            this.btnNewbank.Text = "&New";
            this.btnNewbank.UseVisualStyleBackColor = false;
            this.btnNewbank.Click += new System.EventHandler(this.btnNewbank_Click);
            // 
            // dgvBanks
            // 
            this.dgvBanks.AllowUserToAddRows = false;
            this.dgvBanks.AllowUserToDeleteRows = false;
            this.dgvBanks.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBanks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvBanks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBanks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBanks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBanks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBanks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvBanks.ColumnHeadersHeight = 50;
            this.dgvBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBank,
            this.colBankCode});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanks.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvBanks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBanks.EnableHeadersVisualStyles = false;
            this.dgvBanks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBanks.Location = new System.Drawing.Point(3, 3);
            this.dgvBanks.MultiSelect = false;
            this.dgvBanks.Name = "dgvBanks";
            this.dgvBanks.ReadOnly = true;
            this.dgvBanks.RowHeadersVisible = false;
            this.dgvBanks.RowTemplate.Height = 30;
            this.dgvBanks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanks.Size = new System.Drawing.Size(800, 524);
            this.dgvBanks.TabIndex = 53;
            this.dgvBanks.SelectionChanged += new System.EventHandler(this.dgvBanks_SelectionChanged);
            // 
            // colBank
            // 
            this.colBank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBank.HeaderText = "Banks";
            this.colBank.Name = "colBank";
            this.colBank.ReadOnly = true;
            // 
            // colBankCode
            // 
            this.colBankCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankCode.HeaderText = "Code";
            this.colBankCode.Name = "colBankCode";
            this.colBankCode.ReadOnly = true;
            this.colBankCode.Width = 80;
            // 
            // tpBankAccounts
            // 
            this.tpBankAccounts.Controls.Add(this.lblBankAccountBank);
            this.tpBankAccounts.Controls.Add(this.cmbxBankAccountbank);
            this.tpBankAccounts.Controls.Add(this.btnCancelBankAccount);
            this.tpBankAccounts.Controls.Add(this.btnSaveBankAccount);
            this.tpBankAccounts.Controls.Add(this.btnRemoveBankAccount);
            this.tpBankAccounts.Controls.Add(this.tbxBankAccountCode);
            this.tpBankAccounts.Controls.Add(this.lblbankAccountCode);
            this.tpBankAccounts.Controls.Add(this.tbxBankAccountDescription);
            this.tpBankAccounts.Controls.Add(this.lblBankAccountDescription);
            this.tpBankAccounts.Controls.Add(this.btnEditBankAccount);
            this.tpBankAccounts.Controls.Add(this.btnNewBankAccount);
            this.tpBankAccounts.Controls.Add(this.dgvBankAccounts);
            this.tpBankAccounts.Location = new System.Drawing.Point(4, 58);
            this.tpBankAccounts.Name = "tpBankAccounts";
            this.tpBankAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpBankAccounts.Size = new System.Drawing.Size(1314, 530);
            this.tpBankAccounts.TabIndex = 9;
            this.tpBankAccounts.Text = "Bank Accounts";
            // 
            // lblBankAccountBank
            // 
            this.lblBankAccountBank.AutoSize = true;
            this.lblBankAccountBank.Location = new System.Drawing.Point(804, 56);
            this.lblBankAccountBank.Name = "lblBankAccountBank";
            this.lblBankAccountBank.Size = new System.Drawing.Size(53, 25);
            this.lblBankAccountBank.TabIndex = 64;
            this.lblBankAccountBank.Text = "Bank";
            // 
            // cmbxBankAccountbank
            // 
            this.cmbxBankAccountbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBankAccountbank.Enabled = false;
            this.cmbxBankAccountbank.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxBankAccountbank.FormattingEnabled = true;
            this.cmbxBankAccountbank.Location = new System.Drawing.Point(809, 84);
            this.cmbxBankAccountbank.Name = "cmbxBankAccountbank";
            this.cmbxBankAccountbank.Size = new System.Drawing.Size(407, 33);
            this.cmbxBankAccountbank.TabIndex = 63;
            this.cmbxBankAccountbank.SelectedIndexChanged += new System.EventHandler(this.cmbxBankAccountbank_SelectedIndexChanged);
            // 
            // btnCancelBankAccount
            // 
            this.btnCancelBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnCancelBankAccount.Location = new System.Drawing.Point(1091, 251);
            this.btnCancelBankAccount.Name = "btnCancelBankAccount";
            this.btnCancelBankAccount.Size = new System.Drawing.Size(125, 50);
            this.btnCancelBankAccount.TabIndex = 62;
            this.btnCancelBankAccount.Text = "&Cancel";
            this.btnCancelBankAccount.UseVisualStyleBackColor = false;
            this.btnCancelBankAccount.Click += new System.EventHandler(this.btnCancelBankAccount_Click);
            // 
            // btnSaveBankAccount
            // 
            this.btnSaveBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnSaveBankAccount.Location = new System.Drawing.Point(960, 251);
            this.btnSaveBankAccount.Name = "btnSaveBankAccount";
            this.btnSaveBankAccount.Size = new System.Drawing.Size(125, 50);
            this.btnSaveBankAccount.TabIndex = 61;
            this.btnSaveBankAccount.Text = "&Save";
            this.btnSaveBankAccount.UseVisualStyleBackColor = false;
            this.btnSaveBankAccount.Click += new System.EventHandler(this.btnSaveBankAccount_Click);
            // 
            // btnRemoveBankAccount
            // 
            this.btnRemoveBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnRemoveBankAccount.Location = new System.Drawing.Point(829, 251);
            this.btnRemoveBankAccount.Name = "btnRemoveBankAccount";
            this.btnRemoveBankAccount.Size = new System.Drawing.Size(125, 50);
            this.btnRemoveBankAccount.TabIndex = 60;
            this.btnRemoveBankAccount.Text = "&Remove";
            this.btnRemoveBankAccount.UseVisualStyleBackColor = false;
            this.btnRemoveBankAccount.Click += new System.EventHandler(this.btnRemoveBankAccount_Click);
            // 
            // tbxBankAccountCode
            // 
            this.tbxBankAccountCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBankAccountCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxBankAccountCode.Enabled = false;
            this.tbxBankAccountCode.Location = new System.Drawing.Point(809, 212);
            this.tbxBankAccountCode.MaxLength = 75;
            this.tbxBankAccountCode.Name = "tbxBankAccountCode";
            this.tbxBankAccountCode.Size = new System.Drawing.Size(407, 33);
            this.tbxBankAccountCode.TabIndex = 59;
            // 
            // lblbankAccountCode
            // 
            this.lblbankAccountCode.AutoSize = true;
            this.lblbankAccountCode.Location = new System.Drawing.Point(804, 184);
            this.lblbankAccountCode.Name = "lblbankAccountCode";
            this.lblbankAccountCode.Size = new System.Drawing.Size(56, 25);
            this.lblbankAccountCode.TabIndex = 58;
            this.lblbankAccountCode.Text = "Code";
            // 
            // tbxBankAccountDescription
            // 
            this.tbxBankAccountDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxBankAccountDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxBankAccountDescription.Enabled = false;
            this.tbxBankAccountDescription.Location = new System.Drawing.Point(809, 148);
            this.tbxBankAccountDescription.MaxLength = 75;
            this.tbxBankAccountDescription.Name = "tbxBankAccountDescription";
            this.tbxBankAccountDescription.Size = new System.Drawing.Size(407, 33);
            this.tbxBankAccountDescription.TabIndex = 57;
            // 
            // lblBankAccountDescription
            // 
            this.lblBankAccountDescription.AutoSize = true;
            this.lblBankAccountDescription.Location = new System.Drawing.Point(804, 120);
            this.lblBankAccountDescription.Name = "lblBankAccountDescription";
            this.lblBankAccountDescription.Size = new System.Drawing.Size(108, 25);
            this.lblBankAccountDescription.TabIndex = 56;
            this.lblBankAccountDescription.Text = "Description";
            // 
            // btnEditBankAccount
            // 
            this.btnEditBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnEditBankAccount.Location = new System.Drawing.Point(940, 3);
            this.btnEditBankAccount.Name = "btnEditBankAccount";
            this.btnEditBankAccount.Size = new System.Drawing.Size(125, 50);
            this.btnEditBankAccount.TabIndex = 55;
            this.btnEditBankAccount.Text = "&Edit";
            this.btnEditBankAccount.UseVisualStyleBackColor = false;
            this.btnEditBankAccount.Click += new System.EventHandler(this.btnEditBankAccount_Click);
            // 
            // btnNewBankAccount
            // 
            this.btnNewBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnNewBankAccount.Location = new System.Drawing.Point(809, 3);
            this.btnNewBankAccount.Name = "btnNewBankAccount";
            this.btnNewBankAccount.Size = new System.Drawing.Size(125, 50);
            this.btnNewBankAccount.TabIndex = 54;
            this.btnNewBankAccount.Text = "&New";
            this.btnNewBankAccount.UseVisualStyleBackColor = false;
            this.btnNewBankAccount.Click += new System.EventHandler(this.btnNewBankAccount_Click);
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.AllowUserToAddRows = false;
            this.dgvBankAccounts.AllowUserToDeleteRows = false;
            this.dgvBankAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBankAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvBankAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBankAccounts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBankAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBankAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBankAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBankAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvBankAccounts.ColumnHeadersHeight = 50;
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBankAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBankAccounts,
            this.colBankAccountBank,
            this.colBankAccountCode,
            this.colBankAccountChequeNumber});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBankAccounts.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvBankAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBankAccounts.EnableHeadersVisualStyles = false;
            this.dgvBankAccounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBankAccounts.Location = new System.Drawing.Point(3, 3);
            this.dgvBankAccounts.MultiSelect = false;
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersVisible = false;
            this.dgvBankAccounts.RowTemplate.Height = 30;
            this.dgvBankAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBankAccounts.Size = new System.Drawing.Size(800, 524);
            this.dgvBankAccounts.TabIndex = 53;
            this.dgvBankAccounts.SelectionChanged += new System.EventHandler(this.dgvBankAccounts_SelectionChanged);
            // 
            // colBankAccounts
            // 
            this.colBankAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBankAccounts.HeaderText = "Bank Accounts";
            this.colBankAccounts.Name = "colBankAccounts";
            this.colBankAccounts.ReadOnly = true;
            // 
            // colBankAccountBank
            // 
            this.colBankAccountBank.HeaderText = "Bank";
            this.colBankAccountBank.Name = "colBankAccountBank";
            this.colBankAccountBank.ReadOnly = true;
            this.colBankAccountBank.Width = 77;
            // 
            // colBankAccountCode
            // 
            this.colBankAccountCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBankAccountCode.HeaderText = "Code";
            this.colBankAccountCode.Name = "colBankAccountCode";
            this.colBankAccountCode.ReadOnly = true;
            this.colBankAccountCode.Width = 80;
            // 
            // colBankAccountChequeNumber
            // 
            this.colBankAccountChequeNumber.HeaderText = "Cheque No.";
            this.colBankAccountChequeNumber.Name = "colBankAccountChequeNumber";
            this.colBankAccountChequeNumber.ReadOnly = true;
            this.colBankAccountChequeNumber.Width = 135;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1208, 701);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1345, 763);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcMaintenance);
            this.Controls.Add(this.lblMaintenance);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payables | Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.tcMaintenance.ResumeLayout(false);
            this.tpGeneralSettings.ResumeLayout(false);
            this.tpGeneralSettings.PerformLayout();
            this.tpExpenses.ResumeLayout(false);
            this.tpExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.tpBanks.ResumeLayout(false);
            this.tpBanks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanks)).EndInit();
            this.tpBankAccounts.ResumeLayout(false);
            this.tpBankAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaintenance;
        private System.Windows.Forms.TabControl tcMaintenance;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.Button btnCancelExpense;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.Button btnRemoveExpense;
        private System.Windows.Forms.TextBox tbxExpenseCode;
        private System.Windows.Forms.Label lblExpenseCode;
        private System.Windows.Forms.TextBox tbxExpenseDescription;
        private System.Windows.Forms.Label lblExpenseDescription;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpenseCode;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tpBanks;
        private System.Windows.Forms.TabPage tpBankAccounts;
        private System.Windows.Forms.Button btnCancelBank;
        private System.Windows.Forms.Button btnSaveBank;
        private System.Windows.Forms.Button btnRemoveBank;
        private System.Windows.Forms.TextBox tbxBankCode;
        private System.Windows.Forms.Label lblBankCode;
        private System.Windows.Forms.TextBox tbxBankDescription;
        private System.Windows.Forms.Label lblBankDescription;
        private System.Windows.Forms.Button btnEditBank;
        private System.Windows.Forms.Button btnNewbank;
        private System.Windows.Forms.DataGridView dgvBanks;
        private System.Windows.Forms.Button btnCancelBankAccount;
        private System.Windows.Forms.Button btnSaveBankAccount;
        private System.Windows.Forms.Button btnRemoveBankAccount;
        private System.Windows.Forms.TextBox tbxBankAccountCode;
        private System.Windows.Forms.Label lblbankAccountCode;
        private System.Windows.Forms.TextBox tbxBankAccountDescription;
        private System.Windows.Forms.Label lblBankAccountDescription;
        private System.Windows.Forms.Button btnEditBankAccount;
        private System.Windows.Forms.Button btnNewBankAccount;
        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.Label lblBankAccountBank;
        private System.Windows.Forms.ComboBox cmbxBankAccountbank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankCode;
        private System.Windows.Forms.TabPage tpGeneralSettings;
        private System.Windows.Forms.Label lblRevokeMrisNumber;
        private System.Windows.Forms.TextBox tbxRevokeMrisNumber;
        private System.Windows.Forms.Button btnRevokeMrisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccountChequeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccountBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccounts;
    }
}