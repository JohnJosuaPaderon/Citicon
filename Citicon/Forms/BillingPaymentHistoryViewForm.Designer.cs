namespace Citicon.Forms
{
    partial class BillingPaymentHistoryViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPaymentHistoryViewForm));
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingsDataGridView = new System.Windows.Forms.DataGridView();
            this.BillingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_SiNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_AmountDueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_AmountPaidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.BillingPaymentHistoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_PaymentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_AmountPaidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_OrNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_AckNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_CrNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_PrNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_BankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_ChequeNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_ChequeDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingPaymentHistory_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingPaymentHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(554, 14);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 40);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 29);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(536, 25);
            this.SearchTextBox.TabIndex = 14;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.SearchLabel.TabIndex = 13;
            this.SearchLabel.Text = "Search";
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.AllowUserToAddRows = false;
            this.ClientsDataGridView.AllowUserToDeleteRows = false;
            this.ClientsDataGridView.AllowUserToResizeColumns = false;
            this.ClientsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClientsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClientsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientsDataGridView.ColumnHeadersHeight = 50;
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientColumn,
            this.Client_ExtraColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientsDataGridView.EnableHeadersVisualStyles = false;
            this.ClientsDataGridView.GridColor = System.Drawing.Color.Red;
            this.ClientsDataGridView.Location = new System.Drawing.Point(12, 60);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(642, 312);
            this.ClientsDataGridView.TabIndex = 12;
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClientColumn.HeaderText = "Clients";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Width = 70;
            // 
            // Client_ExtraColumn
            // 
            this.Client_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client_ExtraColumn.HeaderText = "";
            this.Client_ExtraColumn.Name = "Client_ExtraColumn";
            this.Client_ExtraColumn.ReadOnly = true;
            // 
            // BillingsDataGridView
            // 
            this.BillingsDataGridView.AllowUserToAddRows = false;
            this.BillingsDataGridView.AllowUserToDeleteRows = false;
            this.BillingsDataGridView.AllowUserToResizeColumns = false;
            this.BillingsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BillingsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BillingsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BillingsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillingsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillingsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.BillingsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BillingsDataGridView.ColumnHeadersHeight = 50;
            this.BillingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingColumn,
            this.Billing_SiNumberColumn,
            this.Billing_AmountDueColumn,
            this.Billing_AmountPaidColumn,
            this.Billing_ExtraColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillingsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.BillingsDataGridView.EnableHeadersVisualStyles = false;
            this.BillingsDataGridView.GridColor = System.Drawing.Color.Red;
            this.BillingsDataGridView.Location = new System.Drawing.Point(12, 378);
            this.BillingsDataGridView.Name = "BillingsDataGridView";
            this.BillingsDataGridView.ReadOnly = true;
            this.BillingsDataGridView.RowHeadersVisible = false;
            this.BillingsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillingsDataGridView.Size = new System.Drawing.Size(642, 354);
            this.BillingsDataGridView.TabIndex = 16;
            // 
            // BillingColumn
            // 
            this.BillingColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingColumn.HeaderText = "Billings";
            this.BillingColumn.Name = "BillingColumn";
            this.BillingColumn.ReadOnly = true;
            this.BillingColumn.Width = 72;
            // 
            // Billing_SiNumberColumn
            // 
            this.Billing_SiNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Billing_SiNumberColumn.HeaderText = "S.I. No.";
            this.Billing_SiNumberColumn.Name = "Billing_SiNumberColumn";
            this.Billing_SiNumberColumn.ReadOnly = true;
            this.Billing_SiNumberColumn.Width = 68;
            // 
            // Billing_AmountDueColumn
            // 
            this.Billing_AmountDueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "#,##0.00";
            this.Billing_AmountDueColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.Billing_AmountDueColumn.HeaderText = "Amount Due";
            this.Billing_AmountDueColumn.Name = "Billing_AmountDueColumn";
            this.Billing_AmountDueColumn.ReadOnly = true;
            this.Billing_AmountDueColumn.Width = 95;
            // 
            // Billing_AmountPaidColumn
            // 
            this.Billing_AmountPaidColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "#,##0.00";
            this.Billing_AmountPaidColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.Billing_AmountPaidColumn.HeaderText = "Amount Paid";
            this.Billing_AmountPaidColumn.Name = "Billing_AmountPaidColumn";
            this.Billing_AmountPaidColumn.ReadOnly = true;
            this.Billing_AmountPaidColumn.Width = 97;
            // 
            // Billing_ExtraColumn
            // 
            this.Billing_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Billing_ExtraColumn.HeaderText = "";
            this.Billing_ExtraColumn.Name = "Billing_ExtraColumn";
            this.Billing_ExtraColumn.ReadOnly = true;
            // 
            // BillingPaymentHistoryDataGridView
            // 
            this.BillingPaymentHistoryDataGridView.AllowUserToAddRows = false;
            this.BillingPaymentHistoryDataGridView.AllowUserToDeleteRows = false;
            this.BillingPaymentHistoryDataGridView.AllowUserToResizeColumns = false;
            this.BillingPaymentHistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BillingPaymentHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.BillingPaymentHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillingPaymentHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillingPaymentHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BillingPaymentHistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.BillingPaymentHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingPaymentHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.BillingPaymentHistoryDataGridView.ColumnHeadersHeight = 50;
            this.BillingPaymentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillingPaymentHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillingPaymentHistoryColumn,
            this.BillingPaymentHistory_PaymentDateColumn,
            this.BillingPaymentHistory_AmountPaidColumn,
            this.BillingPaymentHistory_OrNumberColumn,
            this.BillingPaymentHistory_AckNumberColumn,
            this.BillingPaymentHistory_CrNumberColumn,
            this.BillingPaymentHistory_PrNumberColumn,
            this.BillingPaymentHistory_BankColumn,
            this.BillingPaymentHistory_ChequeNumberColumn,
            this.BillingPaymentHistory_ChequeDateColumn,
            this.BillingPaymentHistory_ExtraColumn});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillingPaymentHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.BillingPaymentHistoryDataGridView.EnableHeadersVisualStyles = false;
            this.BillingPaymentHistoryDataGridView.GridColor = System.Drawing.Color.Red;
            this.BillingPaymentHistoryDataGridView.Location = new System.Drawing.Point(660, 60);
            this.BillingPaymentHistoryDataGridView.Name = "BillingPaymentHistoryDataGridView";
            this.BillingPaymentHistoryDataGridView.ReadOnly = true;
            this.BillingPaymentHistoryDataGridView.RowHeadersVisible = false;
            this.BillingPaymentHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillingPaymentHistoryDataGridView.Size = new System.Drawing.Size(533, 672);
            this.BillingPaymentHistoryDataGridView.TabIndex = 17;
            // 
            // BillingPaymentHistoryColumn
            // 
            this.BillingPaymentHistoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistoryColumn.HeaderText = "History";
            this.BillingPaymentHistoryColumn.Name = "BillingPaymentHistoryColumn";
            this.BillingPaymentHistoryColumn.ReadOnly = true;
            this.BillingPaymentHistoryColumn.Visible = false;
            this.BillingPaymentHistoryColumn.Width = 73;
            // 
            // BillingPaymentHistory_PaymentDateColumn
            // 
            this.BillingPaymentHistory_PaymentDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Format = "MMMM dd, yyyy";
            this.BillingPaymentHistory_PaymentDateColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.BillingPaymentHistory_PaymentDateColumn.HeaderText = "Payment Date";
            this.BillingPaymentHistory_PaymentDateColumn.Name = "BillingPaymentHistory_PaymentDateColumn";
            this.BillingPaymentHistory_PaymentDateColumn.ReadOnly = true;
            this.BillingPaymentHistory_PaymentDateColumn.Width = 103;
            // 
            // BillingPaymentHistory_AmountPaidColumn
            // 
            this.BillingPaymentHistory_AmountPaidColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "#,##0.00";
            this.BillingPaymentHistory_AmountPaidColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillingPaymentHistory_AmountPaidColumn.HeaderText = "Amount";
            this.BillingPaymentHistory_AmountPaidColumn.Name = "BillingPaymentHistory_AmountPaidColumn";
            this.BillingPaymentHistory_AmountPaidColumn.ReadOnly = true;
            this.BillingPaymentHistory_AmountPaidColumn.Width = 77;
            // 
            // BillingPaymentHistory_OrNumberColumn
            // 
            this.BillingPaymentHistory_OrNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_OrNumberColumn.HeaderText = "O.R. No.";
            this.BillingPaymentHistory_OrNumberColumn.Name = "BillingPaymentHistory_OrNumberColumn";
            this.BillingPaymentHistory_OrNumberColumn.ReadOnly = true;
            this.BillingPaymentHistory_OrNumberColumn.Width = 56;
            // 
            // BillingPaymentHistory_AckNumberColumn
            // 
            this.BillingPaymentHistory_AckNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_AckNumberColumn.HeaderText = "A.C.K. No.";
            this.BillingPaymentHistory_AckNumberColumn.Name = "BillingPaymentHistory_AckNumberColumn";
            this.BillingPaymentHistory_AckNumberColumn.ReadOnly = true;
            this.BillingPaymentHistory_AckNumberColumn.Width = 83;
            // 
            // BillingPaymentHistory_CrNumberColumn
            // 
            this.BillingPaymentHistory_CrNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_CrNumberColumn.HeaderText = "C.R. No.";
            this.BillingPaymentHistory_CrNumberColumn.Name = "BillingPaymentHistory_CrNumberColumn";
            this.BillingPaymentHistory_CrNumberColumn.ReadOnly = true;
            this.BillingPaymentHistory_CrNumberColumn.Width = 54;
            // 
            // BillingPaymentHistory_PrNumberColumn
            // 
            this.BillingPaymentHistory_PrNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_PrNumberColumn.HeaderText = "P.R. No.";
            this.BillingPaymentHistory_PrNumberColumn.Name = "BillingPaymentHistory_PrNumberColumn";
            this.BillingPaymentHistory_PrNumberColumn.ReadOnly = true;
            this.BillingPaymentHistory_PrNumberColumn.Width = 53;
            // 
            // BillingPaymentHistory_BankColumn
            // 
            this.BillingPaymentHistory_BankColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_BankColumn.HeaderText = "Bank";
            this.BillingPaymentHistory_BankColumn.Name = "BillingPaymentHistory_BankColumn";
            this.BillingPaymentHistory_BankColumn.ReadOnly = true;
            this.BillingPaymentHistory_BankColumn.Width = 59;
            // 
            // BillingPaymentHistory_ChequeNumberColumn
            // 
            this.BillingPaymentHistory_ChequeNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillingPaymentHistory_ChequeNumberColumn.HeaderText = "Cheque No.";
            this.BillingPaymentHistory_ChequeNumberColumn.Name = "BillingPaymentHistory_ChequeNumberColumn";
            this.BillingPaymentHistory_ChequeNumberColumn.ReadOnly = true;
            this.BillingPaymentHistory_ChequeNumberColumn.Width = 93;
            // 
            // BillingPaymentHistory_ChequeDateColumn
            // 
            this.BillingPaymentHistory_ChequeDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Format = "MMMM dd, yyyy";
            this.BillingPaymentHistory_ChequeDateColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.BillingPaymentHistory_ChequeDateColumn.HeaderText = "Cheque Date";
            this.BillingPaymentHistory_ChequeDateColumn.Name = "BillingPaymentHistory_ChequeDateColumn";
            this.BillingPaymentHistory_ChequeDateColumn.ReadOnly = true;
            this.BillingPaymentHistory_ChequeDateColumn.Width = 98;
            // 
            // BillingPaymentHistory_ExtraColumn
            // 
            this.BillingPaymentHistory_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BillingPaymentHistory_ExtraColumn.HeaderText = "";
            this.BillingPaymentHistory_ExtraColumn.Name = "BillingPaymentHistory_ExtraColumn";
            this.BillingPaymentHistory_ExtraColumn.ReadOnly = true;
            // 
            // BillingPaymentHistoryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 744);
            this.Controls.Add(this.BillingPaymentHistoryDataGridView);
            this.Controls.Add(this.BillingsDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ClientsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BillingPaymentHistoryViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillingPaymentHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        public System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ExtraColumn;
        public System.Windows.Forms.DataGridView BillingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_SiNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_AmountDueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_AmountPaidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_ExtraColumn;
        public System.Windows.Forms.DataGridView BillingPaymentHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_PaymentDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_AmountPaidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_OrNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_AckNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_CrNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_PrNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_BankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_ChequeNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_ChequeDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingPaymentHistory_ExtraColumn;
    }
}