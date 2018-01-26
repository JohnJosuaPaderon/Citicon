namespace Citicon.Forms
{
    partial class SalesInvoiceAssignmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceAssignmentForm));
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.lblSiNumber = new System.Windows.Forms.Label();
            this.tbxSiNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.lblClients = new System.Windows.Forms.Label();
            this.CheckBillingsLabel = new System.Windows.Forms.Label();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.DeliveriesLabel = new System.Windows.Forms.Label();
            this.DeliveriesDataGridView = new System.Windows.Forms.DataGridView();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Billing_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_DeliveryReceiptNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_ProjectDesignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_VolumeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBilling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBilling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBilling.BackgroundColor = System.Drawing.Color.White;
            this.dgvBilling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBilling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBilling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBilling.ColumnHeadersHeight = 40;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBilling_Check,
            this.colBilling,
            this.colBilling_Volume,
            this.colBilling_AmountDue,
            this.Billing_ExtraColumn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBilling.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBilling.EnableHeadersVisualStyles = false;
            this.dgvBilling.GridColor = System.Drawing.Color.Red;
            this.dgvBilling.Location = new System.Drawing.Point(660, 28);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBilling.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(660, 272);
            this.dgvBilling.TabIndex = 0;
            this.dgvBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellContentClick);
            this.dgvBilling.SelectionChanged += new System.EventHandler(this.dgvBilling_SelectionChanged);
            // 
            // lblSiNumber
            // 
            this.lblSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiNumber.AutoSize = true;
            this.lblSiNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiNumber.Location = new System.Drawing.Point(669, 638);
            this.lblSiNumber.Name = "lblSiNumber";
            this.lblSiNumber.Size = new System.Drawing.Size(99, 37);
            this.lblSiNumber.TabIndex = 1;
            this.lblSiNumber.Text = "S.I. No.";
            // 
            // tbxSiNumber
            // 
            this.tbxSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSiNumber.Location = new System.Drawing.Point(774, 639);
            this.tbxSiNumber.Name = "tbxSiNumber";
            this.tbxSiNumber.Size = new System.Drawing.Size(334, 38);
            this.tbxSiNumber.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1114, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1220, 637);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClients.ColumnHeadersHeight = 40;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClient,
            this.colClient_Address,
            this.Client_ExtraColumn});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.Red;
            this.dgvClients.Location = new System.Drawing.Point(10, 28);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(643, 272);
            this.dgvClients.TabIndex = 5;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(7, 8);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(78, 17);
            this.lblClients.TabIndex = 6;
            this.lblClients.Text = "Select Client";
            // 
            // CheckBillingsLabel
            // 
            this.CheckBillingsLabel.AutoSize = true;
            this.CheckBillingsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CheckBillingsLabel.Location = new System.Drawing.Point(656, 8);
            this.CheckBillingsLabel.Name = "CheckBillingsLabel";
            this.CheckBillingsLabel.Size = new System.Drawing.Size(139, 17);
            this.CheckBillingsLabel.TabIndex = 7;
            this.CheckBillingsLabel.Text = "Check/Uncheck Billings";
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSelectProject.Location = new System.Drawing.Point(7, 303);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(86, 17);
            this.lblSelectProject.TabIndex = 8;
            this.lblSelectProject.Text = "Select Project";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProjects.ColumnHeadersHeight = 40;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProject,
            this.colProject_Location,
            this.Project_ExtraColumn});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProjects.EnableHeadersVisualStyles = false;
            this.dgvProjects.GridColor = System.Drawing.Color.Red;
            this.dgvProjects.Location = new System.Drawing.Point(10, 324);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProjects.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(643, 307);
            this.dgvProjects.TabIndex = 9;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            // 
            // DeliveriesLabel
            // 
            this.DeliveriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeliveriesLabel.AutoSize = true;
            this.DeliveriesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DeliveriesLabel.Location = new System.Drawing.Point(657, 303);
            this.DeliveriesLabel.Name = "DeliveriesLabel";
            this.DeliveriesLabel.Size = new System.Drawing.Size(64, 17);
            this.DeliveriesLabel.TabIndex = 10;
            this.DeliveriesLabel.Text = "Deliveries";
            // 
            // DeliveriesDataGridView
            // 
            this.DeliveriesDataGridView.AllowUserToAddRows = false;
            this.DeliveriesDataGridView.AllowUserToDeleteRows = false;
            this.DeliveriesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.DeliveriesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DeliveriesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveriesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeliveriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DeliveriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeliveriesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DeliveriesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeliveriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DeliveriesDataGridView.ColumnHeadersHeight = 40;
            this.DeliveriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliveryColumn,
            this.Delivery_DeliveryReceiptNumberColumn,
            this.Delivery_ProjectDesignColumn,
            this.Delivery_VolumeColumn,
            this.Delivery_ExtraColumn});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeliveriesDataGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.DeliveriesDataGridView.EnableHeadersVisualStyles = false;
            this.DeliveriesDataGridView.GridColor = System.Drawing.Color.Red;
            this.DeliveriesDataGridView.Location = new System.Drawing.Point(660, 324);
            this.DeliveriesDataGridView.MultiSelect = false;
            this.DeliveriesDataGridView.Name = "DeliveriesDataGridView";
            this.DeliveriesDataGridView.ReadOnly = true;
            this.DeliveriesDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.DeliveriesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DeliveriesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeliveriesDataGridView.Size = new System.Drawing.Size(660, 307);
            this.DeliveriesDataGridView.TabIndex = 11;
            // 
            // colClient
            // 
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 250;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 250;
            // 
            // colClient_Address
            // 
            this.colClient_Address.HeaderText = "Address";
            this.colClient_Address.MinimumWidth = 300;
            this.colClient_Address.Name = "colClient_Address";
            this.colClient_Address.ReadOnly = true;
            this.colClient_Address.Width = 300;
            // 
            // Client_ExtraColumn
            // 
            this.Client_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client_ExtraColumn.HeaderText = "";
            this.Client_ExtraColumn.Name = "Client_ExtraColumn";
            this.Client_ExtraColumn.ReadOnly = true;
            // 
            // colProject
            // 
            this.colProject.HeaderText = "Project";
            this.colProject.MinimumWidth = 250;
            this.colProject.Name = "colProject";
            this.colProject.ReadOnly = true;
            this.colProject.Width = 250;
            // 
            // colProject_Location
            // 
            this.colProject_Location.HeaderText = "Location";
            this.colProject_Location.MinimumWidth = 300;
            this.colProject_Location.Name = "colProject_Location";
            this.colProject_Location.ReadOnly = true;
            this.colProject_Location.Width = 300;
            // 
            // Project_ExtraColumn
            // 
            this.Project_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project_ExtraColumn.HeaderText = "";
            this.Project_ExtraColumn.Name = "Project_ExtraColumn";
            this.Project_ExtraColumn.ReadOnly = true;
            // 
            // colBilling_Check
            // 
            this.colBilling_Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBilling_Check.HeaderText = "Include";
            this.colBilling_Check.MinimumWidth = 100;
            this.colBilling_Check.Name = "colBilling_Check";
            // 
            // colBilling
            // 
            this.colBilling.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBilling.HeaderText = "Billing No.";
            this.colBilling.MinimumWidth = 125;
            this.colBilling.Name = "colBilling";
            this.colBilling.ReadOnly = true;
            this.colBilling.Width = 125;
            // 
            // colBilling_Volume
            // 
            this.colBilling_Volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colBilling_Volume.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBilling_Volume.HeaderText = "Volume";
            this.colBilling_Volume.MinimumWidth = 125;
            this.colBilling_Volume.Name = "colBilling_Volume";
            this.colBilling_Volume.ReadOnly = true;
            this.colBilling_Volume.Width = 125;
            // 
            // colBilling_AmountDue
            // 
            this.colBilling_AmountDue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.colBilling_AmountDue.DefaultCellStyle = dataGridViewCellStyle4;
            this.colBilling_AmountDue.HeaderText = "Amount Due";
            this.colBilling_AmountDue.MinimumWidth = 150;
            this.colBilling_AmountDue.Name = "colBilling_AmountDue";
            this.colBilling_AmountDue.ReadOnly = true;
            this.colBilling_AmountDue.Width = 150;
            // 
            // Billing_ExtraColumn
            // 
            this.Billing_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Billing_ExtraColumn.HeaderText = "";
            this.Billing_ExtraColumn.Name = "Billing_ExtraColumn";
            // 
            // DeliveryColumn
            // 
            this.DeliveryColumn.HeaderText = "Delivery";
            this.DeliveryColumn.Name = "DeliveryColumn";
            this.DeliveryColumn.ReadOnly = true;
            this.DeliveryColumn.Visible = false;
            this.DeliveryColumn.Width = 78;
            // 
            // Delivery_DeliveryReceiptNumberColumn
            // 
            this.Delivery_DeliveryReceiptNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delivery_DeliveryReceiptNumberColumn.HeaderText = "DR No.";
            this.Delivery_DeliveryReceiptNumberColumn.Name = "Delivery_DeliveryReceiptNumberColumn";
            this.Delivery_DeliveryReceiptNumberColumn.ReadOnly = true;
            this.Delivery_DeliveryReceiptNumberColumn.Width = 68;
            // 
            // Delivery_ProjectDesignColumn
            // 
            this.Delivery_ProjectDesignColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delivery_ProjectDesignColumn.HeaderText = "Project Design";
            this.Delivery_ProjectDesignColumn.Name = "Delivery_ProjectDesignColumn";
            this.Delivery_ProjectDesignColumn.ReadOnly = true;
            this.Delivery_ProjectDesignColumn.Width = 106;
            // 
            // Delivery_VolumeColumn
            // 
            this.Delivery_VolumeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delivery_VolumeColumn.HeaderText = "Volume";
            this.Delivery_VolumeColumn.Name = "Delivery_VolumeColumn";
            this.Delivery_VolumeColumn.ReadOnly = true;
            this.Delivery_VolumeColumn.Width = 75;
            // 
            // Delivery_ExtraColumn
            // 
            this.Delivery_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delivery_ExtraColumn.HeaderText = "";
            this.Delivery_ExtraColumn.Name = "Delivery_ExtraColumn";
            this.Delivery_ExtraColumn.ReadOnly = true;
            // 
            // SalesInvoiceAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 689);
            this.Controls.Add(this.DeliveriesDataGridView);
            this.Controls.Add(this.DeliveriesLabel);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.CheckBillingsLabel);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxSiNumber);
            this.Controls.Add(this.lblSiNumber);
            this.Controls.Add(this.dgvBilling);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesInvoiceAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice Assignment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesInvoiceAssignmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBilling;
        private System.Windows.Forms.Label lblSiNumber;
        private System.Windows.Forms.TextBox tbxSiNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Label CheckBillingsLabel;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label DeliveriesLabel;
        private System.Windows.Forms.DataGridView DeliveriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ExtraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_ExtraColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBilling_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Billing_ExtraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_DeliveryReceiptNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_ProjectDesignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_VolumeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery_ExtraColumn;
    }
}