namespace Citicon.Forms
{
    partial class EngineerDeliveryCreationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineerDeliveryCreationForm));
            this.lblSelectClient = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectDesigns = new System.Windows.Forms.DataGridView();
            this.colProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_MixType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_Aggregate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_Strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_Psi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_PricePerCubicMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectDesign_CementFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProjectDesigns = new System.Windows.Forms.Label();
            this.gbxNewProjectDesign = new System.Windows.Forms.GroupBox();
            this.cmbxNewProjectDesign_MixType = new System.Windows.Forms.ComboBox();
            this.lblNewProjectDesign_MixType = new System.Windows.Forms.Label();
            this.lblNewProjectDesign_CementFactor = new System.Windows.Forms.Label();
            this.nudNewProjectDesign_CementFactor = new System.Windows.Forms.NumericUpDown();
            this.lblNewProjectDesign_PricePerCubicMeter = new System.Windows.Forms.Label();
            this.nudNewProjectDesign_PricePerCubicMeter = new System.Windows.Forms.NumericUpDown();
            this.lblNewProjectDesign_Strength = new System.Windows.Forms.Label();
            this.cmbxNewProjectDesign_Strength = new System.Windows.Forms.ComboBox();
            this.lblNewProjectDesign_Aggregate = new System.Windows.Forms.Label();
            this.cmbxNewProjectDesign_Aggregate = new System.Windows.Forms.ComboBox();
            this.nudNewProjectDesign_Psi = new System.Windows.Forms.NumericUpDown();
            this.lblNewProjectDesign_Psi = new System.Windows.Forms.Label();
            this.btnAddNewProjectDesign = new System.Windows.Forms.Button();
            this.btnCancelNewProjectDesign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesigns)).BeginInit();
            this.gbxNewProjectDesign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_CementFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_PricePerCubicMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_Psi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectClient
            // 
            this.lblSelectClient.AutoSize = true;
            this.lblSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClient.Location = new System.Drawing.Point(9, 9);
            this.lblSelectClient.Name = "lblSelectClient";
            this.lblSelectClient.Size = new System.Drawing.Size(103, 18);
            this.lblSelectClient.TabIndex = 0;
            this.lblSelectClient.Text = "Select Client";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeight = 45;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClient,
            this.colClient_Address});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.EnableHeadersVisualStyles = false;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvClients.Location = new System.Drawing.Point(12, 30);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(532, 402);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            // 
            // colClient
            // 
            this.colClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colClient.HeaderText = "Client";
            this.colClient.MinimumWidth = 150;
            this.colClient.Name = "colClient";
            this.colClient.ReadOnly = true;
            this.colClient.Width = 150;
            // 
            // colClient_Address
            // 
            this.colClient_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colClient_Address.HeaderText = "Address";
            this.colClient_Address.MinimumWidth = 150;
            this.colClient_Address.Name = "colClient_Address";
            this.colClient_Address.ReadOnly = true;
            this.colClient_Address.Width = 150;
            // 
            // lblSelectProject
            // 
            this.lblSelectProject.AutoSize = true;
            this.lblSelectProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProject.Location = new System.Drawing.Point(9, 435);
            this.lblSelectProject.Name = "lblSelectProject";
            this.lblSelectProject.Size = new System.Drawing.Size(114, 18);
            this.lblSelectProject.TabIndex = 2;
            this.lblSelectProject.Text = "Select Project";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeColumns = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProjects.ColumnHeadersHeight = 45;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProject,
            this.colProject_Location});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProjects.EnableHeadersVisualStyles = false;
            this.dgvProjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvProjects.Location = new System.Drawing.Point(12, 456);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(530, 327);
            this.dgvProjects.TabIndex = 3;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            // 
            // colProject
            // 
            this.colProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProject.HeaderText = "Projects";
            this.colProject.MinimumWidth = 150;
            this.colProject.Name = "colProject";
            this.colProject.ReadOnly = true;
            this.colProject.Width = 150;
            // 
            // colProject_Location
            // 
            this.colProject_Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProject_Location.HeaderText = "Location";
            this.colProject_Location.MinimumWidth = 150;
            this.colProject_Location.Name = "colProject_Location";
            this.colProject_Location.ReadOnly = true;
            this.colProject_Location.Width = 150;
            // 
            // dgvProjectDesigns
            // 
            this.dgvProjectDesigns.AllowUserToAddRows = false;
            this.dgvProjectDesigns.AllowUserToDeleteRows = false;
            this.dgvProjectDesigns.AllowUserToResizeColumns = false;
            this.dgvProjectDesigns.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProjectDesigns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProjectDesigns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjectDesigns.BackgroundColor = System.Drawing.Color.White;
            this.dgvProjectDesigns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjectDesigns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectDesigns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProjectDesigns.ColumnHeadersHeight = 45;
            this.dgvProjectDesigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjectDesigns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectDesign,
            this.colProjectDesign_MixType,
            this.colProjectDesign_Aggregate,
            this.colProjectDesign_Strength,
            this.colProjectDesign_Psi,
            this.colProjectDesign_PricePerCubicMeter,
            this.colProjectDesign_CementFactor});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjectDesigns.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProjectDesigns.EnableHeadersVisualStyles = false;
            this.dgvProjectDesigns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvProjectDesigns.Location = new System.Drawing.Point(550, 30);
            this.dgvProjectDesigns.MultiSelect = false;
            this.dgvProjectDesigns.Name = "dgvProjectDesigns";
            this.dgvProjectDesigns.ReadOnly = true;
            this.dgvProjectDesigns.RowHeadersVisible = false;
            this.dgvProjectDesigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDesigns.Size = new System.Drawing.Size(911, 402);
            this.dgvProjectDesigns.TabIndex = 5;
            // 
            // colProjectDesign
            // 
            this.colProjectDesign.HeaderText = "Project Design";
            this.colProjectDesign.Name = "colProjectDesign";
            this.colProjectDesign.ReadOnly = true;
            this.colProjectDesign.Visible = false;
            // 
            // colProjectDesign_MixType
            // 
            this.colProjectDesign_MixType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProjectDesign_MixType.HeaderText = "Mix Type";
            this.colProjectDesign_MixType.MinimumWidth = 150;
            this.colProjectDesign_MixType.Name = "colProjectDesign_MixType";
            this.colProjectDesign_MixType.ReadOnly = true;
            this.colProjectDesign_MixType.Width = 150;
            // 
            // colProjectDesign_Aggregate
            // 
            this.colProjectDesign_Aggregate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProjectDesign_Aggregate.HeaderText = "Aggregate";
            this.colProjectDesign_Aggregate.MinimumWidth = 150;
            this.colProjectDesign_Aggregate.Name = "colProjectDesign_Aggregate";
            this.colProjectDesign_Aggregate.ReadOnly = true;
            this.colProjectDesign_Aggregate.Width = 150;
            // 
            // colProjectDesign_Strength
            // 
            this.colProjectDesign_Strength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProjectDesign_Strength.HeaderText = "Strength";
            this.colProjectDesign_Strength.MinimumWidth = 150;
            this.colProjectDesign_Strength.Name = "colProjectDesign_Strength";
            this.colProjectDesign_Strength.ReadOnly = true;
            this.colProjectDesign_Strength.Width = 150;
            // 
            // colProjectDesign_Psi
            // 
            this.colProjectDesign_Psi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.colProjectDesign_Psi.DefaultCellStyle = dataGridViewCellStyle9;
            this.colProjectDesign_Psi.HeaderText = "PSI";
            this.colProjectDesign_Psi.MinimumWidth = 150;
            this.colProjectDesign_Psi.Name = "colProjectDesign_Psi";
            this.colProjectDesign_Psi.ReadOnly = true;
            this.colProjectDesign_Psi.Width = 150;
            // 
            // colProjectDesign_PricePerCubicMeter
            // 
            this.colProjectDesign_PricePerCubicMeter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.colProjectDesign_PricePerCubicMeter.DefaultCellStyle = dataGridViewCellStyle10;
            this.colProjectDesign_PricePerCubicMeter.HeaderText = "Price/Cu.M.";
            this.colProjectDesign_PricePerCubicMeter.MinimumWidth = 150;
            this.colProjectDesign_PricePerCubicMeter.Name = "colProjectDesign_PricePerCubicMeter";
            this.colProjectDesign_PricePerCubicMeter.ReadOnly = true;
            this.colProjectDesign_PricePerCubicMeter.Width = 150;
            // 
            // colProjectDesign_CementFactor
            // 
            this.colProjectDesign_CementFactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = null;
            this.colProjectDesign_CementFactor.DefaultCellStyle = dataGridViewCellStyle11;
            this.colProjectDesign_CementFactor.HeaderText = "Cement Factor";
            this.colProjectDesign_CementFactor.MinimumWidth = 150;
            this.colProjectDesign_CementFactor.Name = "colProjectDesign_CementFactor";
            this.colProjectDesign_CementFactor.ReadOnly = true;
            this.colProjectDesign_CementFactor.Width = 150;
            // 
            // lblProjectDesigns
            // 
            this.lblProjectDesigns.AutoSize = true;
            this.lblProjectDesigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDesigns.Location = new System.Drawing.Point(547, 9);
            this.lblProjectDesigns.Name = "lblProjectDesigns";
            this.lblProjectDesigns.Size = new System.Drawing.Size(128, 18);
            this.lblProjectDesigns.TabIndex = 4;
            this.lblProjectDesigns.Text = "Project Designs";
            // 
            // gbxNewProjectDesign
            // 
            this.gbxNewProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxNewProjectDesign.Controls.Add(this.cmbxNewProjectDesign_MixType);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_MixType);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_CementFactor);
            this.gbxNewProjectDesign.Controls.Add(this.nudNewProjectDesign_CementFactor);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_PricePerCubicMeter);
            this.gbxNewProjectDesign.Controls.Add(this.nudNewProjectDesign_PricePerCubicMeter);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_Strength);
            this.gbxNewProjectDesign.Controls.Add(this.cmbxNewProjectDesign_Strength);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_Aggregate);
            this.gbxNewProjectDesign.Controls.Add(this.cmbxNewProjectDesign_Aggregate);
            this.gbxNewProjectDesign.Controls.Add(this.nudNewProjectDesign_Psi);
            this.gbxNewProjectDesign.Controls.Add(this.lblNewProjectDesign_Psi);
            this.gbxNewProjectDesign.Location = new System.Drawing.Point(550, 456);
            this.gbxNewProjectDesign.Name = "gbxNewProjectDesign";
            this.gbxNewProjectDesign.Size = new System.Drawing.Size(911, 128);
            this.gbxNewProjectDesign.TabIndex = 6;
            this.gbxNewProjectDesign.TabStop = false;
            this.gbxNewProjectDesign.Text = "Add New Project Design";
            // 
            // cmbxNewProjectDesign_MixType
            // 
            this.cmbxNewProjectDesign_MixType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNewProjectDesign_MixType.FormattingEnabled = true;
            this.cmbxNewProjectDesign_MixType.Items.AddRange(new object[] {
            "ORD",
            "PCD"});
            this.cmbxNewProjectDesign_MixType.Location = new System.Drawing.Point(9, 41);
            this.cmbxNewProjectDesign_MixType.Name = "cmbxNewProjectDesign_MixType";
            this.cmbxNewProjectDesign_MixType.Size = new System.Drawing.Size(220, 26);
            this.cmbxNewProjectDesign_MixType.TabIndex = 14;
            // 
            // lblNewProjectDesign_MixType
            // 
            this.lblNewProjectDesign_MixType.AutoSize = true;
            this.lblNewProjectDesign_MixType.Location = new System.Drawing.Point(6, 20);
            this.lblNewProjectDesign_MixType.Name = "lblNewProjectDesign_MixType";
            this.lblNewProjectDesign_MixType.Size = new System.Drawing.Size(67, 18);
            this.lblNewProjectDesign_MixType.TabIndex = 13;
            this.lblNewProjectDesign_MixType.Text = "Mix Type";
            // 
            // lblNewProjectDesign_CementFactor
            // 
            this.lblNewProjectDesign_CementFactor.AutoSize = true;
            this.lblNewProjectDesign_CementFactor.Location = new System.Drawing.Point(458, 70);
            this.lblNewProjectDesign_CementFactor.Name = "lblNewProjectDesign_CementFactor";
            this.lblNewProjectDesign_CementFactor.Size = new System.Drawing.Size(107, 18);
            this.lblNewProjectDesign_CementFactor.TabIndex = 12;
            this.lblNewProjectDesign_CementFactor.Text = "Cement Factor";
            // 
            // nudNewProjectDesign_CementFactor
            // 
            this.nudNewProjectDesign_CementFactor.DecimalPlaces = 2;
            this.nudNewProjectDesign_CementFactor.Location = new System.Drawing.Point(461, 91);
            this.nudNewProjectDesign_CementFactor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNewProjectDesign_CementFactor.Name = "nudNewProjectDesign_CementFactor";
            this.nudNewProjectDesign_CementFactor.Size = new System.Drawing.Size(238, 24);
            this.nudNewProjectDesign_CementFactor.TabIndex = 11;
            this.nudNewProjectDesign_CementFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNewProjectDesign_CementFactor.ThousandsSeparator = true;
            // 
            // lblNewProjectDesign_PricePerCubicMeter
            // 
            this.lblNewProjectDesign_PricePerCubicMeter.AutoSize = true;
            this.lblNewProjectDesign_PricePerCubicMeter.Location = new System.Drawing.Point(232, 70);
            this.lblNewProjectDesign_PricePerCubicMeter.Name = "lblNewProjectDesign_PricePerCubicMeter";
            this.lblNewProjectDesign_PricePerCubicMeter.Size = new System.Drawing.Size(86, 18);
            this.lblNewProjectDesign_PricePerCubicMeter.TabIndex = 10;
            this.lblNewProjectDesign_PricePerCubicMeter.Text = "Price/Cu.M.";
            // 
            // nudNewProjectDesign_PricePerCubicMeter
            // 
            this.nudNewProjectDesign_PricePerCubicMeter.DecimalPlaces = 2;
            this.nudNewProjectDesign_PricePerCubicMeter.Location = new System.Drawing.Point(236, 91);
            this.nudNewProjectDesign_PricePerCubicMeter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNewProjectDesign_PricePerCubicMeter.Name = "nudNewProjectDesign_PricePerCubicMeter";
            this.nudNewProjectDesign_PricePerCubicMeter.Size = new System.Drawing.Size(219, 24);
            this.nudNewProjectDesign_PricePerCubicMeter.TabIndex = 9;
            this.nudNewProjectDesign_PricePerCubicMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNewProjectDesign_PricePerCubicMeter.ThousandsSeparator = true;
            // 
            // lblNewProjectDesign_Strength
            // 
            this.lblNewProjectDesign_Strength.AutoSize = true;
            this.lblNewProjectDesign_Strength.Location = new System.Drawing.Point(458, 20);
            this.lblNewProjectDesign_Strength.Name = "lblNewProjectDesign_Strength";
            this.lblNewProjectDesign_Strength.Size = new System.Drawing.Size(63, 18);
            this.lblNewProjectDesign_Strength.TabIndex = 8;
            this.lblNewProjectDesign_Strength.Text = "Strength";
            // 
            // cmbxNewProjectDesign_Strength
            // 
            this.cmbxNewProjectDesign_Strength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNewProjectDesign_Strength.FormattingEnabled = true;
            this.cmbxNewProjectDesign_Strength.Location = new System.Drawing.Point(461, 41);
            this.cmbxNewProjectDesign_Strength.Name = "cmbxNewProjectDesign_Strength";
            this.cmbxNewProjectDesign_Strength.Size = new System.Drawing.Size(239, 26);
            this.cmbxNewProjectDesign_Strength.TabIndex = 7;
            // 
            // lblNewProjectDesign_Aggregate
            // 
            this.lblNewProjectDesign_Aggregate.AutoSize = true;
            this.lblNewProjectDesign_Aggregate.Location = new System.Drawing.Point(232, 20);
            this.lblNewProjectDesign_Aggregate.Name = "lblNewProjectDesign_Aggregate";
            this.lblNewProjectDesign_Aggregate.Size = new System.Drawing.Size(74, 18);
            this.lblNewProjectDesign_Aggregate.TabIndex = 6;
            this.lblNewProjectDesign_Aggregate.Text = "Aggregate";
            // 
            // cmbxNewProjectDesign_Aggregate
            // 
            this.cmbxNewProjectDesign_Aggregate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNewProjectDesign_Aggregate.FormattingEnabled = true;
            this.cmbxNewProjectDesign_Aggregate.Location = new System.Drawing.Point(235, 41);
            this.cmbxNewProjectDesign_Aggregate.Name = "cmbxNewProjectDesign_Aggregate";
            this.cmbxNewProjectDesign_Aggregate.Size = new System.Drawing.Size(220, 26);
            this.cmbxNewProjectDesign_Aggregate.TabIndex = 5;
            // 
            // nudNewProjectDesign_Psi
            // 
            this.nudNewProjectDesign_Psi.Location = new System.Drawing.Point(10, 92);
            this.nudNewProjectDesign_Psi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNewProjectDesign_Psi.Name = "nudNewProjectDesign_Psi";
            this.nudNewProjectDesign_Psi.Size = new System.Drawing.Size(219, 24);
            this.nudNewProjectDesign_Psi.TabIndex = 4;
            this.nudNewProjectDesign_Psi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNewProjectDesign_Psi.ThousandsSeparator = true;
            // 
            // lblNewProjectDesign_Psi
            // 
            this.lblNewProjectDesign_Psi.AutoSize = true;
            this.lblNewProjectDesign_Psi.Location = new System.Drawing.Point(6, 70);
            this.lblNewProjectDesign_Psi.Name = "lblNewProjectDesign_Psi";
            this.lblNewProjectDesign_Psi.Size = new System.Drawing.Size(31, 18);
            this.lblNewProjectDesign_Psi.TabIndex = 3;
            this.lblNewProjectDesign_Psi.Text = "PSI";
            // 
            // btnAddNewProjectDesign
            // 
            this.btnAddNewProjectDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNewProjectDesign.FlatAppearance.BorderSize = 0;
            this.btnAddNewProjectDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProjectDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProjectDesign.ForeColor = System.Drawing.Color.White;
            this.btnAddNewProjectDesign.Location = new System.Drawing.Point(1231, 590);
            this.btnAddNewProjectDesign.Name = "btnAddNewProjectDesign";
            this.btnAddNewProjectDesign.Size = new System.Drawing.Size(112, 56);
            this.btnAddNewProjectDesign.TabIndex = 7;
            this.btnAddNewProjectDesign.Text = "Add";
            this.btnAddNewProjectDesign.UseVisualStyleBackColor = false;
            this.btnAddNewProjectDesign.Click += new System.EventHandler(this.btnAddNewProjectDesign_Click);
            // 
            // btnCancelNewProjectDesign
            // 
            this.btnCancelNewProjectDesign.BackColor = System.Drawing.Color.White;
            this.btnCancelNewProjectDesign.FlatAppearance.BorderSize = 2;
            this.btnCancelNewProjectDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNewProjectDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNewProjectDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelNewProjectDesign.Location = new System.Drawing.Point(1349, 590);
            this.btnCancelNewProjectDesign.Name = "btnCancelNewProjectDesign";
            this.btnCancelNewProjectDesign.Size = new System.Drawing.Size(112, 56);
            this.btnCancelNewProjectDesign.TabIndex = 8;
            this.btnCancelNewProjectDesign.Text = "Cancel";
            this.btnCancelNewProjectDesign.UseVisualStyleBackColor = false;
            this.btnCancelNewProjectDesign.Click += new System.EventHandler(this.btnCancelNewProjectDesign_Click);
            // 
            // EngineerDeliveryCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 796);
            this.Controls.Add(this.btnCancelNewProjectDesign);
            this.Controls.Add(this.btnAddNewProjectDesign);
            this.Controls.Add(this.gbxNewProjectDesign);
            this.Controls.Add(this.dgvProjectDesigns);
            this.Controls.Add(this.lblProjectDesigns);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.lblSelectClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "EngineerDeliveryCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer\'s Delivery Creation";
            this.Load += new System.EventHandler(this.EngineerDeliveryCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesigns)).EndInit();
            this.gbxNewProjectDesign.ResumeLayout(false);
            this.gbxNewProjectDesign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_CementFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_PricePerCubicMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewProjectDesign_Psi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient_Address;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject_Location;
        private System.Windows.Forms.DataGridView dgvProjectDesigns;
        private System.Windows.Forms.Label lblProjectDesigns;
        private System.Windows.Forms.GroupBox gbxNewProjectDesign;
        private System.Windows.Forms.Label lblNewProjectDesign_Psi;
        private System.Windows.Forms.NumericUpDown nudNewProjectDesign_Psi;
        private System.Windows.Forms.Label lblNewProjectDesign_Aggregate;
        private System.Windows.Forms.ComboBox cmbxNewProjectDesign_Aggregate;
        private System.Windows.Forms.Label lblNewProjectDesign_Strength;
        private System.Windows.Forms.ComboBox cmbxNewProjectDesign_Strength;
        private System.Windows.Forms.Label lblNewProjectDesign_CementFactor;
        private System.Windows.Forms.NumericUpDown nudNewProjectDesign_CementFactor;
        private System.Windows.Forms.Label lblNewProjectDesign_PricePerCubicMeter;
        private System.Windows.Forms.NumericUpDown nudNewProjectDesign_PricePerCubicMeter;
        private System.Windows.Forms.Button btnAddNewProjectDesign;
        private System.Windows.Forms.Button btnCancelNewProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_MixType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_Aggregate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_Strength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_Psi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_PricePerCubicMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign_CementFactor;
        private System.Windows.Forms.ComboBox cmbxNewProjectDesign_MixType;
        private System.Windows.Forms.Label lblNewProjectDesign_MixType;
    }
}