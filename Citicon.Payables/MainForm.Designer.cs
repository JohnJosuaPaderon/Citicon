namespace Citicon.Payables
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Header = new System.Windows.Forms.Panel();
            this.lblCiticonPayables = new System.Windows.Forms.Label();
            this.UserPane = new System.Windows.Forms.Panel();
            this.lblUserDisplayName = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.lblHelloUser = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvUnpaidStocks = new System.Windows.Forms.DataGridView();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockRemainingDayCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnpaidStocksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewUnpaidStockDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMrisNumberIssuanceQueue = new System.Windows.Forms.DataGridView();
            this.colMrisNumberIssuanceQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMrisIssuanceQueueTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsertToQueue = new System.Windows.Forms.Button();
            this.btnRemoveFromQueue = new System.Windows.Forms.Button();
            this.lblActiveSupplier = new System.Windows.Forms.Label();
            this.tbxActiveSupplier = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxActiveMrisNumber = new System.Windows.Forms.TextBox();
            this.lblActiveMrisNumber = new System.Windows.Forms.Label();
            this.lblGenerateMrisNumber = new System.Windows.Forms.LinkLabel();
            this.btnChequeVoucher = new System.Windows.Forms.Button();
            this.btnMaintenanceForm = new System.Windows.Forms.Button();
            this.btnChequeIssuance = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.UserPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidStocks)).BeginInit();
            this.UnpaidStocksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrisNumberIssuanceQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblCiticonPayables);
            this.Header.Controls.Add(this.UserPane);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1567, 100);
            this.Header.TabIndex = 1;
            // 
            // lblCiticonPayables
            // 
            this.lblCiticonPayables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCiticonPayables.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiticonPayables.Location = new System.Drawing.Point(0, 0);
            this.lblCiticonPayables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiticonPayables.Name = "lblCiticonPayables";
            this.lblCiticonPayables.Size = new System.Drawing.Size(1151, 100);
            this.lblCiticonPayables.TabIndex = 1;
            this.lblCiticonPayables.Text = "Citicon Payables";
            this.lblCiticonPayables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPane
            // 
            this.UserPane.Controls.Add(this.lblUserDisplayName);
            this.UserPane.Controls.Add(this.lblLogout);
            this.UserPane.Controls.Add(this.lblHelloUser);
            this.UserPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserPane.Location = new System.Drawing.Point(1151, 0);
            this.UserPane.Margin = new System.Windows.Forms.Padding(4);
            this.UserPane.Name = "UserPane";
            this.UserPane.Size = new System.Drawing.Size(416, 100);
            this.UserPane.TabIndex = 0;
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.Location = new System.Drawing.Point(0, 36);
            this.lblUserDisplayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(416, 34);
            this.lblUserDisplayName.TabIndex = 3;
            this.lblUserDisplayName.Text = "USER\'S DISPLAY NAME";
            this.lblUserDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogout.LinkColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(0, 70);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(416, 30);
            this.lblLogout.TabIndex = 1;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Log out";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHelloUser.Location = new System.Drawing.Point(0, 0);
            this.lblHelloUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(416, 36);
            this.lblHelloUser.TabIndex = 0;
            this.lblHelloUser.Text = "HELLO";
            this.lblHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(15, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 85);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvUnpaidStocks
            // 
            this.dgvUnpaidStocks.AllowUserToAddRows = false;
            this.dgvUnpaidStocks.AllowUserToDeleteRows = false;
            this.dgvUnpaidStocks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUnpaidStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnpaidStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUnpaidStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvUnpaidStocks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvUnpaidStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnpaidStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvUnpaidStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnpaidStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnpaidStocks.ColumnHeadersHeight = 60;
            this.dgvUnpaidStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnpaidStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStock,
            this.colStockSupplier,
            this.colStockTotalAmount,
            this.colStockRemainingDayCount});
            this.dgvUnpaidStocks.ContextMenuStrip = this.UnpaidStocksMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnpaidStocks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUnpaidStocks.EnableHeadersVisualStyles = false;
            this.dgvUnpaidStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvUnpaidStocks.Location = new System.Drawing.Point(15, 198);
            this.dgvUnpaidStocks.MultiSelect = false;
            this.dgvUnpaidStocks.Name = "dgvUnpaidStocks";
            this.dgvUnpaidStocks.ReadOnly = true;
            this.dgvUnpaidStocks.RowHeadersVisible = false;
            this.dgvUnpaidStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnpaidStocks.RowTemplate.Height = 40;
            this.dgvUnpaidStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnpaidStocks.Size = new System.Drawing.Size(848, 510);
            this.dgvUnpaidStocks.TabIndex = 72;
            this.dgvUnpaidStocks.SelectionChanged += new System.EventHandler(this.dgvUnpaidStocks_SelectionChanged);
            // 
            // colStock
            // 
            this.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStock.HeaderText = "Unpaid Stocks";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStockSupplier
            // 
            this.colStockSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colStockSupplier.HeaderText = "Supplier";
            this.colStockSupplier.Name = "colStockSupplier";
            this.colStockSupplier.ReadOnly = true;
            this.colStockSupplier.Width = 5;
            // 
            // colStockTotalAmount
            // 
            this.colStockTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStockTotalAmount.HeaderText = "Total Amount";
            this.colStockTotalAmount.Name = "colStockTotalAmount";
            this.colStockTotalAmount.ReadOnly = true;
            this.colStockTotalAmount.Width = 5;
            // 
            // colStockRemainingDayCount
            // 
            this.colStockRemainingDayCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockRemainingDayCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStockRemainingDayCount.HeaderText = "Remaining Days";
            this.colStockRemainingDayCount.MinimumWidth = 100;
            this.colStockRemainingDayCount.Name = "colStockRemainingDayCount";
            this.colStockRemainingDayCount.ReadOnly = true;
            // 
            // UnpaidStocksMenu
            // 
            this.UnpaidStocksMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewUnpaidStockDetails});
            this.UnpaidStocksMenu.Name = "UnpaidStocksMenu";
            this.UnpaidStocksMenu.Size = new System.Drawing.Size(138, 26);
            this.UnpaidStocksMenu.Opening += new System.ComponentModel.CancelEventHandler(this.UnpaidStocksMenu_Opening);
            // 
            // ViewUnpaidStockDetails
            // 
            this.ViewUnpaidStockDetails.Name = "ViewUnpaidStockDetails";
            this.ViewUnpaidStockDetails.Size = new System.Drawing.Size(137, 22);
            this.ViewUnpaidStockDetails.Text = "View Details";
            this.ViewUnpaidStockDetails.Click += new System.EventHandler(this.ViewUnpaidStockDetails_Click);
            // 
            // dgvMrisNumberIssuanceQueue
            // 
            this.dgvMrisNumberIssuanceQueue.AllowUserToAddRows = false;
            this.dgvMrisNumberIssuanceQueue.AllowUserToDeleteRows = false;
            this.dgvMrisNumberIssuanceQueue.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMrisNumberIssuanceQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMrisNumberIssuanceQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMrisNumberIssuanceQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvMrisNumberIssuanceQueue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMrisNumberIssuanceQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMrisNumberIssuanceQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvMrisNumberIssuanceQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMrisNumberIssuanceQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMrisNumberIssuanceQueue.ColumnHeadersHeight = 60;
            this.dgvMrisNumberIssuanceQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMrisNumberIssuanceQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMrisNumberIssuanceQueue,
            this.colMrisIssuanceQueueTotalAmount});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMrisNumberIssuanceQueue.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMrisNumberIssuanceQueue.EnableHeadersVisualStyles = false;
            this.dgvMrisNumberIssuanceQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvMrisNumberIssuanceQueue.Location = new System.Drawing.Point(950, 198);
            this.dgvMrisNumberIssuanceQueue.MultiSelect = false;
            this.dgvMrisNumberIssuanceQueue.Name = "dgvMrisNumberIssuanceQueue";
            this.dgvMrisNumberIssuanceQueue.ReadOnly = true;
            this.dgvMrisNumberIssuanceQueue.RowHeadersVisible = false;
            this.dgvMrisNumberIssuanceQueue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMrisNumberIssuanceQueue.RowTemplate.Height = 40;
            this.dgvMrisNumberIssuanceQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMrisNumberIssuanceQueue.Size = new System.Drawing.Size(605, 365);
            this.dgvMrisNumberIssuanceQueue.TabIndex = 75;
            // 
            // colMrisNumberIssuanceQueue
            // 
            this.colMrisNumberIssuanceQueue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMrisNumberIssuanceQueue.HeaderText = "MRIS No. Issuance Queue";
            this.colMrisNumberIssuanceQueue.Name = "colMrisNumberIssuanceQueue";
            this.colMrisNumberIssuanceQueue.ReadOnly = true;
            // 
            // colMrisIssuanceQueueTotalAmount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMrisIssuanceQueueTotalAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.colMrisIssuanceQueueTotalAmount.HeaderText = "Total Amount";
            this.colMrisIssuanceQueueTotalAmount.Name = "colMrisIssuanceQueueTotalAmount";
            this.colMrisIssuanceQueueTotalAmount.ReadOnly = true;
            this.colMrisIssuanceQueueTotalAmount.Width = 137;
            // 
            // btnInsertToQueue
            // 
            this.btnInsertToQueue.BackColor = System.Drawing.Color.Black;
            this.btnInsertToQueue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertToQueue.BackgroundImage")));
            this.btnInsertToQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToQueue.ForeColor = System.Drawing.Color.White;
            this.btnInsertToQueue.Location = new System.Drawing.Point(869, 407);
            this.btnInsertToQueue.Name = "btnInsertToQueue";
            this.btnInsertToQueue.Size = new System.Drawing.Size(75, 75);
            this.btnInsertToQueue.TabIndex = 74;
            this.btnInsertToQueue.UseVisualStyleBackColor = false;
            this.btnInsertToQueue.Click += new System.EventHandler(this.btnInsertToQueue_Click);
            // 
            // btnRemoveFromQueue
            // 
            this.btnRemoveFromQueue.BackColor = System.Drawing.Color.Black;
            this.btnRemoveFromQueue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromQueue.BackgroundImage")));
            this.btnRemoveFromQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveFromQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromQueue.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromQueue.Location = new System.Drawing.Point(869, 488);
            this.btnRemoveFromQueue.Name = "btnRemoveFromQueue";
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(75, 75);
            this.btnRemoveFromQueue.TabIndex = 73;
            this.btnRemoveFromQueue.UseVisualStyleBackColor = false;
            this.btnRemoveFromQueue.Click += new System.EventHandler(this.btnRemoveFromQueue_Click);
            // 
            // lblActiveSupplier
            // 
            this.lblActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveSupplier.AutoSize = true;
            this.lblActiveSupplier.Location = new System.Drawing.Point(945, 566);
            this.lblActiveSupplier.Name = "lblActiveSupplier";
            this.lblActiveSupplier.Size = new System.Drawing.Size(138, 25);
            this.lblActiveSupplier.TabIndex = 76;
            this.lblActiveSupplier.Text = "Active Supplier";
            // 
            // tbxActiveSupplier
            // 
            this.tbxActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxActiveSupplier.BackColor = System.Drawing.Color.White;
            this.tbxActiveSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxActiveSupplier.Location = new System.Drawing.Point(950, 594);
            this.tbxActiveSupplier.Name = "tbxActiveSupplier";
            this.tbxActiveSupplier.ReadOnly = true;
            this.tbxActiveSupplier.Size = new System.Drawing.Size(605, 33);
            this.tbxActiveSupplier.TabIndex = 77;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1430, 658);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 50);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxActiveMrisNumber
            // 
            this.tbxActiveMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxActiveMrisNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbxActiveMrisNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxActiveMrisNumber.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveMrisNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxActiveMrisNumber.Location = new System.Drawing.Point(950, 658);
            this.tbxActiveMrisNumber.Name = "tbxActiveMrisNumber";
            this.tbxActiveMrisNumber.ReadOnly = true;
            this.tbxActiveMrisNumber.Size = new System.Drawing.Size(474, 50);
            this.tbxActiveMrisNumber.TabIndex = 92;
            this.tbxActiveMrisNumber.Text = "20160416-1";
            this.tbxActiveMrisNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblActiveMrisNumber
            // 
            this.lblActiveMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveMrisNumber.AutoSize = true;
            this.lblActiveMrisNumber.Location = new System.Drawing.Point(945, 630);
            this.lblActiveMrisNumber.Name = "lblActiveMrisNumber";
            this.lblActiveMrisNumber.Size = new System.Drawing.Size(89, 25);
            this.lblActiveMrisNumber.TabIndex = 93;
            this.lblActiveMrisNumber.Text = "MRIS No.";
            // 
            // lblGenerateMrisNumber
            // 
            this.lblGenerateMrisNumber.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblGenerateMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenerateMrisNumber.AutoSize = true;
            this.lblGenerateMrisNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGenerateMrisNumber.Location = new System.Drawing.Point(1191, 630);
            this.lblGenerateMrisNumber.Name = "lblGenerateMrisNumber";
            this.lblGenerateMrisNumber.Size = new System.Drawing.Size(233, 25);
            this.lblGenerateMrisNumber.TabIndex = 94;
            this.lblGenerateMrisNumber.TabStop = true;
            this.lblGenerateMrisNumber.Text = "Generate Lastest MRIS No.";
            this.lblGenerateMrisNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGenerateMrisNumber_LinkClicked);
            // 
            // btnChequeVoucher
            // 
            this.btnChequeVoucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChequeVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequeVoucher.ForeColor = System.Drawing.Color.White;
            this.btnChequeVoucher.Location = new System.Drawing.Point(221, 107);
            this.btnChequeVoucher.Name = "btnChequeVoucher";
            this.btnChequeVoucher.Size = new System.Drawing.Size(200, 85);
            this.btnChequeVoucher.TabIndex = 95;
            this.btnChequeVoucher.Text = "&Cheque Voucher";
            this.btnChequeVoucher.UseVisualStyleBackColor = false;
            this.btnChequeVoucher.Click += new System.EventHandler(this.btnChequeVoucher_Click);
            // 
            // btnMaintenanceForm
            // 
            this.btnMaintenanceForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMaintenanceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceForm.ForeColor = System.Drawing.Color.White;
            this.btnMaintenanceForm.Location = new System.Drawing.Point(633, 107);
            this.btnMaintenanceForm.Name = "btnMaintenanceForm";
            this.btnMaintenanceForm.Size = new System.Drawing.Size(200, 85);
            this.btnMaintenanceForm.TabIndex = 96;
            this.btnMaintenanceForm.Text = "&Maintenance";
            this.btnMaintenanceForm.UseVisualStyleBackColor = false;
            this.btnMaintenanceForm.Click += new System.EventHandler(this.btnMaintenanceForm_Click);
            // 
            // btnChequeIssuance
            // 
            this.btnChequeIssuance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChequeIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequeIssuance.ForeColor = System.Drawing.Color.White;
            this.btnChequeIssuance.Location = new System.Drawing.Point(427, 107);
            this.btnChequeIssuance.Name = "btnChequeIssuance";
            this.btnChequeIssuance.Size = new System.Drawing.Size(200, 85);
            this.btnChequeIssuance.TabIndex = 97;
            this.btnChequeIssuance.Text = "C&heque Issuance";
            this.btnChequeIssuance.UseVisualStyleBackColor = false;
            this.btnChequeIssuance.Click += new System.EventHandler(this.btnChequeIssuance_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1567, 720);
            this.Controls.Add(this.btnChequeIssuance);
            this.Controls.Add(this.btnMaintenanceForm);
            this.Controls.Add(this.btnChequeVoucher);
            this.Controls.Add(this.lblGenerateMrisNumber);
            this.Controls.Add(this.lblActiveMrisNumber);
            this.Controls.Add(this.tbxActiveMrisNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxActiveSupplier);
            this.Controls.Add(this.lblActiveSupplier);
            this.Controls.Add(this.dgvMrisNumberIssuanceQueue);
            this.Controls.Add(this.btnInsertToQueue);
            this.Controls.Add(this.btnRemoveFromQueue);
            this.Controls.Add(this.dgvUnpaidStocks);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citicon Payables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Header.ResumeLayout(false);
            this.UserPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidStocks)).EndInit();
            this.UnpaidStocksMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrisNumberIssuanceQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label lblCiticonPayables;
        private System.Windows.Forms.Panel UserPane;
        private System.Windows.Forms.Label lblUserDisplayName;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label lblHelloUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvUnpaidStocks;
        private System.Windows.Forms.Button btnRemoveFromQueue;
        private System.Windows.Forms.Button btnInsertToQueue;
        private System.Windows.Forms.DataGridView dgvMrisNumberIssuanceQueue;
        private System.Windows.Forms.ContextMenuStrip UnpaidStocksMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewUnpaidStockDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRemainingDayCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.TextBox tbxActiveSupplier;
        private System.Windows.Forms.Label lblActiveSupplier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxActiveMrisNumber;
        private System.Windows.Forms.Label lblActiveMrisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMrisIssuanceQueueTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMrisNumberIssuanceQueue;
        private System.Windows.Forms.LinkLabel lblGenerateMrisNumber;
        private System.Windows.Forms.Button btnChequeVoucher;
        private System.Windows.Forms.Button btnMaintenanceForm;
        private System.Windows.Forms.Button btnChequeIssuance;
    }
}