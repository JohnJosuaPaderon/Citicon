namespace Citicon.Forms
{
    partial class PurchaseOrderManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderManagementForm));
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.nudPurchaseOrderNumber = new System.Windows.Forms.NumericUpDown();
            this.dgvProjectDesign = new System.Windows.Forms.DataGridView();
            this.colProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbxClient = new System.Windows.Forms.ComboBox();
            this.cmbxProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvPurchaseOrderProjectDesign = new System.Windows.Forms.DataGridView();
            this.colPurchaseOrderProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseOrderProjectDesign_ProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseOrderProjectDesign_MaxVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudMaxVolume = new System.Windows.Forms.NumericUpDown();
            this.lblMaxVolume = new System.Windows.Forms.Label();
            this.lblMaximumCumulativePricePerCubicMeter = new System.Windows.Forms.Label();
            this.nudMaximumCumulativePricePerCubicMeter = new System.Windows.Forms.NumericUpDown();
            this.SearchClientButton = new System.Windows.Forms.Button();
            this.SearchProjectButton = new System.Windows.Forms.Button();
            this.btnIncludeProjectDesign = new System.Windows.Forms.Button();
            this.btnExcludeProjectDesign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseOrderNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderProjectDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumCumulativePricePerCubicMeter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.AutoSize = true;
            this.lblPurchaseOrderNumber.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(9, 11);
            this.lblPurchaseOrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(342, 50);
            this.lblPurchaseOrderNumber.TabIndex = 0;
            this.lblPurchaseOrderNumber.Text = "Purchase Order No.";
            // 
            // nudPurchaseOrderNumber
            // 
            this.nudPurchaseOrderNumber.BackColor = System.Drawing.Color.Black;
            this.nudPurchaseOrderNumber.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPurchaseOrderNumber.ForeColor = System.Drawing.Color.Lime;
            this.nudPurchaseOrderNumber.Location = new System.Drawing.Point(280, 10);
            this.nudPurchaseOrderNumber.Margin = new System.Windows.Forms.Padding(2);
            this.nudPurchaseOrderNumber.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPurchaseOrderNumber.Name = "nudPurchaseOrderNumber";
            this.nudPurchaseOrderNumber.Size = new System.Drawing.Size(233, 57);
            this.nudPurchaseOrderNumber.TabIndex = 1;
            this.nudPurchaseOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvProjectDesign
            // 
            this.dgvProjectDesign.AllowUserToAddRows = false;
            this.dgvProjectDesign.AllowUserToDeleteRows = false;
            this.dgvProjectDesign.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjectDesign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjectDesign.ColumnHeadersHeight = 60;
            this.dgvProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectDesign});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjectDesign.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvProjectDesign.GridColor = System.Drawing.Color.Red;
            this.dgvProjectDesign.Location = new System.Drawing.Point(12, 209);
            this.dgvProjectDesign.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjectDesign.MultiSelect = false;
            this.dgvProjectDesign.Name = "dgvProjectDesign";
            this.dgvProjectDesign.ReadOnly = true;
            this.dgvProjectDesign.RowHeadersVisible = false;
            this.dgvProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProjectDesign.RowTemplate.Height = 40;
            this.dgvProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDesign.Size = new System.Drawing.Size(501, 560);
            this.dgvProjectDesign.TabIndex = 104;
            // 
            // colProjectDesign
            // 
            this.colProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProjectDesign.HeaderText = "Project Designs";
            this.colProjectDesign.MinimumWidth = 100;
            this.colProjectDesign.Name = "colProjectDesign";
            this.colProjectDesign.ReadOnly = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(8, 115);
            this.lblClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(40, 17);
            this.lblClient.TabIndex = 105;
            this.lblClient.Text = "Client";
            // 
            // cmbxClient
            // 
            this.cmbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxClient.FormattingEnabled = true;
            this.cmbxClient.Location = new System.Drawing.Point(11, 134);
            this.cmbxClient.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxClient.Name = "cmbxClient";
            this.cmbxClient.Size = new System.Drawing.Size(419, 25);
            this.cmbxClient.TabIndex = 106;
            this.cmbxClient.SelectedIndexChanged += new System.EventHandler(this.CmbxClient_SelectedIndexChanged);
            // 
            // cmbxProject
            // 
            this.cmbxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxProject.FormattingEnabled = true;
            this.cmbxProject.Location = new System.Drawing.Point(11, 180);
            this.cmbxProject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxProject.Name = "cmbxProject";
            this.cmbxProject.Size = new System.Drawing.Size(419, 25);
            this.cmbxProject.TabIndex = 108;
            this.cmbxProject.SelectedIndexChanged += new System.EventHandler(this.CmbxProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(11, 161);
            this.lblProject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(48, 17);
            this.lblProject.TabIndex = 107;
            this.lblProject.Text = "Project";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1103, 763);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 40);
            this.btnSave.TabIndex = 112;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1185, 763);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 40);
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dgvPurchaseOrderProjectDesign
            // 
            this.dgvPurchaseOrderProjectDesign.AllowUserToAddRows = false;
            this.dgvPurchaseOrderProjectDesign.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderProjectDesign.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPurchaseOrderProjectDesign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPurchaseOrderProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseOrderProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPurchaseOrderProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPurchaseOrderProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchaseOrderProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPurchaseOrderProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrderProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseOrderProjectDesign.ColumnHeadersHeight = 60;
            this.dgvPurchaseOrderProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPurchaseOrderProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPurchaseOrderProjectDesign,
            this.colPurchaseOrderProjectDesign_ProjectDesign,
            this.colPurchaseOrderProjectDesign_MaxVolume});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrderProjectDesign.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPurchaseOrderProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrderProjectDesign.GridColor = System.Drawing.Color.Red;
            this.dgvPurchaseOrderProjectDesign.Location = new System.Drawing.Point(562, 10);
            this.dgvPurchaseOrderProjectDesign.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPurchaseOrderProjectDesign.MultiSelect = false;
            this.dgvPurchaseOrderProjectDesign.Name = "dgvPurchaseOrderProjectDesign";
            this.dgvPurchaseOrderProjectDesign.ReadOnly = true;
            this.dgvPurchaseOrderProjectDesign.RowHeadersVisible = false;
            this.dgvPurchaseOrderProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPurchaseOrderProjectDesign.RowTemplate.Height = 40;
            this.dgvPurchaseOrderProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrderProjectDesign.Size = new System.Drawing.Size(700, 749);
            this.dgvPurchaseOrderProjectDesign.TabIndex = 113;
            // 
            // colPurchaseOrderProjectDesign
            // 
            this.colPurchaseOrderProjectDesign.HeaderText = "";
            this.colPurchaseOrderProjectDesign.Name = "colPurchaseOrderProjectDesign";
            this.colPurchaseOrderProjectDesign.ReadOnly = true;
            this.colPurchaseOrderProjectDesign.Visible = false;
            this.colPurchaseOrderProjectDesign.Width = 18;
            // 
            // colPurchaseOrderProjectDesign_ProjectDesign
            // 
            this.colPurchaseOrderProjectDesign_ProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPurchaseOrderProjectDesign_ProjectDesign.HeaderText = "Included Project Designs";
            this.colPurchaseOrderProjectDesign_ProjectDesign.MinimumWidth = 100;
            this.colPurchaseOrderProjectDesign_ProjectDesign.Name = "colPurchaseOrderProjectDesign_ProjectDesign";
            this.colPurchaseOrderProjectDesign_ProjectDesign.ReadOnly = true;
            // 
            // colPurchaseOrderProjectDesign_MaxVolume
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0.0##";
            dataGridViewCellStyle6.NullValue = null;
            this.colPurchaseOrderProjectDesign_MaxVolume.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPurchaseOrderProjectDesign_MaxVolume.HeaderText = "Max Vol.";
            this.colPurchaseOrderProjectDesign_MaxVolume.MinimumWidth = 150;
            this.colPurchaseOrderProjectDesign_MaxVolume.Name = "colPurchaseOrderProjectDesign_MaxVolume";
            this.colPurchaseOrderProjectDesign_MaxVolume.ReadOnly = true;
            this.colPurchaseOrderProjectDesign_MaxVolume.Width = 150;
            // 
            // nudMaxVolume
            // 
            this.nudMaxVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMaxVolume.DecimalPlaces = 3;
            this.nudMaxVolume.Location = new System.Drawing.Point(280, 773);
            this.nudMaxVolume.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaxVolume.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxVolume.Name = "nudMaxVolume";
            this.nudMaxVolume.Size = new System.Drawing.Size(233, 25);
            this.nudMaxVolume.TabIndex = 114;
            this.nudMaxVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxVolume.ThousandsSeparator = true;
            // 
            // lblMaxVolume
            // 
            this.lblMaxVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaxVolume.AutoSize = true;
            this.lblMaxVolume.Location = new System.Drawing.Point(196, 775);
            this.lblMaxVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxVolume.Name = "lblMaxVolume";
            this.lblMaxVolume.Size = new System.Drawing.Size(80, 17);
            this.lblMaxVolume.TabIndex = 115;
            this.lblMaxVolume.Text = "Max Volume";
            // 
            // lblMaximumCumulativePricePerCubicMeter
            // 
            this.lblMaximumCumulativePricePerCubicMeter.AutoSize = true;
            this.lblMaximumCumulativePricePerCubicMeter.Location = new System.Drawing.Point(11, 69);
            this.lblMaximumCumulativePricePerCubicMeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaximumCumulativePricePerCubicMeter.Name = "lblMaximumCumulativePricePerCubicMeter";
            this.lblMaximumCumulativePricePerCubicMeter.Size = new System.Drawing.Size(177, 17);
            this.lblMaximumCumulativePricePerCubicMeter.TabIndex = 116;
            this.lblMaximumCumulativePricePerCubicMeter.Text = "Max. Cumulative Price/Cu. M.";
            // 
            // nudMaximumCumulativePricePerCubicMeter
            // 
            this.nudMaximumCumulativePricePerCubicMeter.DecimalPlaces = 2;
            this.nudMaximumCumulativePricePerCubicMeter.Location = new System.Drawing.Point(11, 88);
            this.nudMaximumCumulativePricePerCubicMeter.Margin = new System.Windows.Forms.Padding(2);
            this.nudMaximumCumulativePricePerCubicMeter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaximumCumulativePricePerCubicMeter.Name = "nudMaximumCumulativePricePerCubicMeter";
            this.nudMaximumCumulativePricePerCubicMeter.Size = new System.Drawing.Size(502, 25);
            this.nudMaximumCumulativePricePerCubicMeter.TabIndex = 117;
            this.nudMaximumCumulativePricePerCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaximumCumulativePricePerCubicMeter.ThousandsSeparator = true;
            // 
            // SearchClientButton
            // 
            this.SearchClientButton.BackColor = System.Drawing.Color.Red;
            this.SearchClientButton.FlatAppearance.BorderSize = 0;
            this.SearchClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchClientButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClientButton.ForeColor = System.Drawing.Color.White;
            this.SearchClientButton.Location = new System.Drawing.Point(435, 134);
            this.SearchClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchClientButton.Name = "SearchClientButton";
            this.SearchClientButton.Size = new System.Drawing.Size(78, 25);
            this.SearchClientButton.TabIndex = 131;
            this.SearchClientButton.Text = "SEARCH";
            this.SearchClientButton.UseVisualStyleBackColor = false;
            this.SearchClientButton.Click += new System.EventHandler(this.SearchClientButton_Click);
            // 
            // SearchProjectButton
            // 
            this.SearchProjectButton.BackColor = System.Drawing.Color.Red;
            this.SearchProjectButton.FlatAppearance.BorderSize = 0;
            this.SearchProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchProjectButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProjectButton.ForeColor = System.Drawing.Color.White;
            this.SearchProjectButton.Location = new System.Drawing.Point(435, 180);
            this.SearchProjectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchProjectButton.Name = "SearchProjectButton";
            this.SearchProjectButton.Size = new System.Drawing.Size(78, 25);
            this.SearchProjectButton.TabIndex = 132;
            this.SearchProjectButton.Text = "SEARCH";
            this.SearchProjectButton.UseVisualStyleBackColor = false;
            this.SearchProjectButton.Click += new System.EventHandler(this.SearchProjectButton_Click);
            // 
            // btnIncludeProjectDesign
            // 
            this.btnIncludeProjectDesign.BackColor = System.Drawing.Color.Black;
            this.btnIncludeProjectDesign.BackgroundImage = global::Citicon.Properties.Resources.right_arrow;
            this.btnIncludeProjectDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncludeProjectDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncludeProjectDesign.ForeColor = System.Drawing.Color.White;
            this.btnIncludeProjectDesign.Location = new System.Drawing.Point(516, 326);
            this.btnIncludeProjectDesign.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncludeProjectDesign.Name = "btnIncludeProjectDesign";
            this.btnIncludeProjectDesign.Size = new System.Drawing.Size(43, 45);
            this.btnIncludeProjectDesign.TabIndex = 74;
            this.btnIncludeProjectDesign.UseVisualStyleBackColor = false;
            this.btnIncludeProjectDesign.Click += new System.EventHandler(this.BtnIncludeProjectDesign_Click);
            // 
            // btnExcludeProjectDesign
            // 
            this.btnExcludeProjectDesign.BackColor = System.Drawing.Color.Black;
            this.btnExcludeProjectDesign.BackgroundImage = global::Citicon.Properties.Resources.left_arrow;
            this.btnExcludeProjectDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcludeProjectDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcludeProjectDesign.ForeColor = System.Drawing.Color.White;
            this.btnExcludeProjectDesign.Location = new System.Drawing.Point(516, 374);
            this.btnExcludeProjectDesign.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcludeProjectDesign.Name = "btnExcludeProjectDesign";
            this.btnExcludeProjectDesign.Size = new System.Drawing.Size(43, 45);
            this.btnExcludeProjectDesign.TabIndex = 73;
            this.btnExcludeProjectDesign.UseVisualStyleBackColor = false;
            this.btnExcludeProjectDesign.Click += new System.EventHandler(this.BtnExcludeProjectDesign_Click);
            // 
            // PurchaseOrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1272, 809);
            this.Controls.Add(this.SearchProjectButton);
            this.Controls.Add(this.SearchClientButton);
            this.Controls.Add(this.nudMaximumCumulativePricePerCubicMeter);
            this.Controls.Add(this.lblMaximumCumulativePricePerCubicMeter);
            this.Controls.Add(this.lblMaxVolume);
            this.Controls.Add(this.nudMaxVolume);
            this.Controls.Add(this.dgvPurchaseOrderProjectDesign);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbxProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cmbxClient);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dgvProjectDesign);
            this.Controls.Add(this.nudPurchaseOrderNumber);
            this.Controls.Add(this.lblPurchaseOrderNumber);
            this.Controls.Add(this.btnIncludeProjectDesign);
            this.Controls.Add(this.btnExcludeProjectDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PurchaseOrderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseOrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchaseOrderNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderProjectDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumCumulativePricePerCubicMeter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.NumericUpDown nudPurchaseOrderNumber;
        private System.Windows.Forms.DataGridView dgvProjectDesign;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbxClient;
        private System.Windows.Forms.ComboBox cmbxProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderProjectDesign;
        private System.Windows.Forms.Button btnIncludeProjectDesign;
        private System.Windows.Forms.Button btnExcludeProjectDesign;
        private System.Windows.Forms.NumericUpDown nudMaxVolume;
        private System.Windows.Forms.Label lblMaxVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseOrderProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseOrderProjectDesign_ProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseOrderProjectDesign_MaxVolume;
        private System.Windows.Forms.Label lblMaximumCumulativePricePerCubicMeter;
        private System.Windows.Forms.NumericUpDown nudMaximumCumulativePricePerCubicMeter;
        private System.Windows.Forms.Button SearchClientButton;
        private System.Windows.Forms.Button SearchProjectButton;
    }
}