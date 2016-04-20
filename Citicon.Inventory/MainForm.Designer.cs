namespace Citicon.Inventory
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.Panel();
            this.lblCiticonInventory = new System.Windows.Forms.Label();
            this.UserPane = new System.Windows.Forms.Panel();
            this.lblUserDisplayName = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.lblHelloUser = new System.Windows.Forms.Label();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnIncomingStocks = new System.Windows.Forms.Button();
            this.btnOutgoingStocks = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsSubClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewTracking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.UserPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblCiticonInventory);
            this.Header.Controls.Add(this.UserPane);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1460, 100);
            this.Header.TabIndex = 0;
            // 
            // lblCiticonInventory
            // 
            this.lblCiticonInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCiticonInventory.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiticonInventory.Location = new System.Drawing.Point(0, 0);
            this.lblCiticonInventory.Name = "lblCiticonInventory";
            this.lblCiticonInventory.Size = new System.Drawing.Size(1120, 100);
            this.lblCiticonInventory.TabIndex = 1;
            this.lblCiticonInventory.Text = "Citicon Inventory";
            this.lblCiticonInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPane
            // 
            this.UserPane.Controls.Add(this.lblUserDisplayName);
            this.UserPane.Controls.Add(this.lblLogout);
            this.UserPane.Controls.Add(this.lblHelloUser);
            this.UserPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserPane.Location = new System.Drawing.Point(1120, 0);
            this.UserPane.Name = "UserPane";
            this.UserPane.Size = new System.Drawing.Size(340, 100);
            this.UserPane.TabIndex = 0;
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.Location = new System.Drawing.Point(0, 30);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(340, 45);
            this.lblUserDisplayName.TabIndex = 3;
            this.lblUserDisplayName.Text = "USER\'S DISPLAY NAME";
            this.lblUserDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogout.LinkColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(0, 75);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(340, 25);
            this.lblLogout.TabIndex = 1;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Log out";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHelloUser.Location = new System.Drawing.Point(0, 0);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(340, 30);
            this.lblHelloUser.TabIndex = 0;
            this.lblHelloUser.Text = "HELLO";
            this.lblHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(218, 106);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(200, 85);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "&Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnIncomingStocks
            // 
            this.btnIncomingStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIncomingStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomingStocks.ForeColor = System.Drawing.Color.White;
            this.btnIncomingStocks.Location = new System.Drawing.Point(424, 106);
            this.btnIncomingStocks.Name = "btnIncomingStocks";
            this.btnIncomingStocks.Size = new System.Drawing.Size(200, 85);
            this.btnIncomingStocks.TabIndex = 7;
            this.btnIncomingStocks.Text = "I&ncoming Stocks";
            this.btnIncomingStocks.UseVisualStyleBackColor = false;
            this.btnIncomingStocks.Click += new System.EventHandler(this.btnIncomingStocks_Click);
            // 
            // btnOutgoingStocks
            // 
            this.btnOutgoingStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOutgoingStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutgoingStocks.ForeColor = System.Drawing.Color.White;
            this.btnOutgoingStocks.Location = new System.Drawing.Point(630, 106);
            this.btnOutgoingStocks.Name = "btnOutgoingStocks";
            this.btnOutgoingStocks.Size = new System.Drawing.Size(200, 85);
            this.btnOutgoingStocks.TabIndex = 8;
            this.btnOutgoingStocks.Text = "&Outgoing Stocks";
            this.btnOutgoingStocks.UseVisualStyleBackColor = false;
            this.btnOutgoingStocks.Click += new System.EventHandler(this.btnOutgoingStocks_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(1042, 106);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(200, 85);
            this.btnMaintenance.TabIndex = 9;
            this.btnMaintenance.Text = "&Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(836, 106);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(200, 85);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "R&eports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItems.ColumnHeadersHeight = 50;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItems,
            this.colItemsClassification,
            this.colItemsSubClassification,
            this.colItemsStockValue});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(12, 197);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1436, 499);
            this.dgvItems.TabIndex = 11;
            // 
            // colItems
            // 
            this.colItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItems.HeaderText = "Description";
            this.colItems.Name = "colItems";
            this.colItems.ReadOnly = true;
            // 
            // colItemsClassification
            // 
            this.colItemsClassification.HeaderText = "Classification";
            this.colItemsClassification.Name = "colItemsClassification";
            this.colItemsClassification.ReadOnly = true;
            this.colItemsClassification.Width = 147;
            // 
            // colItemsSubClassification
            // 
            this.colItemsSubClassification.HeaderText = "Sub-Classification";
            this.colItemsSubClassification.Name = "colItemsSubClassification";
            this.colItemsSubClassification.ReadOnly = true;
            this.colItemsSubClassification.Width = 187;
            // 
            // colItemsStockValue
            // 
            this.colItemsStockValue.HeaderText = "Stock Value";
            this.colItemsStockValue.Name = "colItemsStockValue";
            this.colItemsStockValue.ReadOnly = true;
            this.colItemsStockValue.Width = 134;
            // 
            // btnViewTracking
            // 
            this.btnViewTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTracking.ForeColor = System.Drawing.Color.White;
            this.btnViewTracking.Location = new System.Drawing.Point(1248, 106);
            this.btnViewTracking.Name = "btnViewTracking";
            this.btnViewTracking.Size = new System.Drawing.Size(200, 85);
            this.btnViewTracking.TabIndex = 12;
            this.btnViewTracking.Text = "&View Tracking";
            this.btnViewTracking.UseVisualStyleBackColor = false;
            this.btnViewTracking.Click += new System.EventHandler(this.btnViewTracking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 106);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 85);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1460, 708);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewTracking);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnOutgoingStocks);
            this.Controls.Add(this.btnIncomingStocks);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.UserPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel UserPane;
        private System.Windows.Forms.Label lblHelloUser;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label lblUserDisplayName;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnOutgoingStocks;
        private System.Windows.Forms.Button btnIncomingStocks;
        private System.Windows.Forms.Label lblCiticonInventory;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsStockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsSubClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.Button btnViewTracking;
        private System.Windows.Forms.Button btnRefresh;
    }
}

