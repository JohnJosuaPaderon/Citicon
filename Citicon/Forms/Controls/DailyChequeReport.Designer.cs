namespace Citicon.Forms.Controls
{
    partial class DailyChequeReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ChequeDataGridView = new System.Windows.Forms.DataGridView();
            this.ChequeSummaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeSummary_SupplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeSummary_CompanyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeSummary_AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeSummary_ChequeDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeSummary_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ChequeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Location = new System.Drawing.Point(3, 0);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(105, 17);
            this.TransactionDateLabel.TabIndex = 0;
            this.TransactionDateLabel.Text = "Transaction Date";
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.TransactionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(6, 20);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(282, 25);
            this.TransactionDateTimePicker.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Red;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(295, 10);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 35);
            this.LoadButton.TabIndex = 114;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ChequeDataGridView
            // 
            this.ChequeDataGridView.AllowUserToAddRows = false;
            this.ChequeDataGridView.AllowUserToDeleteRows = false;
            this.ChequeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChequeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ChequeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChequeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ChequeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ChequeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChequeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ChequeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChequeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ChequeDataGridView.ColumnHeadersHeight = 60;
            this.ChequeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ChequeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChequeSummaryColumn,
            this.ChequeSummary_SupplierColumn,
            this.ChequeSummary_CompanyColumn,
            this.ChequeSummary_AmountColumn,
            this.ChequeSummary_ChequeDateColumn,
            this.ChequeSummary_ExtraColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ChequeDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.ChequeDataGridView.EnableHeadersVisualStyles = false;
            this.ChequeDataGridView.GridColor = System.Drawing.Color.Red;
            this.ChequeDataGridView.Location = new System.Drawing.Point(6, 51);
            this.ChequeDataGridView.MultiSelect = false;
            this.ChequeDataGridView.Name = "ChequeDataGridView";
            this.ChequeDataGridView.ReadOnly = true;
            this.ChequeDataGridView.RowHeadersVisible = false;
            this.ChequeDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.ChequeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ChequeDataGridView.RowTemplate.Height = 40;
            this.ChequeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChequeDataGridView.Size = new System.Drawing.Size(689, 527);
            this.ChequeDataGridView.TabIndex = 115;
            // 
            // ChequeSummaryColumn
            // 
            this.ChequeSummaryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChequeSummaryColumn.HeaderText = "CHEQUES";
            this.ChequeSummaryColumn.MinimumWidth = 100;
            this.ChequeSummaryColumn.Name = "ChequeSummaryColumn";
            this.ChequeSummaryColumn.ReadOnly = true;
            // 
            // ChequeSummary_SupplierColumn
            // 
            this.ChequeSummary_SupplierColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChequeSummary_SupplierColumn.HeaderText = "PAYEE";
            this.ChequeSummary_SupplierColumn.Name = "ChequeSummary_SupplierColumn";
            this.ChequeSummary_SupplierColumn.ReadOnly = true;
            this.ChequeSummary_SupplierColumn.Width = 66;
            // 
            // ChequeSummary_CompanyColumn
            // 
            this.ChequeSummary_CompanyColumn.HeaderText = "COMPANY";
            this.ChequeSummary_CompanyColumn.Name = "ChequeSummary_CompanyColumn";
            this.ChequeSummary_CompanyColumn.ReadOnly = true;
            this.ChequeSummary_CompanyColumn.Width = 93;
            // 
            // ChequeSummary_AmountColumn
            // 
            this.ChequeSummary_AmountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.ChequeSummary_AmountColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ChequeSummary_AmountColumn.HeaderText = "AMOUNT";
            this.ChequeSummary_AmountColumn.Name = "ChequeSummary_AmountColumn";
            this.ChequeSummary_AmountColumn.ReadOnly = true;
            this.ChequeSummary_AmountColumn.Width = 88;
            // 
            // ChequeSummary_ChequeDateColumn
            // 
            this.ChequeSummary_ChequeDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "MMMM dd, yyyy";
            this.ChequeSummary_ChequeDateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.ChequeSummary_ChequeDateColumn.HeaderText = "CHEQUE DATE";
            this.ChequeSummary_ChequeDateColumn.Name = "ChequeSummary_ChequeDateColumn";
            this.ChequeSummary_ChequeDateColumn.ReadOnly = true;
            this.ChequeSummary_ChequeDateColumn.Width = 106;
            // 
            // ChequeSummary_ExtraColumn
            // 
            this.ChequeSummary_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChequeSummary_ExtraColumn.HeaderText = "";
            this.ChequeSummary_ExtraColumn.Name = "ChequeSummary_ExtraColumn";
            this.ChequeSummary_ExtraColumn.ReadOnly = true;
            // 
            // DailyChequeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChequeDataGridView);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.TransactionDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DailyChequeReport";
            this.Size = new System.Drawing.Size(698, 581);
            ((System.ComponentModel.ISupportInitialize)(this.ChequeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.DataGridView ChequeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummary_SupplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummary_CompanyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummary_AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummary_ChequeDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeSummary_ExtraColumn;
    }
}
