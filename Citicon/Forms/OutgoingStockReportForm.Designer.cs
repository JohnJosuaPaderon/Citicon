namespace Citicon.Forms
{
    partial class OutgoingStockReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingStockReportForm));
            this.SearchFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.VehicleFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.VehicleFilterComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.CompanyFilterComboBox = new System.Windows.Forms.ComboBox();
            this.BranchFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.BranchFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StockDataGridView = new System.Windows.Forms.DataGridView();
            this.ExportButton = new System.Windows.Forms.Button();
            this.SearchFilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchFilterGroupBox
            // 
            this.SearchFilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFilterGroupBox.Controls.Add(this.dateTimePicker2);
            this.SearchFilterGroupBox.Controls.Add(this.label1);
            this.SearchFilterGroupBox.Controls.Add(this.dateTimePicker1);
            this.SearchFilterGroupBox.Controls.Add(this.TransactionDateFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.VehicleFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.VehicleFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.CompanyFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.CompanyFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.BranchFilterCheckBox);
            this.SearchFilterGroupBox.Controls.Add(this.BranchFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.DescriptionFilterComboBox);
            this.SearchFilterGroupBox.Controls.Add(this.DescriptionFilterCheckBox);
            this.SearchFilterGroupBox.Location = new System.Drawing.Point(13, 13);
            this.SearchFilterGroupBox.Name = "SearchFilterGroupBox";
            this.SearchFilterGroupBox.Size = new System.Drawing.Size(970, 123);
            this.SearchFilterGroupBox.TabIndex = 0;
            this.SearchFilterGroupBox.TabStop = false;
            this.SearchFilterGroupBox.Text = "Search Filter";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(717, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 25);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "to";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // TransactionDateFilterCheckBox
            // 
            this.TransactionDateFilterCheckBox.AutoSize = true;
            this.TransactionDateFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TransactionDateFilterCheckBox.Location = new System.Drawing.Point(422, 57);
            this.TransactionDateFilterCheckBox.Name = "TransactionDateFilterCheckBox";
            this.TransactionDateFilterCheckBox.Size = new System.Drawing.Size(124, 21);
            this.TransactionDateFilterCheckBox.TabIndex = 10;
            this.TransactionDateFilterCheckBox.Text = "Transaction Date";
            this.TransactionDateFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // VehicleFilterCheckBox
            // 
            this.VehicleFilterCheckBox.AutoSize = true;
            this.VehicleFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VehicleFilterCheckBox.Location = new System.Drawing.Point(479, 26);
            this.VehicleFilterCheckBox.Name = "VehicleFilterCheckBox";
            this.VehicleFilterCheckBox.Size = new System.Drawing.Size(67, 21);
            this.VehicleFilterCheckBox.TabIndex = 9;
            this.VehicleFilterCheckBox.Text = "Vehicle";
            this.VehicleFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // VehicleFilterComboBox
            // 
            this.VehicleFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleFilterComboBox.Enabled = false;
            this.VehicleFilterComboBox.FormattingEnabled = true;
            this.VehicleFilterComboBox.Location = new System.Drawing.Point(552, 24);
            this.VehicleFilterComboBox.Name = "VehicleFilterComboBox";
            this.VehicleFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.VehicleFilterComboBox.TabIndex = 8;
            // 
            // CompanyFilterCheckBox
            // 
            this.CompanyFilterCheckBox.AutoSize = true;
            this.CompanyFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CompanyFilterCheckBox.Location = new System.Drawing.Point(17, 88);
            this.CompanyFilterCheckBox.Name = "CompanyFilterCheckBox";
            this.CompanyFilterCheckBox.Size = new System.Drawing.Size(82, 21);
            this.CompanyFilterCheckBox.TabIndex = 7;
            this.CompanyFilterCheckBox.Text = "Company";
            this.CompanyFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // CompanyFilterComboBox
            // 
            this.CompanyFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyFilterComboBox.Enabled = false;
            this.CompanyFilterComboBox.FormattingEnabled = true;
            this.CompanyFilterComboBox.Location = new System.Drawing.Point(105, 86);
            this.CompanyFilterComboBox.Name = "CompanyFilterComboBox";
            this.CompanyFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.CompanyFilterComboBox.TabIndex = 6;
            // 
            // BranchFilterCheckBox
            // 
            this.BranchFilterCheckBox.AutoSize = true;
            this.BranchFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BranchFilterCheckBox.Location = new System.Drawing.Point(33, 57);
            this.BranchFilterCheckBox.Name = "BranchFilterCheckBox";
            this.BranchFilterCheckBox.Size = new System.Drawing.Size(66, 21);
            this.BranchFilterCheckBox.TabIndex = 5;
            this.BranchFilterCheckBox.Text = "Branch";
            this.BranchFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // BranchFilterComboBox
            // 
            this.BranchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchFilterComboBox.Enabled = false;
            this.BranchFilterComboBox.FormattingEnabled = true;
            this.BranchFilterComboBox.Location = new System.Drawing.Point(105, 55);
            this.BranchFilterComboBox.Name = "BranchFilterComboBox";
            this.BranchFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.BranchFilterComboBox.TabIndex = 4;
            // 
            // DescriptionFilterComboBox
            // 
            this.DescriptionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DescriptionFilterComboBox.Enabled = false;
            this.DescriptionFilterComboBox.FormattingEnabled = true;
            this.DescriptionFilterComboBox.Location = new System.Drawing.Point(105, 24);
            this.DescriptionFilterComboBox.Name = "DescriptionFilterComboBox";
            this.DescriptionFilterComboBox.Size = new System.Drawing.Size(295, 25);
            this.DescriptionFilterComboBox.TabIndex = 3;
            // 
            // DescriptionFilterCheckBox
            // 
            this.DescriptionFilterCheckBox.AutoSize = true;
            this.DescriptionFilterCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DescriptionFilterCheckBox.Location = new System.Drawing.Point(6, 26);
            this.DescriptionFilterCheckBox.Name = "DescriptionFilterCheckBox";
            this.DescriptionFilterCheckBox.Size = new System.Drawing.Size(93, 21);
            this.DescriptionFilterCheckBox.TabIndex = 1;
            this.DescriptionFilterCheckBox.Text = "Description";
            this.DescriptionFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(868, 142);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 40);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // StockDataGridView
            // 
            this.StockDataGridView.AllowUserToAddRows = false;
            this.StockDataGridView.AllowUserToDeleteRows = false;
            this.StockDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StockDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StockDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.StockDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.StockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.StockDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StockDataGridView.ColumnHeadersHeight = 50;
            this.StockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StockDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StockDataGridView.EnableHeadersVisualStyles = false;
            this.StockDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.StockDataGridView.Location = new System.Drawing.Point(13, 187);
            this.StockDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StockDataGridView.MultiSelect = false;
            this.StockDataGridView.Name = "StockDataGridView";
            this.StockDataGridView.ReadOnly = true;
            this.StockDataGridView.RowHeadersVisible = false;
            this.StockDataGridView.RowTemplate.Height = 30;
            this.StockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StockDataGridView.Size = new System.Drawing.Size(970, 515);
            this.StockDataGridView.TabIndex = 103;
            // 
            // ExportButton
            // 
            this.ExportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportButton.BackColor = System.Drawing.Color.Red;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(868, 707);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(115, 40);
            this.ExportButton.TabIndex = 104;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // OutgoingStockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 759);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.StockDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchFilterGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutgoingStockReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outgoing Stocks Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SearchFilterGroupBox.ResumeLayout(false);
            this.SearchFilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchFilterGroupBox;
        private System.Windows.Forms.CheckBox DescriptionFilterCheckBox;
        private System.Windows.Forms.ComboBox DescriptionFilterComboBox;
        private System.Windows.Forms.CheckBox BranchFilterCheckBox;
        private System.Windows.Forms.ComboBox BranchFilterComboBox;
        private System.Windows.Forms.CheckBox CompanyFilterCheckBox;
        private System.Windows.Forms.ComboBox CompanyFilterComboBox;
        private System.Windows.Forms.CheckBox VehicleFilterCheckBox;
        private System.Windows.Forms.ComboBox VehicleFilterComboBox;
        private System.Windows.Forms.CheckBox TransactionDateFilterCheckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView StockDataGridView;
        private System.Windows.Forms.Button ExportButton;
    }
}