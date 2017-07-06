namespace Citicon.Forms
{
    partial class RouteManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteManagementForm));
            this.RouteDataGridView = new System.Windows.Forms.DataGridView();
            this.RouteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route_FromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route_ToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route_RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedRoutePreview = new Citicon.Forms.Controls.RoutePreview();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RouteDataGridView
            // 
            this.RouteDataGridView.AllowUserToAddRows = false;
            this.RouteDataGridView.AllowUserToDeleteRows = false;
            this.RouteDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RouteDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RouteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RouteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RouteDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RouteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RouteDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.RouteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RouteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RouteDataGridView.ColumnHeadersHeight = 60;
            this.RouteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RouteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouteColumn,
            this.Route_FromColumn,
            this.Route_ToColumn,
            this.Route_RateColumn,
            this.Route_ExtraColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RouteDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.RouteDataGridView.EnableHeadersVisualStyles = false;
            this.RouteDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RouteDataGridView.Location = new System.Drawing.Point(12, 12);
            this.RouteDataGridView.MultiSelect = false;
            this.RouteDataGridView.Name = "RouteDataGridView";
            this.RouteDataGridView.ReadOnly = true;
            this.RouteDataGridView.RowHeadersVisible = false;
            this.RouteDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.RouteDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RouteDataGridView.RowTemplate.Height = 40;
            this.RouteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RouteDataGridView.Size = new System.Drawing.Size(740, 628);
            this.RouteDataGridView.TabIndex = 105;
            this.RouteDataGridView.SelectionChanged += new System.EventHandler(this.RouteDataGridView_SelectionChanged);
            // 
            // RouteColumn
            // 
            this.RouteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RouteColumn.HeaderText = "ROUTE NAME";
            this.RouteColumn.MinimumWidth = 100;
            this.RouteColumn.Name = "RouteColumn";
            this.RouteColumn.ReadOnly = true;
            this.RouteColumn.Width = 104;
            // 
            // Route_FromColumn
            // 
            this.Route_FromColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Route_FromColumn.HeaderText = "FROM";
            this.Route_FromColumn.Name = "Route_FromColumn";
            this.Route_FromColumn.ReadOnly = true;
            this.Route_FromColumn.Width = 68;
            // 
            // Route_ToColumn
            // 
            this.Route_ToColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Route_ToColumn.HeaderText = "TO";
            this.Route_ToColumn.Name = "Route_ToColumn";
            this.Route_ToColumn.ReadOnly = true;
            this.Route_ToColumn.Width = 48;
            // 
            // Route_RateColumn
            // 
            this.Route_RateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.Route_RateColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.Route_RateColumn.HeaderText = "RATE";
            this.Route_RateColumn.Name = "Route_RateColumn";
            this.Route_RateColumn.ReadOnly = true;
            this.Route_RateColumn.Width = 61;
            // 
            // Route_ExtraColumn
            // 
            this.Route_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Route_ExtraColumn.HeaderText = "";
            this.Route_ExtraColumn.Name = "Route_ExtraColumn";
            this.Route_ExtraColumn.ReadOnly = true;
            // 
            // SelectedRoutePreview
            // 
            this.SelectedRoutePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedRoutePreview.BackColor = System.Drawing.Color.White;
            this.SelectedRoutePreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedRoutePreview.ForeColor = System.Drawing.Color.Red;
            this.SelectedRoutePreview.Location = new System.Drawing.Point(758, 59);
            this.SelectedRoutePreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectedRoutePreview.Name = "SelectedRoutePreview";
            this.SelectedRoutePreview.Route = null;
            this.SelectedRoutePreview.Size = new System.Drawing.Size(318, 199);
            this.SelectedRoutePreview.TabIndex = 106;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(975, 12);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 35);
            this.DeleteButton.TabIndex = 117;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.BackColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(867, 12);
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
            this.AddNewButton.Location = new System.Drawing.Point(759, 12);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(100, 35);
            this.AddNewButton.TabIndex = 115;
            this.AddNewButton.Text = "ADD NEW";
            this.AddNewButton.UseVisualStyleBackColor = false;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // RouteManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 652);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.SelectedRoutePreview);
            this.Controls.Add(this.RouteDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RouteManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Routes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RouteManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RouteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RouteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route_FromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route_ToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route_RateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route_ExtraColumn;
        private Controls.RoutePreview SelectedRoutePreview;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddNewButton;
    }
}