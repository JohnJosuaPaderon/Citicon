namespace Citicon.Payables.Reports
{
    partial class ChequeVoucherDetailsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPayables = new System.Windows.Forms.DataGridView();
            this.colPayable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayable_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayable_Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayble_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayable_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayables)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 7);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(152, 21);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Cheque Voucher No.";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(10, 32);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(271, 29);
            this.tbxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(289, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPayables
            // 
            this.dgvPayables.AllowUserToAddRows = false;
            this.dgvPayables.AllowUserToDeleteRows = false;
            this.dgvPayables.AllowUserToResizeColumns = false;
            this.dgvPayables.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPayables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPayables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPayables.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPayables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPayables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayables.ColumnHeadersHeight = 40;
            this.dgvPayables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPayable,
            this.colPayable_Description,
            this.colPayable_Branch,
            this.colPayble_Company,
            this.colPayable_Value});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayables.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPayables.EnableHeadersVisualStyles = false;
            this.dgvPayables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPayables.Location = new System.Drawing.Point(10, 68);
            this.dgvPayables.MultiSelect = false;
            this.dgvPayables.Name = "dgvPayables";
            this.dgvPayables.ReadOnly = true;
            this.dgvPayables.RowHeadersVisible = false;
            this.dgvPayables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayables.Size = new System.Drawing.Size(861, 566);
            this.dgvPayables.TabIndex = 3;
            // 
            // colPayable
            // 
            this.colPayable.HeaderText = "Payable";
            this.colPayable.Name = "colPayable";
            this.colPayable.ReadOnly = true;
            this.colPayable.Visible = false;
            this.colPayable.Width = 87;
            // 
            // colPayable_Description
            // 
            this.colPayable_Description.HeaderText = "Description";
            this.colPayable_Description.MinimumWidth = 150;
            this.colPayable_Description.Name = "colPayable_Description";
            this.colPayable_Description.ReadOnly = true;
            this.colPayable_Description.Width = 150;
            // 
            // colPayable_Branch
            // 
            this.colPayable_Branch.HeaderText = "Branch";
            this.colPayable_Branch.MinimumWidth = 150;
            this.colPayable_Branch.Name = "colPayable_Branch";
            this.colPayable_Branch.ReadOnly = true;
            this.colPayable_Branch.Width = 150;
            // 
            // colPayble_Company
            // 
            this.colPayble_Company.HeaderText = "Company";
            this.colPayble_Company.MinimumWidth = 150;
            this.colPayble_Company.Name = "colPayble_Company";
            this.colPayble_Company.ReadOnly = true;
            this.colPayble_Company.Width = 150;
            // 
            // colPayable_Value
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.colPayable_Value.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPayable_Value.HeaderText = "Value";
            this.colPayable_Value.MinimumWidth = 150;
            this.colPayable_Value.Name = "colPayable_Value";
            this.colPayable_Value.ReadOnly = true;
            this.colPayable_Value.Width = 150;
            // 
            // ChequeVoucherDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvPayables);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChequeVoucherDetailsView";
            this.Size = new System.Drawing.Size(883, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPayables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayable_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayable_Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayble_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayable_Value;
    }
}
