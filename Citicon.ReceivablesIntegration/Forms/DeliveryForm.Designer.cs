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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.dgvScheduledProjectDesign = new System.Windows.Forms.DataGridView();
            this.colScheduledProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduledProjectDesign_ProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduledProjectDesign_ProjectDesign_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.colPersonnel_Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPersonnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonnel_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).BeginInit();
            this.gbxProjectDesignDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
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
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvScheduledProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvScheduledProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvScheduledProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScheduledProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvScheduledProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScheduledProjectDesign.ColumnHeadersHeight = 60;
            this.dgvScheduledProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScheduledProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScheduledProjectDesign,
            this.colScheduledProjectDesign_ProjectDesign,
            this.colScheduledProjectDesign_ProjectDesign_Project});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledProjectDesign.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScheduledProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvScheduledProjectDesign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvScheduledProjectDesign.Location = new System.Drawing.Point(11, 12);
            this.dgvScheduledProjectDesign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvScheduledProjectDesign.MultiSelect = false;
            this.dgvScheduledProjectDesign.Name = "dgvScheduledProjectDesign";
            this.dgvScheduledProjectDesign.ReadOnly = true;
            this.dgvScheduledProjectDesign.RowHeadersVisible = false;
            this.dgvScheduledProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScheduledProjectDesign.RowTemplate.Height = 40;
            this.dgvScheduledProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduledProjectDesign.Size = new System.Drawing.Size(661, 417);
            this.dgvScheduledProjectDesign.TabIndex = 108;
            this.dgvScheduledProjectDesign.SelectionChanged += new System.EventHandler(this.dgvScheduledProjectDesign_SelectionChanged);
            // 
            // colScheduledProjectDesign
            // 
            this.colScheduledProjectDesign.HeaderText = "Scheduled Project Designs";
            this.colScheduledProjectDesign.MinimumWidth = 100;
            this.colScheduledProjectDesign.Name = "colScheduledProjectDesign";
            this.colScheduledProjectDesign.ReadOnly = true;
            this.colScheduledProjectDesign.Visible = false;
            this.colScheduledProjectDesign.Width = 149;
            // 
            // colScheduledProjectDesign_ProjectDesign
            // 
            this.colScheduledProjectDesign_ProjectDesign.HeaderText = "Scheduled Project Designs Today";
            this.colScheduledProjectDesign_ProjectDesign.Name = "colScheduledProjectDesign_ProjectDesign";
            this.colScheduledProjectDesign_ProjectDesign.ReadOnly = true;
            this.colScheduledProjectDesign_ProjectDesign.Width = 201;
            // 
            // colScheduledProjectDesign_ProjectDesign_Project
            // 
            this.colScheduledProjectDesign_ProjectDesign_Project.HeaderText = "Project";
            this.colScheduledProjectDesign_ProjectDesign_Project.MinimumWidth = 100;
            this.colScheduledProjectDesign_ProjectDesign_Project.Name = "colScheduledProjectDesign_ProjectDesign_Project";
            this.colScheduledProjectDesign_ProjectDesign_Project.ReadOnly = true;
            // 
            // gbxProjectDesignDetails
            // 
            this.gbxProjectDesignDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gbxProjectDesignDetails.Location = new System.Drawing.Point(12, 435);
            this.gbxProjectDesignDetails.Name = "gbxProjectDesignDetails";
            this.gbxProjectDesignDetails.Size = new System.Drawing.Size(660, 370);
            this.gbxProjectDesignDetails.TabIndex = 109;
            this.gbxProjectDesignDetails.TabStop = false;
            this.gbxProjectDesignDetails.Text = "Project Design Details";
            // 
            // tbxProjectDesignDetails_CementFactor
            // 
            this.tbxProjectDesignDetails_CementFactor.Location = new System.Drawing.Point(10, 329);
            this.tbxProjectDesignDetails_CementFactor.Name = "tbxProjectDesignDetails_CementFactor";
            this.tbxProjectDesignDetails_CementFactor.ReadOnly = true;
            this.tbxProjectDesignDetails_CementFactor.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_CementFactor.TabIndex = 17;
            // 
            // lblProjectDesignDetails_CementFactor
            // 
            this.lblProjectDesignDetails_CementFactor.AutoSize = true;
            this.lblProjectDesignDetails_CementFactor.Location = new System.Drawing.Point(6, 305);
            this.lblProjectDesignDetails_CementFactor.Name = "lblProjectDesignDetails_CementFactor";
            this.lblProjectDesignDetails_CementFactor.Size = new System.Drawing.Size(110, 21);
            this.lblProjectDesignDetails_CementFactor.TabIndex = 16;
            this.lblProjectDesignDetails_CementFactor.Text = "Cement Factor";
            // 
            // tbxProjectDesignDetails_Strength
            // 
            this.tbxProjectDesignDetails_Strength.Location = new System.Drawing.Point(331, 273);
            this.tbxProjectDesignDetails_Strength.Name = "tbxProjectDesignDetails_Strength";
            this.tbxProjectDesignDetails_Strength.ReadOnly = true;
            this.tbxProjectDesignDetails_Strength.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_Strength.TabIndex = 15;
            // 
            // lblProjectDesignDetails_Strength
            // 
            this.lblProjectDesignDetails_Strength.AutoSize = true;
            this.lblProjectDesignDetails_Strength.Location = new System.Drawing.Point(327, 249);
            this.lblProjectDesignDetails_Strength.Name = "lblProjectDesignDetails_Strength";
            this.lblProjectDesignDetails_Strength.Size = new System.Drawing.Size(69, 21);
            this.lblProjectDesignDetails_Strength.TabIndex = 14;
            this.lblProjectDesignDetails_Strength.Text = "Strength";
            // 
            // tbxProjectDesignDetails_Aggregate
            // 
            this.tbxProjectDesignDetails_Aggregate.Location = new System.Drawing.Point(10, 273);
            this.tbxProjectDesignDetails_Aggregate.Name = "tbxProjectDesignDetails_Aggregate";
            this.tbxProjectDesignDetails_Aggregate.ReadOnly = true;
            this.tbxProjectDesignDetails_Aggregate.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_Aggregate.TabIndex = 13;
            // 
            // lblProjectDesignDetails_Aggregate
            // 
            this.lblProjectDesignDetails_Aggregate.AutoSize = true;
            this.lblProjectDesignDetails_Aggregate.Location = new System.Drawing.Point(6, 249);
            this.lblProjectDesignDetails_Aggregate.Name = "lblProjectDesignDetails_Aggregate";
            this.lblProjectDesignDetails_Aggregate.Size = new System.Drawing.Size(82, 21);
            this.lblProjectDesignDetails_Aggregate.TabIndex = 12;
            this.lblProjectDesignDetails_Aggregate.Text = "Aggregate";
            // 
            // tbxProjectDesignDetails_Psi
            // 
            this.tbxProjectDesignDetails_Psi.Location = new System.Drawing.Point(331, 217);
            this.tbxProjectDesignDetails_Psi.Name = "tbxProjectDesignDetails_Psi";
            this.tbxProjectDesignDetails_Psi.ReadOnly = true;
            this.tbxProjectDesignDetails_Psi.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_Psi.TabIndex = 11;
            // 
            // lblProjectDesignDetails_Psi
            // 
            this.lblProjectDesignDetails_Psi.AutoSize = true;
            this.lblProjectDesignDetails_Psi.Location = new System.Drawing.Point(327, 193);
            this.lblProjectDesignDetails_Psi.Name = "lblProjectDesignDetails_Psi";
            this.lblProjectDesignDetails_Psi.Size = new System.Drawing.Size(32, 21);
            this.lblProjectDesignDetails_Psi.TabIndex = 10;
            this.lblProjectDesignDetails_Psi.Text = "PSI";
            // 
            // tbxProjectDesignDetails_MixType
            // 
            this.tbxProjectDesignDetails_MixType.Location = new System.Drawing.Point(10, 217);
            this.tbxProjectDesignDetails_MixType.Name = "tbxProjectDesignDetails_MixType";
            this.tbxProjectDesignDetails_MixType.ReadOnly = true;
            this.tbxProjectDesignDetails_MixType.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_MixType.TabIndex = 9;
            // 
            // lblProjectDesignDetails_MixType
            // 
            this.lblProjectDesignDetails_MixType.AutoSize = true;
            this.lblProjectDesignDetails_MixType.Location = new System.Drawing.Point(6, 193);
            this.lblProjectDesignDetails_MixType.Name = "lblProjectDesignDetails_MixType";
            this.lblProjectDesignDetails_MixType.Size = new System.Drawing.Size(71, 21);
            this.lblProjectDesignDetails_MixType.TabIndex = 8;
            this.lblProjectDesignDetails_MixType.Text = "Mix Type";
            // 
            // tbxProjectDesignDetails_InitialVolume
            // 
            this.tbxProjectDesignDetails_InitialVolume.Location = new System.Drawing.Point(331, 161);
            this.tbxProjectDesignDetails_InitialVolume.Name = "tbxProjectDesignDetails_InitialVolume";
            this.tbxProjectDesignDetails_InitialVolume.ReadOnly = true;
            this.tbxProjectDesignDetails_InitialVolume.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_InitialVolume.TabIndex = 7;
            // 
            // lblProjectDesignDetails_InitialVolume
            // 
            this.lblProjectDesignDetails_InitialVolume.AutoSize = true;
            this.lblProjectDesignDetails_InitialVolume.Location = new System.Drawing.Point(327, 137);
            this.lblProjectDesignDetails_InitialVolume.Name = "lblProjectDesignDetails_InitialVolume";
            this.lblProjectDesignDetails_InitialVolume.Size = new System.Drawing.Size(105, 21);
            this.lblProjectDesignDetails_InitialVolume.TabIndex = 6;
            this.lblProjectDesignDetails_InitialVolume.Text = "Initial Volume";
            // 
            // tbxProjectDesignDetails_PricePerCubicMeter
            // 
            this.tbxProjectDesignDetails_PricePerCubicMeter.Location = new System.Drawing.Point(10, 161);
            this.tbxProjectDesignDetails_PricePerCubicMeter.Name = "tbxProjectDesignDetails_PricePerCubicMeter";
            this.tbxProjectDesignDetails_PricePerCubicMeter.ReadOnly = true;
            this.tbxProjectDesignDetails_PricePerCubicMeter.Size = new System.Drawing.Size(315, 29);
            this.tbxProjectDesignDetails_PricePerCubicMeter.TabIndex = 5;
            // 
            // lblProjectDesignDetails_PricePerCubicMeter
            // 
            this.lblProjectDesignDetails_PricePerCubicMeter.AutoSize = true;
            this.lblProjectDesignDetails_PricePerCubicMeter.Location = new System.Drawing.Point(6, 137);
            this.lblProjectDesignDetails_PricePerCubicMeter.Name = "lblProjectDesignDetails_PricePerCubicMeter";
            this.lblProjectDesignDetails_PricePerCubicMeter.Size = new System.Drawing.Size(101, 21);
            this.lblProjectDesignDetails_PricePerCubicMeter.TabIndex = 4;
            this.lblProjectDesignDetails_PricePerCubicMeter.Text = "Price / Cu. M.";
            // 
            // tbxProjectDesignDetails_Project
            // 
            this.tbxProjectDesignDetails_Project.Location = new System.Drawing.Point(10, 105);
            this.tbxProjectDesignDetails_Project.Name = "tbxProjectDesignDetails_Project";
            this.tbxProjectDesignDetails_Project.ReadOnly = true;
            this.tbxProjectDesignDetails_Project.Size = new System.Drawing.Size(636, 29);
            this.tbxProjectDesignDetails_Project.TabIndex = 3;
            // 
            // lblProjectDesignDetails_Project
            // 
            this.lblProjectDesignDetails_Project.AutoSize = true;
            this.lblProjectDesignDetails_Project.Location = new System.Drawing.Point(6, 81);
            this.lblProjectDesignDetails_Project.Name = "lblProjectDesignDetails_Project";
            this.lblProjectDesignDetails_Project.Size = new System.Drawing.Size(58, 21);
            this.lblProjectDesignDetails_Project.TabIndex = 2;
            this.lblProjectDesignDetails_Project.Text = "Project";
            // 
            // tbxProjectDesignDetails_Project_Client
            // 
            this.tbxProjectDesignDetails_Project_Client.Location = new System.Drawing.Point(10, 49);
            this.tbxProjectDesignDetails_Project_Client.Name = "tbxProjectDesignDetails_Project_Client";
            this.tbxProjectDesignDetails_Project_Client.ReadOnly = true;
            this.tbxProjectDesignDetails_Project_Client.Size = new System.Drawing.Size(636, 29);
            this.tbxProjectDesignDetails_Project_Client.TabIndex = 1;
            // 
            // lblProjectDesignDetails_Project_Client
            // 
            this.lblProjectDesignDetails_Project_Client.AutoSize = true;
            this.lblProjectDesignDetails_Project_Client.Location = new System.Drawing.Point(6, 25);
            this.lblProjectDesignDetails_Project_Client.Name = "lblProjectDesignDetails_Project_Client";
            this.lblProjectDesignDetails_Project_Client.Size = new System.Drawing.Size(50, 21);
            this.lblProjectDesignDetails_Project_Client.TabIndex = 0;
            this.lblProjectDesignDetails_Project_Client.Text = "Client";
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPersonnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonnel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPersonnel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonnel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPersonnel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPersonnel.ColumnHeadersHeight = 60;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonnel_Selected,
            this.colPersonnel,
            this.colPersonnel_Position});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonnel.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPersonnel.EnableHeadersVisualStyles = false;
            this.dgvPersonnel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPersonnel.Location = new System.Drawing.Point(676, 12);
            this.dgvPersonnel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersVisible = false;
            this.dgvPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersonnel.RowTemplate.Height = 40;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(750, 737);
            this.dgvPersonnel.TabIndex = 110;
            // 
            // colPersonnel_Selected
            // 
            this.colPersonnel_Selected.HeaderText = "";
            this.colPersonnel_Selected.MinimumWidth = 75;
            this.colPersonnel_Selected.Name = "colPersonnel_Selected";
            this.colPersonnel_Selected.Width = 75;
            // 
            // colPersonnel
            // 
            this.colPersonnel.HeaderText = "Personnel";
            this.colPersonnel.MinimumWidth = 150;
            this.colPersonnel.Name = "colPersonnel";
            this.colPersonnel.ReadOnly = true;
            this.colPersonnel.Width = 150;
            // 
            // colPersonnel_Position
            // 
            this.colPersonnel_Position.HeaderText = "Position";
            this.colPersonnel_Position.MinimumWidth = 200;
            this.colPersonnel_Position.Name = "colPersonnel_Position";
            this.colPersonnel_Position.ReadOnly = true;
            this.colPersonnel_Position.Width = 200;
            // 
            // btnConfirmDelivery
            // 
            this.btnConfirmDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmDelivery.BackColor = System.Drawing.Color.Red;
            this.btnConfirmDelivery.FlatAppearance.BorderSize = 0;
            this.btnConfirmDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDelivery.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDelivery.Location = new System.Drawing.Point(1276, 755);
            this.btnConfirmDelivery.Name = "btnConfirmDelivery";
            this.btnConfirmDelivery.Size = new System.Drawing.Size(150, 50);
            this.btnConfirmDelivery.TabIndex = 111;
            this.btnConfirmDelivery.Text = "Confirm Delivery";
            this.btnConfirmDelivery.UseVisualStyleBackColor = false;
            this.btnConfirmDelivery.Click += new System.EventHandler(this.btnConfirmDelivery_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 817);
            this.Controls.Add(this.btnConfirmDelivery);
            this.Controls.Add(this.dgvPersonnel);
            this.Controls.Add(this.gbxProjectDesignDetails);
            this.Controls.Add(this.dgvScheduledProjectDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).EndInit();
            this.gbxProjectDesignDetails.ResumeLayout(false);
            this.gbxProjectDesignDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign_ProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign_ProjectDesign_Project;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPersonnel_Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonnel_Position;
        private System.Windows.Forms.Button btnConfirmDelivery;
    }
}