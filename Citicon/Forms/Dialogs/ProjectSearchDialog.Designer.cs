namespace Citicon.Forms.Dialogs
{
    partial class ProjectSearchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSearchDialog));
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.CancelSearchButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectDataGridView.ColumnHeadersHeight = 60;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectDataGridView.EnableHeadersVisualStyles = false;
            this.ProjectDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectDataGridView.Location = new System.Drawing.Point(12, 43);
            this.ProjectDataGridView.MultiSelect = false;
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.ReadOnly = true;
            this.ProjectDataGridView.RowHeadersVisible = false;
            this.ProjectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ProjectDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectDataGridView.RowTemplate.Height = 40;
            this.ProjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectDataGridView.Size = new System.Drawing.Size(960, 468);
            this.ProjectDataGridView.TabIndex = 108;
            // 
            // ProjectColumn
            // 
            this.ProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectColumn.HeaderText = "PROJECT NAME";
            this.ProjectColumn.MinimumWidth = 100;
            this.ProjectColumn.Name = "ProjectColumn";
            this.ProjectColumn.ReadOnly = true;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.BackColor = System.Drawing.Color.White;
            this.ClientNameTextBox.Location = new System.Drawing.Point(55, 523);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = true;
            this.ClientNameTextBox.Size = new System.Drawing.Size(646, 25);
            this.ClientNameTextBox.TabIndex = 107;
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(9, 526);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(40, 17);
            this.ClientNameLabel.TabIndex = 106;
            this.ClientNameLabel.Text = "Client";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(61, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(335, 25);
            this.SearchTextBox.TabIndex = 116;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(9, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.SearchLabel.TabIndex = 115;
            this.SearchLabel.Text = "Search";
            // 
            // CancelSearchButton
            // 
            this.CancelSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelSearchButton.BackColor = System.Drawing.Color.Red;
            this.CancelSearchButton.FlatAppearance.BorderSize = 0;
            this.CancelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSearchButton.ForeColor = System.Drawing.Color.White;
            this.CancelSearchButton.Location = new System.Drawing.Point(871, 517);
            this.CancelSearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelSearchButton.Name = "CancelSearchButton";
            this.CancelSearchButton.Size = new System.Drawing.Size(100, 35);
            this.CancelSearchButton.TabIndex = 134;
            this.CancelSearchButton.Text = "CANCEL";
            this.CancelSearchButton.UseVisualStyleBackColor = false;
            this.CancelSearchButton.Click += new System.EventHandler(this.CancelSearchButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.BackColor = System.Drawing.Color.Red;
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.Color.White;
            this.SelectButton.Location = new System.Drawing.Point(763, 517);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(100, 35);
            this.SelectButton.TabIndex = 133;
            this.SelectButton.Text = "SELECT";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ProjectSearchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.CancelSearchButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ProjectDataGridView);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectSearchDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Project";
            this.Load += new System.EventHandler(this.ProjectSearchDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectColumn;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button CancelSearchButton;
        private System.Windows.Forms.Button SelectButton;
    }
}