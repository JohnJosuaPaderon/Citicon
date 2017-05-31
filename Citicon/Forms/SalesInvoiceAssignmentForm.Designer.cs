﻿namespace Citicon.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesInvoiceAssignmentForm));
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.colBilling_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBilling_AmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSiNumber = new System.Windows.Forms.Label();
            this.tbxSiNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.colClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClient_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectProject = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.colProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProject_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colBilling_AmountDue});
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBilling.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBilling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBilling.Size = new System.Drawing.Size(660, 586);
            this.dgvBilling.TabIndex = 0;
            this.dgvBilling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBilling_CellContentClick);
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
            // lblSiNumber
            // 
            this.lblSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSiNumber.AutoSize = true;
            this.lblSiNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSiNumber.Location = new System.Drawing.Point(731, 621);
            this.lblSiNumber.Name = "lblSiNumber";
            this.lblSiNumber.Size = new System.Drawing.Size(49, 17);
            this.lblSiNumber.TabIndex = 1;
            this.lblSiNumber.Text = "S.I. No.";
            // 
            // tbxSiNumber
            // 
            this.tbxSiNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSiNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSiNumber.Location = new System.Drawing.Point(734, 645);
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
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1073, 621);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 57);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(1199, 621);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 57);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colClient_Address});
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
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(643, 272);
            this.dgvClients.TabIndex = 5;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(656, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Check/Uncheck Billings";
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
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colProject_Location});
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
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProjects.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(643, 290);
            this.dgvProjects.TabIndex = 9;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
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
            // SalesInvoiceAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 689);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.lblSelectProject);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectProject;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProject_Location;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colBilling_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBilling_AmountDue;
    }
}