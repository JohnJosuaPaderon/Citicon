namespace Citicon.ReceivablesIntegration.Forms
{
    partial class DeliveryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.dgvScheduledProjectDesign = new System.Windows.Forms.DataGridView();
            this.colScheduledProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduledProjectDesign_ProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledProjectDesign_PurchaseOrderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledProjectDesign_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxProjectDesignDetails = new System.Windows.Forms.GroupBox();
            this.tbxProjectDesignDetails_CementFactor = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_CementFactor = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_Strength = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_Strength = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_Aggregate = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_Aggregate = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_Psi = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_Psi = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_MixType = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_MixType = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_InitialVolume = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_InitialVolume = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_PricePerCubicMeter = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_PricePerCubicMeter = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_Project = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_Project = new System.Windows.Forms.Label();
            this.tbxProjectDesignDetails_Project_Client = new System.Windows.Forms.TextBox();
            this.lblProjectDesignDetails_Project_Client = new System.Windows.Forms.Label();
            this.btnConfirmDelivery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDataGridView = new System.Windows.Forms.DataGridView();
            this.ProjectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReprintDeliveryReceiptLabel = new System.Windows.Forms.Label();
            this.ReprintDeliveryReceiptTextBox = new System.Windows.Forms.TextBox();
            this.ReprintDeliveryReceiptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).BeginInit();
            this.gbxProjectDesignDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScheduledProjectDesign
            // 
            this.dgvScheduledProjectDesign.AllowUserToAddRows = false;
            this.dgvScheduledProjectDesign.AllowUserToDeleteRows = false;
            this.dgvScheduledProjectDesign.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvScheduledProjectDesign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScheduledProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScheduledProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvScheduledProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvScheduledProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScheduledProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvScheduledProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScheduledProjectDesign.ColumnHeadersHeight = 60;
            this.dgvScheduledProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScheduledProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScheduledProjectDesign,
            this.colScheduledProjectDesign_ProjectDesign,
            this.ScheduledProjectDesign_PurchaseOrderColumn,
            this.ScheduledProjectDesign_ExtraColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledProjectDesign.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScheduledProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvScheduledProjectDesign.GridColor = System.Drawing.Color.Red;
            this.dgvScheduledProjectDesign.Location = new System.Drawing.Point(606, 10);
            this.dgvScheduledProjectDesign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvScheduledProjectDesign.MultiSelect = false;
            this.dgvScheduledProjectDesign.Name = "dgvScheduledProjectDesign";
            this.dgvScheduledProjectDesign.ReadOnly = true;
            this.dgvScheduledProjectDesign.RowHeadersVisible = false;
            this.dgvScheduledProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvScheduledProjectDesign.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScheduledProjectDesign.RowTemplate.Height = 40;
            this.dgvScheduledProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduledProjectDesign.Size = new System.Drawing.Size(513, 433);
            this.dgvScheduledProjectDesign.TabIndex = 108;
            this.dgvScheduledProjectDesign.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduledProjectDesign_CellContentClick);
            this.dgvScheduledProjectDesign.SelectionChanged += new System.EventHandler(this.DgvScheduledProjectDesign_SelectionChanged);
            // 
            // colScheduledProjectDesign
            // 
            this.colScheduledProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colScheduledProjectDesign.HeaderText = "Scheduled Project Designs";
            this.colScheduledProjectDesign.MinimumWidth = 100;
            this.colScheduledProjectDesign.Name = "colScheduledProjectDesign";
            this.colScheduledProjectDesign.ReadOnly = true;
            this.colScheduledProjectDesign.Visible = false;
            this.colScheduledProjectDesign.Width = 149;
            // 
            // colScheduledProjectDesign_ProjectDesign
            // 
            this.colScheduledProjectDesign_ProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colScheduledProjectDesign_ProjectDesign.HeaderText = "SCHEDULED PROJECT DESIGNS TODAY";
            this.colScheduledProjectDesign_ProjectDesign.Name = "colScheduledProjectDesign_ProjectDesign";
            this.colScheduledProjectDesign_ProjectDesign.ReadOnly = true;
            this.colScheduledProjectDesign_ProjectDesign.Width = 131;
            // 
            // ScheduledProjectDesign_PurchaseOrderColumn
            // 
            this.ScheduledProjectDesign_PurchaseOrderColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ScheduledProjectDesign_PurchaseOrderColumn.HeaderText = "PO No.";
            this.ScheduledProjectDesign_PurchaseOrderColumn.Name = "ScheduledProjectDesign_PurchaseOrderColumn";
            this.ScheduledProjectDesign_PurchaseOrderColumn.ReadOnly = true;
            this.ScheduledProjectDesign_PurchaseOrderColumn.Width = 68;
            // 
            // ScheduledProjectDesign_ExtraColumn
            // 
            this.ScheduledProjectDesign_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScheduledProjectDesign_ExtraColumn.HeaderText = "";
            this.ScheduledProjectDesign_ExtraColumn.Name = "ScheduledProjectDesign_ExtraColumn";
            this.ScheduledProjectDesign_ExtraColumn.ReadOnly = true;
            // 
            // gbxProjectDesignDetails
            // 
            this.gbxProjectDesignDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_CementFactor);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_CementFactor);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_Strength);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_Strength);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_Aggregate);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_Aggregate);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_Psi);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_Psi);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_MixType);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_MixType);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_InitialVolume);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_InitialVolume);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_PricePerCubicMeter);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_PricePerCubicMeter);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_Project);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_Project);
            this.gbxProjectDesignDetails.Controls.Add(this.tbxProjectDesignDetails_Project_Client);
            this.gbxProjectDesignDetails.Controls.Add(this.lblProjectDesignDetails_Project_Client);
            this.gbxProjectDesignDetails.Location = new System.Drawing.Point(606, 447);
            this.gbxProjectDesignDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxProjectDesignDetails.Name = "gbxProjectDesignDetails";
            this.gbxProjectDesignDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxProjectDesignDetails.Size = new System.Drawing.Size(513, 255);
            this.gbxProjectDesignDetails.TabIndex = 109;
            this.gbxProjectDesignDetails.TabStop = false;
            this.gbxProjectDesignDetails.Text = "Project Design Details";
            this.gbxProjectDesignDetails.Enter += new System.EventHandler(this.gbxProjectDesignDetails_Enter);
            // 
            // tbxProjectDesignDetails_CementFactor
            // 
            this.tbxProjectDesignDetails_CementFactor.Location = new System.Drawing.Point(257, 221);
            this.tbxProjectDesignDetails_CementFactor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_CementFactor.Name = "tbxProjectDesignDetails_CementFactor";
            this.tbxProjectDesignDetails_CementFactor.ReadOnly = true;
            this.tbxProjectDesignDetails_CementFactor.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_CementFactor.TabIndex = 17;
            // 
            // lblProjectDesignDetails_CementFactor
            // 
            this.lblProjectDesignDetails_CementFactor.AutoSize = true;
            this.lblProjectDesignDetails_CementFactor.Location = new System.Drawing.Point(254, 202);
            this.lblProjectDesignDetails_CementFactor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_CementFactor.Name = "lblProjectDesignDetails_CementFactor";
            this.lblProjectDesignDetails_CementFactor.Size = new System.Drawing.Size(92, 17);
            this.lblProjectDesignDetails_CementFactor.TabIndex = 16;
            this.lblProjectDesignDetails_CementFactor.Text = "Cement Factor";
            // 
            // tbxProjectDesignDetails_Strength
            // 
            this.tbxProjectDesignDetails_Strength.Location = new System.Drawing.Point(8, 221);
            this.tbxProjectDesignDetails_Strength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_Strength.Name = "tbxProjectDesignDetails_Strength";
            this.tbxProjectDesignDetails_Strength.ReadOnly = true;
            this.tbxProjectDesignDetails_Strength.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_Strength.TabIndex = 15;
            // 
            // lblProjectDesignDetails_Strength
            // 
            this.lblProjectDesignDetails_Strength.AutoSize = true;
            this.lblProjectDesignDetails_Strength.Location = new System.Drawing.Point(5, 202);
            this.lblProjectDesignDetails_Strength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_Strength.Name = "lblProjectDesignDetails_Strength";
            this.lblProjectDesignDetails_Strength.Size = new System.Drawing.Size(57, 17);
            this.lblProjectDesignDetails_Strength.TabIndex = 14;
            this.lblProjectDesignDetails_Strength.Text = "Strength";
            // 
            // tbxProjectDesignDetails_Aggregate
            // 
            this.tbxProjectDesignDetails_Aggregate.Location = new System.Drawing.Point(257, 176);
            this.tbxProjectDesignDetails_Aggregate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_Aggregate.Name = "tbxProjectDesignDetails_Aggregate";
            this.tbxProjectDesignDetails_Aggregate.ReadOnly = true;
            this.tbxProjectDesignDetails_Aggregate.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_Aggregate.TabIndex = 13;
            // 
            // lblProjectDesignDetails_Aggregate
            // 
            this.lblProjectDesignDetails_Aggregate.AutoSize = true;
            this.lblProjectDesignDetails_Aggregate.Location = new System.Drawing.Point(254, 156);
            this.lblProjectDesignDetails_Aggregate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_Aggregate.Name = "lblProjectDesignDetails_Aggregate";
            this.lblProjectDesignDetails_Aggregate.Size = new System.Drawing.Size(70, 17);
            this.lblProjectDesignDetails_Aggregate.TabIndex = 12;
            this.lblProjectDesignDetails_Aggregate.Text = "Aggregate";
            // 
            // tbxProjectDesignDetails_Psi
            // 
            this.tbxProjectDesignDetails_Psi.Location = new System.Drawing.Point(8, 176);
            this.tbxProjectDesignDetails_Psi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_Psi.Name = "tbxProjectDesignDetails_Psi";
            this.tbxProjectDesignDetails_Psi.ReadOnly = true;
            this.tbxProjectDesignDetails_Psi.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_Psi.TabIndex = 11;
            // 
            // lblProjectDesignDetails_Psi
            // 
            this.lblProjectDesignDetails_Psi.AutoSize = true;
            this.lblProjectDesignDetails_Psi.Location = new System.Drawing.Point(5, 156);
            this.lblProjectDesignDetails_Psi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_Psi.Name = "lblProjectDesignDetails_Psi";
            this.lblProjectDesignDetails_Psi.Size = new System.Drawing.Size(25, 17);
            this.lblProjectDesignDetails_Psi.TabIndex = 10;
            this.lblProjectDesignDetails_Psi.Text = "PSI";
            // 
            // tbxProjectDesignDetails_MixType
            // 
            this.tbxProjectDesignDetails_MixType.Location = new System.Drawing.Point(257, 130);
            this.tbxProjectDesignDetails_MixType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_MixType.Name = "tbxProjectDesignDetails_MixType";
            this.tbxProjectDesignDetails_MixType.ReadOnly = true;
            this.tbxProjectDesignDetails_MixType.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_MixType.TabIndex = 9;
            // 
            // lblProjectDesignDetails_MixType
            // 
            this.lblProjectDesignDetails_MixType.AutoSize = true;
            this.lblProjectDesignDetails_MixType.Location = new System.Drawing.Point(254, 111);
            this.lblProjectDesignDetails_MixType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_MixType.Name = "lblProjectDesignDetails_MixType";
            this.lblProjectDesignDetails_MixType.Size = new System.Drawing.Size(60, 17);
            this.lblProjectDesignDetails_MixType.TabIndex = 8;
            this.lblProjectDesignDetails_MixType.Text = "Mix Type";
            // 
            // tbxProjectDesignDetails_InitialVolume
            // 
            this.tbxProjectDesignDetails_InitialVolume.Location = new System.Drawing.Point(8, 130);
            this.tbxProjectDesignDetails_InitialVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_InitialVolume.Name = "tbxProjectDesignDetails_InitialVolume";
            this.tbxProjectDesignDetails_InitialVolume.ReadOnly = true;
            this.tbxProjectDesignDetails_InitialVolume.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_InitialVolume.TabIndex = 7;
            // 
            // lblProjectDesignDetails_InitialVolume
            // 
            this.lblProjectDesignDetails_InitialVolume.AutoSize = true;
            this.lblProjectDesignDetails_InitialVolume.Location = new System.Drawing.Point(5, 111);
            this.lblProjectDesignDetails_InitialVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_InitialVolume.Name = "lblProjectDesignDetails_InitialVolume";
            this.lblProjectDesignDetails_InitialVolume.Size = new System.Drawing.Size(85, 17);
            this.lblProjectDesignDetails_InitialVolume.TabIndex = 6;
            this.lblProjectDesignDetails_InitialVolume.Text = "Initial Volume";
            // 
            // tbxProjectDesignDetails_PricePerCubicMeter
            // 
            this.tbxProjectDesignDetails_PricePerCubicMeter.Location = new System.Drawing.Point(257, 266);
            this.tbxProjectDesignDetails_PricePerCubicMeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_PricePerCubicMeter.Name = "tbxProjectDesignDetails_PricePerCubicMeter";
            this.tbxProjectDesignDetails_PricePerCubicMeter.ReadOnly = true;
            this.tbxProjectDesignDetails_PricePerCubicMeter.Size = new System.Drawing.Size(246, 25);
            this.tbxProjectDesignDetails_PricePerCubicMeter.TabIndex = 5;
            this.tbxProjectDesignDetails_PricePerCubicMeter.Visible = false;
            // 
            // lblProjectDesignDetails_PricePerCubicMeter
            // 
            this.lblProjectDesignDetails_PricePerCubicMeter.AutoSize = true;
            this.lblProjectDesignDetails_PricePerCubicMeter.Location = new System.Drawing.Point(254, 247);
            this.lblProjectDesignDetails_PricePerCubicMeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_PricePerCubicMeter.Name = "lblProjectDesignDetails_PricePerCubicMeter";
            this.lblProjectDesignDetails_PricePerCubicMeter.Size = new System.Drawing.Size(86, 17);
            this.lblProjectDesignDetails_PricePerCubicMeter.TabIndex = 4;
            this.lblProjectDesignDetails_PricePerCubicMeter.Text = "Price / Cu. M.";
            this.lblProjectDesignDetails_PricePerCubicMeter.Visible = false;
            // 
            // tbxProjectDesignDetails_Project
            // 
            this.tbxProjectDesignDetails_Project.Location = new System.Drawing.Point(8, 85);
            this.tbxProjectDesignDetails_Project.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_Project.Name = "tbxProjectDesignDetails_Project";
            this.tbxProjectDesignDetails_Project.ReadOnly = true;
            this.tbxProjectDesignDetails_Project.Size = new System.Drawing.Size(496, 25);
            this.tbxProjectDesignDetails_Project.TabIndex = 3;
            // 
            // lblProjectDesignDetails_Project
            // 
            this.lblProjectDesignDetails_Project.AutoSize = true;
            this.lblProjectDesignDetails_Project.Location = new System.Drawing.Point(5, 66);
            this.lblProjectDesignDetails_Project.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_Project.Name = "lblProjectDesignDetails_Project";
            this.lblProjectDesignDetails_Project.Size = new System.Drawing.Size(48, 17);
            this.lblProjectDesignDetails_Project.TabIndex = 2;
            this.lblProjectDesignDetails_Project.Text = "Project";
            // 
            // tbxProjectDesignDetails_Project_Client
            // 
            this.tbxProjectDesignDetails_Project_Client.Location = new System.Drawing.Point(8, 40);
            this.tbxProjectDesignDetails_Project_Client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxProjectDesignDetails_Project_Client.Name = "tbxProjectDesignDetails_Project_Client";
            this.tbxProjectDesignDetails_Project_Client.ReadOnly = true;
            this.tbxProjectDesignDetails_Project_Client.Size = new System.Drawing.Size(496, 25);
            this.tbxProjectDesignDetails_Project_Client.TabIndex = 1;
            // 
            // lblProjectDesignDetails_Project_Client
            // 
            this.lblProjectDesignDetails_Project_Client.AutoSize = true;
            this.lblProjectDesignDetails_Project_Client.Location = new System.Drawing.Point(5, 20);
            this.lblProjectDesignDetails_Project_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectDesignDetails_Project_Client.Name = "lblProjectDesignDetails_Project_Client";
            this.lblProjectDesignDetails_Project_Client.Size = new System.Drawing.Size(40, 17);
            this.lblProjectDesignDetails_Project_Client.TabIndex = 0;
            this.lblProjectDesignDetails_Project_Client.Text = "Client";
            // 
            // btnConfirmDelivery
            // 
            this.btnConfirmDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmDelivery.BackColor = System.Drawing.Color.Red;
            this.btnConfirmDelivery.FlatAppearance.BorderSize = 0;
            this.btnConfirmDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDelivery.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDelivery.Location = new System.Drawing.Point(881, 707);
            this.btnConfirmDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmDelivery.Name = "btnConfirmDelivery";
            this.btnConfirmDelivery.Size = new System.Drawing.Size(117, 40);
            this.btnConfirmDelivery.TabIndex = 111;
            this.btnConfirmDelivery.Text = "Confirm Delivery";
            this.btnConfirmDelivery.UseVisualStyleBackColor = false;
            this.btnConfirmDelivery.Click += new System.EventHandler(this.BtnConfirmDelivery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1002, 707);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 112;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.AllowUserToAddRows = false;
            this.ClientDataGridView.AllowUserToDeleteRows = false;
            this.ClientDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ClientDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientDataGridView.ColumnHeadersHeight = 60;
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientColumn,
            this.Client_ExtraColumn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ClientDataGridView.EnableHeadersVisualStyles = false;
            this.ClientDataGridView.GridColor = System.Drawing.Color.Red;
            this.ClientDataGridView.Location = new System.Drawing.Point(9, 10);
            this.ClientDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientDataGridView.MultiSelect = false;
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.ReadOnly = true;
            this.ClientDataGridView.RowHeadersVisible = false;
            this.ClientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ClientDataGridView.RowTemplate.Height = 40;
            this.ClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDataGridView.Size = new System.Drawing.Size(594, 433);
            this.ClientDataGridView.TabIndex = 113;
            this.ClientDataGridView.SelectionChanged += new System.EventHandler(this.ClientDataGridView_SelectionChanged);
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClientColumn.HeaderText = "CLIENTS";
            this.ClientColumn.MinimumWidth = 100;
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            // 
            // Client_ExtraColumn
            // 
            this.Client_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client_ExtraColumn.HeaderText = "";
            this.Client_ExtraColumn.Name = "Client_ExtraColumn";
            this.Client_ExtraColumn.ReadOnly = true;
            // 
            // ProjectDataGridView
            // 
            this.ProjectDataGridView.AllowUserToAddRows = false;
            this.ProjectDataGridView.AllowUserToDeleteRows = false;
            this.ProjectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ProjectDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProjectDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProjectDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ProjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ProjectDataGridView.ColumnHeadersHeight = 60;
            this.ProjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectColumn,
            this.Project_ExtraColumn});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProjectDataGridView.EnableHeadersVisualStyles = false;
            this.ProjectDataGridView.GridColor = System.Drawing.Color.Red;
            this.ProjectDataGridView.Location = new System.Drawing.Point(8, 447);
            this.ProjectDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProjectDataGridView.MultiSelect = false;
            this.ProjectDataGridView.Name = "ProjectDataGridView";
            this.ProjectDataGridView.ReadOnly = true;
            this.ProjectDataGridView.RowHeadersVisible = false;
            this.ProjectDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ProjectDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.ProjectDataGridView.RowTemplate.Height = 40;
            this.ProjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProjectDataGridView.Size = new System.Drawing.Size(594, 255);
            this.ProjectDataGridView.TabIndex = 114;
            this.ProjectDataGridView.SelectionChanged += new System.EventHandler(this.ProjectDataGridView_SelectionChanged);
            // 
            // ProjectColumn
            // 
            this.ProjectColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectColumn.HeaderText = "PROJECTS";
            this.ProjectColumn.MinimumWidth = 100;
            this.ProjectColumn.Name = "ProjectColumn";
            this.ProjectColumn.ReadOnly = true;
            // 
            // Project_ExtraColumn
            // 
            this.Project_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project_ExtraColumn.HeaderText = "";
            this.Project_ExtraColumn.Name = "Project_ExtraColumn";
            this.Project_ExtraColumn.ReadOnly = true;
            // 
            // ReprintDeliveryReceiptLabel
            // 
            this.ReprintDeliveryReceiptLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReprintDeliveryReceiptLabel.AutoSize = true;
            this.ReprintDeliveryReceiptLabel.Location = new System.Drawing.Point(8, 707);
            this.ReprintDeliveryReceiptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReprintDeliveryReceiptLabel.Name = "ReprintDeliveryReceiptLabel";
            this.ReprintDeliveryReceiptLabel.Size = new System.Drawing.Size(71, 17);
            this.ReprintDeliveryReceiptLabel.TabIndex = 115;
            this.ReprintDeliveryReceiptLabel.Text = "Reprint DR";
            // 
            // ReprintDeliveryReceiptTextBox
            // 
            this.ReprintDeliveryReceiptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReprintDeliveryReceiptTextBox.Location = new System.Drawing.Point(11, 727);
            this.ReprintDeliveryReceiptTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReprintDeliveryReceiptTextBox.Name = "ReprintDeliveryReceiptTextBox";
            this.ReprintDeliveryReceiptTextBox.Size = new System.Drawing.Size(163, 25);
            this.ReprintDeliveryReceiptTextBox.TabIndex = 116;
            // 
            // ReprintDeliveryReceiptButton
            // 
            this.ReprintDeliveryReceiptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReprintDeliveryReceiptButton.BackColor = System.Drawing.Color.Red;
            this.ReprintDeliveryReceiptButton.FlatAppearance.BorderSize = 0;
            this.ReprintDeliveryReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReprintDeliveryReceiptButton.ForeColor = System.Drawing.Color.White;
            this.ReprintDeliveryReceiptButton.Location = new System.Drawing.Point(177, 710);
            this.ReprintDeliveryReceiptButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReprintDeliveryReceiptButton.Name = "ReprintDeliveryReceiptButton";
            this.ReprintDeliveryReceiptButton.Size = new System.Drawing.Size(95, 40);
            this.ReprintDeliveryReceiptButton.TabIndex = 117;
            this.ReprintDeliveryReceiptButton.Text = "Re-print";
            this.ReprintDeliveryReceiptButton.UseVisualStyleBackColor = false;
            this.ReprintDeliveryReceiptButton.Click += new System.EventHandler(this.ReprintDeliveryReceiptButton_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 757);
            this.Controls.Add(this.ReprintDeliveryReceiptButton);
            this.Controls.Add(this.ReprintDeliveryReceiptTextBox);
            this.Controls.Add(this.ReprintDeliveryReceiptLabel);
            this.Controls.Add(this.ProjectDataGridView);
            this.Controls.Add(this.ClientDataGridView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmDelivery);
            this.Controls.Add(this.gbxProjectDesignDetails);
            this.Controls.Add(this.dgvScheduledProjectDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).EndInit();
            this.gbxProjectDesignDetails.ResumeLayout(false);
            this.gbxProjectDesignDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScheduledProjectDesign;
        private System.Windows.Forms.GroupBox gbxProjectDesignDetails;
        private System.Windows.Forms.Label lblProjectDesignDetails_Project_Client;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_Project_Client;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_Project;
        private System.Windows.Forms.Label lblProjectDesignDetails_Project;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_PricePerCubicMeter;
        private System.Windows.Forms.Label lblProjectDesignDetails_PricePerCubicMeter;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_InitialVolume;
        private System.Windows.Forms.Label lblProjectDesignDetails_InitialVolume;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_MixType;
        private System.Windows.Forms.Label lblProjectDesignDetails_MixType;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_Psi;
        private System.Windows.Forms.Label lblProjectDesignDetails_Psi;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_Aggregate;
        private System.Windows.Forms.Label lblProjectDesignDetails_Aggregate;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_Strength;
        private System.Windows.Forms.Label lblProjectDesignDetails_Strength;
        private System.Windows.Forms.TextBox tbxProjectDesignDetails_CementFactor;
        private System.Windows.Forms.Label lblProjectDesignDetails_CementFactor;
        private System.Windows.Forms.Button btnConfirmDelivery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign_ProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledProjectDesign_PurchaseOrderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduledProjectDesign_ExtraColumn;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ExtraColumn;
        private System.Windows.Forms.DataGridView ProjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_ExtraColumn;
        private System.Windows.Forms.Label ReprintDeliveryReceiptLabel;
        private System.Windows.Forms.TextBox ReprintDeliveryReceiptTextBox;
        private System.Windows.Forms.Button ReprintDeliveryReceiptButton;
    }
}