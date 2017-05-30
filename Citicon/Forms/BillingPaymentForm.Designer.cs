namespace Citicon.Forms
{
    partial class BillingPaymentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPaymentForm));
            this.lblClient = new System.Windows.Forms.Label();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.dgvSalesInvoices = new System.Windows.Forms.DataGridView();
            this.colSiNumber_Include = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiNumber_TotalAmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectSalesInvoice = new System.Windows.Forms.Label();
            this.cmbxClients = new System.Windows.Forms.ComboBox();
            this.lblClient_Address = new System.Windows.Forms.Label();
            this.tbxClient_Address = new System.Windows.Forms.TextBox();
            this.cmbxProjects = new System.Windows.Forms.ComboBox();
            this.tbxProject_Location = new System.Windows.Forms.TextBox();
            this.lblProject_Location = new System.Windows.Forms.Label();
            this.dgvBillings = new System.Windows.Forms.DataGridView();
            this.colBilling_Include = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_SiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmountPaid = new System.Windows.Forms.Label();
            this.nudTotalAmountPaid = new System.Windows.Forms.NumericUpDown();
            this.lblRunningBalance = new System.Windows.Forms.Label();
            this.nudRunningBalance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayCheckedBillings = new System.Windows.Forms.Button();
            this.lblTotalAmountTobePaid = new System.Windows.Forms.Label();
            this.nudTotalAmountToBePaid = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountPaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountToBePaid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(8, 9);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(95, 21);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Select Client";
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Location = new System.Drawing.Point(8, 65);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(103, 21);
            this.lblSelectProject.TabIndex = 2;
            this.lblSelectProject.Text = "Select Project";
            // 
            // dgvSalesInvoices
            // 
            this.dgvSalesInvoices.AllowUserToAddRows = false;
            this.dgvSalesInvoices.AllowUserToDeleteRows = false;
            this.dgvSalesInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSalesInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSalesInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalesInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvSalesInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesInvoices.ColumnHeadersHeight = 40;
            this.dgvSalesInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSiNumber_Include,
            this.colSiNumber,
            this.colSiNumber_TotalAmountDue});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesInvoices.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesInvoices.EnableHeadersVisualStyles = false;
            this.dgvSalesInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvSalesInvoices.Location = new System.Drawing.Point(12, 145);
            this.dgvSalesInvoices.MultiSelect = false;
            this.dgvSalesInvoices.Name = "dgvSalesInvoices";
            this.dgvSalesInvoices.RowHeadersVisible = false;
            this.dgvSalesInvoices.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSalesInvoices.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSalesInvoices.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSalesInvoices.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvSalesInvoices.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSalesInvoices.RowTemplate.Height = 30;
            this.dgvSalesInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesInvoices.Size = new System.Drawing.Size(452, 597);
            this.dgvSalesInvoices.TabIndex = 4;
            this.dgvSalesInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesInvoices_CellValueChanged);
            this.dgvSalesInvoices.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSalesInvoices_CurrentCellDirtyStateChanged);
            // 
            // colSiNumber_Include
            // 
            this.colSiNumber_Include.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSiNumber_Include.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSiNumber_Include.HeaderText = "Include";
            this.colSiNumber_Include.Name = "colSiNumber_Include";
            this.colSiNumber_Include.Width = 84;
            // 
            // colSiNumber
            // 
            this.colSiNumber.HeaderText = "S.I. No";
            this.colSiNumber.MinimumWidth = 150;
            this.colSiNumber.Name = "colSiNumber";
            this.colSiNumber.ReadOnly = true;
            this.colSiNumber.Width = 150;
            // 
            // colSiNumber_TotalAmountDue
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colSiNumber_TotalAmountDue.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSiNumber_TotalAmountDue.HeaderText = "Total Amount Due";
            this.colSiNumber_TotalAmountDue.MinimumWidth = 200;
            this.colSiNumber_TotalAmountDue.Name = "colSiNumber_TotalAmountDue";
            this.colSiNumber_TotalAmountDue.ReadOnly = true;
            this.colSiNumber_TotalAmountDue.Width = 200;
            // 
            // lblSelectSalesInvoice
            // 
            this.lblSelectSalesInvoice.AutoSize = true;
            this.lblSelectSalesInvoice.Location = new System.Drawing.Point(8, 121);
            this.lblSelectSalesInvoice.Name = "lblSelectSalesInvoice";
            this.lblSelectSalesInvoice.Size = new System.Drawing.Size(224, 21);
            this.lblSelectSalesInvoice.TabIndex = 5;
            this.lblSelectSalesInvoice.Text = "Check Sales Invoices to include";
            // 
            // cmbxClients
            // 
            this.cmbxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxClients.FormattingEnabled = true;
            this.cmbxClients.Location = new System.Drawing.Point(12, 33);
            this.cmbxClients.Name = "cmbxClients";
            this.cmbxClients.Size = new System.Drawing.Size(452, 29);
            this.cmbxClients.TabIndex = 6;
            this.cmbxClients.SelectedIndexChanged += new System.EventHandler(this.cmbxClients_SelectedIndexChanged);
            // 
            // lblClient_Address
            // 
            this.lblClient_Address.AutoSize = true;
            this.lblClient_Address.Location = new System.Drawing.Point(466, 9);
            this.lblClient_Address.Name = "lblClient_Address";
            this.lblClient_Address.Size = new System.Drawing.Size(66, 21);
            this.lblClient_Address.TabIndex = 7;
            this.lblClient_Address.Text = "Address";
            // 
            // tbxClient_Address
            // 
            this.tbxClient_Address.Location = new System.Drawing.Point(470, 33);
            this.tbxClient_Address.Name = "tbxClient_Address";
            this.tbxClient_Address.ReadOnly = true;
            this.tbxClient_Address.Size = new System.Drawing.Size(384, 29);
            this.tbxClient_Address.TabIndex = 8;
            // 
            // cmbxProjects
            // 
            this.cmbxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxProjects.FormattingEnabled = true;
            this.cmbxProjects.Location = new System.Drawing.Point(12, 89);
            this.cmbxProjects.Name = "cmbxProjects";
            this.cmbxProjects.Size = new System.Drawing.Size(452, 29);
            this.cmbxProjects.TabIndex = 9;
            this.cmbxProjects.SelectedIndexChanged += new System.EventHandler(this.cmbxProjects_SelectedIndexChanged);
            // 
            // tbxProject_Location
            // 
            this.tbxProject_Location.Location = new System.Drawing.Point(470, 89);
            this.tbxProject_Location.Name = "tbxProject_Location";
            this.tbxProject_Location.ReadOnly = true;
            this.tbxProject_Location.Size = new System.Drawing.Size(384, 29);
            this.tbxProject_Location.TabIndex = 11;
            // 
            // lblProject_Location
            // 
            this.lblProject_Location.AutoSize = true;
            this.lblProject_Location.Location = new System.Drawing.Point(466, 65);
            this.lblProject_Location.Name = "lblProject_Location";
            this.lblProject_Location.Size = new System.Drawing.Size(69, 21);
            this.lblProject_Location.TabIndex = 10;
            this.lblProject_Location.Text = "Location";
            // 
            // dgvBillings
            // 
            this.dgvBillings.AllowUserToAddRows = false;
            this.dgvBillings.AllowUserToDeleteRows = false;
            this.dgvBillings.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBillings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBillings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBillings.ColumnHeadersHeight = 40;
            this.dgvBillings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBilling_Include,
            this.colBilling_SiNumber,
            this.colBilling,
            this.colBilling_AmountDue,
            this.colBilling_AmountPaid,
            this.colBilling_SubTotal});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillings.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBillings.EnableHeadersVisualStyles = false;
            this.dgvBillings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBillings.Location = new System.Drawing.Point(470, 145);
            this.dgvBillings.MultiSelect = false;
            this.dgvBillings.Name = "dgvBillings";
            this.dgvBillings.RowHeadersVisible = false;
            this.dgvBillings.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillings.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillings.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBillings.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.RowTemplate.Height = 30;
            this.dgvBillings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillings.Size = new System.Drawing.Size(1002, 597);
            this.dgvBillings.TabIndex = 12;
            this.dgvBillings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillings_CellValueChanged);
            this.dgvBillings.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvBillings_CurrentCellDirtyStateChanged);
            this.dgvBillings.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvBillings_RowsRemoved);
            // 
            // colBilling_Include
            // 
            this.colBilling_Include.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colBilling_Include.DefaultCellStyle = dataGridViewCellStyle8;
            this.colBilling_Include.HeaderText = "Include";
            this.colBilling_Include.Name = "colBilling_Include";
            this.colBilling_Include.Width = 84;
            // 
            // colBilling_SiNumber
            // 
            this.colBilling_SiNumber.HeaderText = "S.I. No.";
            this.colBilling_SiNumber.Name = "colBilling_SiNumber";
            this.colBilling_SiNumber.Width = 81;
            // 
            // colBilling
            // 
            this.colBilling.HeaderText = "Billing No.";
            this.colBilling.MinimumWidth = 100;
            this.colBilling.Name = "colBilling";
            this.colBilling.ReadOnly = true;
            this.colBilling.Width = 105;
            // 
            // colBilling_AmountDue
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.colBilling_AmountDue.DefaultCellStyle = dataGridViewCellStyle9;
            this.colBilling_AmountDue.HeaderText = "Amount Due";
            this.colBilling_AmountDue.MinimumWidth = 150;
            this.colBilling_AmountDue.Name = "colBilling_AmountDue";
            this.colBilling_AmountDue.ReadOnly = true;
            this.colBilling_AmountDue.Width = 150;
            // 
            // colBilling_AmountPaid
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.colBilling_AmountPaid.DefaultCellStyle = dataGridViewCellStyle10;
            this.colBilling_AmountPaid.HeaderText = "Amount Paid";
            this.colBilling_AmountPaid.MinimumWidth = 150;
            this.colBilling_AmountPaid.Name = "colBilling_AmountPaid";
            this.colBilling_AmountPaid.ReadOnly = true;
            this.colBilling_AmountPaid.Width = 150;
            // 
            // colBilling_SubTotal
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.colBilling_SubTotal.DefaultCellStyle = dataGridViewCellStyle11;
            this.colBilling_SubTotal.HeaderText = "Sub-Total";
            this.colBilling_SubTotal.MinimumWidth = 150;
            this.colBilling_SubTotal.Name = "colBilling_SubTotal";
            this.colBilling_SubTotal.ReadOnly = true;
            this.colBilling_SubTotal.Width = 150;
            // 
            // lblTotalAmountPaid
            // 
            this.lblTotalAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountPaid.AutoSize = true;
            this.lblTotalAmountPaid.Location = new System.Drawing.Point(1179, 9);
            this.lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            this.lblTotalAmountPaid.Size = new System.Drawing.Size(135, 21);
            this.lblTotalAmountPaid.TabIndex = 13;
            this.lblTotalAmountPaid.Text = "Total Amount Paid";
            // 
            // nudTotalAmountPaid
            // 
            this.nudTotalAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTotalAmountPaid.DecimalPlaces = 2;
            this.nudTotalAmountPaid.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotalAmountPaid.InterceptArrowKeys = false;
            this.nudTotalAmountPaid.Location = new System.Drawing.Point(1183, 33);
            this.nudTotalAmountPaid.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTotalAmountPaid.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudTotalAmountPaid.Name = "nudTotalAmountPaid";
            this.nudTotalAmountPaid.ReadOnly = true;
            this.nudTotalAmountPaid.Size = new System.Drawing.Size(289, 29);
            this.nudTotalAmountPaid.TabIndex = 14;
            this.nudTotalAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmountPaid.ThousandsSeparator = true;
            // 
            // lblRunningBalance
            // 
            this.lblRunningBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRunningBalance.AutoSize = true;
            this.lblRunningBalance.Location = new System.Drawing.Point(1179, 65);
            this.lblRunningBalance.Name = "lblRunningBalance";
            this.lblRunningBalance.Size = new System.Drawing.Size(126, 21);
            this.lblRunningBalance.TabIndex = 15;
            this.lblRunningBalance.Text = "Running Balance";
            // 
            // nudRunningBalance
            // 
            this.nudRunningBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRunningBalance.DecimalPlaces = 2;
            this.nudRunningBalance.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRunningBalance.InterceptArrowKeys = false;
            this.nudRunningBalance.Location = new System.Drawing.Point(1183, 89);
            this.nudRunningBalance.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRunningBalance.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudRunningBalance.Name = "nudRunningBalance";
            this.nudRunningBalance.ReadOnly = true;
            this.nudRunningBalance.Size = new System.Drawing.Size(289, 29);
            this.nudRunningBalance.TabIndex = 16;
            this.nudRunningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRunningBalance.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Check Billings to include";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(1372, 748);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPayCheckedBillings
            // 
            this.btnPayCheckedBillings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayCheckedBillings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPayCheckedBillings.Enabled = false;
            this.btnPayCheckedBillings.FlatAppearance.BorderSize = 0;
            this.btnPayCheckedBillings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCheckedBillings.ForeColor = System.Drawing.Color.White;
            this.btnPayCheckedBillings.Location = new System.Drawing.Point(1191, 748);
            this.btnPayCheckedBillings.Name = "btnPayCheckedBillings";
            this.btnPayCheckedBillings.Size = new System.Drawing.Size(175, 50);
            this.btnPayCheckedBillings.TabIndex = 18;
            this.btnPayCheckedBillings.Text = "Pay checked Billings";
            this.btnPayCheckedBillings.UseVisualStyleBackColor = false;
            this.btnPayCheckedBillings.Click += new System.EventHandler(this.btnPayCheckedBillings_Click);
            // 
            // lblTotalAmountTobePaid
            // 
            this.lblTotalAmountTobePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountTobePaid.AutoSize = true;
            this.lblTotalAmountTobePaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountTobePaid.Location = new System.Drawing.Point(465, 750);
            this.lblTotalAmountTobePaid.Name = "lblTotalAmountTobePaid";
            this.lblTotalAmountTobePaid.Size = new System.Drawing.Size(365, 45);
            this.lblTotalAmountTobePaid.TabIndex = 20;
            this.lblTotalAmountTobePaid.Text = "Total Amount to be Paid";
            // 
            // nudTotalAmountToBePaid
            // 
            this.nudTotalAmountToBePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTotalAmountToBePaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudTotalAmountToBePaid.DecimalPlaces = 2;
            this.nudTotalAmountToBePaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalAmountToBePaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudTotalAmountToBePaid.Location = new System.Drawing.Point(836, 748);
            this.nudTotalAmountToBePaid.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTotalAmountToBePaid.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudTotalAmountToBePaid.Name = "nudTotalAmountToBePaid";
            this.nudTotalAmountToBePaid.ReadOnly = true;
            this.nudTotalAmountToBePaid.Size = new System.Drawing.Size(349, 50);
            this.nudTotalAmountToBePaid.TabIndex = 21;
            this.nudTotalAmountToBePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmountToBePaid.ThousandsSeparator = true;
            this.nudTotalAmountToBePaid.ValueChanged += new System.EventHandler(this.nudTotalAmountToBePaid_ValueChanged);
            // 
            // BillingPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 810);
            this.Controls.Add(this.nudTotalAmountToBePaid);
            this.Controls.Add(this.lblTotalAmountTobePaid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayCheckedBillings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRunningBalance);
            this.Controls.Add(this.lblRunningBalance);
            this.Controls.Add(this.nudTotalAmountPaid);
            this.Controls.Add(this.lblTotalAmountPaid);
            this.Controls.Add(this.dgvBillings);
            this.Controls.Add(this.tbxProject_Location);
            this.Controls.Add(this.lblProject_Location);
            this.Controls.Add(this.cmbxProjects);
            this.Controls.Add(this.tbxClient_Address);
            this.Controls.Add(this.lblClient_Address);
            this.Controls.Add(this.cmbxClients);
            this.Controls.Add(this.lblSelectSalesInvoice);
            this.Controls.Add(this.dgvSalesInvoices);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.lblClient);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillingPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingPaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountPaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRunningBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountToBePaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.DataGridView dgvSalesInvoices;
        private System.Windows.Forms.Label lblSelectSalesInvoice;
        private System.Windows.Forms.ComboBox cmbxClients;
        private System.Windows.Forms.Label lblClient_Address;
        private System.Windows.Forms.TextBox tbxClient_Address;
        private System.Windows.Forms.ComboBox cmbxProjects;
        private System.Windows.Forms.TextBox tbxProject_Location;
        private System.Windows.Forms.Label lblProject_Location;
        private System.Windows.Forms.DataGridView dgvBillings;
        private System.Windows.Forms.Label lblTotalAmountPaid;
        private System.Windows.Forms.NumericUpDown nudTotalAmountPaid;
        private System.Windows.Forms.Label lblRunningBalance;
        private System.Windows.Forms.NumericUpDown nudRunningBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayCheckedBillings;
        private System.Windows.Forms.Label lblTotalAmountTobePaid;
        private System.Windows.Forms.NumericUpDown nudTotalAmountToBePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiNumber_Include;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiNumber_TotalAmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_Include;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_SiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_SubTotal;
    }
}