namespace Citicon.Forms
{
    partial class ProjectManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagementForm));
            this.ClientNameLabel = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectView = new Citicon.Forms.Controls.ProjectViewControl();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.ViewDesignsButton = new System.Windows.Forms.Button();
            this.ViewQuotationsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientNameLabel
            // 
            this.ClientNameLabel.AutoSize = true;
            this.ClientNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ClientNameLabel.Name = "ClientNameLabel";
            this.ClientNameLabel.Size = new System.Drawing.Size(40, 17);
            this.ClientNameLabel.TabIndex = 0;
            this.ClientNameLabel.Text = "Client";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.BackColor = System.Drawing.Color.White;
            this.ClientNameTextBox.Location = new System.Drawing.Point(58, 12);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.ReadOnly = true;
            this.ClientNameTextBox.Size = new System.Drawing.Size(703, 25);
            this.ClientNameTextBox.TabIndex = 1;
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
            this.ProjectDataGridView.Size = new System.Drawing.Size(832, 795);
            this.ProjectDataGridView.TabIndex = 105;
            this.ProjectDataGridView.SelectionChanged += new System.EventHandler(this.ProjectDataGridView_SelectionChanged);
            // 
            // ProjectColumn
            // 
            this.ProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectColumn.HeaderText = "PROJECT NAME";
            this.ProjectColumn.MinimumWidth = 100;
            this.ProjectColumn.Name = "ProjectColumn";
            this.ProjectColumn.ReadOnly = true;
            // 
            // ProjectView
            // 
            this.ProjectView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectView.BackColor = System.Drawing.Color.White;
            this.ProjectView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectView.ForeColor = System.Drawing.Color.Red;
            this.ProjectView.Location = new System.Drawing.Point(850, 85);
            this.ProjectView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProjectView.Name = "ProjectView";
            this.ProjectView.Project = null;
            this.ProjectView.Size = new System.Drawing.Size(419, 281);
            this.ProjectView.TabIndex = 106;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(1067, 43);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteButton.TabIndex = 117;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(959, 43);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 35);
            this.EditButton.TabIndex = 116;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.BackColor = System.Drawing.Color.Red;
            this.AddNewButton.FlatAppearance.BorderSize = 0;
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewButton.ForeColor = System.Drawing.Color.White;
            this.AddNewButton.Location = new System.Drawing.Point(851, 43);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 115;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // ViewDesignsButton
            // 
            this.ViewDesignsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewDesignsButton.BackColor = System.Drawing.Color.Red;
            this.ViewDesignsButton.FlatAppearance.BorderSize = 0;
            this.ViewDesignsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewDesignsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDesignsButton.ForeColor = System.Drawing.Color.White;
            this.ViewDesignsButton.Location = new System.Drawing.Point(1143, 373);
            this.ViewDesignsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewDesignsButton.Name = "ViewDesignsButton";
            this.ViewDesignsButton.Size = new System.Drawing.Size(125, 35);
            this.ViewDesignsButton.TabIndex = 118;
            this.ViewDesignsButton.Text = "VIEW DESIGNS";
            this.ViewDesignsButton.UseVisualStyleBackColor = false;
            this.ViewDesignsButton.Click += new System.EventHandler(this.ViewDesignsButton_Click);
            // 
            // ViewQuotationsButton
            // 
            this.ViewQuotationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewQuotationsButton.BackColor = System.Drawing.Color.Red;
            this.ViewQuotationsButton.FlatAppearance.BorderSize = 0;
            this.ViewQuotationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewQuotationsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotationsButton.ForeColor = System.Drawing.Color.White;
            this.ViewQuotationsButton.Location = new System.Drawing.Point(985, 373);
            this.ViewQuotationsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewQuotationsButton.Name = "ViewQuotationsButton";
            this.ViewQuotationsButton.Size = new System.Drawing.Size(150, 35);
            this.ViewQuotationsButton.TabIndex = 119;
            this.ViewQuotationsButton.Text = "VIEW QUOTATIONS";
            this.ViewQuotationsButton.UseVisualStyleBackColor = false;
            this.ViewQuotationsButton.Click += new System.EventHandler(this.ViewQuotationsButton_Click);
            // 
            // ProjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 850);
            this.Controls.Add(this.ViewQuotationsButton);
            this.Controls.Add(this.ViewDesignsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.ProjectView);
            this.Controls.Add(this.ProjectDataGridView);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.ClientNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientNameLabel;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectColumn;
        private Controls.ProjectViewControl ProjectView;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ViewDesignsButton;
        private System.Windows.Forms.Button ViewQuotationsButton;
    }
}