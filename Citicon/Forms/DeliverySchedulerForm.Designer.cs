﻿namespace Citicon.Forms
{
    partial class DeliverySchedulerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliverySchedulerForm));
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.colProject_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProjectDesign = new System.Windows.Forms.DataGridView();
            this.colProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_QuotationNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_PricePerCubicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectDesign_ExtraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblScheduledDate = new System.Windows.Forms.Label();
            this.dtpScheduledDate = new System.Windows.Forms.DateTimePicker();
            this.dgvScheduledProjectDesign = new System.Windows.Forms.DataGridView();
            this.colScheduledProjectDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduledProjectDesign_MaximumVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScheduledProjectDesign_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScheduleSelectedProjectDesign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.UseRangedDateCheckBox = new System.Windows.Forms.CheckBox();
            this.RangeEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StructureTypeLabel = new System.Windows.Forms.Label();
            this.StructureTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectDesignMaxVolumeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProjectDesignMaxVolumeLabel = new System.Windows.Forms.Label();
            this.SearchPredicateComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchPredicateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignMaxVolumeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjects.ColumnHeadersHeight = 60;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProject_Client,
            this.colProject,
            this.Project_ExtraColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjects.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProjects.EnableHeadersVisualStyles = false;
            this.dgvProjects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvProjects.Location = new System.Drawing.Point(9, 57);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersVisible = false;
            this.dgvProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProjects.RowTemplate.Height = 40;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(488, 288);
            this.dgvProjects.TabIndex = 103;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            // 
            // colProject_Client
            // 
            this.colProject_Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProject_Client.HeaderText = "Client";
            this.colProject_Client.MinimumWidth = 100;
            this.colProject_Client.Name = "colProject_Client";
            this.colProject_Client.ReadOnly = true;
            // 
            // colProject
            // 
            this.colProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProject.HeaderText = "Projects";
            this.colProject.MinimumWidth = 100;
            this.colProject.Name = "colProject";
            this.colProject.ReadOnly = true;
            // 
            // Project_ExtraColumn
            // 
            this.Project_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Project_ExtraColumn.HeaderText = "";
            this.Project_ExtraColumn.Name = "Project_ExtraColumn";
            this.Project_ExtraColumn.ReadOnly = true;
            // 
            // dgvProjectDesign
            // 
            this.dgvProjectDesign.AllowUserToAddRows = false;
            this.dgvProjectDesign.AllowUserToDeleteRows = false;
            this.dgvProjectDesign.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjectDesign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProjectDesign.ColumnHeadersHeight = 60;
            this.dgvProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProjectDesign,
            this.ProjectDesign_QuotationNumberColumn,
            this.ProjectDesign_PricePerCubicColumn,
            this.ProjectDesign_ExtraColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjectDesign.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvProjectDesign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvProjectDesign.Location = new System.Drawing.Point(9, 351);
            this.dgvProjectDesign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProjectDesign.MultiSelect = false;
            this.dgvProjectDesign.Name = "dgvProjectDesign";
            this.dgvProjectDesign.ReadOnly = true;
            this.dgvProjectDesign.RowHeadersVisible = false;
            this.dgvProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProjectDesign.RowTemplate.Height = 40;
            this.dgvProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDesign.Size = new System.Drawing.Size(488, 257);
            this.dgvProjectDesign.TabIndex = 104;
            // 
            // colProjectDesign
            // 
            this.colProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProjectDesign.HeaderText = "Project Designs";
            this.colProjectDesign.MinimumWidth = 75;
            this.colProjectDesign.Name = "colProjectDesign";
            this.colProjectDesign.ReadOnly = true;
            this.colProjectDesign.Width = 112;
            // 
            // ProjectDesign_QuotationNumberColumn
            // 
            this.ProjectDesign_QuotationNumberColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectDesign_QuotationNumberColumn.HeaderText = "Quotation No.";
            this.ProjectDesign_QuotationNumberColumn.Name = "ProjectDesign_QuotationNumberColumn";
            this.ProjectDesign_QuotationNumberColumn.ReadOnly = true;
            this.ProjectDesign_QuotationNumberColumn.Width = 105;
            // 
            // ProjectDesign_PricePerCubicColumn
            // 
            this.ProjectDesign_PricePerCubicColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProjectDesign_PricePerCubicColumn.HeaderText = "Price/Cu.M.";
            this.ProjectDesign_PricePerCubicColumn.Name = "ProjectDesign_PricePerCubicColumn";
            this.ProjectDesign_PricePerCubicColumn.ReadOnly = true;
            this.ProjectDesign_PricePerCubicColumn.Width = 98;
            // 
            // ProjectDesign_ExtraColumn
            // 
            this.ProjectDesign_ExtraColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectDesign_ExtraColumn.HeaderText = "";
            this.ProjectDesign_ExtraColumn.Name = "ProjectDesign_ExtraColumn";
            this.ProjectDesign_ExtraColumn.ReadOnly = true;
            // 
            // lblScheduledDate
            // 
            this.lblScheduledDate.AutoSize = true;
            this.lblScheduledDate.Location = new System.Drawing.Point(498, 10);
            this.lblScheduledDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScheduledDate.Name = "lblScheduledDate";
            this.lblScheduledDate.Size = new System.Drawing.Size(137, 17);
            this.lblScheduledDate.TabIndex = 105;
            this.lblScheduledDate.Text = "Select Scheduled Date";
            // 
            // dtpScheduledDate
            // 
            this.dtpScheduledDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpScheduledDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduledDate.Location = new System.Drawing.Point(501, 29);
            this.dtpScheduledDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpScheduledDate.Name = "dtpScheduledDate";
            this.dtpScheduledDate.Size = new System.Drawing.Size(176, 25);
            this.dtpScheduledDate.TabIndex = 106;
            // 
            // dgvScheduledProjectDesign
            // 
            this.dgvScheduledProjectDesign.AllowUserToAddRows = false;
            this.dgvScheduledProjectDesign.AllowUserToDeleteRows = false;
            this.dgvScheduledProjectDesign.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvScheduledProjectDesign.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvScheduledProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScheduledProjectDesign.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvScheduledProjectDesign.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvScheduledProjectDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScheduledProjectDesign.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvScheduledProjectDesign.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScheduledProjectDesign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvScheduledProjectDesign.ColumnHeadersHeight = 60;
            this.dgvScheduledProjectDesign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvScheduledProjectDesign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScheduledProjectDesign,
            this.colScheduledProjectDesign_MaximumVolume,
            this.colScheduledProjectDesign_Project});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScheduledProjectDesign.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvScheduledProjectDesign.EnableHeadersVisualStyles = false;
            this.dgvScheduledProjectDesign.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvScheduledProjectDesign.Location = new System.Drawing.Point(500, 57);
            this.dgvScheduledProjectDesign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvScheduledProjectDesign.MultiSelect = false;
            this.dgvScheduledProjectDesign.Name = "dgvScheduledProjectDesign";
            this.dgvScheduledProjectDesign.ReadOnly = true;
            this.dgvScheduledProjectDesign.RowHeadersVisible = false;
            this.dgvScheduledProjectDesign.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScheduledProjectDesign.RowTemplate.Height = 40;
            this.dgvScheduledProjectDesign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduledProjectDesign.Size = new System.Drawing.Size(740, 550);
            this.dgvScheduledProjectDesign.TabIndex = 107;
            // 
            // colScheduledProjectDesign
            // 
            this.colScheduledProjectDesign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScheduledProjectDesign.HeaderText = "Scheduled Project Designs";
            this.colScheduledProjectDesign.MinimumWidth = 100;
            this.colScheduledProjectDesign.Name = "colScheduledProjectDesign";
            this.colScheduledProjectDesign.ReadOnly = true;
            // 
            // colScheduledProjectDesign_MaximumVolume
            // 
            dataGridViewCellStyle9.Format = "#,##0.00";
            this.colScheduledProjectDesign_MaximumVolume.DefaultCellStyle = dataGridViewCellStyle9;
            this.colScheduledProjectDesign_MaximumVolume.HeaderText = "Max. Vol.";
            this.colScheduledProjectDesign_MaximumVolume.Name = "colScheduledProjectDesign_MaximumVolume";
            this.colScheduledProjectDesign_MaximumVolume.ReadOnly = true;
            this.colScheduledProjectDesign_MaximumVolume.Width = 78;
            // 
            // colScheduledProjectDesign_Project
            // 
            this.colScheduledProjectDesign_Project.HeaderText = "Project";
            this.colScheduledProjectDesign_Project.MinimumWidth = 100;
            this.colScheduledProjectDesign_Project.Name = "colScheduledProjectDesign_Project";
            this.colScheduledProjectDesign_Project.ReadOnly = true;
            // 
            // btnScheduleSelectedProjectDesign
            // 
            this.btnScheduleSelectedProjectDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScheduleSelectedProjectDesign.BackColor = System.Drawing.Color.Red;
            this.btnScheduleSelectedProjectDesign.FlatAppearance.BorderSize = 0;
            this.btnScheduleSelectedProjectDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleSelectedProjectDesign.ForeColor = System.Drawing.Color.White;
            this.btnScheduleSelectedProjectDesign.Location = new System.Drawing.Point(372, 611);
            this.btnScheduleSelectedProjectDesign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScheduleSelectedProjectDesign.Name = "btnScheduleSelectedProjectDesign";
            this.btnScheduleSelectedProjectDesign.Size = new System.Drawing.Size(125, 40);
            this.btnScheduleSelectedProjectDesign.TabIndex = 108;
            this.btnScheduleSelectedProjectDesign.Text = "Include Selected";
            this.btnScheduleSelectedProjectDesign.UseVisualStyleBackColor = false;
            this.btnScheduleSelectedProjectDesign.Click += new System.EventHandler(this.btnScheduleSelectedProjectDesign_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1172, 611);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 40);
            this.btnCancel.TabIndex = 109;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1068, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Save Schedule";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAll.BackColor = System.Drawing.Color.Red;
            this.btnRemoveAll.FlatAppearance.BorderSize = 0;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAll.Location = new System.Drawing.Point(964, 611);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(100, 40);
            this.btnRemoveAll.TabIndex = 111;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelected.BackColor = System.Drawing.Color.Red;
            this.btnRemoveSelected.FlatAppearance.BorderSize = 0;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(835, 611);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(125, 40);
            this.btnRemoveSelected.TabIndex = 112;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(5, 10);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 17);
            this.SearchLabel.TabIndex = 113;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(9, 29);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(300, 25);
            this.SearchTextBox.TabIndex = 114;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // UseRangedDateCheckBox
            // 
            this.UseRangedDateCheckBox.AutoSize = true;
            this.UseRangedDateCheckBox.Location = new System.Drawing.Point(681, 9);
            this.UseRangedDateCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UseRangedDateCheckBox.Name = "UseRangedDateCheckBox";
            this.UseRangedDateCheckBox.Size = new System.Drawing.Size(143, 21);
            this.UseRangedDateCheckBox.TabIndex = 115;
            this.UseRangedDateCheckBox.Text = "Use Range of Dates";
            this.UseRangedDateCheckBox.UseVisualStyleBackColor = true;
            this.UseRangedDateCheckBox.CheckedChanged += new System.EventHandler(this.UseRangedDateCheckBox_CheckedChanged);
            // 
            // RangeEndDateTimePicker
            // 
            this.RangeEndDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.RangeEndDateTimePicker.Enabled = false;
            this.RangeEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RangeEndDateTimePicker.Location = new System.Drawing.Point(681, 29);
            this.RangeEndDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RangeEndDateTimePicker.Name = "RangeEndDateTimePicker";
            this.RangeEndDateTimePicker.Size = new System.Drawing.Size(176, 25);
            this.RangeEndDateTimePicker.TabIndex = 116;
            // 
            // StructureTypeLabel
            // 
            this.StructureTypeLabel.AutoSize = true;
            this.StructureTypeLabel.Location = new System.Drawing.Point(860, 10);
            this.StructureTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StructureTypeLabel.Name = "StructureTypeLabel";
            this.StructureTypeLabel.Size = new System.Drawing.Size(91, 17);
            this.StructureTypeLabel.TabIndex = 117;
            this.StructureTypeLabel.Text = "Structure Type";
            // 
            // StructureTypeComboBox
            // 
            this.StructureTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructureTypeComboBox.FormattingEnabled = true;
            this.StructureTypeComboBox.Location = new System.Drawing.Point(860, 29);
            this.StructureTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StructureTypeComboBox.Name = "StructureTypeComboBox";
            this.StructureTypeComboBox.Size = new System.Drawing.Size(184, 25);
            this.StructureTypeComboBox.TabIndex = 118;
            // 
            // ProjectDesignMaxVolumeNumericUpDown
            // 
            this.ProjectDesignMaxVolumeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectDesignMaxVolumeNumericUpDown.DecimalPlaces = 2;
            this.ProjectDesignMaxVolumeNumericUpDown.Location = new System.Drawing.Point(202, 626);
            this.ProjectDesignMaxVolumeNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProjectDesignMaxVolumeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ProjectDesignMaxVolumeNumericUpDown.Name = "ProjectDesignMaxVolumeNumericUpDown";
            this.ProjectDesignMaxVolumeNumericUpDown.Size = new System.Drawing.Size(166, 25);
            this.ProjectDesignMaxVolumeNumericUpDown.TabIndex = 119;
            this.ProjectDesignMaxVolumeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProjectDesignMaxVolumeNumericUpDown.ThousandsSeparator = true;
            // 
            // ProjectDesignMaxVolumeLabel
            // 
            this.ProjectDesignMaxVolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProjectDesignMaxVolumeLabel.AutoSize = true;
            this.ProjectDesignMaxVolumeLabel.Location = new System.Drawing.Point(137, 628);
            this.ProjectDesignMaxVolumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectDesignMaxVolumeLabel.Name = "ProjectDesignMaxVolumeLabel";
            this.ProjectDesignMaxVolumeLabel.Size = new System.Drawing.Size(61, 17);
            this.ProjectDesignMaxVolumeLabel.TabIndex = 120;
            this.ProjectDesignMaxVolumeLabel.Text = "Max. Vol.";
            // 
            // SearchPredicateComboBox
            // 
            this.SearchPredicateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchPredicateComboBox.FormattingEnabled = true;
            this.SearchPredicateComboBox.Location = new System.Drawing.Point(313, 29);
            this.SearchPredicateComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchPredicateComboBox.Name = "SearchPredicateComboBox";
            this.SearchPredicateComboBox.Size = new System.Drawing.Size(100, 25);
            this.SearchPredicateComboBox.TabIndex = 121;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Red;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(418, 29);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(79, 25);
            this.SearchButton.TabIndex = 122;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchPredicateLabel
            // 
            this.SearchPredicateLabel.AutoSize = true;
            this.SearchPredicateLabel.Location = new System.Drawing.Point(310, 10);
            this.SearchPredicateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchPredicateLabel.Name = "SearchPredicateLabel";
            this.SearchPredicateLabel.Size = new System.Drawing.Size(65, 17);
            this.SearchPredicateLabel.TabIndex = 123;
            this.SearchPredicateLabel.Text = "Search by";
            // 
            // DeliverySchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1249, 662);
            this.Controls.Add(this.SearchPredicateLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchPredicateComboBox);
            this.Controls.Add(this.ProjectDesignMaxVolumeLabel);
            this.Controls.Add(this.ProjectDesignMaxVolumeNumericUpDown);
            this.Controls.Add(this.StructureTypeComboBox);
            this.Controls.Add(this.StructureTypeLabel);
            this.Controls.Add(this.RangeEndDateTimePicker);
            this.Controls.Add(this.UseRangedDateCheckBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnScheduleSelectedProjectDesign);
            this.Controls.Add(this.dgvScheduledProjectDesign);
            this.Controls.Add(this.dtpScheduledDate);
            this.Controls.Add(this.lblScheduledDate);
            this.Controls.Add(this.dgvProjectDesign);
            this.Controls.Add(this.dgvProjects);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeliverySchedulerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Scheduler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeliverySchedulerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledProjectDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDesignMaxVolumeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridView dgvProjectDesign;
        private System.Windows.Forms.Label lblScheduledDate;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.DataGridView dgvScheduledProjectDesign;
        private System.Windows.Forms.Button btnScheduleSelectedProjectDesign;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.CheckBox UseRangedDateCheckBox;
        private System.Windows.Forms.DateTimePicker RangeEndDateTimePicker;
        private System.Windows.Forms.Label StructureTypeLabel;
        private System.Windows.Forms.ComboBox StructureTypeComboBox;
        private System.Windows.Forms.NumericUpDown ProjectDesignMaxVolumeNumericUpDown;
        private System.Windows.Forms.Label ProjectDesignMaxVolumeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign_MaximumVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScheduledProjectDesign_Project;
        private System.Windows.Forms.ComboBox SearchPredicateComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchPredicateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_ExtraColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_QuotationNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_PricePerCubicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDesign_ExtraColumn;
    }
}