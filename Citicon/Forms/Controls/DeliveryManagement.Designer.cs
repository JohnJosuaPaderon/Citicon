﻿namespace Citicon.Forms.Controls
{
    partial class DeliveryManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeliveryReceiptNumberLabel = new System.Windows.Forms.Label();
            this.DeliveryReceiptNumberTextBox = new System.Windows.Forms.TextBox();
            this.ProjectGroupBox = new System.Windows.Forms.GroupBox();
            this.Project_LocationTextBox = new System.Windows.Forms.TextBox();
            this.Project_LocationLabel = new System.Windows.Forms.Label();
            this.Project_NameTextBox = new System.Windows.Forms.TextBox();
            this.Project_NameLabel = new System.Windows.Forms.Label();
            this.Project_Client_AddressTextBox = new System.Windows.Forms.TextBox();
            this.Project_Client_AddressLabel = new System.Windows.Forms.Label();
            this.Project_ClientTextBox = new System.Windows.Forms.TextBox();
            this.Project_ClientLabel = new System.Windows.Forms.Label();
            this.DesignGroupBox = new System.Windows.Forms.GroupBox();
            this.Design_CementFactorTextBox = new System.Windows.Forms.TextBox();
            this.Design_CementFactorLabel = new System.Windows.Forms.Label();
            this.Design_StrengthTextBox = new System.Windows.Forms.TextBox();
            this.Design_StrengthLabel = new System.Windows.Forms.Label();
            this.Design_AggregateTextBox = new System.Windows.Forms.TextBox();
            this.Design_AggregateLabel = new System.Windows.Forms.Label();
            this.Design_InitialVolumeTextBox = new System.Windows.Forms.TextBox();
            this.Design_InitialVolumeLabel = new System.Windows.Forms.Label();
            this.Design_PsiTextBox = new System.Windows.Forms.TextBox();
            this.Design_PsiLabel = new System.Windows.Forms.Label();
            this.Design_MixTypeTextBox = new System.Windows.Forms.TextBox();
            this.Design_MixTypeLabel = new System.Windows.Forms.Label();
            this.DeliveryGroupBox = new System.Windows.Forms.GroupBox();
            this.Delivery_TransitMixerTextBox = new System.Windows.Forms.ComboBox();
            this.Delivery_TransitMixerLabel = new System.Windows.Forms.Label();
            this.Delivery_DriverComboBox = new System.Windows.Forms.ComboBox();
            this.Delivery_DriverLabel = new System.Windows.Forms.Label();
            this.Delivery_PlantComboBox = new System.Windows.Forms.ComboBox();
            this.Delivery_PlantLabel = new System.Windows.Forms.Label();
            this.Delivery_RouteComboBox = new System.Windows.Forms.ComboBox();
            this.Delivery_RouteLabel = new System.Windows.Forms.Label();
            this.Delivery_DeliveredVolumeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Delivery_DeliveredVolumeLabel = new System.Windows.Forms.Label();
            this.CancelDeliveryButton = new System.Windows.Forms.Button();
            this.SaveDeliveryButton = new System.Windows.Forms.Button();
            this.PurchaseOrderTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseOrderLabel = new System.Windows.Forms.Label();
            this.DeliveryReceiptRefreshButton = new System.Windows.Forms.Button();
            this.ProjectGroupBox.SuspendLayout();
            this.DesignGroupBox.SuspendLayout();
            this.DeliveryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_DeliveredVolumeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliveryReceiptNumberLabel
            // 
            this.DeliveryReceiptNumberLabel.AutoSize = true;
            this.DeliveryReceiptNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryReceiptNumberLabel.Location = new System.Drawing.Point(3, 6);
            this.DeliveryReceiptNumberLabel.Name = "DeliveryReceiptNumberLabel";
            this.DeliveryReceiptNumberLabel.Size = new System.Drawing.Size(101, 37);
            this.DeliveryReceiptNumberLabel.TabIndex = 0;
            this.DeliveryReceiptNumberLabel.Text = "DR No.";
            // 
            // DeliveryReceiptNumberTextBox
            // 
            this.DeliveryReceiptNumberTextBox.BackColor = System.Drawing.Color.White;
            this.DeliveryReceiptNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryReceiptNumberTextBox.Location = new System.Drawing.Point(110, 3);
            this.DeliveryReceiptNumberTextBox.Name = "DeliveryReceiptNumberTextBox";
            this.DeliveryReceiptNumberTextBox.ReadOnly = true;
            this.DeliveryReceiptNumberTextBox.Size = new System.Drawing.Size(278, 43);
            this.DeliveryReceiptNumberTextBox.TabIndex = 1;
            // 
            // ProjectGroupBox
            // 
            this.ProjectGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectGroupBox.Controls.Add(this.Project_LocationTextBox);
            this.ProjectGroupBox.Controls.Add(this.Project_LocationLabel);
            this.ProjectGroupBox.Controls.Add(this.Project_NameTextBox);
            this.ProjectGroupBox.Controls.Add(this.Project_NameLabel);
            this.ProjectGroupBox.Controls.Add(this.Project_Client_AddressTextBox);
            this.ProjectGroupBox.Controls.Add(this.Project_Client_AddressLabel);
            this.ProjectGroupBox.Controls.Add(this.Project_ClientTextBox);
            this.ProjectGroupBox.Controls.Add(this.Project_ClientLabel);
            this.ProjectGroupBox.Location = new System.Drawing.Point(10, 52);
            this.ProjectGroupBox.Name = "ProjectGroupBox";
            this.ProjectGroupBox.Size = new System.Drawing.Size(866, 125);
            this.ProjectGroupBox.TabIndex = 2;
            this.ProjectGroupBox.TabStop = false;
            this.ProjectGroupBox.Text = "PROJECT DETAILS";
            // 
            // Project_LocationTextBox
            // 
            this.Project_LocationTextBox.BackColor = System.Drawing.Color.White;
            this.Project_LocationTextBox.Location = new System.Drawing.Point(428, 89);
            this.Project_LocationTextBox.Name = "Project_LocationTextBox";
            this.Project_LocationTextBox.ReadOnly = true;
            this.Project_LocationTextBox.Size = new System.Drawing.Size(413, 25);
            this.Project_LocationTextBox.TabIndex = 7;
            // 
            // Project_LocationLabel
            // 
            this.Project_LocationLabel.AutoSize = true;
            this.Project_LocationLabel.Location = new System.Drawing.Point(425, 69);
            this.Project_LocationLabel.Name = "Project_LocationLabel";
            this.Project_LocationLabel.Size = new System.Drawing.Size(57, 17);
            this.Project_LocationLabel.TabIndex = 6;
            this.Project_LocationLabel.Text = "Location";
            // 
            // Project_NameTextBox
            // 
            this.Project_NameTextBox.BackColor = System.Drawing.Color.White;
            this.Project_NameTextBox.Location = new System.Drawing.Point(9, 89);
            this.Project_NameTextBox.Name = "Project_NameTextBox";
            this.Project_NameTextBox.ReadOnly = true;
            this.Project_NameTextBox.Size = new System.Drawing.Size(413, 25);
            this.Project_NameTextBox.TabIndex = 5;
            // 
            // Project_NameLabel
            // 
            this.Project_NameLabel.AutoSize = true;
            this.Project_NameLabel.Location = new System.Drawing.Point(6, 69);
            this.Project_NameLabel.Name = "Project_NameLabel";
            this.Project_NameLabel.Size = new System.Drawing.Size(87, 17);
            this.Project_NameLabel.TabIndex = 4;
            this.Project_NameLabel.Text = "Project Name";
            // 
            // Project_Client_AddressTextBox
            // 
            this.Project_Client_AddressTextBox.BackColor = System.Drawing.Color.White;
            this.Project_Client_AddressTextBox.Location = new System.Drawing.Point(428, 41);
            this.Project_Client_AddressTextBox.Name = "Project_Client_AddressTextBox";
            this.Project_Client_AddressTextBox.ReadOnly = true;
            this.Project_Client_AddressTextBox.Size = new System.Drawing.Size(413, 25);
            this.Project_Client_AddressTextBox.TabIndex = 3;
            // 
            // Project_Client_AddressLabel
            // 
            this.Project_Client_AddressLabel.AutoSize = true;
            this.Project_Client_AddressLabel.Location = new System.Drawing.Point(425, 21);
            this.Project_Client_AddressLabel.Name = "Project_Client_AddressLabel";
            this.Project_Client_AddressLabel.Size = new System.Drawing.Size(56, 17);
            this.Project_Client_AddressLabel.TabIndex = 2;
            this.Project_Client_AddressLabel.Text = "Address";
            // 
            // Project_ClientTextBox
            // 
            this.Project_ClientTextBox.BackColor = System.Drawing.Color.White;
            this.Project_ClientTextBox.Location = new System.Drawing.Point(9, 41);
            this.Project_ClientTextBox.Name = "Project_ClientTextBox";
            this.Project_ClientTextBox.ReadOnly = true;
            this.Project_ClientTextBox.Size = new System.Drawing.Size(413, 25);
            this.Project_ClientTextBox.TabIndex = 1;
            // 
            // Project_ClientLabel
            // 
            this.Project_ClientLabel.AutoSize = true;
            this.Project_ClientLabel.Location = new System.Drawing.Point(6, 21);
            this.Project_ClientLabel.Name = "Project_ClientLabel";
            this.Project_ClientLabel.Size = new System.Drawing.Size(40, 17);
            this.Project_ClientLabel.TabIndex = 0;
            this.Project_ClientLabel.Text = "Client";
            // 
            // DesignGroupBox
            // 
            this.DesignGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesignGroupBox.Controls.Add(this.Design_CementFactorTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_CementFactorLabel);
            this.DesignGroupBox.Controls.Add(this.Design_StrengthTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_StrengthLabel);
            this.DesignGroupBox.Controls.Add(this.Design_AggregateTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_AggregateLabel);
            this.DesignGroupBox.Controls.Add(this.Design_InitialVolumeTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_InitialVolumeLabel);
            this.DesignGroupBox.Controls.Add(this.Design_PsiTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_PsiLabel);
            this.DesignGroupBox.Controls.Add(this.Design_MixTypeTextBox);
            this.DesignGroupBox.Controls.Add(this.Design_MixTypeLabel);
            this.DesignGroupBox.Location = new System.Drawing.Point(10, 183);
            this.DesignGroupBox.Name = "DesignGroupBox";
            this.DesignGroupBox.Size = new System.Drawing.Size(866, 126);
            this.DesignGroupBox.TabIndex = 3;
            this.DesignGroupBox.TabStop = false;
            this.DesignGroupBox.Text = "DESIGN DETAILS";
            // 
            // Design_CementFactorTextBox
            // 
            this.Design_CementFactorTextBox.BackColor = System.Drawing.Color.White;
            this.Design_CementFactorTextBox.Location = new System.Drawing.Point(495, 89);
            this.Design_CementFactorTextBox.Name = "Design_CementFactorTextBox";
            this.Design_CementFactorTextBox.ReadOnly = true;
            this.Design_CementFactorTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_CementFactorTextBox.TabIndex = 18;
            // 
            // Design_CementFactorLabel
            // 
            this.Design_CementFactorLabel.AutoSize = true;
            this.Design_CementFactorLabel.Location = new System.Drawing.Point(492, 69);
            this.Design_CementFactorLabel.Name = "Design_CementFactorLabel";
            this.Design_CementFactorLabel.Size = new System.Drawing.Size(92, 17);
            this.Design_CementFactorLabel.TabIndex = 17;
            this.Design_CementFactorLabel.Text = "Cement Factor";
            // 
            // Design_StrengthTextBox
            // 
            this.Design_StrengthTextBox.BackColor = System.Drawing.Color.White;
            this.Design_StrengthTextBox.Location = new System.Drawing.Point(252, 89);
            this.Design_StrengthTextBox.Name = "Design_StrengthTextBox";
            this.Design_StrengthTextBox.ReadOnly = true;
            this.Design_StrengthTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_StrengthTextBox.TabIndex = 16;
            // 
            // Design_StrengthLabel
            // 
            this.Design_StrengthLabel.AutoSize = true;
            this.Design_StrengthLabel.Location = new System.Drawing.Point(249, 69);
            this.Design_StrengthLabel.Name = "Design_StrengthLabel";
            this.Design_StrengthLabel.Size = new System.Drawing.Size(101, 17);
            this.Design_StrengthLabel.TabIndex = 15;
            this.Design_StrengthLabel.Text = "Design Strength";
            // 
            // Design_AggregateTextBox
            // 
            this.Design_AggregateTextBox.BackColor = System.Drawing.Color.White;
            this.Design_AggregateTextBox.Location = new System.Drawing.Point(9, 89);
            this.Design_AggregateTextBox.Name = "Design_AggregateTextBox";
            this.Design_AggregateTextBox.ReadOnly = true;
            this.Design_AggregateTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_AggregateTextBox.TabIndex = 14;
            // 
            // Design_AggregateLabel
            // 
            this.Design_AggregateLabel.AutoSize = true;
            this.Design_AggregateLabel.Location = new System.Drawing.Point(6, 69);
            this.Design_AggregateLabel.Name = "Design_AggregateLabel";
            this.Design_AggregateLabel.Size = new System.Drawing.Size(70, 17);
            this.Design_AggregateLabel.TabIndex = 13;
            this.Design_AggregateLabel.Text = "Aggregate";
            // 
            // Design_InitialVolumeTextBox
            // 
            this.Design_InitialVolumeTextBox.BackColor = System.Drawing.Color.White;
            this.Design_InitialVolumeTextBox.Location = new System.Drawing.Point(495, 41);
            this.Design_InitialVolumeTextBox.Name = "Design_InitialVolumeTextBox";
            this.Design_InitialVolumeTextBox.ReadOnly = true;
            this.Design_InitialVolumeTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_InitialVolumeTextBox.TabIndex = 12;
            // 
            // Design_InitialVolumeLabel
            // 
            this.Design_InitialVolumeLabel.AutoSize = true;
            this.Design_InitialVolumeLabel.Location = new System.Drawing.Point(492, 21);
            this.Design_InitialVolumeLabel.Name = "Design_InitialVolumeLabel";
            this.Design_InitialVolumeLabel.Size = new System.Drawing.Size(85, 17);
            this.Design_InitialVolumeLabel.TabIndex = 11;
            this.Design_InitialVolumeLabel.Text = "Initial Volume";
            // 
            // Design_PsiTextBox
            // 
            this.Design_PsiTextBox.BackColor = System.Drawing.Color.White;
            this.Design_PsiTextBox.Location = new System.Drawing.Point(252, 41);
            this.Design_PsiTextBox.Name = "Design_PsiTextBox";
            this.Design_PsiTextBox.ReadOnly = true;
            this.Design_PsiTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_PsiTextBox.TabIndex = 10;
            // 
            // Design_PsiLabel
            // 
            this.Design_PsiLabel.AutoSize = true;
            this.Design_PsiLabel.Location = new System.Drawing.Point(249, 21);
            this.Design_PsiLabel.Name = "Design_PsiLabel";
            this.Design_PsiLabel.Size = new System.Drawing.Size(25, 17);
            this.Design_PsiLabel.TabIndex = 9;
            this.Design_PsiLabel.Text = "PSI";
            // 
            // Design_MixTypeTextBox
            // 
            this.Design_MixTypeTextBox.BackColor = System.Drawing.Color.White;
            this.Design_MixTypeTextBox.Location = new System.Drawing.Point(9, 41);
            this.Design_MixTypeTextBox.Name = "Design_MixTypeTextBox";
            this.Design_MixTypeTextBox.ReadOnly = true;
            this.Design_MixTypeTextBox.Size = new System.Drawing.Size(237, 25);
            this.Design_MixTypeTextBox.TabIndex = 8;
            // 
            // Design_MixTypeLabel
            // 
            this.Design_MixTypeLabel.AutoSize = true;
            this.Design_MixTypeLabel.Location = new System.Drawing.Point(6, 21);
            this.Design_MixTypeLabel.Name = "Design_MixTypeLabel";
            this.Design_MixTypeLabel.Size = new System.Drawing.Size(60, 17);
            this.Design_MixTypeLabel.TabIndex = 1;
            this.Design_MixTypeLabel.Text = "Mix Type";
            // 
            // DeliveryGroupBox
            // 
            this.DeliveryGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryGroupBox.Controls.Add(this.Delivery_TransitMixerTextBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_TransitMixerLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DriverComboBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DriverLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_PlantComboBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_PlantLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_RouteComboBox);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_RouteLabel);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DeliveredVolumeNumericUpDown);
            this.DeliveryGroupBox.Controls.Add(this.Delivery_DeliveredVolumeLabel);
            this.DeliveryGroupBox.Location = new System.Drawing.Point(10, 315);
            this.DeliveryGroupBox.Name = "DeliveryGroupBox";
            this.DeliveryGroupBox.Size = new System.Drawing.Size(866, 124);
            this.DeliveryGroupBox.TabIndex = 4;
            this.DeliveryGroupBox.TabStop = false;
            this.DeliveryGroupBox.Text = "DELIVERY DETAILS";
            // 
            // Delivery_TransitMixerTextBox
            // 
            this.Delivery_TransitMixerTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Delivery_TransitMixerTextBox.FormattingEnabled = true;
            this.Delivery_TransitMixerTextBox.Location = new System.Drawing.Point(495, 89);
            this.Delivery_TransitMixerTextBox.Name = "Delivery_TransitMixerTextBox";
            this.Delivery_TransitMixerTextBox.Size = new System.Drawing.Size(237, 25);
            this.Delivery_TransitMixerTextBox.TabIndex = 28;
            // 
            // Delivery_TransitMixerLabel
            // 
            this.Delivery_TransitMixerLabel.AutoSize = true;
            this.Delivery_TransitMixerLabel.Location = new System.Drawing.Point(492, 69);
            this.Delivery_TransitMixerLabel.Name = "Delivery_TransitMixerLabel";
            this.Delivery_TransitMixerLabel.Size = new System.Drawing.Size(83, 17);
            this.Delivery_TransitMixerLabel.TabIndex = 27;
            this.Delivery_TransitMixerLabel.Text = "Transit Mixer";
            // 
            // Delivery_DriverComboBox
            // 
            this.Delivery_DriverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Delivery_DriverComboBox.FormattingEnabled = true;
            this.Delivery_DriverComboBox.Location = new System.Drawing.Point(9, 89);
            this.Delivery_DriverComboBox.Name = "Delivery_DriverComboBox";
            this.Delivery_DriverComboBox.Size = new System.Drawing.Size(480, 25);
            this.Delivery_DriverComboBox.TabIndex = 26;
            // 
            // Delivery_DriverLabel
            // 
            this.Delivery_DriverLabel.AutoSize = true;
            this.Delivery_DriverLabel.Location = new System.Drawing.Point(6, 69);
            this.Delivery_DriverLabel.Name = "Delivery_DriverLabel";
            this.Delivery_DriverLabel.Size = new System.Drawing.Size(43, 17);
            this.Delivery_DriverLabel.TabIndex = 25;
            this.Delivery_DriverLabel.Text = "Driver";
            // 
            // Delivery_PlantComboBox
            // 
            this.Delivery_PlantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Delivery_PlantComboBox.FormattingEnabled = true;
            this.Delivery_PlantComboBox.Location = new System.Drawing.Point(495, 40);
            this.Delivery_PlantComboBox.Name = "Delivery_PlantComboBox";
            this.Delivery_PlantComboBox.Size = new System.Drawing.Size(237, 25);
            this.Delivery_PlantComboBox.TabIndex = 24;
            // 
            // Delivery_PlantLabel
            // 
            this.Delivery_PlantLabel.AutoSize = true;
            this.Delivery_PlantLabel.Location = new System.Drawing.Point(492, 20);
            this.Delivery_PlantLabel.Name = "Delivery_PlantLabel";
            this.Delivery_PlantLabel.Size = new System.Drawing.Size(36, 17);
            this.Delivery_PlantLabel.TabIndex = 23;
            this.Delivery_PlantLabel.Text = "Plant";
            // 
            // Delivery_RouteComboBox
            // 
            this.Delivery_RouteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Delivery_RouteComboBox.FormattingEnabled = true;
            this.Delivery_RouteComboBox.Location = new System.Drawing.Point(252, 41);
            this.Delivery_RouteComboBox.Name = "Delivery_RouteComboBox";
            this.Delivery_RouteComboBox.Size = new System.Drawing.Size(237, 25);
            this.Delivery_RouteComboBox.TabIndex = 22;
            // 
            // Delivery_RouteLabel
            // 
            this.Delivery_RouteLabel.AutoSize = true;
            this.Delivery_RouteLabel.Location = new System.Drawing.Point(249, 21);
            this.Delivery_RouteLabel.Name = "Delivery_RouteLabel";
            this.Delivery_RouteLabel.Size = new System.Drawing.Size(42, 17);
            this.Delivery_RouteLabel.TabIndex = 21;
            this.Delivery_RouteLabel.Text = "Route";
            // 
            // Delivery_DeliveredVolumeNumericUpDown
            // 
            this.Delivery_DeliveredVolumeNumericUpDown.DecimalPlaces = 3;
            this.Delivery_DeliveredVolumeNumericUpDown.Location = new System.Drawing.Point(9, 41);
            this.Delivery_DeliveredVolumeNumericUpDown.Name = "Delivery_DeliveredVolumeNumericUpDown";
            this.Delivery_DeliveredVolumeNumericUpDown.Size = new System.Drawing.Size(237, 25);
            this.Delivery_DeliveredVolumeNumericUpDown.TabIndex = 20;
            this.Delivery_DeliveredVolumeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Delivery_DeliveredVolumeNumericUpDown.ThousandsSeparator = true;
            // 
            // Delivery_DeliveredVolumeLabel
            // 
            this.Delivery_DeliveredVolumeLabel.AutoSize = true;
            this.Delivery_DeliveredVolumeLabel.Location = new System.Drawing.Point(6, 21);
            this.Delivery_DeliveredVolumeLabel.Name = "Delivery_DeliveredVolumeLabel";
            this.Delivery_DeliveredVolumeLabel.Size = new System.Drawing.Size(110, 17);
            this.Delivery_DeliveredVolumeLabel.TabIndex = 19;
            this.Delivery_DeliveredVolumeLabel.Text = "Delivered Volume";
            // 
            // CancelDeliveryButton
            // 
            this.CancelDeliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDeliveryButton.BackColor = System.Drawing.Color.White;
            this.CancelDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDeliveryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDeliveryButton.ForeColor = System.Drawing.Color.Red;
            this.CancelDeliveryButton.Location = new System.Drawing.Point(776, 445);
            this.CancelDeliveryButton.Name = "CancelDeliveryButton";
            this.CancelDeliveryButton.Size = new System.Drawing.Size(100, 50);
            this.CancelDeliveryButton.TabIndex = 114;
            this.CancelDeliveryButton.Text = "CANCEL";
            this.CancelDeliveryButton.UseVisualStyleBackColor = false;
            this.CancelDeliveryButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SaveDeliveryButton
            // 
            this.SaveDeliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveDeliveryButton.BackColor = System.Drawing.Color.Red;
            this.SaveDeliveryButton.FlatAppearance.BorderSize = 0;
            this.SaveDeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDeliveryButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDeliveryButton.ForeColor = System.Drawing.Color.White;
            this.SaveDeliveryButton.Location = new System.Drawing.Point(645, 445);
            this.SaveDeliveryButton.Name = "SaveDeliveryButton";
            this.SaveDeliveryButton.Size = new System.Drawing.Size(125, 50);
            this.SaveDeliveryButton.TabIndex = 113;
            this.SaveDeliveryButton.Text = "SAVE DELIVERY";
            this.SaveDeliveryButton.UseVisualStyleBackColor = false;
            // 
            // PurchaseOrderTextBox
            // 
            this.PurchaseOrderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseOrderTextBox.BackColor = System.Drawing.Color.White;
            this.PurchaseOrderTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrderTextBox.Location = new System.Drawing.Point(610, 3);
            this.PurchaseOrderTextBox.Name = "PurchaseOrderTextBox";
            this.PurchaseOrderTextBox.ReadOnly = true;
            this.PurchaseOrderTextBox.Size = new System.Drawing.Size(266, 43);
            this.PurchaseOrderTextBox.TabIndex = 117;
            // 
            // PurchaseOrderLabel
            // 
            this.PurchaseOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseOrderLabel.AutoSize = true;
            this.PurchaseOrderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseOrderLabel.Location = new System.Drawing.Point(491, 6);
            this.PurchaseOrderLabel.Name = "PurchaseOrderLabel";
            this.PurchaseOrderLabel.Size = new System.Drawing.Size(113, 37);
            this.PurchaseOrderLabel.TabIndex = 116;
            this.PurchaseOrderLabel.Text = "P.O. No.";
            // 
            // DeliveryReceiptRefreshButton
            // 
            this.DeliveryReceiptRefreshButton.BackColor = System.Drawing.Color.Red;
            this.DeliveryReceiptRefreshButton.FlatAppearance.BorderSize = 0;
            this.DeliveryReceiptRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryReceiptRefreshButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryReceiptRefreshButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryReceiptRefreshButton.Image = global::Citicon.Properties.Resources.Refresh_16;
            this.DeliveryReceiptRefreshButton.Location = new System.Drawing.Point(394, 3);
            this.DeliveryReceiptRefreshButton.Name = "DeliveryReceiptRefreshButton";
            this.DeliveryReceiptRefreshButton.Size = new System.Drawing.Size(43, 43);
            this.DeliveryReceiptRefreshButton.TabIndex = 115;
            this.DeliveryReceiptRefreshButton.UseVisualStyleBackColor = false;
            // 
            // DeliveryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PurchaseOrderTextBox);
            this.Controls.Add(this.PurchaseOrderLabel);
            this.Controls.Add(this.DeliveryReceiptRefreshButton);
            this.Controls.Add(this.CancelDeliveryButton);
            this.Controls.Add(this.SaveDeliveryButton);
            this.Controls.Add(this.DeliveryGroupBox);
            this.Controls.Add(this.DesignGroupBox);
            this.Controls.Add(this.ProjectGroupBox);
            this.Controls.Add(this.DeliveryReceiptNumberTextBox);
            this.Controls.Add(this.DeliveryReceiptNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeliveryManagement";
            this.Size = new System.Drawing.Size(885, 503);
            this.Load += new System.EventHandler(this.DeliveryManagement_Load);
            this.ProjectGroupBox.ResumeLayout(false);
            this.ProjectGroupBox.PerformLayout();
            this.DesignGroupBox.ResumeLayout(false);
            this.DesignGroupBox.PerformLayout();
            this.DeliveryGroupBox.ResumeLayout(false);
            this.DeliveryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delivery_DeliveredVolumeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryReceiptNumberLabel;
        private System.Windows.Forms.TextBox DeliveryReceiptNumberTextBox;
        private System.Windows.Forms.GroupBox ProjectGroupBox;
        private System.Windows.Forms.Label Project_ClientLabel;
        private System.Windows.Forms.TextBox Project_ClientTextBox;
        private System.Windows.Forms.TextBox Project_Client_AddressTextBox;
        private System.Windows.Forms.Label Project_Client_AddressLabel;
        private System.Windows.Forms.TextBox Project_LocationTextBox;
        private System.Windows.Forms.Label Project_LocationLabel;
        private System.Windows.Forms.TextBox Project_NameTextBox;
        private System.Windows.Forms.Label Project_NameLabel;
        private System.Windows.Forms.GroupBox DesignGroupBox;
        private System.Windows.Forms.Label Design_MixTypeLabel;
        private System.Windows.Forms.TextBox Design_MixTypeTextBox;
        private System.Windows.Forms.TextBox Design_PsiTextBox;
        private System.Windows.Forms.Label Design_PsiLabel;
        private System.Windows.Forms.TextBox Design_InitialVolumeTextBox;
        private System.Windows.Forms.Label Design_InitialVolumeLabel;
        private System.Windows.Forms.TextBox Design_CementFactorTextBox;
        private System.Windows.Forms.Label Design_CementFactorLabel;
        private System.Windows.Forms.TextBox Design_StrengthTextBox;
        private System.Windows.Forms.Label Design_StrengthLabel;
        private System.Windows.Forms.TextBox Design_AggregateTextBox;
        private System.Windows.Forms.Label Design_AggregateLabel;
        private System.Windows.Forms.GroupBox DeliveryGroupBox;
        private System.Windows.Forms.Label Delivery_DeliveredVolumeLabel;
        private System.Windows.Forms.NumericUpDown Delivery_DeliveredVolumeNumericUpDown;
        private System.Windows.Forms.Label Delivery_RouteLabel;
        private System.Windows.Forms.ComboBox Delivery_RouteComboBox;
        private System.Windows.Forms.ComboBox Delivery_PlantComboBox;
        private System.Windows.Forms.Label Delivery_PlantLabel;
        private System.Windows.Forms.Label Delivery_DriverLabel;
        private System.Windows.Forms.ComboBox Delivery_DriverComboBox;
        private System.Windows.Forms.ComboBox Delivery_TransitMixerTextBox;
        private System.Windows.Forms.Label Delivery_TransitMixerLabel;
        private System.Windows.Forms.Button CancelDeliveryButton;
        private System.Windows.Forms.Button SaveDeliveryButton;
        private System.Windows.Forms.Button DeliveryReceiptRefreshButton;
        private System.Windows.Forms.TextBox PurchaseOrderTextBox;
        private System.Windows.Forms.Label PurchaseOrderLabel;
    }
}
