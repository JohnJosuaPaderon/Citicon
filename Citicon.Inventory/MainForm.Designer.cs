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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.colItemsCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsMeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemsStockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewTracking = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
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
            this.Header.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1195, 84);
            this.Header.TabIndex = 0;
            // 
            // lblCiticonInventory
            // 
            this.lblCiticonInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCiticonInventory.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiticonInventory.Location = new System.Drawing.Point(0, 0);
            this.lblCiticonInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiticonInventory.Name = "lblCiticonInventory";
            this.lblCiticonInventory.Size = new System.Drawing.Size(704, 84);
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
            this.UserPane.Location = new System.Drawing.Point(704, 0);
            this.UserPane.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserPane.Name = "UserPane";
            this.UserPane.Size = new System.Drawing.Size(491, 84);
            this.UserPane.TabIndex = 0;
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.Location = new System.Drawing.Point(0, 25);
            this.lblUserDisplayName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(491, 38);
            this.lblUserDisplayName.TabIndex = 3;
            this.lblUserDisplayName.Text = "USER\'S DISPLAY NAME";
            this.lblUserDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogout.LinkColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(0, 63);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(491, 21);
            this.lblLogout.TabIndex = 1;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Log out";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHelloUser.Location = new System.Drawing.Point(0, 0);
            this.lblHelloUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(491, 25);
            this.lblHelloUser.TabIndex = 0;
            this.lblHelloUser.Text = "HELLO";
            this.lblHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.Red;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(178, 89);
            this.btnItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(164, 71);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "&Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnIncomingStocks
            // 
            this.btnIncomingStocks.BackColor = System.Drawing.Color.Red;
            this.btnIncomingStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomingStocks.ForeColor = System.Drawing.Color.White;
            this.btnIncomingStocks.Location = new System.Drawing.Point(347, 89);
            this.btnIncomingStocks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIncomingStocks.Name = "btnIncomingStocks";
            this.btnIncomingStocks.Size = new System.Drawing.Size(164, 71);
            this.btnIncomingStocks.TabIndex = 7;
            this.btnIncomingStocks.Text = "I&ncoming Stocks";
            this.btnIncomingStocks.UseVisualStyleBackColor = false;
            this.btnIncomingStocks.Click += new System.EventHandler(this.btnIncomingStocks_Click);
            // 
            // btnOutgoingStocks
            // 
            this.btnOutgoingStocks.BackColor = System.Drawing.Color.Red;
            this.btnOutgoingStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutgoingStocks.ForeColor = System.Drawing.Color.White;
            this.btnOutgoingStocks.Location = new System.Drawing.Point(515, 89);
            this.btnOutgoingStocks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnOutgoingStocks.Name = "btnOutgoingStocks";
            this.btnOutgoingStocks.Size = new System.Drawing.Size(164, 71);
            this.btnOutgoingStocks.TabIndex = 8;
            this.btnOutgoingStocks.Text = "&Outgoing Stocks";
            this.btnOutgoingStocks.UseVisualStyleBackColor = false;
            this.btnOutgoingStocks.Click += new System.EventHandler(this.btnOutgoingStocks_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Red;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(853, 89);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(164, 71);
            this.btnMaintenance.TabIndex = 9;
            this.btnMaintenance.Text = "&Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Red;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(684, 89);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(164, 71);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "R&eports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.ColumnHeadersHeight = 50;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItems,
            this.colItemsClassification,
            this.colItemsCode,
            this.colItemsMeasurementUnit,
            this.colItemsStockValue});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvItems.Location = new System.Drawing.Point(10, 198);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1175, 396);
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
            this.colItemsClassification.HeaderText = "Account Descriptions";
            this.colItemsClassification.Name = "colItemsClassification";
            this.colItemsClassification.ReadOnly = true;
            this.colItemsClassification.Width = 164;
            // 
            // colItemsCode
            // 
            this.colItemsCode.HeaderText = "Code";
            this.colItemsCode.Name = "colItemsCode";
            this.colItemsCode.ReadOnly = true;
            this.colItemsCode.Width = 70;
            // 
            // colItemsMeasurementUnit
            // 
            this.colItemsMeasurementUnit.HeaderText = "Measurement Unit";
            this.colItemsMeasurementUnit.Name = "colItemsMeasurementUnit";
            this.colItemsMeasurementUnit.ReadOnly = true;
            this.colItemsMeasurementUnit.Width = 149;
            // 
            // colItemsStockValue
            // 
            this.colItemsStockValue.HeaderText = "Stock Value";
            this.colItemsStockValue.Name = "colItemsStockValue";
            this.colItemsStockValue.ReadOnly = true;
            this.colItemsStockValue.Width = 104;
            // 
            // btnViewTracking
            // 
            this.btnViewTracking.BackColor = System.Drawing.Color.Red;
            this.btnViewTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTracking.ForeColor = System.Drawing.Color.White;
            this.btnViewTracking.Location = new System.Drawing.Point(1021, 89);
            this.btnViewTracking.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnViewTracking.Name = "btnViewTracking";
            this.btnViewTracking.Size = new System.Drawing.Size(164, 71);
            this.btnViewTracking.TabIndex = 12;
            this.btnViewTracking.Text = "&View Tracking";
            this.btnViewTracking.UseVisualStyleBackColor = false;
            this.btnViewTracking.Click += new System.EventHandler(this.btnViewTracking_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(10, 89);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(164, 71);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 167);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 21);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.Location = new System.Drawing.Point(67, 165);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(519, 29);
            this.tbxSearch.TabIndex = 15;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(950, 167);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(235, 21);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Please wait while loading items...";
            this.lblMessage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 595);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnViewTracking);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnOutgoingStocks);
            this.Controls.Add(this.btnIncomingStocks);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.UserPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnViewTracking;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsClassification;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsMeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsStockValue;
    }
}

