namespace Citicon.Forms
{
    partial class ClientAdvancePaymentManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAdvancePaymentManagementForm));
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClientDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientAdvancePaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddAdvancePaymentButton = new System.Windows.Forms.Button();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_CreditColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdvancePaymentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdvancePayment_TransactionDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdvancePayment_AddedValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdvancePayment_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.ClientDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientAdvancePaymentsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.ClientsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Client_CreditColumn,
            this.Client_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClientsDataGridView.EnableHeadersVisualStyles = false;
            this.ClientsDataGridView.GridColor = System.Drawing.Color.Red;
            this.ClientsDataGridView.Location = new System.Drawing.Point(12, 60);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.ReadOnly = true;
            this.ClientsDataGridView.RowHeadersVisible = false;
            this.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView.Size = new System.Drawing.Size(642, 712);
            this.ClientsDataGridView.TabIndex = 8;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.SearchLabel.TabIndex = 9;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 29);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(536, 25);
            this.SearchTextBox.TabIndex = 10;
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
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClientDetailsGroupBox
            // 
            this.ClientDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientDetailsGroupBox.Controls.Add(this.AddressTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.AddressLabel);
            this.ClientDetailsGroupBox.Controls.Add(this.CompanyNameTextBox);
            this.ClientDetailsGroupBox.Controls.Add(this.ClientNameLabel);
            this.ClientDetailsGroupBox.Location = new System.Drawing.Point(660, 60);
            this.ClientDetailsGroupBox.Name = "ClientDetailsGroupBox";
            this.ClientDetailsGroupBox.Size = new System.Drawing.Size(542, 156);
            this.ClientDetailsGroupBox.TabIndex = 12;
            this.ClientDetailsGroupBox.TabStop = false;
            this.ClientDetailsGroupBox.Text = "Client Details";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(10, 95);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(526, 25);
            this.AddressTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(7, 74);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(56, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(10, 46);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(526, 25);
            this.CompanyNameTextBox.TabIndex = 1;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(7, 25);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(102, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Company Name";
            // 
            // ClientAdvancePaymentsDataGridView
            // 
            this.ClientAdvancePaymentsDataGridView.AllowUserToAddRows = false;
            this.ClientAdvancePaymentsDataGridView.AllowUserToDeleteRows = false;
            this.ClientAdvancePaymentsDataGridView.AllowUserToResizeColumns = false;
            this.ClientAdvancePaymentsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientAdvancePaymentsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientAdvancePaymentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAdvancePaymentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientAdvancePaymentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientAdvancePaymentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClientAdvancePaymentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientAdvancePaymentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientAdvancePaymentsDataGridView.ColumnHeadersHeight = 50;
            this.ClientAdvancePaymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientAdvancePaymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientAdvancePaymentColumn,
            this.ClientAdvancePayment_TransactionDateColumn,
            this.ClientAdvancePayment_AddedValueColumn,
            this.ClientAdvancePayment_ExtraColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientAdvancePaymentsDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ClientAdvancePaymentsDataGridView.EnableHeadersVisualStyles = false;
            this.ClientAdvancePaymentsDataGridView.GridColor = System.Drawing.Color.Red;
            this.ClientAdvancePaymentsDataGridView.Location = new System.Drawing.Point(660, 222);
            this.ClientAdvancePaymentsDataGridView.Name = "ClientAdvancePaymentsDataGridView";
            this.ClientAdvancePaymentsDataGridView.ReadOnly = true;
            this.ClientAdvancePaymentsDataGridView.RowHeadersVisible = false;
            this.ClientAdvancePaymentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientAdvancePaymentsDataGridView.Size = new System.Drawing.Size(542, 504);
            this.ClientAdvancePaymentsDataGridView.TabIndex = 13;
            // 
            // AddAdvancePaymentButton
            // 
            this.AddAdvancePaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAdvancePaymentButton.BackColor = System.Drawing.Color.Red;
            this.AddAdvancePaymentButton.FlatAppearance.BorderSize = 0;
            this.AddAdvancePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAdvancePaymentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdvancePaymentButton.ForeColor = System.Drawing.Color.White;
            this.AddAdvancePaymentButton.Location = new System.Drawing.Point(1102, 732);
            this.AddAdvancePaymentButton.Name = "AddAdvancePaymentButton";
            this.AddAdvancePaymentButton.Size = new System.Drawing.Size(100, 40);
            this.AddAdvancePaymentButton.TabIndex = 14;
            this.AddAdvancePaymentButton.Text = "Add";
            this.AddAdvancePaymentButton.UseVisualStyleBackColor = false;
            this.AddAdvancePaymentButton.Click += new System.EventHandler(this.AddAdvancePaymentButton_Click);
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClientColumn.HeaderText = "Clients";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Width = 70;
            // 
            // Client_CreditColumn
            // 
            this.Client_CreditColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "##,##0.00";
            this.Client_CreditColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Client_CreditColumn.HeaderText = "Credits";
            this.Client_CreditColumn.Name = "Client_CreditColumn";
            this.Client_CreditColumn.ReadOnly = true;
            this.Client_CreditColumn.Width = 73;
            // 
            // Client_ExtraColumn
            // 
            this.Client_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client_ExtraColumn.HeaderText = "";
            this.Client_ExtraColumn.Name = "Client_ExtraColumn";
            this.Client_ExtraColumn.ReadOnly = true;
            // 
            // ClientAdvancePaymentColumn
            // 
            this.ClientAdvancePaymentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClientAdvancePaymentColumn.HeaderText = "Advance Payments";
            this.ClientAdvancePaymentColumn.Name = "ClientAdvancePaymentColumn";
            this.ClientAdvancePaymentColumn.ReadOnly = true;
            this.ClientAdvancePaymentColumn.Visible = false;
            this.ClientAdvancePaymentColumn.Width = 128;
            // 
            // ClientAdvancePayment_TransactionDateColumn
            // 
            this.ClientAdvancePayment_TransactionDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "MMM dd, yyyy hh:mm tt";
            this.ClientAdvancePayment_TransactionDateColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.ClientAdvancePayment_TransactionDateColumn.HeaderText = "Transaction Date";
            this.ClientAdvancePayment_TransactionDateColumn.Name = "ClientAdvancePayment_TransactionDateColumn";
            this.ClientAdvancePayment_TransactionDateColumn.ReadOnly = true;
            this.ClientAdvancePayment_TransactionDateColumn.Width = 118;
            // 
            // ClientAdvancePayment_AddedValueColumn
            // 
            this.ClientAdvancePayment_AddedValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Format = "#,##0.00";
            this.ClientAdvancePayment_AddedValueColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.ClientAdvancePayment_AddedValueColumn.HeaderText = "Added Value";
            this.ClientAdvancePayment_AddedValueColumn.Name = "ClientAdvancePayment_AddedValueColumn";
            this.ClientAdvancePayment_AddedValueColumn.ReadOnly = true;
            this.ClientAdvancePayment_AddedValueColumn.Width = 97;
            // 
            // ClientAdvancePayment_ExtraColumn
            // 
            this.ClientAdvancePayment_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientAdvancePayment_ExtraColumn.HeaderText = "";
            this.ClientAdvancePayment_ExtraColumn.Name = "ClientAdvancePayment_ExtraColumn";
            this.ClientAdvancePayment_ExtraColumn.ReadOnly = true;
            // 
            // ClientAdvancePaymentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 784);
            this.Controls.Add(this.AddAdvancePaymentButton);
            this.Controls.Add(this.ClientAdvancePaymentsDataGridView);
            this.Controls.Add(this.ClientDetailsGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ClientsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClientAdvancePaymentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Payments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientAdvancePaymentManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ClientDetailsGroupBox.ResumeLayout(false);
            this.ClientDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientAdvancePaymentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.Label SearchLabel;
        public System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox ClientDetailsGroupBox;
        private System.Windows.Forms.Label ClientNameLabel;
        public System.Windows.Forms.TextBox CompanyNameTextBox;
        public System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        public System.Windows.Forms.DataGridView ClientAdvancePaymentsDataGridView;
        private System.Windows.Forms.Button AddAdvancePaymentButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_CreditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ExtraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdvancePaymentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdvancePayment_TransactionDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdvancePayment_AddedValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdvancePayment_ExtraColumn;
    }
}