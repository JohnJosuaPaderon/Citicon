namespace Citicon.Forms
{
    partial class BillingPaymentConfirmationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingPaymentConfirmationForm));
            this.dgvBillings = new System.Windows.Forms.DataGridView();
            this.colBilling_SiNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AllocatedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmountToBePaid = new System.Windows.Forms.Label();
            this.nudTotalAmountToBePaid = new System.Windows.Forms.NumericUpDown();
            this.lblSelectPaymentType = new System.Windows.Forms.Label();
            this.pnlSelectPaymentType = new System.Windows.Forms.Panel();
            this.rbtnPaymentType_Cheque = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentType_Cash = new System.Windows.Forms.RadioButton();
            this.lblEnterAmountPaid = new System.Windows.Forms.Label();
            this.nudAmountPaid = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayCheckedBillings = new System.Windows.Forms.Button();
            this.pnlVatIncluded = new System.Windows.Forms.Panel();
            this.nudVatIncluded_TotalVat = new System.Windows.Forms.NumericUpDown();
            this.lblVatIncluded_TotalVat = new System.Windows.Forms.Label();
            this.nudVatIncluded_Ewt = new System.Windows.Forms.NumericUpDown();
            this.lblVatIncluded_Ewt = new System.Windows.Forms.Label();
            this.nudVatIncluded_VatLess = new System.Windows.Forms.NumericUpDown();
            this.lblVatIncluded_VatLess = new System.Windows.Forms.Label();
            this.ckbxVatIncluded = new System.Windows.Forms.CheckBox();
            this.gbxPaymentAllocation = new System.Windows.Forms.GroupBox();
            this.nudRemaining = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaymentAllocation_Done = new System.Windows.Forms.Button();
            this.nudPaymentAllocation_AllocatedAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPaymentAllocation_AllocatedAmount = new System.Windows.Forms.Label();
            this.lblPaymentAllocation_PaymentMode = new System.Windows.Forms.Label();
            this.pnlPaymentAllocation_PaymentMode = new System.Windows.Forms.Panel();
            this.rbtnPaymentAllocation_PaymentMode_Partial = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentAllocation_PaymentMode_Full = new System.Windows.Forms.RadioButton();
            this.tbxPaymentAllocation_BillingNumber = new System.Windows.Forms.TextBox();
            this.lblPaymentAllocation_BillingNo = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.nudAmountDue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountToBePaid)).BeginInit();
            this.pnlSelectPaymentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPaid)).BeginInit();
            this.pnlVatIncluded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_TotalVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_Ewt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_VatLess)).BeginInit();
            this.gbxPaymentAllocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemaining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAllocation_AllocatedAmount)).BeginInit();
            this.pnlPaymentAllocation_PaymentMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillings
            // 
            this.dgvBillings.AllowUserToAddRows = false;
            this.dgvBillings.AllowUserToDeleteRows = false;
            this.dgvBillings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBillings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBillings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBillings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillings.ColumnHeadersHeight = 40;
            this.dgvBillings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBilling_SiNumber,
            this.colBilling,
            this.colBilling_AmountDue,
            this.colBilling_AmountPaid,
            this.colBilling_SubTotal,
            this.colBilling_AllocatedAmount});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillings.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBillings.EnableHeadersVisualStyles = false;
            this.dgvBillings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBillings.Location = new System.Drawing.Point(12, 12);
            this.dgvBillings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillings.MultiSelect = false;
            this.dgvBillings.Name = "dgvBillings";
            this.dgvBillings.RowHeadersVisible = false;
            this.dgvBillings.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillings.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillings.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvBillings.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvBillings.RowTemplate.Height = 30;
            this.dgvBillings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillings.Size = new System.Drawing.Size(843, 687);
            this.dgvBillings.TabIndex = 13;
            this.dgvBillings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillings_CellValueChanged);
            this.dgvBillings.SelectionChanged += new System.EventHandler(this.dgvBillings_SelectionChanged);
            // 
            // colBilling_SiNumber
            // 
            this.colBilling_SiNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBilling_SiNumber.HeaderText = "S.I. No.";
            this.colBilling_SiNumber.Name = "colBilling_SiNumber";
            this.colBilling_SiNumber.ReadOnly = true;
            this.colBilling_SiNumber.Width = 81;
            // 
            // colBilling
            // 
            this.colBilling.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBilling.HeaderText = "Billing No.";
            this.colBilling.MinimumWidth = 100;
            this.colBilling.Name = "colBilling";
            this.colBilling.ReadOnly = true;
            this.colBilling.Width = 105;
            // 
            // colBilling_AmountDue
            // 
            this.colBilling_AmountDue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colBilling_AmountDue.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBilling_AmountDue.HeaderText = "Amount Due";
            this.colBilling_AmountDue.MinimumWidth = 150;
            this.colBilling_AmountDue.Name = "colBilling_AmountDue";
            this.colBilling_AmountDue.ReadOnly = true;
            this.colBilling_AmountDue.Width = 150;
            // 
            // colBilling_AmountPaid
            // 
            this.colBilling_AmountPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colBilling_AmountPaid.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBilling_AmountPaid.HeaderText = "Amount Paid";
            this.colBilling_AmountPaid.MinimumWidth = 150;
            this.colBilling_AmountPaid.Name = "colBilling_AmountPaid";
            this.colBilling_AmountPaid.ReadOnly = true;
            this.colBilling_AmountPaid.Width = 150;
            // 
            // colBilling_SubTotal
            // 
            this.colBilling_SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.colBilling_SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colBilling_SubTotal.HeaderText = "Sub-Total";
            this.colBilling_SubTotal.MinimumWidth = 150;
            this.colBilling_SubTotal.Name = "colBilling_SubTotal";
            this.colBilling_SubTotal.ReadOnly = true;
            this.colBilling_SubTotal.Width = 150;
            // 
            // colBilling_AllocatedAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.colBilling_AllocatedAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colBilling_AllocatedAmount.HeaderText = "Allocated Amount";
            this.colBilling_AllocatedAmount.MinimumWidth = 150;
            this.colBilling_AllocatedAmount.Name = "colBilling_AllocatedAmount";
            this.colBilling_AllocatedAmount.ReadOnly = true;
            this.colBilling_AllocatedAmount.Width = 158;
            // 
            // lblTotalAmountToBePaid
            // 
            this.lblTotalAmountToBePaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalAmountToBePaid.AutoSize = true;
            this.lblTotalAmountToBePaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountToBePaid.Location = new System.Drawing.Point(4, 705);
            this.lblTotalAmountToBePaid.Name = "lblTotalAmountToBePaid";
            this.lblTotalAmountToBePaid.Size = new System.Drawing.Size(365, 45);
            this.lblTotalAmountToBePaid.TabIndex = 14;
            this.lblTotalAmountToBePaid.Text = "Total Amount to be Paid";
            // 
            // nudTotalAmountToBePaid
            // 
            this.nudTotalAmountToBePaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTotalAmountToBePaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudTotalAmountToBePaid.DecimalPlaces = 2;
            this.nudTotalAmountToBePaid.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalAmountToBePaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudTotalAmountToBePaid.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotalAmountToBePaid.Location = new System.Drawing.Point(375, 705);
            this.nudTotalAmountToBePaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudTotalAmountToBePaid.Size = new System.Drawing.Size(480, 93);
            this.nudTotalAmountToBePaid.TabIndex = 22;
            this.nudTotalAmountToBePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotalAmountToBePaid.ThousandsSeparator = true;
            this.nudTotalAmountToBePaid.ValueChanged += new System.EventHandler(this.nudTotalAmountToBePaid_ValueChanged);
            // 
            // lblSelectPaymentType
            // 
            this.lblSelectPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectPaymentType.AutoSize = true;
            this.lblSelectPaymentType.Location = new System.Drawing.Point(865, 12);
            this.lblSelectPaymentType.Name = "lblSelectPaymentType";
            this.lblSelectPaymentType.Size = new System.Drawing.Size(151, 21);
            this.lblSelectPaymentType.TabIndex = 23;
            this.lblSelectPaymentType.Text = "Select Payment Type";
            // 
            // pnlSelectPaymentType
            // 
            this.pnlSelectPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectPaymentType.Controls.Add(this.rbtnPaymentType_Cheque);
            this.pnlSelectPaymentType.Controls.Add(this.rbtnPaymentType_Cash);
            this.pnlSelectPaymentType.Location = new System.Drawing.Point(1022, 7);
            this.pnlSelectPaymentType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSelectPaymentType.Name = "pnlSelectPaymentType";
            this.pnlSelectPaymentType.Size = new System.Drawing.Size(156, 31);
            this.pnlSelectPaymentType.TabIndex = 24;
            // 
            // rbtnPaymentType_Cheque
            // 
            this.rbtnPaymentType_Cheque.AutoSize = true;
            this.rbtnPaymentType_Cheque.Location = new System.Drawing.Point(71, 2);
            this.rbtnPaymentType_Cheque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPaymentType_Cheque.Name = "rbtnPaymentType_Cheque";
            this.rbtnPaymentType_Cheque.Size = new System.Drawing.Size(81, 25);
            this.rbtnPaymentType_Cheque.TabIndex = 1;
            this.rbtnPaymentType_Cheque.Text = "Cheque";
            this.rbtnPaymentType_Cheque.UseVisualStyleBackColor = true;
            // 
            // rbtnPaymentType_Cash
            // 
            this.rbtnPaymentType_Cash.AutoSize = true;
            this.rbtnPaymentType_Cash.Checked = true;
            this.rbtnPaymentType_Cash.Location = new System.Drawing.Point(3, 2);
            this.rbtnPaymentType_Cash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPaymentType_Cash.Name = "rbtnPaymentType_Cash";
            this.rbtnPaymentType_Cash.Size = new System.Drawing.Size(62, 25);
            this.rbtnPaymentType_Cash.TabIndex = 0;
            this.rbtnPaymentType_Cash.TabStop = true;
            this.rbtnPaymentType_Cash.Text = "Cash";
            this.rbtnPaymentType_Cash.UseVisualStyleBackColor = true;
            // 
            // lblEnterAmountPaid
            // 
            this.lblEnterAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnterAmountPaid.AutoSize = true;
            this.lblEnterAmountPaid.Location = new System.Drawing.Point(864, 46);
            this.lblEnterAmountPaid.Name = "lblEnterAmountPaid";
            this.lblEnterAmountPaid.Size = new System.Drawing.Size(139, 21);
            this.lblEnterAmountPaid.TabIndex = 25;
            this.lblEnterAmountPaid.Text = "Enter Amount Paid";
            // 
            // nudAmountPaid
            // 
            this.nudAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmountPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudAmountPaid.DecimalPlaces = 2;
            this.nudAmountPaid.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudAmountPaid.Location = new System.Drawing.Point(868, 70);
            this.nudAmountPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmountPaid.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAmountPaid.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudAmountPaid.Name = "nudAmountPaid";
            this.nudAmountPaid.Size = new System.Drawing.Size(501, 50);
            this.nudAmountPaid.TabIndex = 26;
            this.nudAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmountPaid.ThousandsSeparator = true;
            this.nudAmountPaid.ValueChanged += new System.EventHandler(this.nudAmountPaid_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(1269, 749);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 49);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPayCheckedBillings
            // 
            this.btnPayCheckedBillings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayCheckedBillings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPayCheckedBillings.FlatAppearance.BorderSize = 0;
            this.btnPayCheckedBillings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCheckedBillings.ForeColor = System.Drawing.Color.White;
            this.btnPayCheckedBillings.Location = new System.Drawing.Point(1113, 749);
            this.btnPayCheckedBillings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayCheckedBillings.Name = "btnPayCheckedBillings";
            this.btnPayCheckedBillings.Size = new System.Drawing.Size(150, 49);
            this.btnPayCheckedBillings.TabIndex = 28;
            this.btnPayCheckedBillings.Text = "Save Payment";
            this.btnPayCheckedBillings.UseVisualStyleBackColor = false;
            this.btnPayCheckedBillings.Click += new System.EventHandler(this.btnPayCheckedBillings_Click);
            // 
            // pnlVatIncluded
            // 
            this.pnlVatIncluded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVatIncluded.Controls.Add(this.nudVatIncluded_TotalVat);
            this.pnlVatIncluded.Controls.Add(this.lblVatIncluded_TotalVat);
            this.pnlVatIncluded.Controls.Add(this.nudVatIncluded_Ewt);
            this.pnlVatIncluded.Controls.Add(this.lblVatIncluded_Ewt);
            this.pnlVatIncluded.Controls.Add(this.nudVatIncluded_VatLess);
            this.pnlVatIncluded.Controls.Add(this.lblVatIncluded_VatLess);
            this.pnlVatIncluded.Enabled = false;
            this.pnlVatIncluded.Location = new System.Drawing.Point(869, 411);
            this.pnlVatIncluded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlVatIncluded.Name = "pnlVatIncluded";
            this.pnlVatIncluded.Size = new System.Drawing.Size(500, 187);
            this.pnlVatIncluded.TabIndex = 30;
            // 
            // nudVatIncluded_TotalVat
            // 
            this.nudVatIncluded_TotalVat.DecimalPlaces = 2;
            this.nudVatIncluded_TotalVat.Enabled = false;
            this.nudVatIncluded_TotalVat.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudVatIncluded_TotalVat.Location = new System.Drawing.Point(6, 136);
            this.nudVatIncluded_TotalVat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVatIncluded_TotalVat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudVatIncluded_TotalVat.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudVatIncluded_TotalVat.Name = "nudVatIncluded_TotalVat";
            this.nudVatIncluded_TotalVat.ReadOnly = true;
            this.nudVatIncluded_TotalVat.Size = new System.Drawing.Size(476, 29);
            this.nudVatIncluded_TotalVat.TabIndex = 42;
            this.nudVatIncluded_TotalVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVatIncluded_TotalVat.ThousandsSeparator = true;
            this.nudVatIncluded_TotalVat.ValueChanged += new System.EventHandler(this.nudVatIncluded_TotalVat_ValueChanged);
            // 
            // lblVatIncluded_TotalVat
            // 
            this.lblVatIncluded_TotalVat.AutoSize = true;
            this.lblVatIncluded_TotalVat.Location = new System.Drawing.Point(3, 112);
            this.lblVatIncluded_TotalVat.Name = "lblVatIncluded_TotalVat";
            this.lblVatIncluded_TotalVat.Size = new System.Drawing.Size(72, 21);
            this.lblVatIncluded_TotalVat.TabIndex = 41;
            this.lblVatIncluded_TotalVat.Text = "Total VAT";
            // 
            // nudVatIncluded_Ewt
            // 
            this.nudVatIncluded_Ewt.DecimalPlaces = 2;
            this.nudVatIncluded_Ewt.Location = new System.Drawing.Point(6, 80);
            this.nudVatIncluded_Ewt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVatIncluded_Ewt.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudVatIncluded_Ewt.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudVatIncluded_Ewt.Name = "nudVatIncluded_Ewt";
            this.nudVatIncluded_Ewt.Size = new System.Drawing.Size(476, 29);
            this.nudVatIncluded_Ewt.TabIndex = 40;
            this.nudVatIncluded_Ewt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVatIncluded_Ewt.ThousandsSeparator = true;
            this.nudVatIncluded_Ewt.ValueChanged += new System.EventHandler(this.nudVatIncluded_Ewt_ValueChanged);
            // 
            // lblVatIncluded_Ewt
            // 
            this.lblVatIncluded_Ewt.AutoSize = true;
            this.lblVatIncluded_Ewt.Location = new System.Drawing.Point(3, 56);
            this.lblVatIncluded_Ewt.Name = "lblVatIncluded_Ewt";
            this.lblVatIncluded_Ewt.Size = new System.Drawing.Size(41, 21);
            this.lblVatIncluded_Ewt.TabIndex = 39;
            this.lblVatIncluded_Ewt.Text = "EWT";
            // 
            // nudVatIncluded_VatLess
            // 
            this.nudVatIncluded_VatLess.DecimalPlaces = 2;
            this.nudVatIncluded_VatLess.Location = new System.Drawing.Point(6, 23);
            this.nudVatIncluded_VatLess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudVatIncluded_VatLess.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudVatIncluded_VatLess.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudVatIncluded_VatLess.Name = "nudVatIncluded_VatLess";
            this.nudVatIncluded_VatLess.Size = new System.Drawing.Size(476, 29);
            this.nudVatIncluded_VatLess.TabIndex = 38;
            this.nudVatIncluded_VatLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVatIncluded_VatLess.ThousandsSeparator = true;
            this.nudVatIncluded_VatLess.ValueChanged += new System.EventHandler(this.nudVatIncluded_VatLess_ValueChanged);
            // 
            // lblVatIncluded_VatLess
            // 
            this.lblVatIncluded_VatLess.AutoSize = true;
            this.lblVatIncluded_VatLess.Location = new System.Drawing.Point(3, 0);
            this.lblVatIncluded_VatLess.Name = "lblVatIncluded_VatLess";
            this.lblVatIncluded_VatLess.Size = new System.Drawing.Size(70, 21);
            this.lblVatIncluded_VatLess.TabIndex = 38;
            this.lblVatIncluded_VatLess.Text = "VAT Less";
            // 
            // ckbxVatIncluded
            // 
            this.ckbxVatIncluded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbxVatIncluded.AutoSize = true;
            this.ckbxVatIncluded.Location = new System.Drawing.Point(870, 380);
            this.ckbxVatIncluded.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbxVatIncluded.Name = "ckbxVatIncluded";
            this.ckbxVatIncluded.Size = new System.Drawing.Size(118, 25);
            this.ckbxVatIncluded.TabIndex = 0;
            this.ckbxVatIncluded.Text = "VAT included";
            this.ckbxVatIncluded.UseVisualStyleBackColor = true;
            this.ckbxVatIncluded.CheckedChanged += new System.EventHandler(this.ckbxVatIncluded_CheckedChanged);
            // 
            // gbxPaymentAllocation
            // 
            this.gbxPaymentAllocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPaymentAllocation.Controls.Add(this.nudRemaining);
            this.gbxPaymentAllocation.Controls.Add(this.label1);
            this.gbxPaymentAllocation.Controls.Add(this.btnPaymentAllocation_Done);
            this.gbxPaymentAllocation.Controls.Add(this.nudPaymentAllocation_AllocatedAmount);
            this.gbxPaymentAllocation.Controls.Add(this.lblPaymentAllocation_AllocatedAmount);
            this.gbxPaymentAllocation.Controls.Add(this.lblPaymentAllocation_PaymentMode);
            this.gbxPaymentAllocation.Controls.Add(this.pnlPaymentAllocation_PaymentMode);
            this.gbxPaymentAllocation.Controls.Add(this.tbxPaymentAllocation_BillingNumber);
            this.gbxPaymentAllocation.Controls.Add(this.lblPaymentAllocation_BillingNo);
            this.gbxPaymentAllocation.Enabled = false;
            this.gbxPaymentAllocation.Location = new System.Drawing.Point(869, 126);
            this.gbxPaymentAllocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPaymentAllocation.Name = "gbxPaymentAllocation";
            this.gbxPaymentAllocation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxPaymentAllocation.Size = new System.Drawing.Size(500, 248);
            this.gbxPaymentAllocation.TabIndex = 31;
            this.gbxPaymentAllocation.TabStop = false;
            this.gbxPaymentAllocation.Text = "Payment Allocation";
            // 
            // nudRemaining
            // 
            this.nudRemaining.DecimalPlaces = 2;
            this.nudRemaining.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudRemaining.Location = new System.Drawing.Point(6, 199);
            this.nudRemaining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRemaining.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudRemaining.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudRemaining.Name = "nudRemaining";
            this.nudRemaining.ReadOnly = true;
            this.nudRemaining.Size = new System.Drawing.Size(477, 29);
            this.nudRemaining.TabIndex = 37;
            this.nudRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRemaining.ThousandsSeparator = true;
            this.nudRemaining.ValueChanged += new System.EventHandler(this.nudRemaining_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Remaining";
            // 
            // btnPaymentAllocation_Done
            // 
            this.btnPaymentAllocation_Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPaymentAllocation_Done.FlatAppearance.BorderSize = 0;
            this.btnPaymentAllocation_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentAllocation_Done.ForeColor = System.Drawing.Color.White;
            this.btnPaymentAllocation_Done.Location = new System.Drawing.Point(383, 142);
            this.btnPaymentAllocation_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentAllocation_Done.Name = "btnPaymentAllocation_Done";
            this.btnPaymentAllocation_Done.Size = new System.Drawing.Size(100, 30);
            this.btnPaymentAllocation_Done.TabIndex = 32;
            this.btnPaymentAllocation_Done.Text = "Done";
            this.btnPaymentAllocation_Done.UseVisualStyleBackColor = false;
            this.btnPaymentAllocation_Done.Click += new System.EventHandler(this.btnPaymentAllocation_Done_Click);
            // 
            // nudPaymentAllocation_AllocatedAmount
            // 
            this.nudPaymentAllocation_AllocatedAmount.DecimalPlaces = 2;
            this.nudPaymentAllocation_AllocatedAmount.Enabled = false;
            this.nudPaymentAllocation_AllocatedAmount.Location = new System.Drawing.Point(6, 107);
            this.nudPaymentAllocation_AllocatedAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPaymentAllocation_AllocatedAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPaymentAllocation_AllocatedAmount.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudPaymentAllocation_AllocatedAmount.Name = "nudPaymentAllocation_AllocatedAmount";
            this.nudPaymentAllocation_AllocatedAmount.Size = new System.Drawing.Size(477, 29);
            this.nudPaymentAllocation_AllocatedAmount.TabIndex = 36;
            this.nudPaymentAllocation_AllocatedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaymentAllocation_AllocatedAmount.ThousandsSeparator = true;
            this.nudPaymentAllocation_AllocatedAmount.Leave += new System.EventHandler(this.nudPaymentAllocation_AllocatedAmount_Leave);
            // 
            // lblPaymentAllocation_AllocatedAmount
            // 
            this.lblPaymentAllocation_AllocatedAmount.AutoSize = true;
            this.lblPaymentAllocation_AllocatedAmount.Location = new System.Drawing.Point(3, 83);
            this.lblPaymentAllocation_AllocatedAmount.Name = "lblPaymentAllocation_AllocatedAmount";
            this.lblPaymentAllocation_AllocatedAmount.Size = new System.Drawing.Size(134, 21);
            this.lblPaymentAllocation_AllocatedAmount.TabIndex = 35;
            this.lblPaymentAllocation_AllocatedAmount.Text = "Allocated Amount";
            // 
            // lblPaymentAllocation_PaymentMode
            // 
            this.lblPaymentAllocation_PaymentMode.AutoSize = true;
            this.lblPaymentAllocation_PaymentMode.Location = new System.Drawing.Point(346, 25);
            this.lblPaymentAllocation_PaymentMode.Name = "lblPaymentAllocation_PaymentMode";
            this.lblPaymentAllocation_PaymentMode.Size = new System.Drawing.Size(114, 21);
            this.lblPaymentAllocation_PaymentMode.TabIndex = 34;
            this.lblPaymentAllocation_PaymentMode.Text = "Payment Mode";
            // 
            // pnlPaymentAllocation_PaymentMode
            // 
            this.pnlPaymentAllocation_PaymentMode.Controls.Add(this.rbtnPaymentAllocation_PaymentMode_Partial);
            this.pnlPaymentAllocation_PaymentMode.Controls.Add(this.rbtnPaymentAllocation_PaymentMode_Full);
            this.pnlPaymentAllocation_PaymentMode.Location = new System.Drawing.Point(347, 49);
            this.pnlPaymentAllocation_PaymentMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPaymentAllocation_PaymentMode.Name = "pnlPaymentAllocation_PaymentMode";
            this.pnlPaymentAllocation_PaymentMode.Size = new System.Drawing.Size(136, 31);
            this.pnlPaymentAllocation_PaymentMode.TabIndex = 25;
            // 
            // rbtnPaymentAllocation_PaymentMode_Partial
            // 
            this.rbtnPaymentAllocation_PaymentMode_Partial.AutoSize = true;
            this.rbtnPaymentAllocation_PaymentMode_Partial.Location = new System.Drawing.Point(62, 2);
            this.rbtnPaymentAllocation_PaymentMode_Partial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPaymentAllocation_PaymentMode_Partial.Name = "rbtnPaymentAllocation_PaymentMode_Partial";
            this.rbtnPaymentAllocation_PaymentMode_Partial.Size = new System.Drawing.Size(71, 25);
            this.rbtnPaymentAllocation_PaymentMode_Partial.TabIndex = 1;
            this.rbtnPaymentAllocation_PaymentMode_Partial.Text = "Partial";
            this.rbtnPaymentAllocation_PaymentMode_Partial.UseVisualStyleBackColor = true;
            this.rbtnPaymentAllocation_PaymentMode_Partial.CheckedChanged += new System.EventHandler(this.rbtnPaymentAllocation_PaymentMode_Partial_CheckedChanged);
            // 
            // rbtnPaymentAllocation_PaymentMode_Full
            // 
            this.rbtnPaymentAllocation_PaymentMode_Full.AutoSize = true;
            this.rbtnPaymentAllocation_PaymentMode_Full.Checked = true;
            this.rbtnPaymentAllocation_PaymentMode_Full.Location = new System.Drawing.Point(3, 2);
            this.rbtnPaymentAllocation_PaymentMode_Full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnPaymentAllocation_PaymentMode_Full.Name = "rbtnPaymentAllocation_PaymentMode_Full";
            this.rbtnPaymentAllocation_PaymentMode_Full.Size = new System.Drawing.Size(53, 25);
            this.rbtnPaymentAllocation_PaymentMode_Full.TabIndex = 0;
            this.rbtnPaymentAllocation_PaymentMode_Full.TabStop = true;
            this.rbtnPaymentAllocation_PaymentMode_Full.Text = "Full";
            this.rbtnPaymentAllocation_PaymentMode_Full.UseVisualStyleBackColor = true;
            this.rbtnPaymentAllocation_PaymentMode_Full.CheckedChanged += new System.EventHandler(this.rbtnPaymentAllocation_PaymentMode_Full_CheckedChanged);
            // 
            // tbxPaymentAllocation_BillingNumber
            // 
            this.tbxPaymentAllocation_BillingNumber.Location = new System.Drawing.Point(6, 49);
            this.tbxPaymentAllocation_BillingNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPaymentAllocation_BillingNumber.Name = "tbxPaymentAllocation_BillingNumber";
            this.tbxPaymentAllocation_BillingNumber.ReadOnly = true;
            this.tbxPaymentAllocation_BillingNumber.Size = new System.Drawing.Size(333, 29);
            this.tbxPaymentAllocation_BillingNumber.TabIndex = 33;
            // 
            // lblPaymentAllocation_BillingNo
            // 
            this.lblPaymentAllocation_BillingNo.AutoSize = true;
            this.lblPaymentAllocation_BillingNo.Location = new System.Drawing.Point(3, 25);
            this.lblPaymentAllocation_BillingNo.Name = "lblPaymentAllocation_BillingNo";
            this.lblPaymentAllocation_BillingNo.Size = new System.Drawing.Size(81, 21);
            this.lblPaymentAllocation_BillingNo.TabIndex = 32;
            this.lblPaymentAllocation_BillingNo.Text = "Billing No.";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(861, 602);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(201, 45);
            this.lblAmountDue.TabIndex = 38;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // nudAmountDue
            // 
            this.nudAmountDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAmountDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nudAmountDue.DecimalPlaces = 2;
            this.nudAmountDue.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountDue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nudAmountDue.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAmountDue.Location = new System.Drawing.Point(868, 649);
            this.nudAmountDue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAmountDue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudAmountDue.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudAmountDue.Name = "nudAmountDue";
            this.nudAmountDue.ReadOnly = true;
            this.nudAmountDue.Size = new System.Drawing.Size(501, 93);
            this.nudAmountDue.TabIndex = 39;
            this.nudAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmountDue.ThousandsSeparator = true;
            // 
            // BillingPaymentConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 810);
            this.Controls.Add(this.nudAmountDue);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.gbxPaymentAllocation);
            this.Controls.Add(this.ckbxVatIncluded);
            this.Controls.Add(this.pnlVatIncluded);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayCheckedBillings);
            this.Controls.Add(this.nudAmountPaid);
            this.Controls.Add(this.lblEnterAmountPaid);
            this.Controls.Add(this.pnlSelectPaymentType);
            this.Controls.Add(this.lblSelectPaymentType);
            this.Controls.Add(this.nudTotalAmountToBePaid);
            this.Controls.Add(this.lblTotalAmountToBePaid);
            this.Controls.Add(this.dgvBillings);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BillingPaymentConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Payment Confirmation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingPaymentConfirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalAmountToBePaid)).EndInit();
            this.pnlSelectPaymentType.ResumeLayout(false);
            this.pnlSelectPaymentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPaid)).EndInit();
            this.pnlVatIncluded.ResumeLayout(false);
            this.pnlVatIncluded.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_TotalVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_Ewt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVatIncluded_VatLess)).EndInit();
            this.gbxPaymentAllocation.ResumeLayout(false);
            this.gbxPaymentAllocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemaining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaymentAllocation_AllocatedAmount)).EndInit();
            this.pnlPaymentAllocation_PaymentMode.ResumeLayout(false);
            this.pnlPaymentAllocation_PaymentMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillings;
        private System.Windows.Forms.Label lblTotalAmountToBePaid;
        private System.Windows.Forms.NumericUpDown nudTotalAmountToBePaid;
        private System.Windows.Forms.Label lblSelectPaymentType;
        private System.Windows.Forms.Panel pnlSelectPaymentType;
        private System.Windows.Forms.RadioButton rbtnPaymentType_Cash;
        private System.Windows.Forms.RadioButton rbtnPaymentType_Cheque;
        private System.Windows.Forms.Label lblEnterAmountPaid;
        private System.Windows.Forms.NumericUpDown nudAmountPaid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayCheckedBillings;
        private System.Windows.Forms.Panel pnlVatIncluded;
        private System.Windows.Forms.CheckBox ckbxVatIncluded;
        private System.Windows.Forms.GroupBox gbxPaymentAllocation;
        private System.Windows.Forms.Label lblPaymentAllocation_BillingNo;
        private System.Windows.Forms.TextBox tbxPaymentAllocation_BillingNumber;
        private System.Windows.Forms.Label lblPaymentAllocation_PaymentMode;
        private System.Windows.Forms.Label lblPaymentAllocation_AllocatedAmount;
        private System.Windows.Forms.NumericUpDown nudPaymentAllocation_AllocatedAmount;
        private System.Windows.Forms.Panel pnlPaymentAllocation_PaymentMode;
        private System.Windows.Forms.RadioButton rbtnPaymentAllocation_PaymentMode_Partial;
        private System.Windows.Forms.RadioButton rbtnPaymentAllocation_PaymentMode_Full;
        private System.Windows.Forms.Button btnPaymentAllocation_Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_SiNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AllocatedAmount;
        private System.Windows.Forms.Label lblVatIncluded_VatLess;
        private System.Windows.Forms.NumericUpDown nudVatIncluded_VatLess;
        private System.Windows.Forms.Label lblVatIncluded_Ewt;
        private System.Windows.Forms.NumericUpDown nudVatIncluded_Ewt;
        private System.Windows.Forms.Label lblVatIncluded_TotalVat;
        private System.Windows.Forms.NumericUpDown nudVatIncluded_TotalVat;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.NumericUpDown nudAmountDue;
    }
}