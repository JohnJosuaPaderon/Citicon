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
            this.colStockSiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDrNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockRemainingDayCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnpaidStocksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewUnpaidStockDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMrisNumberIssuanceQueue = new System.Windows.Forms.DataGridView();
            this.colMrisNumberIssuanceQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMrisIssuanceQueueTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblActiveSupplier = new System.Windows.Forms.Label();
            this.tbxActiveSupplier = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxActiveMrisNumber = new System.Windows.Forms.TextBox();
            this.lblActiveMrisNumber = new System.Windows.Forms.Label();
            this.lblGenerateMrisNumber = new System.Windows.Forms.LinkLabel();
            this.btnChequeVoucher = new System.Windows.Forms.Button();
            this.btnMaintenanceForm = new System.Windows.Forms.Button();
            this.btnChequeIssuance = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.UsageLabel = new System.Windows.Forms.Label();
            this.UsageTextBox = new System.Windows.Forms.TextBox();
            this.ReceivedStoredByLabel = new System.Windows.Forms.Label();
            this.ReceivedStoredByTextBox = new System.Windows.Forms.TextBox();
            this.InspectedAcceptedByTextBox = new System.Windows.Forms.TextBox();
            this.InspectedAcceptedByLabel = new System.Windows.Forms.Label();
            this.ApprovedByTextBox = new System.Windows.Forms.TextBox();
            this.ApprovedByLabel = new System.Windows.Forms.Label();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.ckbxFilterByDrNumber = new System.Windows.Forms.CheckBox();
            this.nudFilterByDrNumber = new System.Windows.Forms.NumericUpDown();
            this.nudFilterBySiNumber = new System.Windows.Forms.NumericUpDown();
            this.ckbxFilterBySiNumber = new System.Windows.Forms.CheckBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpFilterByDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.ckbxFilterByDeliveryDate = new System.Windows.Forms.CheckBox();
            this.cmbxFilterBySupplier = new System.Windows.Forms.ComboBox();
            this.cmbxFilterByItem = new System.Windows.Forms.ComboBox();
            this.ckbxFilterBySupplier = new System.Windows.Forms.CheckBox();
            this.ckbxFilterByItem = new System.Windows.Forms.CheckBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.tbxGrandTotal = new System.Windows.Forms.TextBox();
            this.lblReprintMris = new System.Windows.Forms.Label();
            this.tbxReprintMris = new System.Windows.Forms.TextBox();
            this.btnReprintMris = new System.Windows.Forms.Button();
            this.lblChangeAccountDescription = new System.Windows.Forms.Label();
            this.cmbxExpense = new System.Windows.Forms.ComboBox();
            this.btnChangeAccountDescription = new System.Windows.Forms.Button();
            this.btnRemoveExpenseClassification = new System.Windows.Forms.Button();
            this.btnInsertToQueue = new System.Windows.Forms.Button();
            this.btnRemoveFromQueue = new System.Windows.Forms.Button();
            this.lblAccountBranch = new System.Windows.Forms.Label();
            this.cmbxAccountBranch = new System.Windows.Forms.ComboBox();
            this.cmbxAccountCompany = new System.Windows.Forms.ComboBox();
            this.lblAccountCompany = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.UserPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnpaidStocks)).BeginInit();
            this.UnpaidStocksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMrisNumberIssuanceQueue)).BeginInit();
            this.gbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterByDrNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterBySiNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.lblCiticonPayables);
            this.Header.Controls.Add(this.UserPane);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1597, 80);
            this.Header.TabIndex = 1;
            // 
            // lblCiticonPayables
            // 
            this.lblCiticonPayables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCiticonPayables.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiticonPayables.Location = new System.Drawing.Point(0, 0);
            this.lblCiticonPayables.Name = "lblCiticonPayables";
            this.lblCiticonPayables.Size = new System.Drawing.Size(1160, 80);
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
            this.UserPane.Location = new System.Drawing.Point(1160, 0);
            this.UserPane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserPane.Name = "UserPane";
            this.UserPane.Size = new System.Drawing.Size(437, 80);
            this.UserPane.TabIndex = 0;
            // 
            // lblUserDisplayName
            // 
            this.lblUserDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserDisplayName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDisplayName.Location = new System.Drawing.Point(0, 28);
            this.lblUserDisplayName.Name = "lblUserDisplayName";
            this.lblUserDisplayName.Size = new System.Drawing.Size(437, 28);
            this.lblUserDisplayName.TabIndex = 3;
            this.lblUserDisplayName.Text = "USER\'S DISPLAY NAME";
            this.lblUserDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogout
            // 
            this.lblLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogout.LinkColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(0, 56);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(437, 24);
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
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(437, 28);
            this.lblHelloUser.TabIndex = 0;
            this.lblHelloUser.Text = "HELLO";
            this.lblHelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(11, 86);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 68);
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
            this.dgvUnpaidStocks.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUnpaidStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnpaidStocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvUnpaidStocks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnpaidStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnpaidStocks.ColumnHeadersHeight = 60;
            this.dgvUnpaidStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnpaidStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStock,
            this.colStockSiNumber,
            this.colStockDrNumber,
            this.colStockSupplier,
            this.colStockBranch,
            this.colStockDeliveryDate,
            this.colStockTotalAmount,
            this.colStockRemainingDayCount});
            this.dgvUnpaidStocks.ContextMenuStrip = this.UnpaidStocksMenu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnpaidStocks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUnpaidStocks.EnableHeadersVisualStyles = false;
            this.dgvUnpaidStocks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvUnpaidStocks.Location = new System.Drawing.Point(11, 293);
            this.dgvUnpaidStocks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUnpaidStocks.MultiSelect = false;
            this.dgvUnpaidStocks.Name = "dgvUnpaidStocks";
            this.dgvUnpaidStocks.ReadOnly = true;
            this.dgvUnpaidStocks.RowHeadersVisible = false;
            this.dgvUnpaidStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUnpaidStocks.RowTemplate.Height = 40;
            this.dgvUnpaidStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnpaidStocks.Size = new System.Drawing.Size(1064, 222);
            this.dgvUnpaidStocks.TabIndex = 72;
            this.dgvUnpaidStocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnpaidStocks_CellContentClick);
            this.dgvUnpaidStocks.SelectionChanged += new System.EventHandler(this.dgvUnpaidStocks_SelectionChanged);
            // 
            // colStock
            // 
            this.colStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStock.HeaderText = "Unpaid Stocks";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 116;
            // 
            // colStockSiNumber
            // 
            this.colStockSiNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStockSiNumber.HeaderText = "SI No.";
            this.colStockSiNumber.Name = "colStockSiNumber";
            this.colStockSiNumber.ReadOnly = true;
            this.colStockSiNumber.Width = 67;
            // 
            // colStockDrNumber
            // 
            this.colStockDrNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStockDrNumber.HeaderText = "DR No.";
            this.colStockDrNumber.Name = "colStockDrNumber";
            this.colStockDrNumber.ReadOnly = true;
            this.colStockDrNumber.Width = 74;
            // 
            // colStockSupplier
            // 
            this.colStockSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStockSupplier.HeaderText = "Supplier";
            this.colStockSupplier.Name = "colStockSupplier";
            this.colStockSupplier.ReadOnly = true;
            this.colStockSupplier.Width = 88;
            // 
            // colStockBranch
            // 
            this.colStockBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStockBranch.HeaderText = "Volume";
            this.colStockBranch.Name = "colStockBranch";
            this.colStockBranch.ReadOnly = true;
            this.colStockBranch.Width = 83;
            // 
            // colStockDeliveryDate
            // 
            this.colStockDeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colStockDeliveryDate.HeaderText = "Delivery Date";
            this.colStockDeliveryDate.Name = "colStockDeliveryDate";
            this.colStockDeliveryDate.ReadOnly = true;
            this.colStockDeliveryDate.Width = 113;
            // 
            // colStockTotalAmount
            // 
            this.colStockTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockTotalAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colStockTotalAmount.HeaderText = "Total Amount";
            this.colStockTotalAmount.Name = "colStockTotalAmount";
            this.colStockTotalAmount.ReadOnly = true;
            this.colStockTotalAmount.Width = 113;
            // 
            // colStockRemainingDayCount
            // 
            this.colStockRemainingDayCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colStockRemainingDayCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStockRemainingDayCount.HeaderText = "Remaining Days";
            this.colStockRemainingDayCount.MinimumWidth = 100;
            this.colStockRemainingDayCount.Name = "colStockRemainingDayCount";
            this.colStockRemainingDayCount.ReadOnly = true;
            this.colStockRemainingDayCount.Width = 128;
            // 
            // UnpaidStocksMenu
            // 
            this.UnpaidStocksMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.dgvMrisNumberIssuanceQueue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMrisNumberIssuanceQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMrisNumberIssuanceQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvMrisNumberIssuanceQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
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
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMrisNumberIssuanceQueue.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMrisNumberIssuanceQueue.EnableHeadersVisualStyles = false;
            this.dgvMrisNumberIssuanceQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvMrisNumberIssuanceQueue.Location = new System.Drawing.Point(1138, 191);
            this.dgvMrisNumberIssuanceQueue.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMrisNumberIssuanceQueue.MultiSelect = false;
            this.dgvMrisNumberIssuanceQueue.Name = "dgvMrisNumberIssuanceQueue";
            this.dgvMrisNumberIssuanceQueue.ReadOnly = true;
            this.dgvMrisNumberIssuanceQueue.RowHeadersVisible = false;
            this.dgvMrisNumberIssuanceQueue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMrisNumberIssuanceQueue.RowTemplate.Height = 40;
            this.dgvMrisNumberIssuanceQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMrisNumberIssuanceQueue.Size = new System.Drawing.Size(450, 257);
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
            this.colMrisIssuanceQueueTotalAmount.Width = 113;
            // 
            // lblActiveSupplier
            // 
            this.lblActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveSupplier.AutoSize = true;
            this.lblActiveSupplier.Location = new System.Drawing.Point(1138, 557);
            this.lblActiveSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveSupplier.Name = "lblActiveSupplier";
            this.lblActiveSupplier.Size = new System.Drawing.Size(109, 20);
            this.lblActiveSupplier.TabIndex = 76;
            this.lblActiveSupplier.Text = "Active Supplier";
            // 
            // tbxActiveSupplier
            // 
            this.tbxActiveSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxActiveSupplier.BackColor = System.Drawing.Color.White;
            this.tbxActiveSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxActiveSupplier.Location = new System.Drawing.Point(1142, 579);
            this.tbxActiveSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.tbxActiveSupplier.Name = "tbxActiveSupplier";
            this.tbxActiveSupplier.ReadOnly = true;
            this.tbxActiveSupplier.Size = new System.Drawing.Size(447, 27);
            this.tbxActiveSupplier.TabIndex = 77;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1498, 630);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 50);
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
            this.tbxActiveMrisNumber.ForeColor = System.Drawing.Color.Lime;
            this.tbxActiveMrisNumber.Location = new System.Drawing.Point(1142, 630);
            this.tbxActiveMrisNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbxActiveMrisNumber.Name = "tbxActiveMrisNumber";
            this.tbxActiveMrisNumber.ReadOnly = true;
            this.tbxActiveMrisNumber.Size = new System.Drawing.Size(352, 50);
            this.tbxActiveMrisNumber.TabIndex = 92;
            this.tbxActiveMrisNumber.Text = "20160416-1";
            this.tbxActiveMrisNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblActiveMrisNumber
            // 
            this.lblActiveMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblActiveMrisNumber.AutoSize = true;
            this.lblActiveMrisNumber.Location = new System.Drawing.Point(1138, 608);
            this.lblActiveMrisNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveMrisNumber.Name = "lblActiveMrisNumber";
            this.lblActiveMrisNumber.Size = new System.Drawing.Size(70, 20);
            this.lblActiveMrisNumber.TabIndex = 93;
            this.lblActiveMrisNumber.Text = "MRIS No.";
            // 
            // lblGenerateMrisNumber
            // 
            this.lblGenerateMrisNumber.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblGenerateMrisNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenerateMrisNumber.AutoSize = true;
            this.lblGenerateMrisNumber.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGenerateMrisNumber.Location = new System.Drawing.Point(1651, 619);
            this.lblGenerateMrisNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenerateMrisNumber.Name = "lblGenerateMrisNumber";
            this.lblGenerateMrisNumber.Size = new System.Drawing.Size(183, 20);
            this.lblGenerateMrisNumber.TabIndex = 94;
            this.lblGenerateMrisNumber.TabStop = true;
            this.lblGenerateMrisNumber.Text = "Generate Lastest MRIS No.";
            this.lblGenerateMrisNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGenerateMrisNumber_LinkClicked);
            // 
            // btnChequeVoucher
            // 
            this.btnChequeVoucher.BackColor = System.Drawing.Color.Red;
            this.btnChequeVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequeVoucher.ForeColor = System.Drawing.Color.White;
            this.btnChequeVoucher.Location = new System.Drawing.Point(161, 86);
            this.btnChequeVoucher.Margin = new System.Windows.Forms.Padding(2);
            this.btnChequeVoucher.Name = "btnChequeVoucher";
            this.btnChequeVoucher.Size = new System.Drawing.Size(145, 68);
            this.btnChequeVoucher.TabIndex = 95;
            this.btnChequeVoucher.Text = "&Cheque Voucher";
            this.btnChequeVoucher.UseVisualStyleBackColor = false;
            this.btnChequeVoucher.Click += new System.EventHandler(this.btnChequeVoucher_Click);
            // 
            // btnMaintenanceForm
            // 
            this.btnMaintenanceForm.BackColor = System.Drawing.Color.Red;
            this.btnMaintenanceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenanceForm.ForeColor = System.Drawing.Color.White;
            this.btnMaintenanceForm.Location = new System.Drawing.Point(461, 86);
            this.btnMaintenanceForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaintenanceForm.Name = "btnMaintenanceForm";
            this.btnMaintenanceForm.Size = new System.Drawing.Size(145, 68);
            this.btnMaintenanceForm.TabIndex = 96;
            this.btnMaintenanceForm.Text = "&Maintenance";
            this.btnMaintenanceForm.UseVisualStyleBackColor = false;
            this.btnMaintenanceForm.Click += new System.EventHandler(this.btnMaintenanceForm_Click);
            // 
            // btnChequeIssuance
            // 
            this.btnChequeIssuance.BackColor = System.Drawing.Color.Red;
            this.btnChequeIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChequeIssuance.ForeColor = System.Drawing.Color.White;
            this.btnChequeIssuance.Location = new System.Drawing.Point(311, 86);
            this.btnChequeIssuance.Margin = new System.Windows.Forms.Padding(2);
            this.btnChequeIssuance.Name = "btnChequeIssuance";
            this.btnChequeIssuance.Size = new System.Drawing.Size(145, 68);
            this.btnChequeIssuance.TabIndex = 97;
            this.btnChequeIssuance.Text = "C&heque Issuance";
            this.btnChequeIssuance.UseVisualStyleBackColor = false;
            this.btnChequeIssuance.Click += new System.EventHandler(this.btnChequeIssuance_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Red;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(610, 86);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(145, 68);
            this.btnReports.TabIndex = 98;
            this.btnReports.Text = "R&eports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // UsageLabel
            // 
            this.UsageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsageLabel.AutoSize = true;
            this.UsageLabel.Location = new System.Drawing.Point(15, 579);
            this.UsageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsageLabel.Name = "UsageLabel";
            this.UsageLabel.Size = new System.Drawing.Size(50, 20);
            this.UsageLabel.TabIndex = 99;
            this.UsageLabel.Text = "Usage";
            // 
            // UsageTextBox
            // 
            this.UsageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsageTextBox.BackColor = System.Drawing.Color.White;
            this.UsageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsageTextBox.Location = new System.Drawing.Point(19, 601);
            this.UsageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsageTextBox.Name = "UsageTextBox";
            this.UsageTextBox.Size = new System.Drawing.Size(328, 27);
            this.UsageTextBox.TabIndex = 100;
            // 
            // ReceivedStoredByLabel
            // 
            this.ReceivedStoredByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReceivedStoredByLabel.AutoSize = true;
            this.ReceivedStoredByLabel.Location = new System.Drawing.Point(351, 579);
            this.ReceivedStoredByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceivedStoredByLabel.Name = "ReceivedStoredByLabel";
            this.ReceivedStoredByLabel.Size = new System.Drawing.Size(166, 20);
            this.ReceivedStoredByLabel.TabIndex = 101;
            this.ReceivedStoredByLabel.Text = "Received and Stored by";
            // 
            // ReceivedStoredByTextBox
            // 
            this.ReceivedStoredByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReceivedStoredByTextBox.BackColor = System.Drawing.Color.White;
            this.ReceivedStoredByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceivedStoredByTextBox.Location = new System.Drawing.Point(354, 601);
            this.ReceivedStoredByTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ReceivedStoredByTextBox.Name = "ReceivedStoredByTextBox";
            this.ReceivedStoredByTextBox.Size = new System.Drawing.Size(341, 27);
            this.ReceivedStoredByTextBox.TabIndex = 102;
            // 
            // InspectedAcceptedByTextBox
            // 
            this.InspectedAcceptedByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InspectedAcceptedByTextBox.BackColor = System.Drawing.Color.White;
            this.InspectedAcceptedByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InspectedAcceptedByTextBox.Location = new System.Drawing.Point(19, 653);
            this.InspectedAcceptedByTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InspectedAcceptedByTextBox.Name = "InspectedAcceptedByTextBox";
            this.InspectedAcceptedByTextBox.Size = new System.Drawing.Size(328, 27);
            this.InspectedAcceptedByTextBox.TabIndex = 104;
            // 
            // InspectedAcceptedByLabel
            // 
            this.InspectedAcceptedByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InspectedAcceptedByLabel.AutoSize = true;
            this.InspectedAcceptedByLabel.Location = new System.Drawing.Point(15, 630);
            this.InspectedAcceptedByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InspectedAcceptedByLabel.Name = "InspectedAcceptedByLabel";
            this.InspectedAcceptedByLabel.Size = new System.Drawing.Size(189, 20);
            this.InspectedAcceptedByLabel.TabIndex = 103;
            this.InspectedAcceptedByLabel.Text = "Inspected and Accepted by";
            // 
            // ApprovedByTextBox
            // 
            this.ApprovedByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApprovedByTextBox.BackColor = System.Drawing.Color.White;
            this.ApprovedByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApprovedByTextBox.Location = new System.Drawing.Point(354, 653);
            this.ApprovedByTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApprovedByTextBox.Name = "ApprovedByTextBox";
            this.ApprovedByTextBox.Size = new System.Drawing.Size(341, 27);
            this.ApprovedByTextBox.TabIndex = 106;
            // 
            // ApprovedByLabel
            // 
            this.ApprovedByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApprovedByLabel.AutoSize = true;
            this.ApprovedByLabel.Location = new System.Drawing.Point(351, 630);
            this.ApprovedByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApprovedByLabel.Name = "ApprovedByLabel";
            this.ApprovedByLabel.Size = new System.Drawing.Size(95, 20);
            this.ApprovedByLabel.TabIndex = 105;
            this.ApprovedByLabel.Text = "Approved by";
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.ckbxFilterByDrNumber);
            this.gbxFilter.Controls.Add(this.nudFilterByDrNumber);
            this.gbxFilter.Controls.Add(this.nudFilterBySiNumber);
            this.gbxFilter.Controls.Add(this.ckbxFilterBySiNumber);
            this.gbxFilter.Controls.Add(this.btnFilter);
            this.gbxFilter.Controls.Add(this.dtpFilterByDeliveryDate);
            this.gbxFilter.Controls.Add(this.ckbxFilterByDeliveryDate);
            this.gbxFilter.Controls.Add(this.cmbxFilterBySupplier);
            this.gbxFilter.Controls.Add(this.cmbxFilterByItem);
            this.gbxFilter.Controls.Add(this.ckbxFilterBySupplier);
            this.gbxFilter.Controls.Add(this.ckbxFilterByItem);
            this.gbxFilter.Location = new System.Drawing.Point(11, 159);
            this.gbxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Padding = new System.Windows.Forms.Padding(2);
            this.gbxFilter.Size = new System.Drawing.Size(1064, 130);
            this.gbxFilter.TabIndex = 107;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filtering";
            // 
            // ckbxFilterByDrNumber
            // 
            this.ckbxFilterByDrNumber.AutoSize = true;
            this.ckbxFilterByDrNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxFilterByDrNumber.Location = new System.Drawing.Point(469, 54);
            this.ckbxFilterByDrNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxFilterByDrNumber.Name = "ckbxFilterByDrNumber";
            this.ckbxFilterByDrNumber.Size = new System.Drawing.Size(81, 24);
            this.ckbxFilterByDrNumber.TabIndex = 112;
            this.ckbxFilterByDrNumber.Text = "D.R. No.";
            this.ckbxFilterByDrNumber.UseVisualStyleBackColor = true;
            this.ckbxFilterByDrNumber.CheckedChanged += new System.EventHandler(this.ckbxFilterByDrNumber_CheckedChanged);
            // 
            // nudFilterByDrNumber
            // 
            this.nudFilterByDrNumber.Enabled = false;
            this.nudFilterByDrNumber.Location = new System.Drawing.Point(554, 55);
            this.nudFilterByDrNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudFilterByDrNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudFilterByDrNumber.Name = "nudFilterByDrNumber";
            this.nudFilterByDrNumber.Size = new System.Drawing.Size(250, 27);
            this.nudFilterByDrNumber.TabIndex = 111;
            // 
            // nudFilterBySiNumber
            // 
            this.nudFilterBySiNumber.Enabled = false;
            this.nudFilterBySiNumber.Location = new System.Drawing.Point(112, 88);
            this.nudFilterBySiNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudFilterBySiNumber.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudFilterBySiNumber.Name = "nudFilterBySiNumber";
            this.nudFilterBySiNumber.Size = new System.Drawing.Size(275, 27);
            this.nudFilterBySiNumber.TabIndex = 110;
            this.nudFilterBySiNumber.ValueChanged += new System.EventHandler(this.nudFilterBySiNumber_ValueChanged);
            // 
            // ckbxFilterBySiNumber
            // 
            this.ckbxFilterBySiNumber.AutoSize = true;
            this.ckbxFilterBySiNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxFilterBySiNumber.Location = new System.Drawing.Point(35, 88);
            this.ckbxFilterBySiNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxFilterBySiNumber.Name = "ckbxFilterBySiNumber";
            this.ckbxFilterBySiNumber.Size = new System.Drawing.Size(73, 24);
            this.ckbxFilterBySiNumber.TabIndex = 109;
            this.ckbxFilterBySiNumber.Text = "S.I. No.";
            this.ckbxFilterBySiNumber.UseVisualStyleBackColor = true;
            this.ckbxFilterBySiNumber.CheckedChanged += new System.EventHandler(this.ckbxFilterBySiNumber_CheckedChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.BackColor = System.Drawing.Color.Red;
            this.btnFilter.Enabled = false;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(713, 86);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(91, 29);
            this.btnFilter.TabIndex = 108;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpFilterByDeliveryDate
            // 
            this.dtpFilterByDeliveryDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpFilterByDeliveryDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFilterByDeliveryDate.Enabled = false;
            this.dtpFilterByDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterByDeliveryDate.Location = new System.Drawing.Point(553, 23);
            this.dtpFilterByDeliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFilterByDeliveryDate.Name = "dtpFilterByDeliveryDate";
            this.dtpFilterByDeliveryDate.Size = new System.Drawing.Size(251, 27);
            this.dtpFilterByDeliveryDate.TabIndex = 7;
            // 
            // ckbxFilterByDeliveryDate
            // 
            this.ckbxFilterByDeliveryDate.AutoSize = true;
            this.ckbxFilterByDeliveryDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxFilterByDeliveryDate.Location = new System.Drawing.Point(431, 26);
            this.ckbxFilterByDeliveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxFilterByDeliveryDate.Name = "ckbxFilterByDeliveryDate";
            this.ckbxFilterByDeliveryDate.Size = new System.Drawing.Size(118, 24);
            this.ckbxFilterByDeliveryDate.TabIndex = 6;
            this.ckbxFilterByDeliveryDate.Text = "Delivery Date";
            this.ckbxFilterByDeliveryDate.UseVisualStyleBackColor = true;
            this.ckbxFilterByDeliveryDate.CheckedChanged += new System.EventHandler(this.ckbxFilterByDeliveryDate_CheckedChanged);
            // 
            // cmbxFilterBySupplier
            // 
            this.cmbxFilterBySupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFilterBySupplier.Enabled = false;
            this.cmbxFilterBySupplier.FormattingEnabled = true;
            this.cmbxFilterBySupplier.Location = new System.Drawing.Point(112, 56);
            this.cmbxFilterBySupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxFilterBySupplier.Name = "cmbxFilterBySupplier";
            this.cmbxFilterBySupplier.Size = new System.Drawing.Size(275, 28);
            this.cmbxFilterBySupplier.TabIndex = 3;
            // 
            // cmbxFilterByItem
            // 
            this.cmbxFilterByItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFilterByItem.Enabled = false;
            this.cmbxFilterByItem.FormattingEnabled = true;
            this.cmbxFilterByItem.Location = new System.Drawing.Point(112, 24);
            this.cmbxFilterByItem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxFilterByItem.Name = "cmbxFilterByItem";
            this.cmbxFilterByItem.Size = new System.Drawing.Size(275, 28);
            this.cmbxFilterByItem.TabIndex = 2;
            // 
            // ckbxFilterBySupplier
            // 
            this.ckbxFilterBySupplier.AutoSize = true;
            this.ckbxFilterBySupplier.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxFilterBySupplier.Location = new System.Drawing.Point(23, 59);
            this.ckbxFilterBySupplier.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxFilterBySupplier.Name = "ckbxFilterBySupplier";
            this.ckbxFilterBySupplier.Size = new System.Drawing.Size(83, 24);
            this.ckbxFilterBySupplier.TabIndex = 1;
            this.ckbxFilterBySupplier.Text = "Supplier";
            this.ckbxFilterBySupplier.UseVisualStyleBackColor = true;
            this.ckbxFilterBySupplier.CheckedChanged += new System.EventHandler(this.ckbxFilterBySupplier_CheckedChanged);
            // 
            // ckbxFilterByItem
            // 
            this.ckbxFilterByItem.AutoSize = true;
            this.ckbxFilterByItem.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbxFilterByItem.Location = new System.Drawing.Point(4, 26);
            this.ckbxFilterByItem.Margin = new System.Windows.Forms.Padding(2);
            this.ckbxFilterByItem.Name = "ckbxFilterByItem";
            this.ckbxFilterByItem.Size = new System.Drawing.Size(104, 24);
            this.ckbxFilterByItem.TabIndex = 0;
            this.ckbxFilterByItem.Text = "Description";
            this.ckbxFilterByItem.UseVisualStyleBackColor = true;
            this.ckbxFilterByItem.CheckedChanged += new System.EventHandler(this.ckbxFilterByItem_CheckedChanged);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(749, 525);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(86, 20);
            this.lblGrandTotal.TabIndex = 108;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // tbxGrandTotal
            // 
            this.tbxGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrandTotal.ForeColor = System.Drawing.Color.Lime;
            this.tbxGrandTotal.Location = new System.Drawing.Point(839, 519);
            this.tbxGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGrandTotal.Name = "tbxGrandTotal";
            this.tbxGrandTotal.ReadOnly = true;
            this.tbxGrandTotal.Size = new System.Drawing.Size(236, 33);
            this.tbxGrandTotal.TabIndex = 109;
            this.tbxGrandTotal.Text = "0.00";
            this.tbxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxGrandTotal.TextChanged += new System.EventHandler(this.tbxGrandTotal_TextChanged);
            // 
            // lblReprintMris
            // 
            this.lblReprintMris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReprintMris.AutoSize = true;
            this.lblReprintMris.Location = new System.Drawing.Point(7, 532);
            this.lblReprintMris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReprintMris.Name = "lblReprintMris";
            this.lblReprintMris.Size = new System.Drawing.Size(95, 20);
            this.lblReprintMris.TabIndex = 110;
            this.lblReprintMris.Text = "Reprint MRIS";
            // 
            // tbxReprintMris
            // 
            this.tbxReprintMris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxReprintMris.BackColor = System.Drawing.Color.White;
            this.tbxReprintMris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxReprintMris.Location = new System.Drawing.Point(106, 530);
            this.tbxReprintMris.Margin = new System.Windows.Forms.Padding(2);
            this.tbxReprintMris.Name = "tbxReprintMris";
            this.tbxReprintMris.Size = new System.Drawing.Size(240, 27);
            this.tbxReprintMris.TabIndex = 111;
            // 
            // btnReprintMris
            // 
            this.btnReprintMris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReprintMris.BackColor = System.Drawing.Color.Red;
            this.btnReprintMris.FlatAppearance.BorderSize = 0;
            this.btnReprintMris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprintMris.ForeColor = System.Drawing.Color.White;
            this.btnReprintMris.Location = new System.Drawing.Point(350, 530);
            this.btnReprintMris.Margin = new System.Windows.Forms.Padding(2);
            this.btnReprintMris.Name = "btnReprintMris";
            this.btnReprintMris.Size = new System.Drawing.Size(87, 27);
            this.btnReprintMris.TabIndex = 112;
            this.btnReprintMris.Text = "Reprint";
            this.btnReprintMris.UseVisualStyleBackColor = false;
            this.btnReprintMris.Click += new System.EventHandler(this.btnReprintMris_Click);
            // 
            // lblChangeAccountDescription
            // 
            this.lblChangeAccountDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangeAccountDescription.AutoSize = true;
            this.lblChangeAccountDescription.Location = new System.Drawing.Point(1134, 502);
            this.lblChangeAccountDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeAccountDescription.Name = "lblChangeAccountDescription";
            this.lblChangeAccountDescription.Size = new System.Drawing.Size(310, 20);
            this.lblChangeAccountDescription.TabIndex = 113;
            this.lblChangeAccountDescription.Text = "Change Account Description of Selected Item";
            // 
            // cmbxExpense
            // 
            this.cmbxExpense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxExpense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxExpense.FormattingEnabled = true;
            this.cmbxExpense.Location = new System.Drawing.Point(1138, 524);
            this.cmbxExpense.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxExpense.Name = "cmbxExpense";
            this.cmbxExpense.Size = new System.Drawing.Size(360, 28);
            this.cmbxExpense.TabIndex = 113;
            // 
            // btnChangeAccountDescription
            // 
            this.btnChangeAccountDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeAccountDescription.BackColor = System.Drawing.Color.Red;
            this.btnChangeAccountDescription.FlatAppearance.BorderSize = 0;
            this.btnChangeAccountDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeAccountDescription.ForeColor = System.Drawing.Color.White;
            this.btnChangeAccountDescription.Location = new System.Drawing.Point(1502, 524);
            this.btnChangeAccountDescription.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeAccountDescription.Name = "btnChangeAccountDescription";
            this.btnChangeAccountDescription.Size = new System.Drawing.Size(87, 28);
            this.btnChangeAccountDescription.TabIndex = 114;
            this.btnChangeAccountDescription.Text = "Done";
            this.btnChangeAccountDescription.UseVisualStyleBackColor = false;
            this.btnChangeAccountDescription.Click += new System.EventHandler(this.btnChangeAccountDescription_Click);
            // 
            // btnRemoveExpenseClassification
            // 
            this.btnRemoveExpenseClassification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveExpenseClassification.BackColor = System.Drawing.Color.Red;
            this.btnRemoveExpenseClassification.FlatAppearance.BorderSize = 0;
            this.btnRemoveExpenseClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveExpenseClassification.ForeColor = System.Drawing.Color.White;
            this.btnRemoveExpenseClassification.Location = new System.Drawing.Point(1363, 159);
            this.btnRemoveExpenseClassification.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveExpenseClassification.Name = "btnRemoveExpenseClassification";
            this.btnRemoveExpenseClassification.Size = new System.Drawing.Size(226, 28);
            this.btnRemoveExpenseClassification.TabIndex = 115;
            this.btnRemoveExpenseClassification.Text = "Remove Expense Classification";
            this.btnRemoveExpenseClassification.UseVisualStyleBackColor = false;
            this.btnRemoveExpenseClassification.Click += new System.EventHandler(this.btnRemoveExpenseClassification_Click);
            // 
            // btnInsertToQueue
            // 
            this.btnInsertToQueue.BackColor = System.Drawing.Color.Black;
            this.btnInsertToQueue.BackgroundImage = global::Citicon.Payables.Properties.Resources.right_arrow;
            this.btnInsertToQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsertToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToQueue.ForeColor = System.Drawing.Color.White;
            this.btnInsertToQueue.Location = new System.Drawing.Point(1079, 322);
            this.btnInsertToQueue.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertToQueue.Name = "btnInsertToQueue";
            this.btnInsertToQueue.Size = new System.Drawing.Size(55, 55);
            this.btnInsertToQueue.TabIndex = 74;
            this.btnInsertToQueue.UseVisualStyleBackColor = false;
            this.btnInsertToQueue.Click += new System.EventHandler(this.btnInsertToQueue_Click);
            // 
            // btnRemoveFromQueue
            // 
            this.btnRemoveFromQueue.BackColor = System.Drawing.Color.Black;
            this.btnRemoveFromQueue.BackgroundImage = global::Citicon.Payables.Properties.Resources.left_arrow;
            this.btnRemoveFromQueue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveFromQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromQueue.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromQueue.Location = new System.Drawing.Point(1079, 387);
            this.btnRemoveFromQueue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFromQueue.Name = "btnRemoveFromQueue";
            this.btnRemoveFromQueue.Size = new System.Drawing.Size(55, 55);
            this.btnRemoveFromQueue.TabIndex = 73;
            this.btnRemoveFromQueue.UseVisualStyleBackColor = false;
            this.btnRemoveFromQueue.Click += new System.EventHandler(this.btnRemoveFromQueue_Click);
            // 
            // lblAccountBranch
            // 
            this.lblAccountBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAccountBranch.AutoSize = true;
            this.lblAccountBranch.Location = new System.Drawing.Point(1134, 450);
            this.lblAccountBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountBranch.Name = "lblAccountBranch";
            this.lblAccountBranch.Size = new System.Drawing.Size(54, 20);
            this.lblAccountBranch.TabIndex = 116;
            this.lblAccountBranch.Text = "Branch";
            // 
            // cmbxAccountBranch
            // 
            this.cmbxAccountBranch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbxAccountBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAccountBranch.FormattingEnabled = true;
            this.cmbxAccountBranch.Location = new System.Drawing.Point(1138, 472);
            this.cmbxAccountBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxAccountBranch.Name = "cmbxAccountBranch";
            this.cmbxAccountBranch.Size = new System.Drawing.Size(229, 28);
            this.cmbxAccountBranch.TabIndex = 117;
            // 
            // cmbxAccountCompany
            // 
            this.cmbxAccountCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbxAccountCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAccountCompany.FormattingEnabled = true;
            this.cmbxAccountCompany.Location = new System.Drawing.Point(1371, 472);
            this.cmbxAccountCompany.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxAccountCompany.Name = "cmbxAccountCompany";
            this.cmbxAccountCompany.Size = new System.Drawing.Size(218, 28);
            this.cmbxAccountCompany.TabIndex = 119;
            // 
            // lblAccountCompany
            // 
            this.lblAccountCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAccountCompany.AutoSize = true;
            this.lblAccountCompany.Location = new System.Drawing.Point(1367, 450);
            this.lblAccountCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountCompany.Name = "lblAccountCompany";
            this.lblAccountCompany.Size = new System.Drawing.Size(72, 20);
            this.lblAccountCompany.TabIndex = 118;
            this.lblAccountCompany.Text = "Company";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1597, 691);
            this.Controls.Add(this.cmbxAccountCompany);
            this.Controls.Add(this.lblAccountCompany);
            this.Controls.Add(this.cmbxAccountBranch);
            this.Controls.Add(this.lblAccountBranch);
            this.Controls.Add(this.btnRemoveExpenseClassification);
            this.Controls.Add(this.btnChangeAccountDescription);
            this.Controls.Add(this.cmbxExpense);
            this.Controls.Add(this.lblChangeAccountDescription);
            this.Controls.Add(this.btnReprintMris);
            this.Controls.Add(this.tbxReprintMris);
            this.Controls.Add(this.lblReprintMris);
            this.Controls.Add(this.tbxGrandTotal);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.ApprovedByTextBox);
            this.Controls.Add(this.ApprovedByLabel);
            this.Controls.Add(this.InspectedAcceptedByTextBox);
            this.Controls.Add(this.InspectedAcceptedByLabel);
            this.Controls.Add(this.ReceivedStoredByTextBox);
            this.Controls.Add(this.ReceivedStoredByLabel);
            this.Controls.Add(this.UsageTextBox);
            this.Controls.Add(this.UsageLabel);
            this.Controls.Add(this.btnReports);
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
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterByDrNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterBySiNumber)).EndInit();
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
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label UsageLabel;
        private System.Windows.Forms.TextBox UsageTextBox;
        private System.Windows.Forms.Label ReceivedStoredByLabel;
        private System.Windows.Forms.TextBox ReceivedStoredByTextBox;
        private System.Windows.Forms.TextBox InspectedAcceptedByTextBox;
        private System.Windows.Forms.Label InspectedAcceptedByLabel;
        private System.Windows.Forms.TextBox ApprovedByTextBox;
        private System.Windows.Forms.Label ApprovedByLabel;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.CheckBox ckbxFilterByItem;
        private System.Windows.Forms.ComboBox cmbxFilterBySupplier;
        private System.Windows.Forms.ComboBox cmbxFilterByItem;
        private System.Windows.Forms.CheckBox ckbxFilterBySupplier;
        private System.Windows.Forms.CheckBox ckbxFilterByDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpFilterByDeliveryDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox tbxGrandTotal;
        private System.Windows.Forms.NumericUpDown nudFilterBySiNumber;
        private System.Windows.Forms.CheckBox ckbxFilterBySiNumber;
        private System.Windows.Forms.NumericUpDown nudFilterByDrNumber;
        private System.Windows.Forms.CheckBox ckbxFilterByDrNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockSiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDrNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockRemainingDayCount;
        private System.Windows.Forms.Label lblReprintMris;
        private System.Windows.Forms.TextBox tbxReprintMris;
        private System.Windows.Forms.Button btnReprintMris;
        private System.Windows.Forms.Label lblChangeAccountDescription;
        private System.Windows.Forms.ComboBox cmbxExpense;
        private System.Windows.Forms.Button btnChangeAccountDescription;
        private System.Windows.Forms.Button btnRemoveExpenseClassification;
        private System.Windows.Forms.Label lblAccountBranch;
        private System.Windows.Forms.ComboBox cmbxAccountBranch;
        private System.Windows.Forms.ComboBox cmbxAccountCompany;
        private System.Windows.Forms.Label lblAccountCompany;
    }
}