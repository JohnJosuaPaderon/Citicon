namespace Citicon.Payables.Reports
{
    partial class ChequeReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.colChequeSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChequeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBankAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDisbursement = new System.Windows.Forms.Label();
            this.tbxTotalDisbursement = new System.Windows.Forms.TextBox();
            this.ReportFilter = new Citicon.Payables.Reports.ChequeReportFilter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.Red;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(973, 157);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 50);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Search";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // dgvCheques
            // 
            this.dgvCheques.AllowUserToAddRows = false;
            this.dgvCheques.AllowUserToDeleteRows = false;
            this.dgvCheques.AllowUserToResizeColumns = false;
            this.dgvCheques.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCheques.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCheques.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCheques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCheques.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvCheques.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheques.ColumnHeadersHeight = 40;
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChequeSummary,
            this.colChequeNumber,
            this.colChequeDate,
            this.colTransactionDate,
            this.colSupplier,
            this.colBank,
            this.colBankAccount,
            this.colTotalAmount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheques.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCheques.EnableHeadersVisualStyles = false;
            this.dgvCheques.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCheques.Location = new System.Drawing.Point(4, 213);
            this.dgvCheques.MultiSelect = false;
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.RowHeadersVisible = false;
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.Size = new System.Drawing.Size(1069, 252);
            this.dgvCheques.TabIndex = 2;
            // 
            // colChequeSummary
            // 
            this.colChequeSummary.HeaderText = "Cheque Summary";
            this.colChequeSummary.Name = "colChequeSummary";
            this.colChequeSummary.ReadOnly = true;
            this.colChequeSummary.Visible = false;
            this.colChequeSummary.Width = 160;
            // 
            // colChequeNumber
            // 
            this.colChequeNumber.HeaderText = "Cheque No.";
            this.colChequeNumber.MinimumWidth = 100;
            this.colChequeNumber.Name = "colChequeNumber";
            this.colChequeNumber.ReadOnly = true;
            this.colChequeNumber.Width = 115;
            // 
            // colChequeDate
            // 
            dataGridViewCellStyle3.Format = "MMMM dd, yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.colChequeDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colChequeDate.HeaderText = "Cheque Date";
            this.colChequeDate.MinimumWidth = 150;
            this.colChequeDate.Name = "colChequeDate";
            this.colChequeDate.ReadOnly = true;
            this.colChequeDate.Width = 150;
            // 
            // colTransactionDate
            // 
            dataGridViewCellStyle4.Format = "MMMM dd, yyyy";
            this.colTransactionDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTransactionDate.HeaderText = "Transaction Date";
            this.colTransactionDate.MinimumWidth = 150;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.ReadOnly = true;
            this.colTransactionDate.Width = 150;
            // 
            // colSupplier
            // 
            this.colSupplier.HeaderText = "Supplier";
            this.colSupplier.MinimumWidth = 200;
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.ReadOnly = true;
            this.colSupplier.Width = 200;
            // 
            // colBank
            // 
            this.colBank.HeaderText = "Bank";
            this.colBank.MinimumWidth = 150;
            this.colBank.Name = "colBank";
            this.colBank.ReadOnly = true;
            this.colBank.Width = 150;
            // 
            // colBankAccount
            // 
            this.colBankAccount.HeaderText = "Bank Account";
            this.colBankAccount.MinimumWidth = 150;
            this.colBankAccount.Name = "colBankAccount";
            this.colBankAccount.ReadOnly = true;
            this.colBankAccount.Width = 150;
            // 
            // colTotalAmount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colTotalAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTotalAmount.HeaderText = "Total Amount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            this.colTotalAmount.Width = 126;
            // 
            // lblTotalDisbursement
            // 
            this.lblTotalDisbursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDisbursement.AutoSize = true;
            this.lblTotalDisbursement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDisbursement.Location = new System.Drawing.Point(492, 474);
            this.lblTotalDisbursement.Name = "lblTotalDisbursement";
            this.lblTotalDisbursement.Size = new System.Drawing.Size(237, 32);
            this.lblTotalDisbursement.TabIndex = 3;
            this.lblTotalDisbursement.Text = "Total Disbursement";
            // 
            // tbxTotalDisbursement
            // 
            this.tbxTotalDisbursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTotalDisbursement.BackColor = System.Drawing.Color.Black;
            this.tbxTotalDisbursement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalDisbursement.ForeColor = System.Drawing.Color.Lime;
            this.tbxTotalDisbursement.Location = new System.Drawing.Point(735, 471);
            this.tbxTotalDisbursement.Name = "tbxTotalDisbursement";
            this.tbxTotalDisbursement.Size = new System.Drawing.Size(338, 39);
            this.tbxTotalDisbursement.TabIndex = 4;
            this.tbxTotalDisbursement.Text = "0.00";
            this.tbxTotalDisbursement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReportFilter
            // 
            this.ReportFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportFilter.BackColor = System.Drawing.Color.White;
            this.ReportFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportFilter.ForeColor = System.Drawing.Color.Red;
            this.ReportFilter.HasFiltered = null;
            this.ReportFilter.Location = new System.Drawing.Point(4, 5);
            this.ReportFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportFilter.Name = "ReportFilter";
            this.ReportFilter.Size = new System.Drawing.Size(1072, 144);
            this.ReportFilter.TabIndex = 0;
            // 
            // ChequeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbxTotalDisbursement);
            this.Controls.Add(this.lblTotalDisbursement);
            this.Controls.Add(this.dgvCheques);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.ReportFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChequeReports";
            this.Size = new System.Drawing.Size(1080, 513);
            this.Load += new System.EventHandler(this.ChequeReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChequeReportFilter ReportFilter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.Label lblTotalDisbursement;
        private System.Windows.Forms.TextBox tbxTotalDisbursement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChequeSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChequeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBankAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
    }
}
