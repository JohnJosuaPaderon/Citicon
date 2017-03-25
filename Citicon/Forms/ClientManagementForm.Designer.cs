namespace Citicon.Forms
{
    partial class ClientManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagementForm));
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientView = new Citicon.Forms.Controls.ClientViewControl();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.ViewProjectsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.AllowUserToAddRows = false;
            this.ClientDataGridView.AllowUserToDeleteRows = false;
            this.ClientDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ClientDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientDataGridView.ColumnHeadersHeight = 60;
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClient});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientDataGridView.EnableHeadersVisualStyles = false;
            this.ClientDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientDataGridView.Location = new System.Drawing.Point(10, 40);
            this.ClientDataGridView.MultiSelect = false;
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.ReadOnly = true;
            this.ClientDataGridView.RowHeadersVisible = false;
            this.ClientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ClientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientDataGridView.RowTemplate.Height = 40;
            this.ClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGridView.Size = new System.Drawing.Size(1060, 642);
            this.ClientDataGridView.TabIndex = 104;
            this.ClientDataGridView.SelectionChanged += new System.EventHandler(this.ClientDataGridView_SelectionChanged);
            // 
            // colClient
            // 
            this.colClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClient.HeaderText = "CLIENT NAME";
            this.colClient.MinimumWidth = 100;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            // 
            // ClientView
            // 
            this.ClientView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientView.BackColor = System.Drawing.Color.White;
            this.ClientView.Client = null;
            this.ClientView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientView.ForeColor = System.Drawing.Color.Red;
            this.ClientView.Location = new System.Drawing.Point(1077, 81);
            this.ClientView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(400, 478);
            this.ClientView.TabIndex = 109;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 14);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.SearchLabel.TabIndex = 110;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(62, 11);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(335, 25);
            this.SearchTextBox.TabIndex = 111;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(1293, 40);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteButton.TabIndex = 114;
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
            this.EditButton.Location = new System.Drawing.Point(1185, 40);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 35);
            this.EditButton.TabIndex = 113;
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
            this.AddNewButton.Location = new System.Drawing.Point(1077, 40);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 112;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // ViewProjectsButton
            // 
            this.ViewProjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewProjectsButton.BackColor = System.Drawing.Color.Red;
            this.ViewProjectsButton.FlatAppearance.BorderSize = 0;
            this.ViewProjectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProjectsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProjectsButton.ForeColor = System.Drawing.Color.White;
            this.ViewProjectsButton.Location = new System.Drawing.Point(1352, 565);
            this.ViewProjectsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ViewProjectsButton.Name = "ViewProjectsButton";
            this.ViewProjectsButton.Size = new System.Drawing.Size(125, 35);
            this.ViewProjectsButton.TabIndex = 115;
            this.ViewProjectsButton.Text = "VIEW PROJECTS";
            this.ViewProjectsButton.UseVisualStyleBackColor = false;
            this.ViewProjectsButton.Click += new System.EventHandler(this.ViewProjectsButton_Click);
            // 
            // ClientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 693);
            this.Controls.Add(this.ViewProjectsButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ClientView);
            this.Controls.Add(this.ClientDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ClientManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClientManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientDataGridView;
        private Controls.ClientViewControl ClientView;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ViewProjectsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
    }
}