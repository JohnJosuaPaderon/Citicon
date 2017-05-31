namespace Citicon.Forms.Dialogs
{
    partial class AddEditClientDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditClientDialog));
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.LegitimateCheckBox = new System.Windows.Forms.CheckBox();
            this.TINTextBox = new System.Windows.Forms.TextBox();
            this.TINLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.ContactPersonGroupBox = new System.Windows.Forms.GroupBox();
            this.ContactPersonPositionTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonPositionLabel = new System.Windows.Forms.Label();
            this.ContactPersonTitleTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonTitleLabel = new System.Windows.Forms.Label();
            this.ContactPersonLastNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonLastNameLabel = new System.Windows.Forms.Label();
            this.ContactPersonFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonFirstNameLabel = new System.Windows.Forms.Label();
            this.ContactPersonEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonEmailAddressLabel = new System.Windows.Forms.Label();
            this.ContactPersonContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContactPersonContactNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExecutivePositionComboBox = new System.Windows.Forms.ComboBox();
            this.ExecutiveMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExecutiveMobileNumberLabel = new System.Windows.Forms.Label();
            this.ExecutiveTelephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExecutiveTelephoneNumberLabel = new System.Windows.Forms.Label();
            this.ExecutivePositionLabel = new System.Windows.Forms.Label();
            this.ExecutiveNameTextBox = new System.Windows.Forms.TextBox();
            this.ExecutiveNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.ContactPersonGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.LegitimateCheckBox);
            this.GroupBox.Controls.Add(this.TINTextBox);
            this.GroupBox.Controls.Add(this.TINLabel);
            this.GroupBox.Controls.Add(this.AddressTextBox);
            this.GroupBox.Controls.Add(this.AddressLabel);
            this.GroupBox.Controls.Add(this.CompanyNameTextBox);
            this.GroupBox.Controls.Add(this.CompanyNameLabel);
            this.GroupBox.Location = new System.Drawing.Point(13, 12);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupBox.Size = new System.Drawing.Size(394, 169);
            this.GroupBox.TabIndex = 117;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Client Details";
            // 
            // LegitimateCheckBox
            // 
            this.LegitimateCheckBox.AutoSize = true;
            this.LegitimateCheckBox.Location = new System.Drawing.Point(317, 14);
            this.LegitimateCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LegitimateCheckBox.Name = "LegitimateCheckBox";
            this.LegitimateCheckBox.Size = new System.Drawing.Size(68, 21);
            this.LegitimateCheckBox.TabIndex = 0;
            this.LegitimateCheckBox.Text = "Special";
            this.LegitimateCheckBox.UseVisualStyleBackColor = true;
            this.LegitimateCheckBox.CheckedChanged += new System.EventHandler(this.LegitimateCheckBox_CheckedChanged);
            // 
            // TINTextBox
            // 
            this.TINTextBox.BackColor = System.Drawing.Color.White;
            this.TINTextBox.Location = new System.Drawing.Point(11, 134);
            this.TINTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TINTextBox.Name = "TINTextBox";
            this.TINTextBox.Size = new System.Drawing.Size(374, 25);
            this.TINTextBox.TabIndex = 3;
            this.TINTextBox.TextChanged += new System.EventHandler(this.TINTextBox_TextChanged);
            // 
            // TINLabel
            // 
            this.TINLabel.AutoSize = true;
            this.TINLabel.Location = new System.Drawing.Point(8, 114);
            this.TINLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TINLabel.Name = "TINLabel";
            this.TINLabel.Size = new System.Drawing.Size(28, 17);
            this.TINLabel.TabIndex = 8;
            this.TINLabel.Text = "TIN";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.White;
            this.AddressTextBox.Location = new System.Drawing.Point(11, 86);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(374, 25);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(8, 69);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(56, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.BackColor = System.Drawing.Color.White;
            this.CompanyNameTextBox.Location = new System.Drawing.Point(11, 41);
            this.CompanyNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(374, 25);
            this.CompanyNameTextBox.TabIndex = 1;
            this.CompanyNameTextBox.TextChanged += new System.EventHandler(this.CompanyNameTextBox_TextChanged);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(8, 21);
            this.CompanyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(102, 17);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // ContactPersonGroupBox
            // 
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonPositionTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonPositionLabel);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonTitleTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonTitleLabel);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonLastNameTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonLastNameLabel);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonFirstNameTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonFirstNameLabel);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonEmailAddressTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonEmailAddressLabel);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonContactNumberTextBox);
            this.ContactPersonGroupBox.Controls.Add(this.ContactPersonContactNumberLabel);
            this.ContactPersonGroupBox.Location = new System.Drawing.Point(13, 188);
            this.ContactPersonGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonGroupBox.Name = "ContactPersonGroupBox";
            this.ContactPersonGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonGroupBox.Size = new System.Drawing.Size(394, 169);
            this.ContactPersonGroupBox.TabIndex = 118;
            this.ContactPersonGroupBox.TabStop = false;
            this.ContactPersonGroupBox.Text = "Contact Person";
            // 
            // ContactPersonPositionTextBox
            // 
            this.ContactPersonPositionTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonPositionTextBox.Location = new System.Drawing.Point(202, 86);
            this.ContactPersonPositionTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonPositionTextBox.Name = "ContactPersonPositionTextBox";
            this.ContactPersonPositionTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonPositionTextBox.TabIndex = 3;
            this.ContactPersonPositionTextBox.TextChanged += new System.EventHandler(this.ContactPersonPositionTextBox_TextChanged);
            // 
            // ContactPersonPositionLabel
            // 
            this.ContactPersonPositionLabel.AutoSize = true;
            this.ContactPersonPositionLabel.Location = new System.Drawing.Point(199, 69);
            this.ContactPersonPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonPositionLabel.Name = "ContactPersonPositionLabel";
            this.ContactPersonPositionLabel.Size = new System.Drawing.Size(54, 17);
            this.ContactPersonPositionLabel.TabIndex = 14;
            this.ContactPersonPositionLabel.Text = "Position";
            // 
            // ContactPersonTitleTextBox
            // 
            this.ContactPersonTitleTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonTitleTextBox.Location = new System.Drawing.Point(11, 86);
            this.ContactPersonTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonTitleTextBox.Name = "ContactPersonTitleTextBox";
            this.ContactPersonTitleTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonTitleTextBox.TabIndex = 2;
            this.ContactPersonTitleTextBox.TextChanged += new System.EventHandler(this.ContactPersonTitleTextBox_TextChanged);
            // 
            // ContactPersonTitleLabel
            // 
            this.ContactPersonTitleLabel.AutoSize = true;
            this.ContactPersonTitleLabel.Location = new System.Drawing.Point(8, 69);
            this.ContactPersonTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonTitleLabel.Name = "ContactPersonTitleLabel";
            this.ContactPersonTitleLabel.Size = new System.Drawing.Size(32, 17);
            this.ContactPersonTitleLabel.TabIndex = 12;
            this.ContactPersonTitleLabel.Text = "Title";
            // 
            // ContactPersonLastNameTextBox
            // 
            this.ContactPersonLastNameTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonLastNameTextBox.Location = new System.Drawing.Point(202, 41);
            this.ContactPersonLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonLastNameTextBox.Name = "ContactPersonLastNameTextBox";
            this.ContactPersonLastNameTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonLastNameTextBox.TabIndex = 1;
            this.ContactPersonLastNameTextBox.TextChanged += new System.EventHandler(this.ContactPersonLastNameTextBox_TextChanged);
            // 
            // ContactPersonLastNameLabel
            // 
            this.ContactPersonLastNameLabel.AutoSize = true;
            this.ContactPersonLastNameLabel.Location = new System.Drawing.Point(199, 21);
            this.ContactPersonLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonLastNameLabel.Name = "ContactPersonLastNameLabel";
            this.ContactPersonLastNameLabel.Size = new System.Drawing.Size(70, 17);
            this.ContactPersonLastNameLabel.TabIndex = 10;
            this.ContactPersonLastNameLabel.Text = "Last Name";
            // 
            // ContactPersonFirstNameTextBox
            // 
            this.ContactPersonFirstNameTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonFirstNameTextBox.Location = new System.Drawing.Point(11, 41);
            this.ContactPersonFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonFirstNameTextBox.Name = "ContactPersonFirstNameTextBox";
            this.ContactPersonFirstNameTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonFirstNameTextBox.TabIndex = 0;
            this.ContactPersonFirstNameTextBox.TextChanged += new System.EventHandler(this.ContactPersonFirstNameTextBox_TextChanged);
            // 
            // ContactPersonFirstNameLabel
            // 
            this.ContactPersonFirstNameLabel.AutoSize = true;
            this.ContactPersonFirstNameLabel.Location = new System.Drawing.Point(8, 21);
            this.ContactPersonFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonFirstNameLabel.Name = "ContactPersonFirstNameLabel";
            this.ContactPersonFirstNameLabel.Size = new System.Drawing.Size(71, 17);
            this.ContactPersonFirstNameLabel.TabIndex = 8;
            this.ContactPersonFirstNameLabel.Text = "First Name";
            // 
            // ContactPersonEmailAddressTextBox
            // 
            this.ContactPersonEmailAddressTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonEmailAddressTextBox.Location = new System.Drawing.Point(11, 134);
            this.ContactPersonEmailAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonEmailAddressTextBox.Name = "ContactPersonEmailAddressTextBox";
            this.ContactPersonEmailAddressTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonEmailAddressTextBox.TabIndex = 4;
            this.ContactPersonEmailAddressTextBox.TextChanged += new System.EventHandler(this.ContactPersonEmailAddressTextBox_TextChanged);
            // 
            // ContactPersonEmailAddressLabel
            // 
            this.ContactPersonEmailAddressLabel.AutoSize = true;
            this.ContactPersonEmailAddressLabel.Location = new System.Drawing.Point(8, 114);
            this.ContactPersonEmailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonEmailAddressLabel.Name = "ContactPersonEmailAddressLabel";
            this.ContactPersonEmailAddressLabel.Size = new System.Drawing.Size(96, 17);
            this.ContactPersonEmailAddressLabel.TabIndex = 4;
            this.ContactPersonEmailAddressLabel.Text = "E-mail Address";
            // 
            // ContactPersonContactNumberTextBox
            // 
            this.ContactPersonContactNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ContactPersonContactNumberTextBox.Location = new System.Drawing.Point(202, 134);
            this.ContactPersonContactNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ContactPersonContactNumberTextBox.Name = "ContactPersonContactNumberTextBox";
            this.ContactPersonContactNumberTextBox.Size = new System.Drawing.Size(183, 25);
            this.ContactPersonContactNumberTextBox.TabIndex = 5;
            this.ContactPersonContactNumberTextBox.TextChanged += new System.EventHandler(this.ContactPersonContactNumberTextBox_TextChanged);
            // 
            // ContactPersonContactNumberLabel
            // 
            this.ContactPersonContactNumberLabel.AutoSize = true;
            this.ContactPersonContactNumberLabel.Location = new System.Drawing.Point(199, 114);
            this.ContactPersonContactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactPersonContactNumberLabel.Name = "ContactPersonContactNumberLabel";
            this.ContactPersonContactNumberLabel.Size = new System.Drawing.Size(77, 17);
            this.ContactPersonContactNumberLabel.TabIndex = 6;
            this.ContactPersonContactNumberLabel.Text = "Contact No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExecutivePositionComboBox);
            this.groupBox1.Controls.Add(this.ExecutiveMobileNumberTextBox);
            this.groupBox1.Controls.Add(this.ExecutiveMobileNumberLabel);
            this.groupBox1.Controls.Add(this.ExecutiveTelephoneNumberTextBox);
            this.groupBox1.Controls.Add(this.ExecutiveTelephoneNumberLabel);
            this.groupBox1.Controls.Add(this.ExecutivePositionLabel);
            this.groupBox1.Controls.Add(this.ExecutiveNameTextBox);
            this.groupBox1.Controls.Add(this.ExecutiveNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(394, 122);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Executive\'s Details";
            // 
            // ExecutivePositionComboBox
            // 
            this.ExecutivePositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExecutivePositionComboBox.FormattingEnabled = true;
            this.ExecutivePositionComboBox.Location = new System.Drawing.Point(201, 41);
            this.ExecutivePositionComboBox.Name = "ExecutivePositionComboBox";
            this.ExecutivePositionComboBox.Size = new System.Drawing.Size(184, 25);
            this.ExecutivePositionComboBox.TabIndex = 1;
            this.ExecutivePositionComboBox.SelectedIndexChanged += new System.EventHandler(this.ExecutivePositionComboBox_SelectedIndexChanged);
            // 
            // ExecutiveMobileNumberTextBox
            // 
            this.ExecutiveMobileNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ExecutiveMobileNumberTextBox.Location = new System.Drawing.Point(202, 89);
            this.ExecutiveMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecutiveMobileNumberTextBox.Name = "ExecutiveMobileNumberTextBox";
            this.ExecutiveMobileNumberTextBox.Size = new System.Drawing.Size(183, 25);
            this.ExecutiveMobileNumberTextBox.TabIndex = 3;
            this.ExecutiveMobileNumberTextBox.TextChanged += new System.EventHandler(this.ExecutiveMobileNumberTextBox_TextChanged);
            // 
            // ExecutiveMobileNumberLabel
            // 
            this.ExecutiveMobileNumberLabel.AutoSize = true;
            this.ExecutiveMobileNumberLabel.Location = new System.Drawing.Point(199, 69);
            this.ExecutiveMobileNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecutiveMobileNumberLabel.Name = "ExecutiveMobileNumberLabel";
            this.ExecutiveMobileNumberLabel.Size = new System.Drawing.Size(74, 17);
            this.ExecutiveMobileNumberLabel.TabIndex = 16;
            this.ExecutiveMobileNumberLabel.Text = "Mobile No.";
            // 
            // ExecutiveTelephoneNumberTextBox
            // 
            this.ExecutiveTelephoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.ExecutiveTelephoneNumberTextBox.Location = new System.Drawing.Point(11, 89);
            this.ExecutiveTelephoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecutiveTelephoneNumberTextBox.Name = "ExecutiveTelephoneNumberTextBox";
            this.ExecutiveTelephoneNumberTextBox.Size = new System.Drawing.Size(183, 25);
            this.ExecutiveTelephoneNumberTextBox.TabIndex = 2;
            this.ExecutiveTelephoneNumberTextBox.TextChanged += new System.EventHandler(this.ExecutiveTelephoneNumberTextBox_TextChanged);
            // 
            // ExecutiveTelephoneNumberLabel
            // 
            this.ExecutiveTelephoneNumberLabel.AutoSize = true;
            this.ExecutiveTelephoneNumberLabel.Location = new System.Drawing.Point(8, 69);
            this.ExecutiveTelephoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecutiveTelephoneNumberLabel.Name = "ExecutiveTelephoneNumberLabel";
            this.ExecutiveTelephoneNumberLabel.Size = new System.Drawing.Size(93, 17);
            this.ExecutiveTelephoneNumberLabel.TabIndex = 14;
            this.ExecutiveTelephoneNumberLabel.Text = "Telephone No.";
            // 
            // ExecutivePositionLabel
            // 
            this.ExecutivePositionLabel.AutoSize = true;
            this.ExecutivePositionLabel.Location = new System.Drawing.Point(199, 21);
            this.ExecutivePositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecutivePositionLabel.Name = "ExecutivePositionLabel";
            this.ExecutivePositionLabel.Size = new System.Drawing.Size(54, 17);
            this.ExecutivePositionLabel.TabIndex = 13;
            this.ExecutivePositionLabel.Text = "Position";
            // 
            // ExecutiveNameTextBox
            // 
            this.ExecutiveNameTextBox.BackColor = System.Drawing.Color.White;
            this.ExecutiveNameTextBox.Location = new System.Drawing.Point(11, 41);
            this.ExecutiveNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExecutiveNameTextBox.Name = "ExecutiveNameTextBox";
            this.ExecutiveNameTextBox.Size = new System.Drawing.Size(183, 25);
            this.ExecutiveNameTextBox.TabIndex = 0;
            this.ExecutiveNameTextBox.TextChanged += new System.EventHandler(this.ExecutiveNameTextBox_TextChanged);
            // 
            // ExecutiveNameLabel
            // 
            this.ExecutiveNameLabel.AutoSize = true;
            this.ExecutiveNameLabel.Location = new System.Drawing.Point(8, 21);
            this.ExecutiveNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExecutiveNameLabel.Name = "ExecutiveNameLabel";
            this.ExecutiveNameLabel.Size = new System.Drawing.Size(43, 17);
            this.ExecutiveNameLabel.TabIndex = 10;
            this.ExecutiveNameLabel.Text = "Name";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Red;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(199, 492);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 35);
            this.SaveButton.TabIndex = 120;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(307, 492);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 121;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEditClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 537);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.ContactPersonGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditClientDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add or Edit New Client";
            this.Load += new System.EventHandler(this.AddEditClientDialog_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ContactPersonGroupBox.ResumeLayout(false);
            this.ContactPersonGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.CheckBox LegitimateCheckBox;
        private System.Windows.Forms.TextBox TINTextBox;
        private System.Windows.Forms.Label TINLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.GroupBox ContactPersonGroupBox;
        private System.Windows.Forms.TextBox ContactPersonPositionTextBox;
        private System.Windows.Forms.Label ContactPersonPositionLabel;
        private System.Windows.Forms.TextBox ContactPersonTitleTextBox;
        private System.Windows.Forms.Label ContactPersonTitleLabel;
        private System.Windows.Forms.TextBox ContactPersonLastNameTextBox;
        private System.Windows.Forms.Label ContactPersonLastNameLabel;
        private System.Windows.Forms.TextBox ContactPersonFirstNameTextBox;
        private System.Windows.Forms.Label ContactPersonFirstNameLabel;
        private System.Windows.Forms.TextBox ContactPersonEmailAddressTextBox;
        private System.Windows.Forms.Label ContactPersonEmailAddressLabel;
        private System.Windows.Forms.TextBox ContactPersonContactNumberTextBox;
        private System.Windows.Forms.Label ContactPersonContactNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ExecutiveMobileNumberTextBox;
        private System.Windows.Forms.Label ExecutiveMobileNumberLabel;
        private System.Windows.Forms.TextBox ExecutiveTelephoneNumberTextBox;
        private System.Windows.Forms.Label ExecutiveTelephoneNumberLabel;
        private System.Windows.Forms.Label ExecutivePositionLabel;
        private System.Windows.Forms.TextBox ExecutiveNameTextBox;
        private System.Windows.Forms.Label ExecutiveNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox ExecutivePositionComboBox;
    }
}