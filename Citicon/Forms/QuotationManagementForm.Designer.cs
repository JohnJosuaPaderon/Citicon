namespace Citicon.Forms
{
    partial class QuotationManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationManagementForm));
            this.ProjectTextBox = new System.Windows.Forms.TextBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.QuotationDataGridView = new System.Windows.Forms.DataGridView();
            this.QuotationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuotationView = new Citicon.Forms.Controls.QuotationViewControl();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.ReviseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuotationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectTextBox
            // 
            this.ProjectTextBox.BackColor = System.Drawing.Color.White;
            this.ProjectTextBox.Location = new System.Drawing.Point(66, 43);
            this.ProjectTextBox.Name = "ProjectTextBox";
            this.ProjectTextBox.ReadOnly = true;
            this.ProjectTextBox.Size = new System.Drawing.Size(695, 25);
            this.ProjectTextBox.TabIndex = 114;
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(12, 46);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(48, 17);
            this.ProjectLabel.TabIndex = 113;
            this.ProjectLabel.Text = "Project";
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.BackColor = System.Drawing.Color.White;
            this.ClientTextBox.Location = new System.Drawing.Point(66, 12);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.ReadOnly = true;
            this.ClientTextBox.Size = new System.Drawing.Size(695, 25);
            this.ClientTextBox.TabIndex = 112;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(12, 15);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(40, 17);
            this.ClientLabel.TabIndex = 111;
            this.ClientLabel.Text = "Client";
            // 
            // QuotationDataGridView
            // 
            this.QuotationDataGridView.AllowUserToAddRows = false;
            this.QuotationDataGridView.AllowUserToDeleteRows = false;
            this.QuotationDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuotationDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QuotationDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.QuotationDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.QuotationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuotationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.QuotationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuotationDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuotationDataGridView.ColumnHeadersHeight = 60;
            this.QuotationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.QuotationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuotationColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuotationDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuotationDataGridView.EnableHeadersVisualStyles = false;
            this.QuotationDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.QuotationDataGridView.Location = new System.Drawing.Point(12, 74);
            this.QuotationDataGridView.MultiSelect = false;
            this.QuotationDataGridView.Name = "QuotationDataGridView";
            this.QuotationDataGridView.ReadOnly = true;
            this.QuotationDataGridView.RowHeadersVisible = false;
            this.QuotationDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.QuotationDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.QuotationDataGridView.RowTemplate.Height = 40;
            this.QuotationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuotationDataGridView.Size = new System.Drawing.Size(1070, 715);
            this.QuotationDataGridView.TabIndex = 115;
            this.QuotationDataGridView.SelectionChanged += new System.EventHandler(this.QuotationDataGridView_SelectionChanged);
            // 
            // QuotationColumn
            // 
            this.QuotationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuotationColumn.HeaderText = "QUOTATION NO.";
            this.QuotationColumn.MinimumWidth = 100;
            this.QuotationColumn.Name = "QuotationColumn";
            this.QuotationColumn.ReadOnly = true;
            // 
            // QuotationView
            // 
            this.QuotationView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuotationView.BackColor = System.Drawing.Color.White;
            this.QuotationView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotationView.ForeColor = System.Drawing.Color.Red;
            this.QuotationView.Location = new System.Drawing.Point(1088, 116);
            this.QuotationView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuotationView.Name = "QuotationView";
            this.QuotationView.Quotation = null;
            this.QuotationView.Size = new System.Drawing.Size(385, 672);
            this.QuotationView.TabIndex = 116;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.BackColor = System.Drawing.Color.Red;
            this.AddNewButton.FlatAppearance.BorderSize = 0;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(1089, 74);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 120;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // ReviseButton
            // 
            this.ReviseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviseButton.BackColor = System.Drawing.Color.Red;
            this.ReviseButton.FlatAppearance.BorderSize = 0;
            this.ReviseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseButton.ForeColor = System.Drawing.Color.White;
            this.ReviseButton.Location = new System.Drawing.Point(1197, 74);
            this.ReviseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReviseButton.Name = "ReviseButton";
            this.ReviseButton.Size = new System.Drawing.Size(100, 35);
            this.ReviseButton.TabIndex = 121;
            this.ReviseButton.Text = "REVISE";
            this.ReviseButton.UseVisualStyleBackColor = false;
            this.ReviseButton.Click += new System.EventHandler(this.ReviseButton_Click);
            // 
            // QuotationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 801);
            this.Controls.Add(this.ReviseButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.QuotationView);
            this.Controls.Add(this.QuotationDataGridView);
            this.Controls.Add(this.ProjectTextBox);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.ClientLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuotationManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuotationManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuotationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectTextBox;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.DataGridView QuotationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuotationColumn;
        private Controls.QuotationViewControl QuotationView;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ReviseButton;
    }
}