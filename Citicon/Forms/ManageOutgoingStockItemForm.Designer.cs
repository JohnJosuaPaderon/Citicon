namespace Citicon.Forms
{
    partial class ManageOutgoingStockItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOutgoingStockItemForm));
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RemovedStockValueLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemStockValueTextBox = new System.Windows.Forms.TextBox();
            this.ItemStockValueLabel = new System.Windows.Forms.Label();
            this.ItemClassificationTextBox = new System.Windows.Forms.TextBox();
            this.ItemClassificationLabel = new System.Windows.Forms.Label();
            this.ItemCodeTextBox = new System.Windows.Forms.TextBox();
            this.ItemCodeLabel = new System.Windows.Forms.Label();
            this.ItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ItemDescriptionLabel = new System.Windows.Forms.Label();
            this.RemovedStockValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.VehicleComboBox = new System.Windows.Forms.ComboBox();
            this.VehicleLabel = new System.Windows.Forms.Label();
            this.RequestedByLabel = new System.Windows.Forms.Label();
            this.RequestedByTextBox = new System.Windows.Forms.TextBox();
            this.ReleasedByTextBox = new System.Windows.Forms.TextBox();
            this.ReleasedByLabel = new System.Windows.Forms.Label();
            this.PurposeTextBox = new System.Windows.Forms.TextBox();
            this.PurposeLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.ItemDescriptionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovedStockValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Location = new System.Drawing.Point(9, 153);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(105, 17);
            this.TransactionDateLabel.TabIndex = 0;
            this.TransactionDateLabel.Text = "Transaction Date";
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            this.TransactionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(12, 173);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(205, 25);
            this.TransactionDateTimePicker.TabIndex = 1;
            // 
            // RemovedStockValueLabel
            // 
            this.RemovedStockValueLabel.AutoSize = true;
            this.RemovedStockValueLabel.Location = new System.Drawing.Point(220, 153);
            this.RemovedStockValueLabel.Name = "RemovedStockValueLabel";
            this.RemovedStockValueLabel.Size = new System.Drawing.Size(133, 17);
            this.RemovedStockValueLabel.TabIndex = 2;
            this.RemovedStockValueLabel.Text = "Removed Stock Value";
            // 
            // ItemDescriptionGroupBox
            // 
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemStockValueTextBox);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemStockValueLabel);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemClassificationTextBox);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemClassificationLabel);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemCodeTextBox);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemCodeLabel);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemDescriptionTextBox);
            this.ItemDescriptionGroupBox.Controls.Add(this.ItemDescriptionLabel);
            this.ItemDescriptionGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ItemDescriptionGroupBox.Name = "ItemDescriptionGroupBox";
            this.ItemDescriptionGroupBox.Size = new System.Drawing.Size(626, 122);
            this.ItemDescriptionGroupBox.TabIndex = 3;
            this.ItemDescriptionGroupBox.TabStop = false;
            this.ItemDescriptionGroupBox.Text = "Item Details";
            // 
            // ItemStockValueTextBox
            // 
            this.ItemStockValueTextBox.Location = new System.Drawing.Point(421, 89);
            this.ItemStockValueTextBox.Name = "ItemStockValueTextBox";
            this.ItemStockValueTextBox.ReadOnly = true;
            this.ItemStockValueTextBox.Size = new System.Drawing.Size(199, 25);
            this.ItemStockValueTextBox.TabIndex = 8;
            // 
            // ItemStockValueLabel
            // 
            this.ItemStockValueLabel.AutoSize = true;
            this.ItemStockValueLabel.Location = new System.Drawing.Point(418, 69);
            this.ItemStockValueLabel.Name = "ItemStockValueLabel";
            this.ItemStockValueLabel.Size = new System.Drawing.Size(74, 17);
            this.ItemStockValueLabel.TabIndex = 7;
            this.ItemStockValueLabel.Text = "Stock Value";
            // 
            // ItemClassificationTextBox
            // 
            this.ItemClassificationTextBox.Location = new System.Drawing.Point(7, 89);
            this.ItemClassificationTextBox.Name = "ItemClassificationTextBox";
            this.ItemClassificationTextBox.ReadOnly = true;
            this.ItemClassificationTextBox.Size = new System.Drawing.Size(408, 25);
            this.ItemClassificationTextBox.TabIndex = 6;
            // 
            // ItemClassificationLabel
            // 
            this.ItemClassificationLabel.AutoSize = true;
            this.ItemClassificationLabel.Location = new System.Drawing.Point(4, 69);
            this.ItemClassificationLabel.Name = "ItemClassificationLabel";
            this.ItemClassificationLabel.Size = new System.Drawing.Size(83, 17);
            this.ItemClassificationLabel.TabIndex = 5;
            this.ItemClassificationLabel.Text = "Classification";
            // 
            // ItemCodeTextBox
            // 
            this.ItemCodeTextBox.Location = new System.Drawing.Point(421, 41);
            this.ItemCodeTextBox.Name = "ItemCodeTextBox";
            this.ItemCodeTextBox.ReadOnly = true;
            this.ItemCodeTextBox.Size = new System.Drawing.Size(199, 25);
            this.ItemCodeTextBox.TabIndex = 4;
            // 
            // ItemCodeLabel
            // 
            this.ItemCodeLabel.AutoSize = true;
            this.ItemCodeLabel.Location = new System.Drawing.Point(418, 21);
            this.ItemCodeLabel.Name = "ItemCodeLabel";
            this.ItemCodeLabel.Size = new System.Drawing.Size(39, 17);
            this.ItemCodeLabel.TabIndex = 3;
            this.ItemCodeLabel.Text = "Code";
            // 
            // ItemDescriptionTextBox
            // 
            this.ItemDescriptionTextBox.Location = new System.Drawing.Point(7, 41);
            this.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            this.ItemDescriptionTextBox.ReadOnly = true;
            this.ItemDescriptionTextBox.Size = new System.Drawing.Size(408, 25);
            this.ItemDescriptionTextBox.TabIndex = 2;
            // 
            // ItemDescriptionLabel
            // 
            this.ItemDescriptionLabel.AutoSize = true;
            this.ItemDescriptionLabel.Location = new System.Drawing.Point(4, 21);
            this.ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            this.ItemDescriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.ItemDescriptionLabel.TabIndex = 1;
            this.ItemDescriptionLabel.Text = "Description";
            // 
            // RemovedStockValueNumericUpDown
            // 
            this.RemovedStockValueNumericUpDown.Location = new System.Drawing.Point(223, 173);
            this.RemovedStockValueNumericUpDown.Name = "RemovedStockValueNumericUpDown";
            this.RemovedStockValueNumericUpDown.Size = new System.Drawing.Size(205, 25);
            this.RemovedStockValueNumericUpDown.TabIndex = 4;
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Location = new System.Drawing.Point(9, 201);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(47, 17);
            this.BranchLabel.TabIndex = 5;
            this.BranchLabel.Text = "Branch";
            // 
            // BranchComboBox
            // 
            this.BranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBox.FormattingEnabled = true;
            this.BranchComboBox.Location = new System.Drawing.Point(12, 221);
            this.BranchComboBox.Name = "BranchComboBox";
            this.BranchComboBox.Size = new System.Drawing.Size(205, 25);
            this.BranchComboBox.TabIndex = 6;
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(223, 221);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(205, 25);
            this.CompanyComboBox.TabIndex = 8;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(220, 201);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(63, 17);
            this.CompanyLabel.TabIndex = 7;
            this.CompanyLabel.Text = "Company";
            // 
            // VehicleComboBox
            // 
            this.VehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleComboBox.FormattingEnabled = true;
            this.VehicleComboBox.Location = new System.Drawing.Point(434, 221);
            this.VehicleComboBox.Name = "VehicleComboBox";
            this.VehicleComboBox.Size = new System.Drawing.Size(205, 25);
            this.VehicleComboBox.TabIndex = 10;
            // 
            // VehicleLabel
            // 
            this.VehicleLabel.AutoSize = true;
            this.VehicleLabel.Location = new System.Drawing.Point(431, 201);
            this.VehicleLabel.Name = "VehicleLabel";
            this.VehicleLabel.Size = new System.Drawing.Size(48, 17);
            this.VehicleLabel.TabIndex = 9;
            this.VehicleLabel.Text = "Vehicle";
            // 
            // RequestedByLabel
            // 
            this.RequestedByLabel.AutoSize = true;
            this.RequestedByLabel.Location = new System.Drawing.Point(9, 249);
            this.RequestedByLabel.Name = "RequestedByLabel";
            this.RequestedByLabel.Size = new System.Drawing.Size(87, 17);
            this.RequestedByLabel.TabIndex = 11;
            this.RequestedByLabel.Text = "Requested By";
            // 
            // RequestedByTextBox
            // 
            this.RequestedByTextBox.Location = new System.Drawing.Point(12, 269);
            this.RequestedByTextBox.Name = "RequestedByTextBox";
            this.RequestedByTextBox.Size = new System.Drawing.Size(205, 25);
            this.RequestedByTextBox.TabIndex = 12;
            // 
            // ReleasedByTextBox
            // 
            this.ReleasedByTextBox.Location = new System.Drawing.Point(223, 270);
            this.ReleasedByTextBox.Name = "ReleasedByTextBox";
            this.ReleasedByTextBox.Size = new System.Drawing.Size(205, 25);
            this.ReleasedByTextBox.TabIndex = 14;
            // 
            // ReleasedByLabel
            // 
            this.ReleasedByLabel.AutoSize = true;
            this.ReleasedByLabel.Location = new System.Drawing.Point(219, 249);
            this.ReleasedByLabel.Name = "ReleasedByLabel";
            this.ReleasedByLabel.Size = new System.Drawing.Size(78, 17);
            this.ReleasedByLabel.TabIndex = 13;
            this.ReleasedByLabel.Text = "Released By";
            // 
            // PurposeTextBox
            // 
            this.PurposeTextBox.Location = new System.Drawing.Point(14, 319);
            this.PurposeTextBox.Name = "PurposeTextBox";
            this.PurposeTextBox.Size = new System.Drawing.Size(625, 25);
            this.PurposeTextBox.TabIndex = 16;
            // 
            // PurposeLabel
            // 
            this.PurposeLabel.AutoSize = true;
            this.PurposeLabel.Location = new System.Drawing.Point(10, 298);
            this.PurposeLabel.Name = "PurposeLabel";
            this.PurposeLabel.Size = new System.Drawing.Size(56, 17);
            this.PurposeLabel.TabIndex = 15;
            this.PurposeLabel.Text = "Purpose";
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.Red;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(433, 358);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(100, 40);
            this.DoneButton.TabIndex = 44;
            this.DoneButton.Text = "DONE";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDialogButton.BackColor = System.Drawing.Color.Red;
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDialogButton.ForeColor = System.Drawing.Color.White;
            this.CancelDialogButton.Location = new System.Drawing.Point(539, 358);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(100, 40);
            this.CancelDialogButton.TabIndex = 45;
            this.CancelDialogButton.Text = "CANCEL";
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelDialogButton_Click);
            // 
            // ManageOutgoingStockItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 410);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PurposeTextBox);
            this.Controls.Add(this.PurposeLabel);
            this.Controls.Add(this.ReleasedByTextBox);
            this.Controls.Add(this.ReleasedByLabel);
            this.Controls.Add(this.RequestedByTextBox);
            this.Controls.Add(this.RequestedByLabel);
            this.Controls.Add(this.VehicleComboBox);
            this.Controls.Add(this.VehicleLabel);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.BranchComboBox);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.RemovedStockValueNumericUpDown);
            this.Controls.Add(this.ItemDescriptionGroupBox);
            this.Controls.Add(this.RemovedStockValueLabel);
            this.Controls.Add(this.TransactionDateTimePicker);
            this.Controls.Add(this.TransactionDateLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageOutgoingStockItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outgoing Stocks";
            this.Load += new System.EventHandler(this.ManageOutgoingStockItemForm_Load);
            this.ItemDescriptionGroupBox.ResumeLayout(false);
            this.ItemDescriptionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovedStockValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label RemovedStockValueLabel;
        private System.Windows.Forms.GroupBox ItemDescriptionGroupBox;
        private System.Windows.Forms.Label ItemDescriptionLabel;
        private System.Windows.Forms.TextBox ItemDescriptionTextBox;
        private System.Windows.Forms.TextBox ItemCodeTextBox;
        private System.Windows.Forms.Label ItemCodeLabel;
        private System.Windows.Forms.TextBox ItemStockValueTextBox;
        private System.Windows.Forms.Label ItemStockValueLabel;
        private System.Windows.Forms.TextBox ItemClassificationTextBox;
        private System.Windows.Forms.Label ItemClassificationLabel;
        private System.Windows.Forms.NumericUpDown RemovedStockValueNumericUpDown;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.ComboBox BranchComboBox;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.ComboBox VehicleComboBox;
        private System.Windows.Forms.Label VehicleLabel;
        private System.Windows.Forms.Label RequestedByLabel;
        private System.Windows.Forms.TextBox RequestedByTextBox;
        private System.Windows.Forms.TextBox ReleasedByTextBox;
        private System.Windows.Forms.Label ReleasedByLabel;
        private System.Windows.Forms.TextBox PurposeTextBox;
        private System.Windows.Forms.Label PurposeLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelDialogButton;
    }
}